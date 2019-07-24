using System.Collections;
using System.Collections.Generic;
using System.Collections.Concurrent;
using UnityEngine;
namespace GalaxyGenerator
{
    public class Galaxy : MonoBehaviour
    {
        public StarType[] starTypeTable;
        public Planet[] planetTypeTable;

        public Mesh sphereMesh;
        public GameObject player;

        List<Sector> galaxySectors;
        public SectorCoord playerSectorCoord;
        SectorCoord playerLastSectorCoord;

        public Vector3 playerSectorCoordVector;

        public static int SectorSize = 1000;

        public static int galaxyHeight = 120; // the height of the Galaxy
        public static int galaxyLength = 1000; // the length of the Galaxy
        public static int galaxyWidth = 1000; // the width of the Galaxy

        List<Sector> createdSectors = new List<Sector>();
        List<SectorCoord> createdSectorCoords = new List<SectorCoord>();
        List<Sector> activeSectors = new List<Sector>();
        List<Sector> sectorsToCreate = new List<Sector>();
        List<Sector> sectorsToUpdate = new List<Sector>();
        public Queue<Sector> sectorsToDraw = new Queue<Sector>();

        public static readonly int ViewDistanceInSectors = 1;

        // Start is called before the first frame update
        void Start()
        {
            GenerateGalaxy((int)(player.transform.position.x / SectorSize), (int)(player.transform.position.y / SectorSize), (int)(player.transform.position.z / SectorSize), ViewDistanceInSectors);
            playerLastSectorCoord = GetSectorCoordFromVector3(player.transform.position);
        }
        void Update()
        {
            playerSectorCoord = GetSectorCoordFromVector3(player.transform.position);
            playerSectorCoordVector = GetSectorVectorFromSectorCoord(playerSectorCoord);
            if (!playerSectorCoord.Equals(playerLastSectorCoord))
            {
                CheckViewDistance();
            }
            if (sectorsToCreate.Count > 0)
            {

            }
        }
        void GenerateGalaxy(int x, int y, int z, int startradius)// builds Sectors around the player
        {
            for (int startx = x - startradius; startx <= x + startradius; startx++)
            {
                for (int starty = y - startradius; starty <= y + startradius; starty++)
                {
                    for (int startz = z - startradius; startz <= z + startradius; startz++)
                    {
                        GenerateSectorAt(startx, starty, startz);
                    }
                }
            }
        }
        void CheckViewDistance()
        {
            SectorCoord sectorCoord = GetSectorCoordFromVector3(player.transform.position);
            playerLastSectorCoord = playerSectorCoord;
            List<Sector> previouslyActiveSector = new List<Sector>(activeSectors);
            for (int x = sectorCoord.x - ViewDistanceInSectors; x <= sectorCoord.x + ViewDistanceInSectors; x++)
            {
                for (int y = sectorCoord.y - ViewDistanceInSectors; y <= sectorCoord.y + ViewDistanceInSectors; y++)
                {
                    for (int z = sectorCoord.z - ViewDistanceInSectors; z <= sectorCoord.z + ViewDistanceInSectors; z++)
                    {
                        if (IsSectorInGalaxy(new SectorCoord(x,y,z)))
                        {
                            GenerateSectorAt(x, y, z);
                        }
                        if (IsSectorCreatedBefore(new SectorCoord(x, y, z)))
                        {

                        }
                        for (int i = 0; i < previouslyActiveSector.Count; i++)
                        {
                            if (previouslyActiveSector[i].Equals(new SectorCoord(x,y,z)))
                            {
                                previouslyActiveSector.RemoveAt(i);
                            }
                        }
                    }
                }
            }
            foreach (Sector c in previouslyActiveSector)
            {
                c.IsActive = false;
                Destroy(c.sectorGameObject);
            }
        }
        SectorCoord GetRawSectorCoordFromVector3(Vector3 pos)
        {
            int x = (int)pos.x;
            int y = (int)pos.y;
            int z = (int)pos.z;
            return new SectorCoord(x, y, z);
        }
        SectorCoord GetSectorCoordFromVector3(Vector3 pos)
        {
            int x = Mathf.FloorToInt(pos.x / SectorSize);
            int y = Mathf.FloorToInt(pos.y / SectorSize);
            int z = Mathf.FloorToInt(pos.z / SectorSize);
            return new SectorCoord(x, y, z);
        }
        public Vector3 GetSectorVectorFromSectorCoord(SectorCoord sectorCoord)
        {
            Vector3 sectorCoordVector3convert;
            sectorCoordVector3convert.x = sectorCoord.x / SectorSize;
            sectorCoordVector3convert.y = sectorCoord.y / SectorSize;
            sectorCoordVector3convert.z = sectorCoord.z / SectorSize;
            return sectorCoordVector3convert;
        }
        //void  
        void GenerateSectorAt(int x, int y, int z)// builds Sectors
        {
            Vector3 SectorPosition = new Vector3(x * SectorSize, y * SectorSize, z * SectorSize);
            SectorCoord rawSectorCoord = GetRawSectorCoordFromVector3(SectorPosition);
            SectorCoord sectorCoord = GetSectorCoordFromVector3(SectorPosition);
            Sector i = new Sector(sectorCoord, rawSectorCoord, sphereMesh, this);
            createdSectors.Add(i);
            activeSectors.Add(i);
            createdSectorCoords.Add(sectorCoord);
        }
        bool IsSectorCreatedBefore(SectorCoord coord)
        {
            if (createdSectorCoords.Contains(coord))
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool IsSectorInGalaxy(SectorCoord coord)
        {
            if (coord.x >= -galaxyLength + 1 && coord.x <= galaxyLength - 1 
                && coord.y >= -galaxyHeight + 1 && coord.y <= galaxyHeight - 1 
                && coord.z >= -galaxyLength + 1 && coord.z <= galaxyWidth - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool IsStarSystemInGalaxy(Vector3 pos)
        {
            if (pos.x >= 0 && pos.x < galaxyLength && pos.y >= 0 && pos.y < galaxyHeight && pos.z >= 0 && pos.z < galaxyWidth)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
    }
}
