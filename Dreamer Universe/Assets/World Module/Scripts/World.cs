using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
namespace WorldModule
{
    public class World : MonoBehaviour
    {
        public World world;
        [Header("World Generation Values")]
        public int seed;

        [Header("Performance")]
        public bool enableThreading;

        [Header("Other")]
        [Range(0.95f, 0f)]
        public float globalLightLevel;

        public Color Day;
        public Color Night;

        public Transform Player;
        public Vector3 spawnPosition;

        public Material material;
        public Material transparentMaterial;

        public BlockType[] blockType;
        public Biomes biome;

        Chunk[,,] chunks = new Chunk[WorldSizeInChunks, WorldSizeInChunks, WorldSizeInChunks];

        List<ChunkCoord> activeChunks = new List<ChunkCoord>();
        public ChunkCoord playerChunkCoord;
        ChunkCoord playerLastChunkCoord;

        List<ChunkCoord> chunksToCreate = new List<ChunkCoord>();
        public List<Chunk> chunksToUpdate = new List<Chunk>();
        public Queue<Chunk> chunksToDraw = new Queue<Chunk>();

        bool applyingModifications = false;

        readonly Queue<Queue<BlockMod>> modifications = new Queue<Queue<BlockMod>>();

        private bool _inUI = false;

        public GameObject debugScreen;

        public GameObject creativeInventoryWindow;
        public GameObject cursorSlot;

        Thread ChunkUpdateThread;
        public object ChunkUpdateThreadLock = new object();

