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
    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Affixs", order = 1)]
    public class ItemAffixs : ScriptableObject
    {
        public ItemAffix itemAffixType;
        public ItemMod itemMod;
        public string itemAffixString;
        public bool isSpecialModifier;
    }
}
