using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{
    enum ItemStatType
    {
        CriticalChance,
        MagicalDamage,
        PhysicalDamage,
        Handling,
        Accuracy,
        Guard,
        Weight,
        Range,
        AttackSpeed,
        ReloadTime,
        FireRate,
        MagazineSize,
    }
    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Stats", order = 1)]
    public class ItemStats : ScriptableObject
    {
        public string itemStatString;
        public bool isPercentage;
        ItemStatType itemStatType;
    }
}
