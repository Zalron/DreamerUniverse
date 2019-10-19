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
        public Sector sectorClass;
        public Mesh sphereMesh;
        public SectorType sectorType;
        public Galaxy galaxy;
        public string sectorName;
        public int numSectorStars;
        //public StarSystem[] starSystemsInSector = new StarSystem[];
        public List<StarSystem> SectorStars = new List<StarSystem>();
        public GameObject sectorGameObject;
        Queue<SectorStarTransform> StarTransformList = new Queue<SectorStarTransform>();
        public Sector sector;
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
            GenerateStarSystemAll(StarTransformList);
            //Debug.Log("I am created " + sn);
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
            //Debug.Log("UpdateSector");
        }
        public int GenerateSectorNumStars(SectorType sectorType)
        {
            int _numSectorStars;
            if (sectorType == SectorType.Core)
            {
                _numSectorStars = galaxy.randomNumber.Next(galaxy.SectorTypeTable[0].SectorStarNumMin, galaxy.SectorTypeTable[0].SectorStarNumMax);
                return _numSectorStars;
            }
            else if (sectorType == SectorType.Middle)
            {
                _numSectorStars = galaxy.randomNumber.Next(galaxy.SectorTypeTable[1].SectorStarNumMin, galaxy.SectorTypeTable[1].SectorStarNumMax);
                return _numSectorStars;
            }
            else if (sectorType == SectorType.Edge)
            {
                _numSectorStars = galaxy.randomNumber.Next(galaxy.SectorTypeTable[2].SectorStarNumMin, galaxy.SectorTypeTable[2].SectorStarNumMax);
                return _numSectorStars;
            }
            else if (sectorType == SectorType.Far)
            {
                _numSectorStars = galaxy.randomNumber.Next(galaxy.SectorTypeTable[3].SectorStarNumMin, galaxy.SectorTypeTable[3].SectorStarNumMax);
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
            if (sectorCoord.x >= galaxy.SectorTypeTable[0].xpositiveBoundsMin && sectorCoord.x <= galaxy.SectorTypeTable[0].xpositiveBoundsMax || sectorCoord.x >= galaxy.SectorTypeTable[0].xnegativeBoundsMin && sectorCoord.x <= galaxy.SectorTypeTable[0].xnegativeBoundsMax ||
                sectorCoord.y >= galaxy.SectorTypeTable[0].ypositiveBoundsMin && sectorCoord.y <= galaxy.SectorTypeTable[0].ypositiveBoundsMax || sectorCoord.y >= galaxy.SectorTypeTable[0].ynegativeBoundsMin && sectorCoord.y <= galaxy.SectorTypeTable[0].ynegativeBoundsMax ||
                sectorCoord.z >= galaxy.SectorTypeTable[0].zpositiveBoundsMin && sectorCoord.z <= galaxy.SectorTypeTable[0].zpositiveBoundsMax || sectorCoord.z >= galaxy.SectorTypeTable[0].znegativeBoundsMin && sectorCoord.z <= galaxy.SectorTypeTable[0].znegativeBoundsMax)
            {
                sectorType = SectorType.Core;
                return sectorType;
            }
            if (sectorCoord.x > galaxy.SectorTypeTable[1].xpositiveBoundsMin && sectorCoord.x <= galaxy.SectorTypeTable[1].xpositiveBoundsMax || sectorCoord.x > galaxy.SectorTypeTable[1].xnegativeBoundsMin && sectorCoord.x <= galaxy.SectorTypeTable[1].xnegativeBoundsMax ||
                sectorCoord.y > galaxy.SectorTypeTable[1].ypositiveBoundsMin && sectorCoord.y <= galaxy.SectorTypeTable[1].ypositiveBoundsMax || sectorCoord.y > galaxy.SectorTypeTable[1].ynegativeBoundsMin && sectorCoord.y <= galaxy.SectorTypeTable[1].ynegativeBoundsMax ||
                sectorCoord.z > galaxy.SectorTypeTable[1].zpositiveBoundsMin && sectorCoord.z <= galaxy.SectorTypeTable[1].zpositiveBoundsMax || sectorCoord.z > galaxy.SectorTypeTable[1].znegativeBoundsMin && sectorCoord.z <= galaxy.SectorTypeTable[1].znegativeBoundsMax)
            {
                sectorType = SectorType.Middle;
                return sectorType;
            }
            if (sectorCoord.x > galaxy.SectorTypeTable[2].xpositiveBoundsMin && sectorCoord.x <= galaxy.SectorTypeTable[2].xpositiveBoundsMax || sectorCoord.x > galaxy.SectorTypeTable[2].xnegativeBoundsMin && sectorCoord.x <= galaxy.SectorTypeTable[2].xnegativeBoundsMax ||
                sectorCoord.y > galaxy.SectorTypeTable[2].ypositiveBoundsMin && sectorCoord.y <= galaxy.SectorTypeTable[2].ypositiveBoundsMax || sectorCoord.y > galaxy.SectorTypeTable[2].ynegativeBoundsMin && sectorCoord.y <= galaxy.SectorTypeTable[2].ynegativeBoundsMax ||
                sectorCoord.z > galaxy.SectorTypeTable[2].zpositiveBoundsMin && sectorCoord.z <= galaxy.SectorTypeTable[2].zpositiveBoundsMax || sectorCoord.z > galaxy.SectorTypeTable[2].znegativeBoundsMin && sectorCoord.z <= galaxy.SectorTypeTable[2].znegativeBoundsMax)
            {
                sectorType = SectorType.Edge;
                return sectorType;
            }
            if (sectorCoord.x > galaxy.SectorTypeTable[3].xpositiveBoundsMin && sectorCoord.x <= galaxy.SectorTypeTable[3].xpositiveBoundsMax || sectorCoord.x > galaxy.SectorTypeTable[3].xnegativeBoundsMin && sectorCoord.x <= galaxy.SectorTypeTable[3].xnegativeBoundsMax ||
                sectorCoord.y > galaxy.SectorTypeTable[3].ypositiveBoundsMin && sectorCoord.y <= galaxy.SectorTypeTable[3].ypositiveBoundsMax || sectorCoord.y > galaxy.SectorTypeTable[3].ynegativeBoundsMin && sectorCoord.y <= galaxy.SectorTypeTable[3].ynegativeBoundsMax ||
                sectorCoord.z > galaxy.SectorTypeTable[3].zpositiveBoundsMin && sectorCoord.z <= galaxy.SectorTypeTable[3].zpositiveBoundsMax || sectorCoord.z > galaxy.SectorTypeTable[3].znegativeBoundsMin && sectorCoord.z <= galaxy.SectorTypeTable[3].znegativeBoundsMax)
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
                float fStarSystemSize = galaxy.randomNumber.Next(1, 10);
                StarType starType1 = null;
                StarType starType2 = null;
                StarType starType3 = null;
                StarSystemType starSystemType = (StarSystemType)galaxy.randomNumber.Next(0, (int)StarSystemType.COUNT);
                if (starSystemType == StarSystemType.SINGULAR_STAR_SYSTEM)
                {
                    int starType1int = galaxy.randomNumber.Next(0, galaxy.starTypeTable.Length);
                    starType1 = galaxy.starTypeTable[starType1int];
                }
                else if (starSystemType == StarSystemType.BINARY_STAR_SYSTEM)
                {
                    int starType1int = galaxy.randomNumber.Next(0, galaxy.starTypeTable.Length);
                    starType1 = galaxy.starTypeTable[starType1int];
                    int starType2int = galaxy.randomNumber.Next(0, galaxy.starTypeTable.Length);
                    starType2 = galaxy.starTypeTable[starType2int];
                }
                else if (starSystemType == StarSystemType.TRINARY_STAR_SYSTEM)
                {
                    int starType1int = galaxy.randomNumber.Next(0, galaxy.starTypeTable.Length);
                    starType1 = galaxy.starTypeTable[starType1int];
                    int starType2int = galaxy.randomNumber.Next(0, galaxy.starTypeTable.Length);
                    starType2 = galaxy.starTypeTable[starType2int];
                    int starType3int = galaxy.randomNumber.Next(0, galaxy.starTypeTable.Length);
                    starType3 = galaxy.starTypeTable[starType3int];
                }
                SectorStarTransform StarTransform = new SectorStarTransform(new Vector3 (galaxy.randomNumber.Next(trueSectorCoord.x, Galaxy.SectorSize + trueSectorCoord.x + 1), 
                                                                                         galaxy.randomNumber.Next(trueSectorCoord.y, Galaxy.SectorSize + trueSectorCoord.y + 1), 
                                                                                         galaxy.randomNumber.Next(trueSectorCoord.z, Galaxy.SectorSize + trueSectorCoord.z + 1)),
                                                                            new Vector3 (fStarSystemSize, fStarSystemSize, fStarSystemSize), 
                                                                            starSystemType, starType1, starType2, starType3);
                                                                            
                StarTransformList.Enqueue(StarTransform);
            }
            IsSectorPopulated = true;
            //Debug.Log("Creating star positions");
        }
       
        public void GenerateStarSystemAll(Queue<SectorStarTransform> _StarPositionList)
        {
            while(_StarPositionList.Count > 0)
            {
                SectorStarTransform _SingleStarPosition = _StarPositionList.Dequeue();
                GenerateStarSystem( _SingleStarPosition, sectorName, sectorGameObject);
            }
            //Debug.Log(_StarPositionList.Count + "_" + _StarSystemSizeList.Count);
        }
        public void GenerateStarSystem(SectorStarTransform StarTransform, string sectorName, GameObject sectorGameObject)
        {
            string ssn = BuildStarSystemName(StarTransform.StarPosition, sectorName);
            GameObject starSystemObject = new GameObject(ssn);
            starSystemObject.AddComponent<MeshFilter>().mesh = sphereMesh;
            starSystemObject.AddComponent<MeshRenderer>();
            starSystemObject.transform.position = StarTransform.StarPosition;
            starSystemObject.transform.localScale = StarTransform.StarSystemSize;
            starSystemObject.transform.SetParent(sectorGameObject.transform);
            StarSystem i = new StarSystem(StarTransform.starType1, StarTransform.starType2, StarTransform.starType3, StarTransform.StarSystemType, StarTransform.StarPosition, ssn, sector, starSystemObject, galaxy);
            SectorStars.Add(i);
            //Debug.Log("Created StarSystems");
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
        //public bool IsPopulated
        //{
        //    get
        //    {
        //        if (!IsSectorPopulated)
        //        {
        //            return false;
        //        }
        //        else
        //        {
        //            return true;
        //        }
        //    }
        //}
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
    public class SectorStarTransform
    {
        public Vector3 StarPosition;
        public Vector3 StarSystemSize;
        public StarSystemType StarSystemType;
        public StarType starType1;
        public StarType starType2;
        public StarType starType3;
        public SectorStarTransform(Vector3 _StarPositionList, Vector3 _StarSystemSizeList, StarSystemType _StarSystemType, StarType _starType1, StarType _starType2, StarType _starType3)
        {
            StarPosition = _StarPositionList;
            StarSystemSize = _StarSystemSizeList;
            StarSystemType = _StarSystemType;
            starType1 = _starType1;
            starType2 = _starType2;
            starType3 = _starType3;
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
