using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GalaxyGenerator
{

    public class Planet: ScriptableObject
    {
        public int planetSize;
        public bool planetHasAstroidBelt;
        public int planetAstroidBeltSize;
        public bool planetHasSatellite;
        public int planetSatelliteNumber;
    }
}