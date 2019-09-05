using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GalaxyModule
{
    public enum StarSystemType 
    {
        SINGULAR_STAR_SYSTEM,
        BINARY_STAR_SYSTEM,
        TRINARY_STAR_SYSTEM,
        COUNT,
    }
    public class StarSystem
    {
        public int numPlanets;
        public Galaxy galaxy;
        public StarType starType1;
        public StarType starType2;
        public StarType starType3;
        public StarSystemType starSystemType;
        public Vector3 starPosition;
        public Sector sector;
        public GameObject starSystemsObject;
        public string starSystemName;
        public StarSystem(StarType _starType1, StarType _starType2, StarType _starType3, Vector3 StarPosition, string StarSystemName, Sector Sector, GameObject StarSystemsObject, Galaxy Galaxy) 
        {
            starType1 = _starType1;
            starType2 = _starType2;
            starType3 = _starType3;
            galaxy = Galaxy;
            starPosition = StarPosition;
            starSystemName = StarSystemName;
            sector = Sector;
            GenerateStarSystemType();
            starSystemsObject = StarSystemsObject;
            GenerateStars(starSystemType);
            starSystemsObject.GetComponent<MeshRenderer>().material = starType1.starColour;
        }
        void GenerateStarSystemType() 
        {
            starSystemType = (StarSystemType)Random.Range(0, (int)StarSystemType.COUNT);
        }
        void GenerateStars(StarSystemType StarSystemType) 
        {
            if (StarSystemType == StarSystemType.SINGULAR_STAR_SYSTEM) 
            {
                int starType1Int = Random.Range(0, galaxy.starTypeTable.Length);
                starType1 = galaxy.starTypeTable[starType1Int];
                starType2 = null;
                starType3 = null;
                numPlanets = (int)Random.Range(0, 9);
            }
            if (StarSystemType == StarSystemType.BINARY_STAR_SYSTEM)
            {
                int starType1Int = Random.Range(0, galaxy.starTypeTable.Length);
                starType1 = galaxy.starTypeTable[starType1Int];
                int starType2Int = Random.Range(0, galaxy.starTypeTable.Length);
                starType2 = galaxy.starTypeTable[starType2Int];
                starType3 = null;
                numPlanets = (int)Random.Range(0, 9);
            }
            if (StarSystemType == StarSystemType.TRINARY_STAR_SYSTEM)
            {
                int starType1Int = Random.Range(0, galaxy.starTypeTable.Length);
                starType1 = galaxy.starTypeTable[starType1Int];
                int starType2Int = Random.Range(0, galaxy.starTypeTable.Length);
                starType2 = galaxy.starTypeTable[starType2Int];
                int starType3Int = Random.Range(0, galaxy.starTypeTable.Length);
                starType3 = galaxy.starTypeTable[starType3Int];
                numPlanets = (int)Random.Range(0, 9);
            }
        }
    }
}
