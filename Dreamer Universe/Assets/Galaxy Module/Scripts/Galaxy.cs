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
        //public Sector sector;
        public Mesh sphereMesh;
        public GameObject player;
        //public GameObject starSystemsObjectMaster;
        public static int SectorSize = 1000;
        public static ConcurrentDictionary<string, Sector> sectors;
        public static List<string> toRemove = new List<string>(); // a list to remove the chunks that are not needed from the dictionary
        public static int galaxyHeight = 120; // the height of the Galaxy
        public static int galaxyLength = 1000; // the length of the Galaxy
        public static int galaxyWidth = 1000; // the width of the Galaxy
        // Start is called before the first frame update
        void Start()
        {
            GenerateGalaxy((int)(player.transform.position.x / SectorSize), (int)(player.transform.position.y / SectorSize), (int)(player.transform.position.z / SectorSize), 1);
            //sphereMesh = starSystemsObjectMaster.GetComponent<MeshFilter>().mesh;
            //Destroy(starSystemsObjectMaster);
        }
        void Update()
        {

        }
        public static string BuildSectorName(SectorCoord v) // assigning a name to a Sector
        {
            return "Sector : " + (int)v.x + "_" + (int)v.y + "_" + (int)v.z;
        }
        void GenerateSectorAt(int x, int y, int z)// builds Sectors
        {
            Vector3 SectorPosition = new Vector3(x * SectorSize, y * SectorSize, z * SectorSize);
            SectorCoord rawSectorCoord = GetRawSectorCoordFromVector3(SectorPosition);
            SectorCoord sectorCoord = GetSectorCoordFromVector3(SectorPosition);
            string sn = BuildSectorName(sectorCoord);
            Sector.sector = new Sector(true, sectorCoord, rawSectorCoord, SectorType.Core, sn, 0, sphereMesh, this);
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
        void GenerateGalaxy(int x, int y, int z, int startradius)// builds Sectors around the player
        {
            //builds sector center
            GenerateSectorAt(x, y, z);
            //builds sector forward
            GenerateSectorAt(x, y, z + startradius);
            //builds sector back
            GenerateSectorAt(x, y, z - startradius);
            //builds sector left
            GenerateSectorAt(x - startradius, y, z);
            //builds sector right
            GenerateSectorAt(x + startradius, y, z);
            //builds sector up
            GenerateSectorAt(x, y + startradius, z);
            //builds sector down
            GenerateSectorAt(x, y - startradius, z);

            //builds sectors on the x and z planes
            GenerateSectorAt(x - startradius, y, z - startradius);
            GenerateSectorAt(x - startradius, y, z + startradius);
            GenerateSectorAt(x + startradius, y, z + startradius);
            GenerateSectorAt(x + startradius, y, z - startradius);

            //builds sectors on the y and z planes
            GenerateSectorAt(x, y - startradius, z + startradius);
            GenerateSectorAt(x, y - startradius, z - startradius);
            GenerateSectorAt(x, y + startradius, z + startradius);
            GenerateSectorAt(x, y + startradius, z - startradius);

            //builds sectors on the x and z planes
            GenerateSectorAt(x - startradius, y - startradius, z);
            GenerateSectorAt(x - startradius, y + startradius, z);
            GenerateSectorAt(x + startradius, y + startradius, z);
            GenerateSectorAt(x + startradius, y - startradius, z);

            //builds edge sectors on the x y z planes
            GenerateSectorAt(x - startradius, y - startradius, z - startradius);
            GenerateSectorAt(x + startradius, y - startradius, z - startradius);
            GenerateSectorAt(x + startradius, y + startradius, z - startradius);
            GenerateSectorAt(x + startradius, y + startradius, z + startradius);
            GenerateSectorAt(x - startradius, y - startradius, z + startradius);
            GenerateSectorAt(x - startradius, y + startradius, z + startradius);
            GenerateSectorAt(x + startradius, y - startradius, z + startradius);
            GenerateSectorAt(x - startradius, y + startradius, z - startradius);
        }
    }
}
