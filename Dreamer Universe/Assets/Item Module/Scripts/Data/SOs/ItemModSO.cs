using UnityEngine;
using System.Collections;
namespace ItemSubModule
{
    [CreateAssetMenu(fileName = "ItemSO", menuName = "ItemSO/ItemSO Mod", order = 1)]
    public class ItemModSO : ScriptableObject
    {
        public string itemModString;
        public string itemModDescriptionString;
        public string itemModOnItemString;
        public int itemModIntModifierMin;
        public int itemModIntModifierMax;
        public ItemStatsSO itemStatModifiying;
        public int itemModScore;
    }
    
}
