using UnityEngine;
using System.Collections;
namespace ItemModule
{
    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Mod", order = 1)]
    public class ItemMod : ScriptableObject
    {
        public string itemModString;
        public string itemModDescriptionString;
        public string itemModOnItemString;
        public int itemModIntModifier;
        public ItemStats itemStatModifiying;
        public ItemMod SetItemMods(Item i, ItemMod itemMod)
        {
            itemMod.itemModOnItemString = ConvertString.ItemModStringGenerator(itemMod.itemModIntModifier, itemMod.itemModDescriptionString);
            return itemMod;
        }
    }
    
}
