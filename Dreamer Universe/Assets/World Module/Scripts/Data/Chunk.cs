using System.Collections;
using System.Collections.Generic;
//using System.Drawing;
//using System.Numerics;
//using System.Threading;
using UnityEngine;

namespace WorldModule
{
    public class Chunk
    {
        int airBlockState;
        public ChunkCoord coord;
        GameObject chunkObject;
        public MeshRenderer meshRenderer;
        public MeshFilter meshFilter;

        public static int chunkSize = 16;
        int vertexIndex = 0;
        List<Vector3> vertices = new List<Vector3>();
        List<int> triangles = new List<int>();
        List<int> transparentTriangles = new List<int>();
        Material[] materials = new Material[2];
        List<Vector2> uvs = new List<Vector2>();
        List<Color> colours = new List<Color>();
        List<Vector3> normals = new List<Vector3>();

        public Vector3 position;

        public BlockState [,,] blockMap = new BlockState[chunkSize, chunkSize, chunkSize];

        public Queue<BlockMod> modifications = new Queue<BlockMod>();

        World world;

        private bool _isActive;
        private bool IsBlockMapPopulated = false;
        public Chunk(ChunkCoord _coord, World _world)
        {
            coord = _coord;
            world = _world;
        }
        public void Init()
        {
            chunkObject = new GameObject();
            meshFilter = chunkObject.AddComponent<MeshFilter>();
            meshRenderer = chunkObject.AddComponent<MeshRenderer>();

            materials[0] = world.material;
            materials[1] = world.transparentMaterial;
            meshRenderer.materials = materials;

            chunkObject.transform.SetParent(world.transform);
            chunkObject.transform.position = new Vector3(coord.x * chunkSize, coord.y * chunkSize, coord.z * chunkSize);
            chunkObject.name = "Chunk " + coord.x + "x, " + coord.y + "y, " + coord.z + "z";
            position = chunkObject.transform.position;

            PopulateBlockMap();

        }
        private void PopulateBlockMap()
        {
            for (int x = 0; x < chunkSize; x++)
            {
                for (int y = 0; y < chunkSize; y++)
                {
                    for (int z = 0; z < chunkSize; z++)
                    {
                        BlockState bs = new BlockState(world.GetBlock(new Vector3(x, y, z) + position));
                        blockMap[x, y, z] = bs;
                        //UnityEngine.Debug.Log("|BlockMap " + " x " + x + " y " + y + " z " + z + "| BlockState: " + bs.id + "| Chunk position: " + " x " + coord.x + " y " + coord.y + " z " + coord.z);
                    }
                }
            }
            IsBlockMapPopulated = true;
            lock (world.ChunkUpdateThreadLock)
            {
                world.chunksToUpdate.Add(this);
            }
        }
        public void UpdateChunk()
        {

            while (modifications.Count > 0)
            {
                BlockMod b = modifications.Dequeue();
                Vector3 pos = b.position -= position;
                
                blockMap[(int)pos.x, (int)pos.y, (int)pos.z].id = b.id;
            }
            ClearMeshData();
            CalculateLight();
            for (int x = 0; x < chunkSize; x++)
            {
                for (int y = 0; y < chunkSize; y++)
                {
                    for (int z = 0; z < chunkSize; z++)
                    {
                        if (world.blockType[blockMap[x, y, z].id].isSolid)
                        {
                            UpdateMeshData(new Vector3(x, y, z));
                        }
                    }
                }
            }
            world.chunksToDraw.Enqueue(this);
        }
        private void CalculateLight()
        {

            Queue<Vector3Int> litVoxels = new Queue<Vector3Int>();

            for (int x = 0; x < chunkSize; x++)
            {
                for (int z = 0; z < chunkSize; z++)
                {

                    float lightRay = 1f;

                    for (int y = chunkSize - 1; y >= 0; y--)
                    {

                        BlockState thisVoxel = blockMap[x, y, z];

                        if (thisVoxel.id > 0 && world.blockType[thisVoxel.id].transparency < lightRay)
                        {
                            lightRay = world.blockType[thisVoxel.id].transparency;
                        }

                        thisVoxel.globalLightPercent = lightRay;

                        blockMap[x, y, z] = thisVoxel;

                        if (lightRay > Block.LightFalloff)
                        {
                            litVoxels.Enqueue(new Vector3Int(x, y, z));
                        }

                    }
                }
            }

            while (litVoxels.Count > 0)
            {

                Vector3Int v = litVoxels.Dequeue();

                for (int p = 0; p < 6; p++)
                {

                    Vector3 currentVoxel = v + Block.faceChecks[p];
                    Vector3Int neighbour = new Vector3Int((int)currentVoxel.x, (int)currentVoxel.y, (int)currentVoxel.z);

                    if (IsBlockInChunk(neighbour.x, neighbour.y, neighbour.z))
                    {

                        if (blockMap[neighbour.x, neighbour.y, neighbour.z].globalLightPercent < blockMap[v.x, v.y, v.z].globalLightPercent - Block.LightFalloff)
                        {

                            blockMap[neighbour.x, neighbour.y, neighbour.z].globalLightPercent = blockMap[v.x, v.y, v.z].globalLightPercent - Block.LightFalloff;

                            if (blockMap[neighbour.x, neighbour.y, neighbour.z].globalLightPercent > Block.LightFalloff)
                            {
                                litVoxels.Enqueue(neighbour);
                            }

                        }

                    }

                }

            }

        }
        private void ClearMeshData()
        {
            vertexIndex = 0;
            vertices.Clear();
            triangles.Clear();
            transparentTriangles.Clear();
            normals.Clear();
            uvs.Clear();
            colours.Clear();
        }
        public bool IsActive
        {
            get
            {
                return _isActive;
            }
            set
            {
                _isActive = value;
                if (chunkObject != null)
                {
                    chunkObject.SetActive(value);
                }
            }
        }
        public bool IsEditable
        {
            get
            {
                if (!IsBlockMapPopulated)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        static bool IsBlockInChunk(int x, int y, int z)
        {
            if (x < 0 || x > chunkSize - 1 || y < 0 || y > chunkSize - 1 || z < 0 || z > chunkSize - 1)
            {
                return false;
            }
            else
            {
                return true;
            }
        }
        public void EditBlock(Vector3 pos, byte newID)
        {
            int xCheck = Mathf.FloorToInt(pos.x);
            int yCheck = Mathf.FloorToInt(pos.y);
            int zCheck = Mathf.FloorToInt(pos.z);

            xCheck -= Mathf.FloorToInt(chunkObject.transform.position.x);
            yCheck -= Mathf.FloorToInt(chunkObject.transform.position.y);
            zCheck -= Mathf.FloorToInt(chunkObject.transform.position.z);

            blockMap[xCheck, yCheck, zCheck].id = newID;
            lock (world.ChunkUpdateThreadLock)
            {
                world.chunksToUpdate.Insert(0, this);
                UpdateSurroundingBlocks(xCheck, yCheck, zCheck);
            }
        }
        void UpdateSurroundingBlocks(int x, int y, int z)
        {
            Vector3 thisBlock = new Vector3(x, y, z);
            for (int p = 0; p < 6; p++)
            {
                Vector3 currentBlock = thisBlock + Block.faceChecks[p];
                if (!IsBlockInChunk((int)currentBlock.x, (int)currentBlock.y, (int)currentBlock.z))
                {
                    world.chunksToUpdate.Insert(0, world.GetChunkFromVector3(currentBlock + position));
                }
            }
        }
        BlockState CheckBlock(Vector3 pos)
        {
            int x = Mathf.FloorToInt(pos.x);
            int y = Mathf.FloorToInt(pos.y);
            int z = Mathf.FloorToInt(pos.z);
            if (!IsBlockInChunk(x, y, z))
            {
                //UnityEngine.Debug.Log( "BlockState "+ " x " + pos.x + " y " + pos.y + " z " + pos.z);
                return world.GetBlockState(pos + position);
            }
            return blockMap[x, y, z];
        }

        public BlockState GetBlockFromGlobalVector3(Vector3 pos)
        {
            int xCheck = Mathf.FloorToInt(pos.x);
            int yCheck = Mathf.FloorToInt(pos.y);
            int zCheck = Mathf.FloorToInt(pos.z);
            xCheck -= Mathf.FloorToInt(position.x);
            yCheck -= Mathf.FloorToInt(position.y);
            zCheck -= Mathf.FloorToInt(position.z);
            if (xCheck <= -1 || xCheck > chunkSize - 1) // checking for solid neighbour in other chunks
            {
                xCheck = ConvertBlockIndexToLocal(xCheck);
            }
            if (yCheck <= -1 || yCheck > chunkSize - 1)
            {
                yCheck = ConvertBlockIndexToLocal(yCheck);
            }
            if (zCheck <= -1 || zCheck > chunkSize - 1)
            {
                zCheck = ConvertBlockIndexToLocal(zCheck);
            }
            return blockMap[xCheck, yCheck, zCheck];
        }
        static int ConvertBlockIndexToLocal(int i) // converts the block index from other chunk into a index for this chunk
        {
            if (i <= -1)
            {
                i = i + chunkSize - 1;
            }
            else if (i > chunkSize - 1)
            {
                i = i - chunkSize - 1;
            }
            return i;
        }
        public byte GetBlockId(Vector3 pos)
        {
            byte blockID = 0;
            int xCheck = Mathf.FloorToInt(pos.x);
            int yCheck = Mathf.FloorToInt(pos.y);
            int zCheck = Mathf.FloorToInt(pos.z);

            xCheck -= Mathf.FloorToInt(position.x);
            yCheck -= Mathf.FloorToInt(position.y);
            zCheck -= Mathf.FloorToInt(position.z);
            if (xCheck >= 0 || xCheck < chunkSize ) // checking for solid neighbour in other chunks
            {
                xCheck = ConvertBlockIndexToLocal(xCheck);
            }
            if (yCheck >= 0 || yCheck < chunkSize)
            {
                yCheck = ConvertBlockIndexToLocal(yCheck);
            }
            if (zCheck >= 0 || zCheck < chunkSize)
            {
                zCheck = ConvertBlockIndexToLocal(zCheck);
            }
            blockMap[xCheck, yCheck, zCheck].id = blockID;
            return blockID;
        }
        private void UpdateMeshData(Vector3 pos)
        {
            int x = Mathf.FloorToInt(pos.x);
            int y = Mathf.FloorToInt(pos.y);
            int z = Mathf.FloorToInt(pos.z);

            byte blockID = blockMap[x, y, z].id;
            //bool isTransparent = world.blockType[blockID].renderNeighbourFaces;
            for (int p = 0; p < 6; p++)
            {
                BlockState neighbour = CheckBlock(pos + Block.faceChecks[p]);
                
                if (neighbour != null && world.blockType[neighbour.id].renderNeighbourFaces)
                {
                    vertices.Add(pos + Block.Verts[Block.Tris[p, 0]]);
                    vertices.Add(pos + Block.Verts[Block.Tris[p, 1]]);
                    vertices.Add(pos + Block.Verts[Block.Tris[p, 2]]);
                    vertices.Add(pos + Block.Verts[Block.Tris[p, 3]]);
                    
                    for (int i= 0; i < 4; i++) 
                    {
                        normals.Add(Block.faceChecks[p]);
                    }

                    AddTexture(world.blockType[blockID].GetTextureID(p));
                    
                    float lightLevel = neighbour.globalLightPercent;
                    
                    colours.Add(new Color(0, 0, 0, lightLevel));
                    colours.Add(new Color(0, 0, 0, lightLevel));
                    colours.Add(new Color(0, 0, 0, lightLevel));
                    colours.Add(new Color(0, 0, 0, lightLevel));

                    if (! world.blockType[neighbour.id].renderNeighbourFaces)
                    {
                        triangles.Add(vertexIndex);
                        triangles.Add(vertexIndex + 1);
                        triangles.Add(vertexIndex + 2);
                        triangles.Add(vertexIndex + 2);
                        triangles.Add(vertexIndex + 1);
                        triangles.Add(vertexIndex + 3);
                    }
                    else
                    {
                        transparentTriangles.Add(vertexIndex);
                        transparentTriangles.Add(vertexIndex + 1);
                        transparentTriangles.Add(vertexIndex + 2);
                        transparentTriangles.Add(vertexIndex + 2);
                        transparentTriangles.Add(vertexIndex + 1);
                        transparentTriangles.Add(vertexIndex + 3);
                    }
                    vertexIndex += 4;
                }
            }
        }
        public void CreateMesh()
        {
            Mesh mesh = new Mesh
            {
                vertices = vertices.ToArray(),
                subMeshCount = 2,
                //triangles = triangles.ToArray(),
                uv = uvs.ToArray(),
                colors = colours.ToArray(),
                normals = normals.ToArray()
            };
            mesh.SetTriangles(triangles.ToArray(), 0);
            mesh.SetTriangles(transparentTriangles.ToArray(), 1);
            meshFilter.mesh = mesh;
        }
        void AddTexture(int textureID)
        {
            float y = textureID / Block.TextureAtlasSizeInBlocks;
            float x = textureID - (y * Block.TextureAtlasSizeInBlocks);
            x *= Block.NormalizedBlockTextureSize;
            y *= Block.NormalizedBlockTextureSize;

            y = 1f - y - Block.NormalizedBlockTextureSize;

            uvs.Add(new Vector2(x, y));
            uvs.Add(new Vector2(x, y + Block.NormalizedBlockTextureSize));
            uvs.Add(new Vector2(x + Block.NormalizedBlockTextureSize, y));
            uvs.Add(new Vector2(x + Block.NormalizedBlockTextureSize, y + Block.NormalizedBlockTextureSize));
        }
    }
    public struct ChunkCoord
    {
        public int x;
        public int y;
        public int z;

        public ChunkCoord(int _x, int _y, int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        public ChunkCoord(Vector3 pos)
        {
            int xCheck = Mathf.FloorToInt(pos.x);
            int yCheck = Mathf.FloorToInt(pos.y);
            int zCheck = Mathf.FloorToInt(pos.z);

            x = xCheck / Chunk.chunkSize;
            y = yCheck / Chunk.chunkSize;
            z = zCheck / Chunk.chunkSize;
        }
        public bool Equals(ChunkCoord other)
        {
            if (other.x == x && other.y == y && other.z == z)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
    public class BlockState
    {
        public byte id;
        public float globalLightPercent;
        public BlockState()
        {

            id = 0;
            globalLightPercent = 0f;

        }
        public BlockState(byte _id)
        {

            id = _id;
            globalLightPercent = 0f;

        }
    }
}
