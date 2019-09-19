using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{
    public enum ItemQualityType
    {
        Quality_1, Quality_2, Quality_3, Quality_4, Quality_5, Quality_6, Quality_7, Quality_8, Quality_9, Quality_10,
        Quality_11, Quality_12, Quality_13, Quality_14, Quality_15, Quality_16, Quality_17, Quality_18, Quality_19, Quality_20,
    }
    public class ItemQualitySO : MonoBehaviour
    {
        public string ItemQualityPercent;
        public ItemQualityType ItemQuality;
        public int ItemQualityPercentIntMin;
        public int ItemQualityPercentIntMax;
    }
}