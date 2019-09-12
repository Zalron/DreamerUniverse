using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{

    [CreateAssetMenu(fileName = "ItemSO", menuName = "ItemSO/ItemSO Rarity", order = 1)]
    public class ItemRaritiesSO : ScriptableObject
    {
        public string rarityName;
        public Color rarityColor;
        public int itemRarityIntModifierMin;
        public int itemRarityIntModifierMax;
        public int rarityIntAffixsAllowed;
    }
}
