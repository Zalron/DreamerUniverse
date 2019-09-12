using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{
    public enum ItemAffix
    {
        Preffix,
        Suffix
    }
    [CreateAssetMenu(fileName = "ItemSO", menuName = "ItemSO/ItemSO Affixs", order = 1)]
    public class ItemAffixsSO : ScriptableObject
    {
        public ItemAffix itemAffixType;
        public ItemModSO itemMod;
        public string itemAffixString;
        public bool isSpecialModifier;
    }
}
