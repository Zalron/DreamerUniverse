using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{
    public class ItemQuality
    {
        public string QualityPercent;
        public int QualityModifier;
        public ItemQuality(int _QualityModifier, string _QualityPercent)
        {
            QualityModifier = _QualityModifier;
            QualityPercent = _QualityPercent;
        }
    }
}
