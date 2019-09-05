using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace GalaxyModule
{
    [CreateAssetMenu(fileName = "Sector", menuName = "Galaxy/Sector", order = 1)]
    public class SectorSO : ScriptableObject
    {
        public int xpositiveBoundsMin;
        public int xpositiveBoundsMax;
        public int xnegativeBoundsMin;
        public int xnegativeBoundsMax;
        public int ypositiveBoundsMin;
        public int ypositiveBoundsMax;
        public int ynegativeBoundsMin;
        public int ynegativeBoundsMax;
        public int zpositiveBoundsMin;
        public int zpositiveBoundsMax;
        public int znegativeBoundsMin;
        public int znegativeBoundsMax;
        public int SectorStarNumMin;
        public int SectorStarNumMax;
    }
}
