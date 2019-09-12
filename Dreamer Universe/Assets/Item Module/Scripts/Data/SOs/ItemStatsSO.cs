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
    [CreateAssetMenu(fileName = "ItemSO", menuName = "ItemSO/ItemSO Stats", order = 1)]
    public class ItemStatsSO : ScriptableObject
    {
        public string itemStatString;
        public bool isPercentage;
        ItemStatType itemStatType;
    }
}
