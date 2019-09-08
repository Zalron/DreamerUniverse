using UnityEngine;
using System.Collections;
namespace ItemSubModule
{
    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Mod", order = 1)]
    public class ItemMod : ScriptableObject
    {
        public string itemModString;
        public string itemModDescriptionString;
        public string itemModOnItemString;
        public int itemModIntModifierMin;
        public int itemModIntModifierMax;
        public ItemStats itemStatModifiying;
        
    }
    
}
