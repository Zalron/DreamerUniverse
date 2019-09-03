using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using System.Threading;
namespace GalaxyModule
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
        public int numSectorStars;
        //public StarSystem[] starSystemsInSector = new StarSystem[];
        public List<StarSystem> SectorStars = new List<StarSystem>();
        public GameObject sectorGameObject;
        List<Vector3> StarPositionList = new List<Vector3>();
        List<Vector3> StarSystemSizeList = new List<Vector3>();
        static public Sector sector;
        public SectorCoord sectorCoord;
        public SectorCoord trueSectorCoord;
        private bool _isActive;
        public bool threadLocked = false;
        private bool IsSectorPopulated = false;
        public Sector(SectorCoord SectorCoord, SectorCoord TrueSectorCoord, Mesh sectorSphereMesh, Galaxy Galaxy)
        {
            galaxy = Galaxy;
            sectorCoord = SectorCoord;
            trueSectorCoord = TrueSectorCoord;
            sphereMesh = sectorSphereMesh;
        }
        public void Init()
        {
            string sn = BuildSectorName(sectorCoord);
            sectorName = sn;
            sectorGameObject = new GameObject(sectorName);
            sectorGameObject.transform.SetParent(galaxy.transform);
            GenerateStarSystemAll(StarPositionList, StarSystemSizeList);
            Debug.Log("I am created" + sn);
        }
        public static string BuildSectorName(SectorCoord v) // assigning a name to a Sector
        {
            return "Sector : " + (int)v.x + "_" + (int)v.y + "_" + (int)v.z;
        }
        public static string BuildStarSystemName(Vector3 v, string sectorName) // assigning a name to a Sector
        {
            return (int)v.x + "_" + (int)v.y + "_" + (int)v.z + "_: " + sectorName;
        }
        
        public void UpdateSector()
        {
            GenerateSectorStarPosition();
            galaxy.sectorsToDraw.Enqueue(this);
            Debug.Log("UpdateSector");
        }
        public int GenerateSectorNumStars(SectorType sectorType)
        {
            int _numSectorStars;
            if (sectorType == SectorType.Core)
            {
                _numSectorStars = galaxy.randomNumber.Next(4500, 5000 + 1);
                return _numSectorStars;
            }
            else if (sectorType == SectorType.Middle)
            {
                _numSectorStars = galaxy.randomNumber.Next(1000, 1500 + 1);
                return _numSectorStars;
            }
            else if (sectorType == SectorType.Edge)
            {
                _numSectorStars = galaxy.randomNumber.Next(100, 200 + 1);
                return _numSectorStars;
            }
            else if (sectorType == SectorType.Far)
            {
                _numSectorStars = galaxy.randomNumber.Next(10, 50 + 1);
                return _numSectorStars;
            }
            else 
            {
                return 0;
            }
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
        public void GenerateSectorStarPosition()
        {
            sectorType = SectorTypeGeneration(sectorCoord);
            numSectorStars = GenerateSectorNumStars(sectorType);            
            for (int i = 0; i < numSectorStars; i++)
            {
                Vector3 StarPosition = new Vector3(galaxy.randomNumber.Next(trueSectorCoord.x, Galaxy.SectorSize + trueSectorCoord.x + 1), galaxy.randomNumber.Next(trueSectorCoord.y, Galaxy.SectorSize + trueSectorCoord.y + 1), galaxy.randomNumber.Next(trueSectorCoord.z, Galaxy.SectorSize + trueSectorCoord.z + 1));
                StarPositionList.Add(StarPosition);
                float fStarSystemSize = galaxy.randomNumber.Next(1, 10);
                Vector3 StarSystemSize = new Vector3(fStarSystemSize, fStarSystemSize, fStarSystemSize);
                StarPositionList.Add(StarSystemSize);
            }
            IsSectorPopulated = true;
            Debug.Log("Creating star positions");
        }
        public void GenerateStarSystemAll(List<Vector3> _StarPositionList, List<Vector3> _StarSystemSizeList)
        {
            for(int p = 0; p < _StarPositionList.Count; p++)
            {
                for(int s = 0; s < _StarSystemSizeList.Count; s++)
                {
                    GenerateStarSystem( _StarPositionList[p], _StarSystemSizeList[s], sectorName, sectorGameObject);
                }
            }
        }
        public void GenerateStarSystem(Vector3 StarPosition, Vector3 StarSystemSize, string sectorName, GameObject sectorGameObject)
        {
            string ssn = BuildStarSystemName(StarPosition, sectorName);
            GameObject starSystemObject = new GameObject(ssn);
            starSystemObject.AddComponent<MeshFilter>().mesh = sphereMesh;
            starSystemObject.AddComponent<MeshRenderer>();
            starSystemObject.transform.position = StarPosition;
            starSystemObject.transform.localScale = StarSystemSize;
            starSystemObject.transform.SetParent(sectorGameObject.transform);
            StarSystem i = new StarSystem(null, null, null, StarSystemType.COUNT, 0, StarPosition, ssn, sector, starSystemObject, galaxy);
            SectorStars.Add(i);
            Debug.Log("Created StarSystems");
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
        public bool IsPopulated
        {
            get
            {
                if (!IsSectorPopulated)
                {
                    return false;
                }
                else
                {
                    return true;
                }
            }
        }
        public bool IsEditable
        {
            get
            {
                if (!IsSectorPopulated)
                {
                    return false;
                }
                else
                {
                    return true;
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
