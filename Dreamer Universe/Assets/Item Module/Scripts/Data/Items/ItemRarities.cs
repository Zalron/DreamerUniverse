using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{

    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Rarity", order = 1)]
    public class ItemRarities : ScriptableObject
    {
        public string rarityName;
        public Color rarityColor;
        public int itemRarityIntModifierMin;
        public int itemRarityIntModifierMax;
        public int rarityIntAffixsAllowed;
    }
}
