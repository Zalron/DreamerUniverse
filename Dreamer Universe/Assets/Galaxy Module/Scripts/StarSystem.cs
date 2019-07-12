using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GalaxyGenerator
{
    public enum StarSystemType 
    {
        SINGULAR_STAR_SYSTEM,
        BINARY_STAR_SYSTEM,
        TRINARY_STAR_SYSTEM,
        COUNT,
    }
    public enum StarTypes 
    {   
        NONE,
        PULSAR,
        NEUTRON_STAR,
        WHITE_DWARF,
        BROWN_DWARF,
        YELLOW_DWARF,
        YELLOW,
        BLUE,
        WHITE,
        BLUE_GIANT,
        RED_GIANT,
        SUPER_RED_GIANT,
        COUNT,
    }
    public class StarSystem
    {
        public int numPlanets;
        public StarTypes starType1;
        public StarTypes starType2;
        public StarTypes starType3;
        public StarSystemType starSystemType;
        public Vector3 starPosition;
        public Sector sector;
        public GameObject starSystemsObject;
        public string starSystemName;
        public StarSystem(StarTypes StarType1, StarTypes StarType2, StarTypes StarType3, StarSystemType StarSystemType, int NumPlanets, Vector3 StarPosition, string StarSystemName, Sector Sector, GameObject StarSystemObject) 
        {
            numPlanets = NumPlanets;
            starSystemType = StarSystemType;
            starType1 = StarType1;
            starType2 = StarType2;
            starType3 = StarType3;
            starPosition = StarPosition;
            starSystemName = StarSystemName;
            sector = Sector;
            starSystemsObject = StarSystemObject;
            GenerateStars(StarSystemType);
            GenerateStarSystemType();
        }
        void GenerateStarSystemType() 
        {
            starSystemType = (StarSystemType)Random.Range(0, (int)StarSystemType.COUNT); 
        }
        void GenerateStars(StarSystemType StarSystemType) 
        {
            if (StarSystemType == StarSystemType.SINGULAR_STAR_SYSTEM) 
            {
                starType1 = (StarTypes)Random.Range(0, (int)StarTypes.COUNT);
                starType2 = StarTypes.NONE;
                starType3 = StarTypes.NONE;
                numPlanets = (int)Random.Range(0,9);
            }
            if (StarSystemType == StarSystemType.BINARY_STAR_SYSTEM)
            {
                starType1 = (StarTypes)Random.Range(0, (int)StarTypes.COUNT);
                starType2 = (StarTypes)Random.Range(0, (int)StarTypes.COUNT);
                starType3 = StarTypes.NONE;
                numPlanets = (int)Random.Range(0, 9);
            }
            if (StarSystemType == StarSystemType.TRINARY_STAR_SYSTEM)
            {
                starType1 = (StarTypes)Random.Range(0, (int)StarTypes.COUNT);
                starType2 = (StarTypes)Random.Range(0, (int)StarTypes.COUNT);
                starType3 = (StarTypes)Random.Range(0, (int)StarTypes.COUNT);
                numPlanets = (int)Random.Range(0, 9);
            }
        }
    }
}
