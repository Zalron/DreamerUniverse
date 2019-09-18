using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{
    public class ItemQuality
    {
        int QualityPercent;
        int QualityModifier;
        public ItemQuality(int _QualityModifier, int _QualityPercent)
        {
            QualityModifier = _QualityModifier;
            QualityPercent = _QualityPercent;
        }
    }
}
