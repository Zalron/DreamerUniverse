using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
using System.IO;
using System.Linq;

namespace WorldModule
{
    public class World : MonoBehaviour
    {
        public WorldSettings worldSettings;

        public World world;

        [Header("Other")]
        [Range(0f, 1f)]

        public float globalLightLevel;
        public Color Day;
        public Color Night;

        public Transform Player;
        public Vector3 spawnPosition;

        public Material material;
        public Material transparentMaterial;

        public BlockType[] blockType;
        public Biomes biome;

        
        Dictionary<ChunkCoord, Chunk> createdChunks = new Dictionary<ChunkCoord, Chunk>();
        //List<Chunk> createdChunks = new List<Chunk>();
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

        Thread ChunkUpdateThread1;
        Thread ChunkUpdateThread2;
        Thread ChunkUpdateThread3;
        Thread ChunkUpdateThread4;
        Thread ChunkUpdateThread5;
        Thread ChunkUpdateThread6;
        Thread ChunkUpdateThread7;
        public object ChunkUpdateThreadLock = new object();


        public static readonly int WorldSizeInChunks = 6200;
        public static int WorldSizeInBlocks
        {
            get { return WorldSizeInChunks * Chunk.chunkSize; }
        }
        public void Start()
        {
            if (worldSettings.SaveOrLoad == true)
            {
                string jsonExport = JsonUtility.ToJson(worldSettings);
                Debug.Log(jsonExport);
                File.WriteAllText(Application.dataPath + "/WorldSettings.cfg", jsonExport);
            }
            else if(worldSettings.SaveOrLoad == false)
            {
                string jsonImport = File.ReadAllText(Application.dataPath + "/WorldSettings.cfg");
                Debug.Log(jsonImport);
                worldSettings = JsonUtility.FromJson<WorldSettings>(jsonImport);
            }

            Random.InitState(worldSettings.seed);

            Shader.SetGlobalFloat("minGlobalLightLevel", Block.minLightLevel);
            Shader.SetGlobalFloat("maxGlobalLightLevel", Block.maxLightLevel);

            if (worldSettings.enableThreading)
            {
                if (worldSettings.UpdateThreadNumber == 1)
                {
                    ChunkUpdateThread1 = new Thread(new ThreadStart(ThreadedUpdate));
                    ChunkUpdateThread1.Start();
                }
                if (worldSettings.UpdateThreadNumber == 2)
                {
                    ChunkUpdateThread1 = new Thread(new ThreadStart(ThreadedUpdate));
                    ChunkUpdateThread1.Start();
                    ChunkUpdateThread2 = new Thread(new ThreadStart(ThreadedUpdate));
                    ChunkUpdateThread2.Start();
                }
                if (worldSettings.UpdateThreadNumber == 3)
                {
                    ChunkUpdateThread1 = new Thread(new ThreadStart(ThreadedUpdate));
                    ChunkUpdateThread1.Start();
                    ChunkUpdateThread2 = new Thread(new ThreadStart(ThreadedUpdate));
                    ChunkUpdateThread2.Start();
                    ChunkUpdateThread3 = new Thread(new ThreadStart(ThreadedUpdate));
                    ChunkUpdateThread3.Start();
                }
                if (worldSettings.UpdateThreadNumber == 4)
                {
                    ChunkUpdateThread1 = new Thread(new ThreadStart(ThreadedUpdate));
                    ChunkUpdateThread1.Start();
                    ChunkUpdateThread2 = new Thread(new ThreadStart(ThreadedUpdate));
                    ChunkUpdateThread2.Start();
                    ChunkUpdateThread3 = new Thread(new ThreadStart(ThreadedUpdate));
                    ChunkUpdateThread3.Start();
                    ChunkUpdateThread4 = new Thread(new ThreadStart(ThreadedUpdate));
                    ChunkUpdateThread4.Start();
                }
                if (worldSettings.UpdateThreadNumber == 5)
                {
                    ChunkUpdateThread1 = new Thread(new ThreadStart(ThreadedUpdate));
                    ChunkUpdateThread1.Start();
                    ChunkUpdateThread2 = new Thread(new ThreadStart(ThreadedUpdate));
                    ChunkUpdateThread2.Start();
                    ChunkUpdateThread3 = new Thread(new ThreadStart(ThreadedUpdate));
                    ChunkUpdateThread3.Start();
                    ChunkUpdateThread4 = new Thread(new ThreadStart(ThreadedUpdate));
                    ChunkUpdateThread4.Start();
                    ChunkUpdateThread5 = new Thread(new ThreadStart(ThreadedUpdate));
                    ChunkUpdateThread5.Start();
                }
            }

            SetGlobalLightValue();
            spawnPosition = new Vector3(0, biome.terrainHeightFromSoild + 3, 0);
            GenerateWorld();
            playerLastChunkCoord = GetChunkCoordFromVector3(Player.position);


        }

