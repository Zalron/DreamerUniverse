using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace RPGLootGenerator
{
    public enum ItemSubType
    {
        Weapon_Melee_OneHanded,
        Weapon_Melee_TwoHanded,
        Weapon_Ranged_OneHanded,
        Weapon_Ranged_TwoHanded,
        Armour_PowerArmour,
        Armour_NonPowerArmour,
        Currency_Stackable,
        Currency_NonStackable,
        Equipment,
        Spells,
    }
    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Types", order = 1)]
    public class ItemTypes : ScriptableObject
    {
        public string ItemTypeName;
        public int itemTypeIntModifier;
        public ItemSubType itemSubType;
    }
}
