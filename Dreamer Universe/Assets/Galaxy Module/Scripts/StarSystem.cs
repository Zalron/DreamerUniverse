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
        public StarSystem(StarType _starType1, StarType _starType2, StarType _starType3, 
                          StarSystemType _starSystemType, Vector3 StarPosition, string StarSystemName, Sector Sector, GameObject StarSystemsObject, Galaxy Galaxy) 
        {
            starType1 = _starType1;
            starType2 = _starType2;
            starType3 = _starType3;
            starSystemType = _starSystemType;
            galaxy = Galaxy;
            starPosition = StarPosition;
            starSystemName = StarSystemName;
            sector = Sector;
            starSystemsObject = StarSystemsObject;
            starSystemsObject.GetComponent<MeshRenderer>().material = starType1.starColour;
        }
    }
}