        public static readonly int ViewDistanceInChunks = 3;
        public static readonly int WorldSizeInChunks = 16;
        public static int WorldSizeInBlocks
        {
            get { return WorldSizeInChunks * Chunk.chunkSize; }
        }
        public void Start()
        {
            Random.InitState(seed);

            Shader.SetGlobalFloat("minGlobalLightLevel", Block.minLightLevel);
            Shader.SetGlobalFloat("maxGlobalLightLevel", Block.maxLightLevel);

            if (enableThreading)
            {
                ChunkUpdateThread = new Thread(new ThreadStart(ThreadedUpdate));
                ChunkUpdateThread.Start();
            }
            
            spawnPosition = new Vector3((WorldSizeInChunks * Chunk.chunkSize) / 2f, biome.solidGroundHeight + 20, (WorldSizeInChunks * Chunk.chunkSize) / 2f);
            GenerateWorld();
            playerLastChunkCoord = GetChunkCoordFromVector3(Player.position);


        }
        public void Update()
        {
            playerChunkCoord = GetChunkCoordFromVector3(Player.position);

            Shader.SetGlobalFloat("GlobalLightLevel", globalLightLevel);
            Camera.main.backgroundColor = Color.Lerp(Day, Night, globalLightLevel);

            if (!playerChunkCoord.Equals(playerLastChunkCoord))
            {
                CheckViewDistance();
            }
            if (chunksToCreate.Count > 0)
            {
                CreateChunk();
            }
            if (chunksToDraw.Count > 0)
            {
                if (chunksToDraw.Peek().IsEditable)
                {
                    chunksToDraw.Dequeue().CreateMesh();
                }
            }
            if (!enableThreading)
            {
                if (!applyingModifications)
                    ApplyModifications();

                if (chunksToUpdate.Count > 0)
                    UpdateChunks();

            }
            if (Input.GetKeyDown(KeyCode.F3))
            {
                debugScreen.SetActive(!debugScreen.activeSelf);
            }
        }
        void GenerateWorld()
        {
            Player.position = spawnPosition;
            for (int x = (WorldSizeInChunks / 2) - ViewDistanceInChunks; x < (WorldSizeInChunks / 2) + ViewDistanceInChunks; x++)
            {
                for (int y = (WorldSizeInChunks / 2) - ViewDistanceInChunks; y < (WorldSizeInChunks / 2) + ViewDistanceInChunks; y++)
                {
                    for (int z = (WorldSizeInChunks / 2) - ViewDistanceInChunks; z < (WorldSizeInChunks / 2) + ViewDistanceInChunks; z++)
                    {
                        ChunkCoord newChunk = new ChunkCoord(x,y,z);
                        chunks[x, y, z] = new Chunk(newChunk, this);
                        activeChunks.Add(newChunk);
                    }
                }
            }
            CheckViewDistance();
        }
        void CreateChunk()
        {
            ChunkCoord c = chunksToCreate[0];
            chunksToCreate.RemoveAt(0);
            chunks[c.x, c.y, c.z].Init();
        }
        void UpdateChunks()
        {
            bool updated = false;
            int index = 0;
            lock(ChunkUpdateThreadLock)
            {
                while (!updated && index < chunksToUpdate.Count - 1)
                {

                    if (chunksToUpdate[index].IsEditable)
                    {
                        chunksToUpdate[index].UpdateChunk();
                        activeChunks.Add(chunksToUpdate[index].coord);
                        chunksToUpdate.RemoveAt(index);
                        updated = true;
                    }
                    else
                    {
                        index++;
                    }
                }
            }
        }
        void ThreadedUpdate()
        {
            while (true)
            {
                if (!applyingModifications)
                {
                    ApplyModifications();
                }
                if (chunksToUpdate.Count > 0)
                {
                    UpdateChunks();
                }
            }
        }
        private void OnDisable()
        {
            if (enableThreading)
            {
                ChunkUpdateThread.Abort();
            }
        }
        void ApplyModifications()
        {
            applyingModifications = true;
            //if (modifications.Count <= 0)
            //{
            //    Debug.Log(modifications.Count);
            //}
            while (modifications.Count > 0)
            {
                Queue<BlockMod> queue = modifications.Dequeue();
                //if (queue.Count <= 0)
                //{
                //    Debug.Log(queue.Count);
                //}
                while (queue.Count > 0)
                {
                    BlockMod b = queue.Dequeue();
                    ChunkCoord c = GetChunkCoordFromVector3(b.position);
                    if (chunks[c.x, c.y, c.z] == null)
                    {
                        //Debug.Log(chunks[c.x, c.y, c.z]);
                        chunks[c.x, c.y, c.z] = new Chunk(c, this);
                        chunksToCreate.Add(c);
                    }
                    chunks[c.x, c.y, c.z].modifications.Enqueue(b);
                }
            }
            applyingModifications = false;
        }
        ChunkCoord GetChunkCoordFromVector3(Vector3 pos)
        {
            int x = Mathf.FloorToInt(pos.x / Chunk.chunkSize);
            int y = Mathf.FloorToInt(pos.y / Chunk.chunkSize);
            int z = Mathf.FloorToInt(pos.z / Chunk.chunkSize);
            return new ChunkCoord(x,y,z);
        }
        public Chunk GetChunkFromVector3(Vector3 pos)
        {
            int x = Mathf.FloorToInt(pos.x / Chunk.chunkSize);
            int y = Mathf.FloorToInt(pos.y / Chunk.chunkSize);
            int z = Mathf.FloorToInt(pos.z / Chunk.chunkSize);
            return chunks[x, y, z];
        }
        void CheckViewDistance()
        {
            ChunkCoord coord = GetChunkCoordFromVector3(Player.position);
            playerLastChunkCoord = playerChunkCoord;

            List<ChunkCoord> previouslyActiveChunks = new List<ChunkCoord>(activeChunks);
            activeChunks.Clear();

            // Loops through all chunks currently within view distance of the player
            for (int x = coord.x - ViewDistanceInChunks; x < coord.x + ViewDistanceInChunks; x++)
            {
                for (int y = coord.y - ViewDistanceInChunks; y < coord.y + ViewDistanceInChunks; y++)
                {
                    for (int z = coord.z - ViewDistanceInChunks; z < coord.z + ViewDistanceInChunks; z++)
                    {
                        ChunkCoord Chunk = new ChunkCoord(x, y, z);
                        // If the current chunks is in the world
                        if (IsChunkInWorld(new ChunkCoord(x,y,z)))
                        {
                            //checks if it is active, if not, activate it.
                            if (chunks[x, y, z] == null)
                            {
                                chunks[x, y, z] = new Chunk(Chunk, this);
                                chunksToCreate.Add(Chunk);
                            }
                            else if(!chunks[x,y,z].IsActive)
                            {
                                chunks[x, y, z].IsActive = true;
                            }
                            activeChunks.Add(Chunk);
                        }
                        // Check throught previously active chunks to see if this chunk is there, If it is, remove if from the list
                        for (int i = 0; i < previouslyActiveChunks.Count; i++)
                        {
                            if (previouslyActiveChunks[i].Equals(Chunk))
                            {
                                previouslyActiveChunks.RemoveAt(i);
                            }
                        }
                    }
                }
            }
            foreach (ChunkCoord c in previouslyActiveChunks)
            {
                chunks[c.x, c.y, c.z].IsActive = false;
            } 
        }
        
