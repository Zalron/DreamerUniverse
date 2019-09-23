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
        public string itemQualityPercent;
        public ItemQualityType itemQuality;
        public int itemQualityPercentIntMin;
        public int itemQualityPercentIntMax;
    }
    public class ItemQuality
    {
        public string ItemQualityPercent;
        public ItemQualityType ItemQualityType;
        public int ItemQualityPercentInt;
        public ItemQuality(string _itemQualityPercent, int _itemQualityPercentInt, ItemQualityType _itemQualityType)
        {
            ItemQualityPercent = _itemQualityPercent;
            ItemQualityPercentInt = _itemQualityPercentInt;
            ItemQualityType = _itemQualityType;
        }
    }
}