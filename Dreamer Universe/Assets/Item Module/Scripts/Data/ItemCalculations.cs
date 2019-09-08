using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{
    public static class ItemCalculations
    {
        public static Item ItemGenerator(Item i, ItemName[] itemNameDropTable, ItemAffixs[] itemPrefixDropTable, ItemAffixs[] itemSuffixDropTable, ItemStats[] itemStatDropTable, ItemRarities[] itemRarityDropTable, ItemLevel[] itemRequirementsDropTable)
        {
            if (itemNameDropTable == null || itemPrefixDropTable == null || itemSuffixDropTable == null || itemStatDropTable == null || itemRarityDropTable == null || itemRequirementsDropTable == null)
            {
                Debug.Log("A table doesn't have anything in it");
            }
            int itemNameDropTableNumber = Random.Range(0, itemNameDropTable.Length);
            i.itemName = itemNameDropTable[itemNameDropTableNumber];
            i.itemType = i.itemName.itemType;
            int itemRequirementsDropTableNumber = Random.Range(0, itemRequirementsDropTable.Length);
            i.itemLevel = itemRequirementsDropTable[itemRequirementsDropTableNumber];
            int itemRarityDropTableNumber = Random.Range(0, itemRarityDropTable.Length);
            i.itemRarity = itemRarityDropTable[itemRarityDropTableNumber];
            i = RarityAffixGenerator(i, itemPrefixDropTable, itemSuffixDropTable);
            i.itemStat1 = itemStatDropTable[0];
            i.itemStat2 = itemStatDropTable[1];
            i.itemStat3 = itemStatDropTable[2];
            i.itemStat4 = itemStatDropTable[3];
            i.itemStat5 = itemStatDropTable[4];
            i.itemStat6 = itemStatDropTable[5];
            i.itemStat1 = ItemModStatGenerator(i, i.itemStat1, i.itemMod1, i.itemMod2, i.itemMod3, i.itemMod4, i.itemMod5, i.itemMod6);
            i.itemStat2 = ItemModStatGenerator(i, i.itemStat2, i.itemMod1, i.itemMod2, i.itemMod3, i.itemMod4, i.itemMod5, i.itemMod6);
            i.itemStat3 = ItemModStatGenerator(i, i.itemStat3, i.itemMod1, i.itemMod2, i.itemMod3, i.itemMod4, i.itemMod5, i.itemMod6);
            i.itemStat4 = ItemModStatGenerator(i, i.itemStat4, i.itemMod1, i.itemMod2, i.itemMod3, i.itemMod4, i.itemMod5, i.itemMod6);
            i.itemStat5 = ItemModStatGenerator(i, i.itemStat5, i.itemMod1, i.itemMod2, i.itemMod3, i.itemMod4, i.itemMod5, i.itemMod6);
            i.itemStat6 = ItemModStatGenerator(i, i.itemStat6, i.itemMod1, i.itemMod2, i.itemMod3, i.itemMod4, i.itemMod5, i.itemMod6);
            if (i.itemPrefixs1 == null && i.itemSuffixs1 == null)
            {
                i.itemCombinedNameString = ConvertString.CombineNameString("", i.itemName.ItemNameString, "");
            }
            else if (i.itemSuffixs1 == null)
            {
                i.itemCombinedNameString = ConvertString.CombineNameString(i.itemPrefixs1.itemAffixString, i.itemName.ItemNameString, "");
            }
            else if (i.itemPrefixs1 == null)
            {
                i.itemCombinedNameString = ConvertString.CombineNameString("", i.itemName.ItemNameString, i.itemSuffixs1.itemAffixString);
            }
            else
            {
                i.itemCombinedNameString = ConvertString.CombineNameString(i.itemPrefixs1.itemAffixString, i.itemName.ItemNameString, i.itemSuffixs1.itemAffixString);
            }
            return i;

        }
        public static ItemStats ItemModStatGenerator(Item i, ItemStats itemStat, ItemMod itemMod1, ItemMod itemMod2, ItemMod itemMod3, ItemMod itemMod4, ItemMod itemMod5, ItemMod itemMod6)
        {
            if (itemMod1 == null)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemLevel, null);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if (itemStat.name == itemMod1.itemStatModifiying.name)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemLevel, itemMod1);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if (itemMod1 == null || itemMod2 == null)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemLevel, null);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if (itemStat.name == itemMod2.itemStatModifiying.name)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemLevel, itemMod2);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if (itemMod1 == null || itemMod2 == null || itemMod3 == null)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemLevel, null);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if (itemStat.name == itemMod3.itemStatModifiying.name)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemLevel, itemMod3);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if (itemMod1 == null || itemMod2 == null || itemMod3 == null || itemMod4 == null)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemLevel, null);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if (itemStat.name == itemMod4.itemStatModifiying.name)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemLevel, itemMod4);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if (itemMod1 == null || itemMod2 == null || itemMod3 == null || itemMod4 == null || itemMod5 == null)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemLevel, null);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if (itemStat.name == itemMod5.itemStatModifiying.name)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemLevel, itemMod5);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if (itemMod1 == null || itemMod2 == null || itemMod3 == null || itemMod4 == null || itemMod5 == null || itemMod6 == null)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemLevel, null);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else if (itemStat.name == itemMod6.itemStatModifiying.name)
            {
                itemStat.itemStatInt = ItemStatGenerators(i.itemName, i.itemType, i.itemRarity, i.itemLevel, itemMod6);
                itemStat.itemStatOnItemString = ConvertString.ItemStatStringGenerator(itemStat.itemStatInt, itemStat.itemStatString);
                return itemStat;
            }
            else
            {
                return itemStat;
            }
        }
        public static int ItemStatGenerators(ItemName itemName, ItemTypes itemType, ItemRarities itemRarities, ItemLevel itemLevel, ItemMod itemMod)
        {
            int ItemStatInt = 0;
            int ItemNameIntModifierSolved = Random.Range(itemName.itemNameIntModifierMin, itemName.itemNameIntModifierMax);
            ItemStatInt += ItemNameIntModifierSolved;
            int ItemTypeIntModifierSolved = Random.Range(itemType.itemTypeIntModifierMin, itemType.itemTypeIntModifierMax);
            ItemStatInt += ItemTypeIntModifierSolved;
            int ItemRarityIntModifierSolved = Random.Range(itemRarities.itemRarityIntModifierMin, itemName.itemNameIntModifierMax);
            ItemStatInt += ItemRarityIntModifierSolved;
            int ItemLevelIntModifierSolved = Random.Range(itemLevel.ItemLevelIntModifierMin, itemLevel.ItemLevelIntModifierMax);
            ItemStatInt += ItemLevelIntModifierSolved;
            if (itemMod == null)
            {
                ItemStatInt += 0;
            }
            else
            {
                int ItemModIntModifierSolved = Random.Range(itemMod.itemModIntModifierMin, itemMod.itemModIntModifierMax);
                ItemStatInt += ItemModIntModifierSolved;
            }
            return ItemStatInt;
        }
        public static ItemMod SetItemMods(Item i, ItemMod itemMod)
        {
            itemMod.itemModOnItemString = ConvertString.ItemModStringGenerator(itemMod.itemModIntModifierMin, itemMod.itemModDescriptionString);
            return itemMod;
        }
        public static Item RarityAffixGenerator(Item i, ItemAffixs[] itemPrefixDropTable, ItemAffixs[] itemSuffixDropTable)
        {
            int itemAffixSort;
            int itemPrefixDropTableNumber1;
            int itemPrefixDropTableNumber2;
            int itemPrefixDropTableNumber3;
            int itemPrefixDropTableNumber4;
            int itemPrefixDropTableNumber5;
            int itemSuffixDropTableNumber1;
            int itemSuffixDropTableNumber2;
            int itemSuffixDropTableNumber3;
            int itemSuffixDropTableNumber4;
            int itemSuffixDropTableNumber5;
            switch (i.itemRarity.rarityIntAffixsAllowed)
            {
                case 0:
                    i.itemPrefixs1 = null;
                    i.itemPrefixs2 = null;
                    i.itemPrefixs3 = null;
                    i.itemPrefixs4 = null;
                    i.itemPrefixs5 = null;
                    i.itemSuffixs1 = null;
                    i.itemSuffixs2 = null;
                    i.itemSuffixs3 = null;
                    i.itemSuffixs4 = null;
                    i.itemSuffixs5 = null;
                    return i;
                case 1:
                    itemAffixSort = Random.Range(1, 3);
                    if (itemAffixSort == 1)
                    {
                        itemPrefixDropTableNumber1 = Random.Range(0, itemPrefixDropTable.Length);
                        i.itemPrefixs1 = itemPrefixDropTable[itemPrefixDropTableNumber1];
                        i.itemSuffixs1 = null;
                        i.itemMod1 = i.itemPrefixs1.itemMod;
                        i.itemMod1 = SetItemMods(i, i.itemMod1);
                    }
                    else if (itemAffixSort == 2)
                    {
                        itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                        i.itemPrefixs1 = null;
                        i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                        i.itemMod1 = i.itemSuffixs1.itemMod;
                        i.itemMod1 = SetItemMods(i, i.itemMod1);
                    }
                    i.itemPrefixs2 = null;
                    i.itemPrefixs3 = null;
                    i.itemPrefixs4 = null;
                    i.itemPrefixs5 = null;
                    i.itemSuffixs2 = null;
                    i.itemSuffixs3 = null;
                    i.itemSuffixs4 = null;
                    i.itemSuffixs5 = null;
                    return i;
                case 2:
                    itemPrefixDropTableNumber1 = Random.Range(0, itemPrefixDropTable.Length);
                    itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                    i.itemPrefixs1 = itemPrefixDropTable[itemPrefixDropTableNumber1];
                    i.itemMod1 = i.itemPrefixs1.itemMod;
                    i.itemMod1 = SetItemMods(i, i.itemMod1);
                    i.itemPrefixs2 = null;
                    i.itemPrefixs3 = null;
                    i.itemPrefixs4 = null;
                    i.itemPrefixs5 = null;
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemMod2 = i.itemSuffixs1.itemMod;
                    i.itemMod2 = SetItemMods(i, i.itemMod2);
                    i.itemSuffixs2 = null;
                    i.itemSuffixs3 = null;
                    i.itemSuffixs4 = null;
                    i.itemSuffixs5 = null;
                    return i;
                case 3:
                    itemAffixSort = Random.Range(1, 3);
                    if (itemAffixSort == 1)
                    {
                        itemPrefixDropTableNumber2 = Random.Range(0, itemPrefixDropTable.Length);
                        i.itemPrefixs2 = itemPrefixDropTable[itemPrefixDropTableNumber2];
                        i.itemMod3 = i.itemPrefixs2.itemMod;
                        i.itemMod3 = SetItemMods(i, i.itemMod3);
                        i.itemSuffixs2 = null;
                    }
                    else if (itemAffixSort == 2)
                    {
                        itemSuffixDropTableNumber2 = Random.Range(0, itemSuffixDropTable.Length);
                        i.itemPrefixs2 = null;
                        i.itemSuffixs2 = itemSuffixDropTable[itemSuffixDropTableNumber2];
                        i.itemMod3 = i.itemSuffixs2.itemMod;
                        i.itemMod3 = SetItemMods(i, i.itemMod3);
                    }
                    itemPrefixDropTableNumber1 = Random.Range(0, itemPrefixDropTable.Length);
                    itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                    i.itemPrefixs1 = itemPrefixDropTable[itemPrefixDropTableNumber1];
                    i.itemMod1 = i.itemPrefixs1.itemMod;
                    i.itemMod1 = SetItemMods(i, i.itemMod1);
                    i.itemPrefixs3 = null;
                    i.itemPrefixs4 = null;
                    i.itemPrefixs5 = null;
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemMod2 = i.itemSuffixs1.itemMod;
                    i.itemMod2 = SetItemMods(i, i.itemMod2);
                    i.itemSuffixs3 = null;
                    i.itemSuffixs4 = null;
                    i.itemSuffixs5 = null;
                    return i;
                case 4:
                    itemPrefixDropTableNumber1 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber2 = Random.Range(0, itemPrefixDropTable.Length);
                    itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber2 = Random.Range(0, itemSuffixDropTable.Length);
                    i.itemPrefixs1 = itemPrefixDropTable[itemPrefixDropTableNumber1];
                    i.itemMod1 = i.itemPrefixs1.itemMod;
                    i.itemMod1 = SetItemMods(i, i.itemMod1);
                    i.itemPrefixs2 = itemPrefixDropTable[itemPrefixDropTableNumber2];
                    i.itemMod3 = i.itemPrefixs1.itemMod;
                    i.itemMod3 = SetItemMods(i, i.itemMod3);
                    i.itemPrefixs3 = null;
                    i.itemPrefixs4 = null;
                    i.itemPrefixs5 = null;
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemMod2 = i.itemSuffixs1.itemMod;
                    i.itemMod2 = SetItemMods(i, i.itemMod2);
                    i.itemSuffixs2 = itemSuffixDropTable[itemSuffixDropTableNumber2];
                    i.itemMod4 = i.itemSuffixs1.itemMod;
                    i.itemMod4 = SetItemMods(i, i.itemMod4);
                    i.itemSuffixs3 = null;
                    i.itemSuffixs4 = null;
                    i.itemSuffixs5 = null;
                    return i;
                case 5:
                    itemAffixSort = Random.Range(1, 3);
                    if (itemAffixSort == 1)
                    {
                        itemPrefixDropTableNumber3 = Random.Range(0, itemPrefixDropTable.Length);
                        i.itemPrefixs3 = itemPrefixDropTable[itemPrefixDropTableNumber3];
                        i.itemSuffixs3 = null;
                        i.itemMod5 = i.itemPrefixs3.itemMod;
                        i.itemMod5 = SetItemMods(i, i.itemMod5);
                    }
                    else if (itemAffixSort == 2)
                    {
                        itemSuffixDropTableNumber3 = Random.Range(0, itemSuffixDropTable.Length);
                        i.itemPrefixs3 = null;
                        i.itemSuffixs3 = itemSuffixDropTable[itemSuffixDropTableNumber3];
                        i.itemMod5 = i.itemSuffixs3.itemMod;
                        i.itemMod5 = SetItemMods(i, i.itemMod5);
                    }
                    itemPrefixDropTableNumber1 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber2 = Random.Range(0, itemPrefixDropTable.Length);
                    itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber2 = Random.Range(0, itemSuffixDropTable.Length);
                    i.itemPrefixs1 = itemPrefixDropTable[itemPrefixDropTableNumber1];
                    i.itemMod1 = i.itemPrefixs1.itemMod;
                    i.itemMod1 = SetItemMods(i, i.itemMod1);
                    i.itemPrefixs2 = itemPrefixDropTable[itemPrefixDropTableNumber2];
                    i.itemMod3 = i.itemPrefixs2.itemMod;
                    i.itemMod3 = SetItemMods(i, i.itemMod3);
                    i.itemPrefixs4 = null;
                    i.itemPrefixs5 = null;
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemMod2 = i.itemSuffixs1.itemMod;
                    i.itemMod2 = SetItemMods(i, i.itemMod2);
                    i.itemSuffixs2 = itemSuffixDropTable[itemSuffixDropTableNumber2];
                    i.itemMod4 = i.itemSuffixs2.itemMod;
                    i.itemMod4 = SetItemMods(i, i.itemMod4);
                    i.itemSuffixs4 = null;
                    i.itemSuffixs5 = null;
                    return i;
                case 6:
                    itemPrefixDropTableNumber1 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber2 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber3 = Random.Range(0, itemPrefixDropTable.Length);
                    itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber2 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber3 = Random.Range(0, itemSuffixDropTable.Length);
                    i.itemPrefixs1 = itemPrefixDropTable[itemPrefixDropTableNumber1];
                    i.itemMod1 = i.itemPrefixs1.itemMod;
                    i.itemMod1 = SetItemMods(i, i.itemMod1);
                    i.itemPrefixs2 = itemPrefixDropTable[itemPrefixDropTableNumber2];
                    i.itemMod3 = i.itemPrefixs2.itemMod;
                    i.itemMod3 = SetItemMods(i, i.itemMod3);
                    i.itemPrefixs3 = itemPrefixDropTable[itemPrefixDropTableNumber3];
                    i.itemMod5 = i.itemPrefixs3.itemMod;
                    i.itemMod5 = SetItemMods(i, i.itemMod5);
                    i.itemPrefixs4 = null;
                    i.itemPrefixs5 = null;
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemMod2 = i.itemSuffixs1.itemMod;
                    i.itemMod2 = SetItemMods(i, i.itemMod2);
                    i.itemSuffixs2 = itemSuffixDropTable[itemSuffixDropTableNumber2];
                    i.itemMod4 = i.itemSuffixs2.itemMod;
                    i.itemMod4 = SetItemMods(i, i.itemMod4);
                    i.itemSuffixs3 = itemSuffixDropTable[itemSuffixDropTableNumber3];
                    i.itemMod6 = i.itemSuffixs3.itemMod;
                    i.itemMod6 = SetItemMods(i, i.itemMod6);
                    i.itemSuffixs4 = null;
                    i.itemSuffixs5 = null;
                    return i;
                case 7:
                    itemAffixSort = Random.Range(1, 3);
                    if (itemAffixSort == 1)
                    {
                        itemPrefixDropTableNumber4 = Random.Range(0, itemPrefixDropTable.Length);
                        i.itemPrefixs4 = itemPrefixDropTable[itemPrefixDropTableNumber4];
                        i.itemSuffixs4 = null;
                        i.itemMod7 = i.itemPrefixs4.itemMod;
                        i.itemMod7 = SetItemMods(i, i.itemMod5);
                    }
                    else if (itemAffixSort == 2)
                    {
                        itemSuffixDropTableNumber4 = Random.Range(0, itemSuffixDropTable.Length);
                        i.itemPrefixs4 = null;
                        i.itemSuffixs4 = itemSuffixDropTable[itemSuffixDropTableNumber4];
                        i.itemMod7 = i.itemSuffixs4.itemMod;
                        i.itemMod7 = SetItemMods(i, i.itemMod5);
                    }
                    itemPrefixDropTableNumber1 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber2 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber3 = Random.Range(0, itemPrefixDropTable.Length);
                    itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber2 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber3 = Random.Range(0, itemSuffixDropTable.Length);
                    i.itemPrefixs1 = itemPrefixDropTable[itemPrefixDropTableNumber1];
                    i.itemMod1 = i.itemPrefixs1.itemMod;
                    i.itemMod1 = SetItemMods(i, i.itemMod1);
                    i.itemPrefixs2 = itemPrefixDropTable[itemPrefixDropTableNumber2];
                    i.itemMod3 = i.itemPrefixs2.itemMod;
                    i.itemMod3 = SetItemMods(i, i.itemMod3);
                    i.itemPrefixs3 = itemPrefixDropTable[itemPrefixDropTableNumber3];
                    i.itemMod5 = i.itemPrefixs3.itemMod;
                    i.itemMod5 = SetItemMods(i, i.itemMod5);
                    i.itemPrefixs5 = null;
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemMod2 = i.itemSuffixs1.itemMod;
                    i.itemMod2 = SetItemMods(i, i.itemMod2);
                    i.itemSuffixs2 = itemSuffixDropTable[itemSuffixDropTableNumber2];
                    i.itemMod4 = i.itemSuffixs2.itemMod;
                    i.itemMod4 = SetItemMods(i, i.itemMod4);
                    i.itemSuffixs3 = itemSuffixDropTable[itemSuffixDropTableNumber3];
                    i.itemMod6 = i.itemSuffixs3.itemMod;
                    i.itemMod6 = SetItemMods(i, i.itemMod6);
                    i.itemSuffixs5 = null;
                    return i;
                case 8:
                    itemPrefixDropTableNumber1 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber2 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber3 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber4 = Random.Range(0, itemPrefixDropTable.Length);
                    itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber2 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber3 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber4 = Random.Range(0, itemSuffixDropTable.Length);
                    i.itemPrefixs1 = itemPrefixDropTable[itemPrefixDropTableNumber1];
                    i.itemMod1 = i.itemPrefixs1.itemMod;
                    i.itemMod1 = SetItemMods(i, i.itemMod1);
                    i.itemPrefixs2 = itemPrefixDropTable[itemPrefixDropTableNumber2];
                    i.itemMod3 = i.itemPrefixs2.itemMod;
                    i.itemMod3 = SetItemMods(i, i.itemMod3);
                    i.itemPrefixs3 = itemPrefixDropTable[itemPrefixDropTableNumber3];
                    i.itemMod5 = i.itemPrefixs3.itemMod;
                    i.itemMod5 = SetItemMods(i, i.itemMod5);
                    i.itemPrefixs4 = itemPrefixDropTable[itemPrefixDropTableNumber4];
                    i.itemMod7 = i.itemPrefixs4.itemMod;
                    i.itemMod7 = SetItemMods(i, i.itemMod7);
                    i.itemPrefixs5 = null;
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemMod2 = i.itemSuffixs1.itemMod;
                    i.itemMod2 = SetItemMods(i, i.itemMod2);
                    i.itemSuffixs2 = itemSuffixDropTable[itemSuffixDropTableNumber2];
                    i.itemMod4 = i.itemSuffixs2.itemMod;
                    i.itemMod4 = SetItemMods(i, i.itemMod4);
                    i.itemSuffixs3 = itemSuffixDropTable[itemSuffixDropTableNumber3];
                    i.itemMod6 = i.itemSuffixs3.itemMod;
                    i.itemMod6 = SetItemMods(i, i.itemMod6);
                    i.itemSuffixs4 = itemSuffixDropTable[itemSuffixDropTableNumber4];
                    i.itemMod8 = i.itemSuffixs4.itemMod;
                    i.itemMod8 = SetItemMods(i, i.itemMod8);
                    i.itemSuffixs5 = null;
                    return i;
                case 9:
                    itemAffixSort = Random.Range(1, 3);
                    if (itemAffixSort == 1)
                    {
                        itemPrefixDropTableNumber5 = Random.Range(0, itemPrefixDropTable.Length);
                        i.itemPrefixs5 = itemPrefixDropTable[itemPrefixDropTableNumber5];
                        i.itemSuffixs5 = null;
                        i.itemMod10 = i.itemPrefixs4.itemMod;
                        i.itemMod10 = SetItemMods(i, i.itemMod5);
                    }
                    else if (itemAffixSort == 2)
                    {
                        itemSuffixDropTableNumber5 = Random.Range(0, itemSuffixDropTable.Length);
                        i.itemPrefixs5 = null;
                        i.itemSuffixs5 = itemSuffixDropTable[itemSuffixDropTableNumber5];
                        i.itemMod10 = i.itemSuffixs4.itemMod;
                        i.itemMod10 = SetItemMods(i, i.itemMod5);
                    }
                    itemPrefixDropTableNumber1 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber2 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber3 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber4 = Random.Range(0, itemPrefixDropTable.Length);
                    itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber2 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber3 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber4 = Random.Range(0, itemSuffixDropTable.Length);
                    i.itemPrefixs1 = itemPrefixDropTable[itemPrefixDropTableNumber1];
                    i.itemMod1 = i.itemPrefixs1.itemMod;
                    i.itemMod1 = SetItemMods(i, i.itemMod1);
                    i.itemPrefixs2 = itemPrefixDropTable[itemPrefixDropTableNumber2];
                    i.itemMod3 = i.itemPrefixs2.itemMod;
                    i.itemMod3 = SetItemMods(i, i.itemMod3);
                    i.itemPrefixs3 = itemPrefixDropTable[itemPrefixDropTableNumber3];
                    i.itemMod5 = i.itemPrefixs3.itemMod;
                    i.itemMod5 = SetItemMods(i, i.itemMod5);
                    i.itemPrefixs4 = itemPrefixDropTable[itemPrefixDropTableNumber4];
                    i.itemMod7 = i.itemPrefixs4.itemMod;
                    i.itemMod7 = SetItemMods(i, i.itemMod7);
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemMod2 = i.itemSuffixs1.itemMod;
                    i.itemMod2 = SetItemMods(i, i.itemMod2);
                    i.itemSuffixs2 = itemSuffixDropTable[itemSuffixDropTableNumber2];
                    i.itemMod4 = i.itemSuffixs2.itemMod;
                    i.itemMod4 = SetItemMods(i, i.itemMod4);
                    i.itemSuffixs3 = itemSuffixDropTable[itemSuffixDropTableNumber3];
                    i.itemMod6 = i.itemSuffixs3.itemMod;
                    i.itemMod6 = SetItemMods(i, i.itemMod6);
                    i.itemSuffixs4 = itemSuffixDropTable[itemSuffixDropTableNumber4];
                    i.itemMod8 = i.itemSuffixs4.itemMod;
                    i.itemMod8 = SetItemMods(i, i.itemMod8);
                    return i;
                default:
                    return null;
            }
        }
    }
}
