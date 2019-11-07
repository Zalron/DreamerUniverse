using System.Collections;
using System.Collections.Generic;
using SimplexNoise;
using UnityEngine;
namespace WorldModule
{
    [CreateAssetMenu(fileName = "Biomes", menuName = "ScriptableObject/Biomes", order = 1)]
    public class Biomes : ScriptableObject
    {
        public string biomeName;
        [Header("Terrian Height")]
        public int terrainHeight;
        
        public byte surfaceBlock;
        public byte subSurfaceBlock;
        [Header("Terrian Settings")]
        public float terrainOffset;
        public int terrainOctaves;
        public float terrainSmooth;
        public float terrainScale;
        public float terrainPersistance;
        [Header("Major Flora")]
        public int majorFloraIndex;
        public float majorFloraZoneScale = 1.3f;
        [Range(0.1f, 1f)]
        public float majorFloraZoneThreshold = 0.6f;
        public float majorFloraPlacementScale = 15f;
        [Range(0.1f, 1f)]
        public float majorFloraPlacementThreshold = 0.8f;
        public bool placeMajorFlora = true;

        public int maxMajorFloraHeight = 12;
        public int minMajorFloraHeight = 4;
        [Header("Blocks")]
        public Lode[] lodes;
    }
    [System.Serializable]
    public class Lode
    {
        public BlockType blockType;
        public byte BlockID;
        public int minHeight;
        public int maxHeight;
        public float scale;
        public float smooth;
        public float octaves;
        public float persistance;
        public float threshold;
        public float offset;
    }
}