using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
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
        public GameObject starSystemObject;
        public int numSectorStars;
        //public StarSystem[] starSystemsInSector = new StarSystem[];
        public GameObject sectorGameObject;
        static public Sector sector;
        public SectorCoord sectorCoord;
        public SectorCoord trueSectorCoord;
        private bool _isActive;
        public bool threadLocked = false;

        public Sector(SectorCoord SectorCoord, SectorCoord TrueSectorCoord, Mesh sectorSphereMesh, Galaxy Galaxy)
        {
            galaxy = Galaxy;
            sectorCoord = SectorCoord;
            trueSectorCoord = TrueSectorCoord;
            sphereMesh = sectorSphereMesh;
            string sn = BuildSectorName(sectorCoord);
            sectorName = sn;
            _isActive = true;
            sectorGameObject = new GameObject(sectorName);
            sectorGameObject.transform.SetParent(galaxy.transform);
            sectorType = SectorTypeGeneration(sectorCoord);
            GenerateSector(sectorType);
        }
        public static string BuildSectorName(SectorCoord v) // assigning a name to a Sector
        {
            return "Sector : " + (int)v.x + "_" + (int)v.y + "_" + (int)v.z;
        }
        public static string BuildStarSystemName(Vector3 v, string sectorName) // assigning a name to a Sector
        {
            return (int)v.x + "_" + (int)v.y + "_" + (int)v.z + "_: " + sectorName;
        }
        public SectorType SectorTypeGeneration(SectorCoord sectorCoord)
        {
            SectorType sectorType;
            if (sectorCoord.x >= 0 && sectorCoord.x <= 50 || sectorCoord.x >= -0 && sectorCoord.x <= -50 ||
                sectorCoord.y >= 0 && sectorCoord.y <= 30 || sectorCoord.y >= -0 && sectorCoord.y <= -30 ||
                sectorCoord.z >= 0 && sectorCoord.z <= 50 || sectorCoord.z >= -0 && sectorCoord.z <= -50)
            {
                sectorType = SectorType.Core;
                return sectorType;
            }
            if (sectorCoord.x > 50 && sectorCoord.x <= 100 || sectorCoord.x > -50 && sectorCoord.x <= -100 ||
                sectorCoord.y > 30 && sectorCoord.y <= 35 || sectorCoord.y > -30 && sectorCoord.y <= -35 ||
                sectorCoord.z > 50 && sectorCoord.z <= 100 || sectorCoord.z > -50 && sectorCoord.z <= -100)
            {
                sectorType = SectorType.Middle;
                return sectorType;
            }
            if (sectorCoord.x > 100 && sectorCoord.x <= 200 || sectorCoord.x > -100 && sectorCoord.x <= -200 ||
                sectorCoord.y > 35 && sectorCoord.y <= 40 || sectorCoord.y > -35 && sectorCoord.y <= -40 ||
                sectorCoord.z > 100 && sectorCoord.z <= 200 || sectorCoord.z > -100 && sectorCoord.z <= -200)
            {
                sectorType = SectorType.Edge;
                return sectorType;
            }
            if (sectorCoord.x > 200 && sectorCoord.x <= 500 || sectorCoord.x > -200 && sectorCoord.x <= -500 ||
                sectorCoord.y > 40 && sectorCoord.y <= 50 || sectorCoord.y > -40 && sectorCoord.y <= -50 ||
                sectorCoord.z > 200 && sectorCoord.z <= 500 || sectorCoord.z > -200 && sectorCoord.z <= -500)
            {
                sectorType = SectorType.Far;
                return sectorType;
            }
            else
            {
                sectorType = SectorType.Core;
                return sectorType;
            }

        }
        public void GenerateSector(SectorType sectorType)
        {
            if (sectorType == SectorType.Core)
            {
                numSectorStars = Random.Range(4500, 5000 + 1);
            }
            else if (sectorType == SectorType.Middle)
            {
                numSectorStars = Random.Range(1000, 1500 + 1);
            }
            else if (sectorType == SectorType.Edge)
            {
                numSectorStars = Random.Range(100, 200 + 1);
            }
            else if (sectorType == SectorType.Far)
            {
                numSectorStars = Random.Range(10, 50 + 1);
            }
            for (int i = 0; i < numSectorStars; i++)
            {
                Vector3 StarPosition = new Vector3(Random.Range(trueSectorCoord.x, Galaxy.SectorSize + trueSectorCoord.x + 1), Random.Range(trueSectorCoord.y, Galaxy.SectorSize + trueSectorCoord.y + 1), Random.Range(trueSectorCoord.z, Galaxy.SectorSize + trueSectorCoord.z + 1));
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
            starSystemObject.transform.SetParent(sectorGameObject.transform);
            new StarSystem(null, null, null, StarSystemType.COUNT, 0, StarPosition, ssn, sector, starSystemObject, galaxy);
        }
        public bool IsActive
        {
            get { return _isActive; }
            set
            {
                _isActive = value;
                if (sectorGameObject != null)
                {
                    sectorGameObject.SetActive(value);
                    
                }
            }
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