        public bool CheckForSolidBlockInChunk(Vector3 pos)
        {
            ChunkCoord thisChunk = new ChunkCoord(pos);

            if (!IsChunkInWorld(thisChunk))
            {
                return false;
            }
            if (chunks[thisChunk.x, thisChunk.y, thisChunk.z] != null && chunks[thisChunk.x, thisChunk.y, thisChunk.z].IsEditable)
            {
                return blockType[chunks[thisChunk.x, thisChunk.y, thisChunk.z].GetBlockFromGlobalVector3(pos).id].isSolid;
            }
            return blockType[GetBlock(pos)].isSolid;
        }
        public BlockState GetBlockState(Vector3 pos)
        {
            ChunkCoord thisChunk = new ChunkCoord(pos);

            if (!IsChunkInWorld(thisChunk))
            {
                return null;
            }
            if (chunks[thisChunk.x, thisChunk.y, thisChunk.z] != null && chunks[thisChunk.x, thisChunk.y, thisChunk.z].IsEditable)
            {
                return chunks[thisChunk.x, thisChunk.y, thisChunk.z].GetBlockFromGlobalVector3(pos);
            }
            return new BlockState (GetBlock(pos));
        }
        public bool inUI
        {
            get { return _inUI; }
            set
            {
                _inUI = value;
                if (_inUI)
                {
                    Cursor.lockState = CursorLockMode.None;
                    creativeInventoryWindow.SetActive(true);
                    cursorSlot.SetActive(true);
                }
                else
                {
                    Cursor.lockState = CursorLockMode.Locked;
                    creativeInventoryWindow.SetActive(false);
                    cursorSlot.SetActive(false);
                }
            }
        }
        public byte GetBlock(Vector3 pos)
        {
            // IMMUTABLE PASS
            int yPos = Mathf.FloorToInt(pos.y);
            if (!IsBlockInWorld(pos))
            {
                return 0;
            }
            if (yPos <= 3)
            {
                return 1;
            }
            // BASIC TERRAIN PASS
            int terrainHeight = Terrian.GenerateHeight(new Vector2(pos.x, pos.z), biome.solidGroundHeight, biome.terrainHeightFromSoild, biome.terrainOffset, biome.terrainSmooth, biome.terrainOctaves, biome.terrainScale);
            byte blockValue = 0;
            if (yPos == terrainHeight)
            {
                blockValue = 3; //Grass
            }
            else if (yPos < terrainHeight && yPos > terrainHeight - 4)
            {
                blockValue = 5; // Dirt
            }
            else if (yPos > terrainHeight)
            {
                return 0; // Air
            }
            else
            {
                blockValue = 2; //Stone
            }

            // ORE TERRAIN PASS
            if (blockValue == 2)
            {
                foreach (Lode lode in biome.lodes)
                {
                    if (yPos > lode.minHeight && yPos < lode.maxHeight)
                    {
                        if (Terrian.FBM3D(pos.x, pos.y, pos.z, lode.offset, lode.octaves, (int)lode.persistance, lode.scale, lode.threshold))
                        {
                            blockValue = lode.BlockID;
                        }
                    }
                }
            }
            

            // TREE TERRAIN PASS
            if (yPos == terrainHeight)
            {
                if (Terrian.TreeGeneration(new Vector2(pos.x,pos.z), 0, biome.treeZoneScale) > biome.treeZoneThreshold) 
                {
                    if (Terrian.TreeGeneration(new Vector2(pos.x, pos.z), 0, biome.treePlacementScale) > biome.treeZonePlacementThreshold)
                    {
                        modifications.Enqueue(Structure.MakeTree(pos, biome.minTreeHeight, biome.maxTreeHeight));
                    }
                }
            }
            return blockValue;
        }
        bool IsChunkInWorld(ChunkCoord coord)
        {
            if (coord.x > 0 && coord.x < WorldSizeInChunks - 1 && coord.y > 0 && coord.y < WorldSizeInChunks - 1 && coord.z > 0 && coord.z < WorldSizeInChunks - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool IsBlockInWorld(Vector3 pos)
        {
            if (pos.x >= 0 && pos.x < WorldSizeInBlocks && pos.y >= 0 && pos.y < WorldSizeInBlocks && pos.z >= 0 && pos.z < WorldSizeInBlocks)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public struct BlockMod
    {
        public Vector3 position;
        public byte id;
        public BlockMod(Vector3 _position, byte _id)
        {
            position = _position;
            id = _id;
        }

    }
}
