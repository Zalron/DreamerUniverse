using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GalaxyGenerator
{
    public enum SectorType
    {
        Core,
        Middle,
        Edge,
        Far,
    }
    public class Sector
    {
        public Mesh sphereMesh;
        public SectorType sectorType;
        public Galaxy galaxy;
        public string sectorName;
        public Vector3 sectorPosition;
        public GameObject starSystemObject;
        public int numSectorStars;
        public GameObject sectorGameObject;
        static public Sector sector;
        public SectorCoord sectorCoord;

        public Sector(SectorCoord SectorCoord, SectorType SectorType, Vector3 SectorPosition, string SectorName, int NumSectorStars, Mesh sectorSphereMesh)
        {
            sectorName = SectorName;
            sectorCoord = SectorCoord;
            sectorType = SectorType;
            sectorPosition = SectorPosition; 
            numSectorStars = NumSectorStars;
            sphereMesh = sectorSphereMesh;
            sectorGameObject = new GameObject(sectorName);
            GenerateSector(SectorType);
        }
        public static string BuildStarSystemName(Vector3 v, string sectorName) // assigning a name to a Sector
        {
            return (int)v.x + "_" + (int)v.y + "_" + (int)v.z + "_Sector: " + sectorName;
        }
        public void GenerateSector(SectorType sectorType)
        {
            if (sectorType == SectorType.Core)
            {
                numSectorStars = Random.Range(500, 800 + 1);
            }
            else if (sectorType == SectorType.Middle)
            {
                numSectorStars = Random.Range(200, 500 + 1);
            }
            else if (sectorType == SectorType.Edge)
            {
                numSectorStars = Random.Range(50, 200 + 1);
            }
            else if (sectorType == SectorType.Far)
            {
                numSectorStars = Random.Range(10, 50 + 1);
            }
            for (int i = 0; i < numSectorStars; i++)
            {
                Vector3 StarPosition = new Vector3(Random.Range(sectorPosition.x, Galaxy.SectorSize + sectorPosition.x + 1), Random.Range(sectorPosition.y, Galaxy.SectorSize + sectorPosition.y + 1), Random.Range(sectorPosition.z, Galaxy.SectorSize + sectorPosition.z + 1));
                float fStarSystemSize = Random.Range(1, 10);
                Vector3 StarSystemSize = new Vector3(fStarSystemSize, fStarSystemSize, fStarSystemSize);
                GenerateStarSystem(StarPosition, StarSystemSize, sectorName, sectorGameObject);
            }
        }
        public void GenerateStarSystem(Vector3 StarPosition, Vector3 StarSystemSize, string sectorName, GameObject sectorGameObject)
        {
            string ssn = BuildStarSystemName(StarPosition, sectorName);
            starSystemObject = new GameObject(ssn);
            starSystemObject.AddComponent<MeshFilter>().mesh = sphereMesh;
            starSystemObject.AddComponent<MeshRenderer>();
            starSystemObject.transform.position = StarPosition;
            starSystemObject.transform.localScale = StarSystemSize;
            new StarSystem(StarType.NONE, StarType.NONE, StarType.NONE, StarSystemType.COUNT, 0, StarPosition, ssn, sector, starSystemObject);
            starSystemObject.transform.SetParent(sectorGameObject.transform);

        }
    }
    public class SectorCoord
    {
        public int x;
        public int y;
        public int z;

        public SectorCoord()
        {
            x = 0;
            y = 0;
            z = 0;
        }
        public SectorCoord(int _x, int _y, int _z)
        {
            x = _x;
            y = _y;
            z = _z;
        }
        public SectorCoord(Vector3 pos)
        {
            int xCheck = Mathf.FloorToInt(pos.x);
            int yCheck = Mathf.FloorToInt(pos.y);
            int zCheck = Mathf.FloorToInt(pos.z);

            x = xCheck / Galaxy.SectorSize;
            y = yCheck / Galaxy.SectorSize;
            z = zCheck / Galaxy.SectorSize;
        }
        public bool Equals(SectorCoord other)
        {
            if (other == null)
            {
                return false;
            }
            else if (other.x == x && other.y == y && other.z == z)
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
