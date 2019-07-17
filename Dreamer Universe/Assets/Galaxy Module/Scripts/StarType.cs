using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GalaxyGenerator
{
    [CreateAssetMenu(fileName = "StarType", menuName = "Galaxy/StarType", order = 1)]
    public class StarType : ScriptableObject
    {
        public string starTypeString;
        public Material starColour;
        public int temperatureK;
        public int radiusMetric_m;
        public int luminosity;
        public float absoluteMagnitude;
        public int massMetric_m;
        public int habitableZone;
        public float abundance;
    }
}
