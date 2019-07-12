﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GalaxyGenerator
{
    [CreateAssetMenu(fileName = "StarType", menuName = "Galaxy/StarType", order = 1)]
    public class StarType : ScriptableObject
    {
        public string starTypeString;
        public Material starColour;
        public int temperature;
        public int size;
        public int luminosity;
        public int mass;
    }
}