        public void SetGlobalLightValue()
        {
            Shader.SetGlobalFloat("GlobalLightLevel", globalLightLevel);
            Camera.main.backgroundColor = Color.Lerp(Day, Night, globalLightLevel);
        }

        public void Update()
        {
            playerChunkCoord = GetChunkCoordFromVector3(Player.position);


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
            if (!worldSettings.enableThreading)
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
            if (Input.GetKeyDown(KeyCode.F3))
            {
                debugScreen.SetActive(!debugScreen.activeSelf);
            }
        }
        void GenerateWorld()
        {
            for (int x = -worldSettings.ViewDistanceInChunks; x <= worldSettings.ViewDistanceInChunks; x++)
            {
                for (int y = -worldSettings.ViewDistanceInChunks + ((int)spawnPosition.y/Chunk.chunkSize); y <= worldSettings.ViewDistanceInChunks + ((int)spawnPosition.y/Chunk.chunkSize); y++)
                {
                    for (int z = -worldSettings.ViewDistanceInChunks; z <= worldSettings.ViewDistanceInChunks; z++)
                    {
                        //Debug.Log("First Generated Chunk " + x + " " + y + " " + z);
                        ChunkCoord newChunk = new ChunkCoord(x,y,z);
                        chunksToCreate.Add(newChunk);
                    }
                }
            }
            Player.position = spawnPosition;
            CheckViewDistance();
        }
        void CreateChunk()
        {
            ChunkCoord c = chunksToCreate[0];
            //Debug.Log("raw chunk coords " + c.x + " " + c.y + " " + c.z);
            Chunk newChunk = new Chunk(c, this);
            if (DictionaryChunkFinder(c.x, c.y, c.z) == newChunk)
            {
                Debug.Log("Rejected chunk coords " + c.x + " " + c.y + " " + c.z);
            }
            if(DictionaryChunkFinder(c.x, c.y, c.z) == null)
            {
                Debug.Log("created chunk coords " + c.x + " " + c.y + " " + c.z);
                createdChunks.Add(c, newChunk);
                DictionaryChunkFinder(c.x,c.y,c.z).Init();
                chunksToUpdate.Add(newChunk);
                chunksToCreate.RemoveAt(0);
            }
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
                        if (!activeChunks.Contains(chunksToUpdate[index].coord))
                        {
                            activeChunks.Add(chunksToUpdate[index].coord);
                        }
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
            if (worldSettings.enableThreading)
            {
                ChunkUpdateThread1.Abort();
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
                    if (!IsBlockInWorld(b.position))
                    {
                        return;
                    }
                    ChunkCoord c = GetChunkCoordFromVector3(b.position);
                    Chunk modificationChunk = DictionaryChunkFinder(c.x, c.y, c.z);
                    if (modificationChunk == null)
                    {
                        chunksToCreate.Add(c);
                    }
                    //UnityEngine.Debug.Log( "BlockState "+ " x " + b.position.x + " y " + b.position.y + " z " + b.position.z);
                    modificationChunk.modifications.Enqueue(b);
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
            return DictionaryChunkFinder(x,y,z);
        }
        public Chunk DictionaryChunkFinder(int x, int y, int z)
        {
            ChunkCoord chunkCoord = new ChunkCoord(x, y, z);
            Chunk foundChunk;
            if (createdChunks.TryGetValue(chunkCoord, out foundChunk))
            {
                return foundChunk;
            }
            return null;

        }
        void CheckViewDistance()
        {
            ChunkCoord coord = GetChunkCoordFromVector3(Player.position);
            playerLastChunkCoord = playerChunkCoord;

            List<ChunkCoord> previouslyActiveChunks = new List<ChunkCoord>(activeChunks);
            activeChunks.Clear();
            
            // Loops through all chunks currently within view distance of the player
            for (int x = coord.x - worldSettings.ViewDistanceInChunks; x <= coord.x + worldSettings.ViewDistanceInChunks; x++)
            {
                for (int y = coord.y - worldSettings.ViewDistanceInChunks; y <= coord.y + worldSettings.ViewDistanceInChunks; y++)
                {
                    for (int z = coord.z - worldSettings.ViewDistanceInChunks; z <= coord.z + worldSettings.ViewDistanceInChunks; z++)
                    {
                        ChunkCoord newChunkCoord = new ChunkCoord(x, y, z);
                        Chunk checkChunk = DictionaryChunkFinder(newChunkCoord.x, newChunkCoord.y, newChunkCoord.z);
                        Debug.Log("updated chunk finder " + x + " " + y + " " + z);
                        // If the current chunks is in the world
                        if (IsChunkInWorld(newChunkCoord))
                        {
                            //checks if it is active, if not, activate it.
                            if (checkChunk == null)
                            {
                                //Debug.Log("New chunk finder " + x + " " + y + " " + z);
                                chunksToCreate.Add(newChunkCoord);
                            }
                            else if(!checkChunk.IsActive)
                            {
                                checkChunk.IsActive = true;
                            }
                            activeChunks.Add(newChunkCoord);
                        }
                        // Check throught previously active chunks to see if this chunk is there, If it is, remove if from the list
                        for (int i = 0; i < previouslyActiveChunks.Count; i++)
                        {
                            if (previouslyActiveChunks[i].Equals(newChunkCoord))
                            {
                                previouslyActiveChunks.RemoveAt(i);
                            }
                        }
                    }
                }
            }
            foreach (ChunkCoord c in previouslyActiveChunks)
            {
                //Debug.Log("updated chunk finder previously Active Chunks " + c.x + " " + c.y + " " + c.z);
                if (DictionaryChunkFinder(c.x, c.y, c.z) != null)
                {
                    DictionaryChunkFinder(c.x, c.y, c.z).IsActive = false;
                }
            } 
        }
        
        public bool CheckForSolidBlockInChunk(Vector3 pos)
        {
            ChunkCoord thisChunk = new ChunkCoord(pos);
            Chunk blockChunk = DictionaryChunkFinder(thisChunk.x, thisChunk.y, thisChunk.z);
            if (!IsChunkInWorld(thisChunk))
            {
                return false;
            }
            if (blockChunk != null && blockChunk.IsEditable)
            {
                return blockType[blockChunk.GetBlockFromGlobalVector3(pos).id].isSolid;
            }
            return blockType[GetBlock(pos)].isSolid;
        }
        public BlockState GetBlockState(Vector3 pos)
        {
            ChunkCoord thisChunk = new ChunkCoord(pos);
            Chunk blockChunk = DictionaryChunkFinder(thisChunk.x, thisChunk.y, thisChunk.z);
            if (!IsChunkInWorld(thisChunk))
            {
                return null;
            }
            if (blockChunk != null && blockChunk.IsEditable)
            {
                return blockChunk.GetBlockFromGlobalVector3(pos);
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
            if (yPos == 0)
            {
                return 1;
            }
            // BASIC TERRAIN PASS
            int terrainHeight = Terrian.GenerateHeight(new Vector2(pos.x, pos.z), biome.solidGroundHeight, biome.terrainHeightFromSoild, biome.terrainOffset, biome.terrainSmooth, biome.terrainOctaves, biome.terrainScale);
            byte blockValue;
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
                        if (Terrian.FBM3D(pos.x, pos.y, pos.z, lode.offset, lode.smooth, (int)lode.octaves, lode.persistance, lode.threshold))
                        {
                            blockValue = lode.BlockID;
                        }
                    }
                }
            }
            

            //TREE TERRAIN PASS
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
            if (coord.x >= -WorldSizeInChunks && coord.x <= WorldSizeInChunks && coord.y >= -WorldSizeInChunks && coord.y <= WorldSizeInChunks && coord.z >= -WorldSizeInChunks && coord.z <= WorldSizeInChunks)
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
            if (pos.x >= -WorldSizeInBlocks && pos.x <= WorldSizeInBlocks && pos.y >= -WorldSizeInBlocks && pos.y <= WorldSizeInBlocks && pos.z >= -WorldSizeInBlocks && pos.z <= WorldSizeInBlocks)
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
    [System.Serializable]
    public class WorldSettings
    {
        [Header("Save or Load (on is save off is load)")]
        public bool SaveOrLoad = false;
        [Header("Game Data")]
        public string GameVersion;
        [Header("World Generation Values")]
        public int seed;
        [Header("Performance")]
        public bool enableThreading;
        public int ViewDistanceInChunks = 3;
        public int UpdateThreadNumber = 3;
        [Range(0.1f,10)]
        public float mouseSensitivity;
    }
}
