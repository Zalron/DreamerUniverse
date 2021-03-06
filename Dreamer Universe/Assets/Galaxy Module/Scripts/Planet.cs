﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using Sirenix.OdinInspector;
namespace GalaxyModule
{
    [CreateAssetMenu(fileName = "Planet", menuName = "Galaxy/Planet", order = 1)]
    public class Planet: ScriptableObject
    {
        public string planetString;
        public int planetMass;
        public int planetTemperature;
        public int planetRadius;
        public int planetGravity;
        public int planetOrbitSpeed;
        public int planetRotationSpeed;
        public bool plaetHasWater;
        public bool planetHasAstroidBelt;
        [EnableIf("planetHasAstroidBelt")]
        public int planetAstroidBeltSize;
        public bool planetHasSatellite;
        [EnableIf("planetHasSatellite")]
        public int planetSatelliteNumber;
    }
}