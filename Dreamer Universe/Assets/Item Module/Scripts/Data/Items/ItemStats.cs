using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemModule
{

    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Stats", order = 1)]
    public class ItemStats : ScriptableObject
    {
        public string itemStatString;
        public int itemStatInt;
        public string itemStatOnItemString;
        public bool isPercentage;
        public ItemStats ItemModStatGenerator(Item i, ItemStats itemStat, ItemMod itemMod1, ItemMod itemMod2, ItemMod itemMod3, ItemMod itemMod4, ItemMod itemMod5, ItemMod itemMod6)
        {
            if(itemMod1 == null)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemRequirements, null);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if (itemStat.name == itemMod1.itemStatModifiying.name)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemRequirements, itemMod1);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if (itemMod1 == null || itemMod2 == null )
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemRequirements, null);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if (itemStat.name == itemMod2.itemStatModifiying.name)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemRequirements, itemMod2);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if(itemMod1 == null || itemMod2 == null || itemMod3 == null )
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemRequirements, null);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if (itemStat.name == itemMod3.itemStatModifiying.name)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemRequirements, itemMod3);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if(itemMod1 == null || itemMod2 == null || itemMod3 == null || itemMod4 == null )
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemRequirements, null);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if (itemStat.name == itemMod4.itemStatModifiying.name)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemRequirements, itemMod4);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if(itemMod1 == null || itemMod2 == null || itemMod3 == null || itemMod4 == null || itemMod5 == null )
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemRequirements, null);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if (itemStat.name == itemMod5.itemStatModifiying.name)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemRequirements, itemMod5);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if(itemMod1 == null || itemMod2 == null || itemMod3 == null || itemMod4 == null || itemMod5 == null || itemMod6 == null)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemRequirements, null);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if (itemStat.name == itemMod6.itemStatModifiying.name)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemRequirements, itemMod6);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else
            {
                return itemStat;
            }
        }
        public static int ItemStatGenerators(ItemName itemName, ItemTypes itemType, ItemRarities itemRarities, ItemRequirements itemRequirement, ItemMod itemMod)
        {
            int ItemStatInt = 0;
            ItemStatInt += itemName.itemNameIntModifier;
            ItemStatInt += itemType.itemTypeIntModifier;
            ItemStatInt += itemRarities.rarityIntModifier;
            ItemStatInt += itemRequirement.ItemLevelModifier;
            if (itemMod == null)
            {
                ItemStatInt += 0;
            }
            else
            {
                ItemStatInt += itemMod.itemModIntModifier;
            }
            return ItemStatInt;
        }

    }
}
