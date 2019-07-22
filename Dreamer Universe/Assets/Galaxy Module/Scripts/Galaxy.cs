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

        List<SectorCoord> sectorsToCreate = new List<SectorCoord>();
        List<Sector> sectorsToUpdate = new List<Sector>();
        public Queue<Sector> sectorsToDraw = new Queue<Sector>();

        // Start is called before the first frame update
        void Start()
        {
            GenerateGalaxy((int)(player.transform.position.x / SectorSize), (int)(player.transform.position.y / SectorSize), (int)(player.transform.position.z / SectorSize), 1);
            playerLastSectorCoord = GetSectorCoordFromVector3(player.transform.position);
        }
        void Update()
        {
            playerSectorCoord = GetSectorCoordFromVector3(player.transform.position);
            playerSectorCoordVector = playerSectorCoord;
            if (!playerSectorCoord.Equals(playerLastSectorCoord))
            {

            }
        }
        void GenerateGalaxy(int x, int y, int z, int startradius)// builds Sectors around the player
        {
            //builds sector center
            GenerateSectorAt(x, y, z, true);
            //builds sector forward
            GenerateSectorAt(x, y, z + startradius, true);
            //builds sector back
            GenerateSectorAt(x, y, z - startradius, true);
            //builds sector left
            GenerateSectorAt(x - startradius, y, z, true);
            //builds sector right
            GenerateSectorAt(x + startradius, y, z, true);
            //builds sector up
            GenerateSectorAt(x, y + startradius, z, true);
            //builds sector down
            GenerateSectorAt(x, y - startradius, z, true);

            //builds sectors on the x and z planes
            GenerateSectorAt(x - startradius, y, z - startradius, true);
            GenerateSectorAt(x - startradius, y, z + startradius, true);
            GenerateSectorAt(x + startradius, y, z + startradius, true);
            GenerateSectorAt(x + startradius, y, z - startradius, true);

            //builds sectors on the y and z planes
            GenerateSectorAt(x, y - startradius, z + startradius, true);
            GenerateSectorAt(x, y - startradius, z - startradius, true);
            GenerateSectorAt(x, y + startradius, z + startradius, true);
            GenerateSectorAt(x, y + startradius, z - startradius, true);

            //builds sectors on the x and z planes
            GenerateSectorAt(x - startradius, y - startradius, z, true);
            GenerateSectorAt(x - startradius, y + startradius, z, true);
            GenerateSectorAt(x + startradius, y + startradius, z, true);
            GenerateSectorAt(x + startradius, y - startradius, z, true);

            //builds edge sectors on the x y z planes
            GenerateSectorAt(x - startradius, y - startradius, z - startradius, true);
            GenerateSectorAt(x + startradius, y - startradius, z - startradius, true);
            GenerateSectorAt(x + startradius, y + startradius, z - startradius, true);
            GenerateSectorAt(x + startradius, y + startradius, z + startradius, true);
            GenerateSectorAt(x - startradius, y - startradius, z + startradius, true);
            GenerateSectorAt(x - startradius, y + startradius, z + startradius, true);
            GenerateSectorAt(x + startradius, y - startradius, z + startradius, true);
            GenerateSectorAt(x - startradius, y + startradius, z - startradius, true);
        }
        void CheckViewDistance()
        {

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

        }
        void GenerateSectorAt(int x, int y, int z, bool isGeneratedAtStarttime)// builds Sectors
        {
            Vector3 SectorPosition = new Vector3(x * SectorSize, y * SectorSize, z * SectorSize);
            SectorCoord rawSectorCoord = GetRawSectorCoordFromVector3(SectorPosition);
            SectorCoord sectorCoord = GetSectorCoordFromVector3(SectorPosition);
            new Sector(isGeneratedAtStarttime, sectorCoord, rawSectorCoord, sphereMesh, this);
        }
        bool IsSectorInGalaxy(SectorCoord coord)
        {
            if (coord.x > 0 && coord.x < galaxyLength - 1 && coord.y > 0 && coord.y < galaxyHeight - 1 && coord.z > 0 && coord.z < galaxyWidth - 1)
            {
                return true;
            }
            else
            {
                return false;
            }
        }
        bool IsStarSystemInWorld(Vector3 pos)
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
