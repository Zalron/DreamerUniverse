using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{
    public static class ItemCalculations
    {
        public static Item ItemSOConverter(Item item, ItemSO itemSo)
        {
            item.ItemName = ItemNameSoConverter(item.ItemName, itemSo.itemName);
            item.ItemQuality = ItemQualitySoConverter(item.ItemQuality, itemSo.itemQuality);
            item.ItemType = ItemTypeSoConverter(item.ItemType, itemSo.itemType);
            item.ItemLevel = ItemLevelSoConverter(item.ItemLevel, itemSo.itemLevel);
            item.ItemManufacturer = ItemManufacturerSoConverter(item.ItemManufacturer, itemSo.itemManufacturer);
            item.ItemMaterial = ItemMaterialSoConverter(item.ItemMaterial, itemSo.itemMaterial);
            item.ItemRaritiy = ItemRaritiesSoConverter(item.ItemRaritiy, itemSo.itemRarity);
            return item;
        }
        public static ItemName ItemNameSoConverter(ItemName itemName, ItemNameSO itemNameSo)
        {
            itemName.itemName = itemNameSo.ItemNameString;
            itemName.ItemNameInt = Random.Range(itemNameSo.itemNameIntModifierMin, itemNameSo.itemNameIntModifierMax + 1);
            return itemName;
        }
        public static ItemMaterial ItemMaterialSoConverter(ItemMaterial itemMaterial, ItemMaterialSO itemMaterialSo)
        {
            itemMaterial.ItemMaterialName = itemMaterialSo.itemMaterialName;
            itemMaterial.ItemMaterialInt = Random.Range(itemMaterialSo.ItemMaterialModifierMin, itemMaterialSo.ItemMaterialModifierMax + 1);
            return itemMaterial;
        }
        public static ItemManufacturer ItemManufacturerSoConverter(ItemManufacturer itemManufacturer, ItemManufacturerSO itemManufacturerSo)
        {
            itemManufacturer.ManufacturerName = itemManufacturerSo.manufacturerName;
            return itemManufacturer;
        }
        public static ItemType ItemTypeSoConverter(ItemType itemType, ItemTypesSO itemTypesSo)
        {
            itemType.ItemSubType = itemTypesSo.itemSubType;
            itemType.ItemTypeName = itemTypesSo.ItemTypeName;
            itemType.ItemTypeIntModifier = Random.Range(itemTypesSo.itemTypeIntModifierMin, itemTypesSo.itemTypeIntModifierMax + 1);
            return itemType;
        }
        public static ItemQuality ItemQualitySoConverter(ItemQuality itemQuality, ItemQualitySO itemQualitySo)
        {
            itemQuality.ItemQualityPercent = itemQualitySo.itemQualityPercent;
            itemQuality.ItemQualityType = itemQualitySo.itemQuality;
            itemQuality.ItemQualityPercentInt = Random.Range(itemQualitySo.itemQualityPercentIntMin, itemQualitySo.itemQualityPercentIntMax = 1);
            return itemQuality;
        }
        public static ItemLevel ItemLevelSoConverter(ItemLevel itemLevel, ItemLevelSO itemLevelSo)
        {
            itemLevel.ItemLevelInt = itemLevelSo.ItemLevelint;
            itemLevel.ItemLevelModifierInt = Random.Range(itemLevelSo.ItemLevelIntModifierMin, itemLevelSo.ItemLevelIntModifierMin + 1);
            return itemLevel;
        }

        public static ItemRarities ItemRaritiesSoConverter(ItemRarities itemRarities, ItemRaritiesSO itemRaritiesSo)
        {
            itemRarities.ItemRarityName = itemRaritiesSo.rarityName;
            itemRarities.ItemRarityInt = Random.Range(itemRaritiesSo.itemRarityIntModifierMin, itemRaritiesSo.itemRarityIntModifierMax + 1);
            itemRarities.ItemRarityAffixAllowed = itemRaritiesSo.rarityIntAffixsAllowed;
            return itemRarities;
        }

        public static ItemSO ItemGenerator(ItemSO i, ItemNameSO[] itemNameDropTable, ItemAffixsSO[] itemPrefixDropTable, ItemAffixsSO[] itemSuffixDropTable, ItemStatsSO[] itemStatDropTable, ItemRaritiesSO[] itemRarityDropTable, ItemLevelSO[] itemRequirementsDropTable)
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
            if (i.itemType.itemSubType == ItemSubType.WEAPON_MELEE_ONEHANDED_AXE ||
                i.itemType.itemSubType == ItemSubType.WEAPON_MELEE_ONEHANDED_CLUB ||
                i.itemType.itemSubType == ItemSubType.WEAPON_MELEE_ONEHANDED_KNIFE ||
                i.itemType.itemSubType == ItemSubType.WEAPON_MELEE_ONEHANDED_MACE ||
                i.itemType.itemSubType == ItemSubType.WEAPON_MELEE_ONEHANDED_RAPIER ||
                i.itemType.itemSubType == ItemSubType.WEAPON_MELEE_ONEHANDED_SHIELD ||
                i.itemType.itemSubType == ItemSubType.WEAPON_MELEE_ONEHANDED_SWORD ||
                i.itemType.itemSubType == ItemSubType.WEAPON_MELEE_ONEHANDED_WARHAMMER ||
                i.itemType.itemSubType == ItemSubType.WEAPON_MELEE_TWOHANDED_AXE ||
                i.itemType.itemSubType == ItemSubType.WEAPON_MELEE_TWOHANDED_CLAWS ||
                i.itemType.itemSubType == ItemSubType.WEAPON_MELEE_TWOHANDED_CLUB ||
                i.itemType.itemSubType == ItemSubType.WEAPON_MELEE_TWOHANDED_HALBERD||
                i.itemType.itemSubType == ItemSubType.WEAPON_MELEE_TWOHANDED_MACE ||
                i.itemType.itemSubType == ItemSubType.WEAPON_MELEE_TWOHANDED_SPEAR||
                i.itemType.itemSubType == ItemSubType.WEAPON_MELEE_TWOHANDED_STAFF ||
                i.itemType.itemSubType == ItemSubType.WEAPON_MELEE_TWOHANDED_SWORD||
                i.itemType.itemSubType == ItemSubType.WEAPON_MELEE_TWOHANDED_WARHAMMER)
            {
                i.itemStat1 = itemStatDropTable[0];
                i.itemStat2 = itemStatDropTable[1];
                i.itemStat3 = itemStatDropTable[2];
                i.itemStat4 = itemStatDropTable[3];
                i.itemStat5 = itemStatDropTable[4];
                i.itemStat6 = itemStatDropTable[5];
                i.itemStat7 = itemStatDropTable[6];
                i.itemStat8 = itemStatDropTable[7];
                i.itemStat9 = itemStatDropTable[8];
                i.itemStat10 = itemStatDropTable[9];
            }
            int itemPartDropTableNumber1 = Random.Range(0, i.itemName.itemParts1.Count);
            i.itemPart1 = i.itemName.itemParts1[itemPartDropTableNumber1];
            int itemPartDropTableNumber2 = Random.Range(0, i.itemName.itemParts2.Count);
            i.itemPart2 = i.itemName.itemParts2[itemPartDropTableNumber2];
            int itemPartDropTableNumber3 = Random.Range(0, i.itemName.itemParts3.Count);
            i.itemPart3= i.itemName.itemParts3[itemPartDropTableNumber3];
            int itemPartDropTableNumber4 = Random.Range(0, i.itemName.itemParts4.Count);
            i.itemPart4 = i.itemName.itemParts4[itemPartDropTableNumber4];
            int itemPartDropTableNumber5 = Random.Range(0, i.itemName.itemParts5.Count);
            i.itemPart5 = i.itemName.itemParts5[itemPartDropTableNumber5];
            int itemPartDropTableNumber6 = Random.Range(0, i.itemName.itemParts6.Count);
            i.itemPart6 = i.itemName.itemParts6[itemPartDropTableNumber6];
            int itemPartDropTableNumber7 = Random.Range(0, i.itemName.itemParts7 .Count);
            i.itemPart7 = i.itemName.itemParts7[itemPartDropTableNumber7];
            int itemPartDropTableNumber8 = Random.Range(0, i.itemName.itemParts8 .Count);
            i.itemPart8 = i.itemName.itemParts8[itemPartDropTableNumber8];
            int itemPartDropTableNumber9 = Random.Range(0, i.itemName.itemParts9.Count);
            i.itemPart9= i.itemName.itemParts9[itemPartDropTableNumber9];
            int itemPartDropTableNumber10 = Random.Range(0, i.itemName.itemParts10.Count);
            i.itemPart10 = i.itemName.itemParts10[itemPartDropTableNumber10];
            return i;
        }
        public static ItemStatsSO ItemModStatGenerator(ItemSO i, ItemStatsSO itemStat, ItemModSO itemMod)
        {
            return itemStat;
        }
        public static int ItemStatGenerators(ItemNameSO itemName, ItemTypesSO itemType, ItemRaritiesSO itemRarities, ItemLevelSO itemLevel, ItemModSO itemMod)
        {
            int ItemStatInt = 0;
            int ItemNameIntModifierSolved = Random.Range(itemName.itemNameIntModifierMin, itemName.itemNameIntModifierMax + 1);
            ItemStatInt += ItemNameIntModifierSolved;
            int ItemTypeIntModifierSolved = Random.Range(itemType.itemTypeIntModifierMin, itemType.itemTypeIntModifierMax + 1);
            ItemStatInt += ItemTypeIntModifierSolved;
            int ItemRarityIntModifierSolved = Random.Range(itemRarities.itemRarityIntModifierMin, itemName.itemNameIntModifierMax + 1);
            ItemStatInt += ItemRarityIntModifierSolved;
            int ItemLevelIntModifierSolved = Random.Range(itemLevel.ItemLevelIntModifierMin, itemLevel.ItemLevelIntModifierMax + 1);
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
        public static ItemModSO SetItemMods(ItemSO i, ItemModSO itemMod)
        {
            itemMod.itemModOnItemString = ConvertString.ItemModStringGenerator(itemMod.itemModIntModifierMin, itemMod.itemModDescriptionString);
            return itemMod;
        }
        public static ItemSO RarityAffixGenerator(ItemSO i, ItemAffixsSO[] itemPrefixDropTable, ItemAffixsSO[] itemSuffixDropTable)
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
                        i.itemMod1 = i.itemPrefixs1.itemAffixMod;
                    }
                    else if (itemAffixSort == 2)
                    {
                        itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                        i.itemPrefixs1 = null;
                        i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                        i.itemMod1 = i.itemSuffixs1.itemAffixMod;
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
                    i.itemMod1 = i.itemPrefixs1.itemAffixMod;
                    i.itemPrefixs2 = null;
                    i.itemPrefixs3 = null;
                    i.itemPrefixs4 = null;
                    i.itemPrefixs5 = null;
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemMod2 = i.itemSuffixs1.itemAffixMod;
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
                        i.itemMod3 = i.itemPrefixs2.itemAffixMod;
                        i.itemSuffixs2 = null;
                    }
                    else if (itemAffixSort == 2)
                    {
                        itemSuffixDropTableNumber2 = Random.Range(0, itemSuffixDropTable.Length);
                        i.itemPrefixs2 = null;
                        i.itemSuffixs2 = itemSuffixDropTable[itemSuffixDropTableNumber2];
                        i.itemMod3 = i.itemSuffixs2.itemAffixMod;
                    }
                    itemPrefixDropTableNumber1 = Random.Range(0, itemPrefixDropTable.Length);
                    itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                    i.itemPrefixs1 = itemPrefixDropTable[itemPrefixDropTableNumber1];
                    i.itemMod1 = i.itemPrefixs1.itemAffixMod;
                    i.itemPrefixs3 = null;
                    i.itemPrefixs4 = null;
                    i.itemPrefixs5 = null;
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemMod2 = i.itemSuffixs1.itemAffixMod;
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
                    i.itemMod1 = i.itemPrefixs1.itemAffixMod;
                    i.itemPrefixs2 = itemPrefixDropTable[itemPrefixDropTableNumber2];
                    i.itemMod3 = i.itemPrefixs1.itemAffixMod;
                    i.itemPrefixs3 = null;
                    i.itemPrefixs4 = null;
                    i.itemPrefixs5 = null;
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemMod2 = i.itemSuffixs1.itemAffixMod;
                    i.itemSuffixs2 = itemSuffixDropTable[itemSuffixDropTableNumber2];
                    i.itemMod4 = i.itemSuffixs1.itemAffixMod;
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
                        i.itemMod5 = i.itemPrefixs3.itemAffixMod;
                    }
                    else if (itemAffixSort == 2)
                    {
                        itemSuffixDropTableNumber3 = Random.Range(0, itemSuffixDropTable.Length);
                        i.itemPrefixs3 = null;
                        i.itemSuffixs3 = itemSuffixDropTable[itemSuffixDropTableNumber3];
                        i.itemMod5 = i.itemSuffixs3.itemAffixMod;
                    }
                    itemPrefixDropTableNumber1 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber2 = Random.Range(0, itemPrefixDropTable.Length);
                    itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber2 = Random.Range(0, itemSuffixDropTable.Length);
                    i.itemPrefixs1 = itemPrefixDropTable[itemPrefixDropTableNumber1];
                    i.itemMod1 = i.itemPrefixs1.itemAffixMod;
                    i.itemPrefixs2 = itemPrefixDropTable[itemPrefixDropTableNumber2];
                    i.itemMod3 = i.itemPrefixs2.itemAffixMod;
                    i.itemPrefixs4 = null;
                    i.itemPrefixs5 = null;
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemMod2 = i.itemSuffixs1.itemAffixMod;
                    i.itemSuffixs2 = itemSuffixDropTable[itemSuffixDropTableNumber2];
                    i.itemMod4 = i.itemSuffixs2.itemAffixMod;
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
                    i.itemMod1 = i.itemPrefixs1.itemAffixMod;
                    i.itemPrefixs2 = itemPrefixDropTable[itemPrefixDropTableNumber2];
                    i.itemMod3 = i.itemPrefixs2.itemAffixMod;
                    i.itemPrefixs3 = itemPrefixDropTable[itemPrefixDropTableNumber3];
                    i.itemMod5 = i.itemPrefixs3.itemAffixMod;
                    i.itemPrefixs4 = null;
                    i.itemPrefixs5 = null;
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemMod2 = i.itemSuffixs1.itemAffixMod;
                    i.itemSuffixs2 = itemSuffixDropTable[itemSuffixDropTableNumber2];
                    i.itemMod4 = i.itemSuffixs2.itemAffixMod;
                    i.itemSuffixs3 = itemSuffixDropTable[itemSuffixDropTableNumber3];
                    i.itemMod6 = i.itemSuffixs3.itemAffixMod;
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
                        i.itemMod7 = i.itemPrefixs4.itemAffixMod;
                    }
                    else if (itemAffixSort == 2)
                    {
                        itemSuffixDropTableNumber4 = Random.Range(0, itemSuffixDropTable.Length);
                        i.itemPrefixs4 = null;
                        i.itemSuffixs4 = itemSuffixDropTable[itemSuffixDropTableNumber4];
                        i.itemMod7 = i.itemSuffixs4.itemAffixMod;
                    }
                    itemPrefixDropTableNumber1 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber2 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber3 = Random.Range(0, itemPrefixDropTable.Length);
                    itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber2 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber3 = Random.Range(0, itemSuffixDropTable.Length);
                    i.itemPrefixs1 = itemPrefixDropTable[itemPrefixDropTableNumber1];
                    i.itemMod1 = i.itemPrefixs1.itemAffixMod;
                    i.itemPrefixs2 = itemPrefixDropTable[itemPrefixDropTableNumber2];
                    i.itemMod3 = i.itemPrefixs2.itemAffixMod;
                    i.itemPrefixs3 = itemPrefixDropTable[itemPrefixDropTableNumber3];
                    i.itemMod5 = i.itemPrefixs3.itemAffixMod;
                    i.itemPrefixs5 = null;
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemMod2 = i.itemSuffixs1.itemAffixMod;
                    i.itemSuffixs2 = itemSuffixDropTable[itemSuffixDropTableNumber2];
                    i.itemMod4 = i.itemSuffixs2.itemAffixMod;
                    i.itemSuffixs3 = itemSuffixDropTable[itemSuffixDropTableNumber3];
                    i.itemMod6 = i.itemSuffixs3.itemAffixMod;
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
                    i.itemMod1 = i.itemPrefixs1.itemAffixMod;
                    i.itemPrefixs2 = itemPrefixDropTable[itemPrefixDropTableNumber2];
                    i.itemMod3 = i.itemPrefixs2.itemAffixMod;
                    i.itemPrefixs3 = itemPrefixDropTable[itemPrefixDropTableNumber3];
                    i.itemMod5 = i.itemPrefixs3.itemAffixMod;
                    i.itemPrefixs4 = itemPrefixDropTable[itemPrefixDropTableNumber4];
                    i.itemMod7 = i.itemPrefixs4.itemAffixMod;
                    i.itemPrefixs5 = null;
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemMod2 = i.itemSuffixs1.itemAffixMod;
                    i.itemSuffixs2 = itemSuffixDropTable[itemSuffixDropTableNumber2];
                    i.itemMod4 = i.itemSuffixs2.itemAffixMod;
                    i.itemSuffixs3 = itemSuffixDropTable[itemSuffixDropTableNumber3];
                    i.itemMod6 = i.itemSuffixs3.itemAffixMod;
                    i.itemSuffixs4 = itemSuffixDropTable[itemSuffixDropTableNumber4];
                    i.itemMod8 = i.itemSuffixs4.itemAffixMod;
                    i.itemSuffixs5 = null;
                    return i;
                case 9:
                    itemAffixSort = Random.Range(1, 3);
                    if (itemAffixSort == 1)
                    {
                        itemPrefixDropTableNumber5 = Random.Range(0, itemPrefixDropTable.Length);
                        i.itemPrefixs5 = itemPrefixDropTable[itemPrefixDropTableNumber5];
                        i.itemSuffixs5 = null;
                        i.itemMod10 = i.itemPrefixs4.itemAffixMod;
                    }
                    else if (itemAffixSort == 2)
                    {
                        itemSuffixDropTableNumber5 = Random.Range(0, itemSuffixDropTable.Length);
                        i.itemPrefixs5 = null;
                        i.itemSuffixs5 = itemSuffixDropTable[itemSuffixDropTableNumber5];
                        i.itemMod10 = i.itemSuffixs4.itemAffixMod;
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
                    i.itemMod1 = i.itemPrefixs1.itemAffixMod;
                    i.itemPrefixs2 = itemPrefixDropTable[itemPrefixDropTableNumber2];
                    i.itemMod3 = i.itemPrefixs2.itemAffixMod;
                    i.itemPrefixs3 = itemPrefixDropTable[itemPrefixDropTableNumber3];
                    i.itemMod5 = i.itemPrefixs3.itemAffixMod;
                    i.itemPrefixs4 = itemPrefixDropTable[itemPrefixDropTableNumber4];
                    i.itemMod7 = i.itemPrefixs4.itemAffixMod;
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemMod2 = i.itemSuffixs1.itemAffixMod;
                    i.itemSuffixs2 = itemSuffixDropTable[itemSuffixDropTableNumber2];
                    i.itemMod4 = i.itemSuffixs2.itemAffixMod;
                    i.itemSuffixs3 = itemSuffixDropTable[itemSuffixDropTableNumber3];
                    i.itemMod6 = i.itemSuffixs3.itemAffixMod;
                    i.itemSuffixs4 = itemSuffixDropTable[itemSuffixDropTableNumber4];
                    i.itemMod8 = i.itemSuffixs4.itemAffixMod;
                    return i;
                case 10:
                    itemPrefixDropTableNumber1 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber2 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber3 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber4 = Random.Range(0, itemPrefixDropTable.Length);
                    itemPrefixDropTableNumber5 = Random.Range(0, itemPrefixDropTable.Length);
                    itemSuffixDropTableNumber1 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber2 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber3 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber4 = Random.Range(0, itemSuffixDropTable.Length);
                    itemSuffixDropTableNumber5 = Random.Range(0, itemSuffixDropTable.Length);
                    i.itemPrefixs1 = itemPrefixDropTable[itemPrefixDropTableNumber1];
                    i.itemMod1 = i.itemPrefixs1.itemAffixMod;
                    i.itemPrefixs2 = itemPrefixDropTable[itemPrefixDropTableNumber2];
                    i.itemMod3 = i.itemPrefixs2.itemAffixMod;
                    i.itemPrefixs3 = itemPrefixDropTable[itemPrefixDropTableNumber3];
                    i.itemMod5 = i.itemPrefixs3.itemAffixMod;
                    i.itemPrefixs4 = itemPrefixDropTable[itemPrefixDropTableNumber4];
                    i.itemMod7 = i.itemPrefixs4.itemAffixMod;
                    i.itemPrefixs5 = itemPrefixDropTable[itemPrefixDropTableNumber5];
                    i.itemMod9 = i.itemSuffixs5.itemAffixMod;
                    i.itemSuffixs1 = itemSuffixDropTable[itemSuffixDropTableNumber1];
                    i.itemMod2 = i.itemSuffixs1.itemAffixMod;
                    i.itemSuffixs2 = itemSuffixDropTable[itemSuffixDropTableNumber2];
                    i.itemMod4 = i.itemSuffixs2.itemAffixMod;
                    i.itemSuffixs3 = itemSuffixDropTable[itemSuffixDropTableNumber3];
                    i.itemMod6 = i.itemSuffixs3.itemAffixMod;
                    i.itemSuffixs4 = itemSuffixDropTable[itemSuffixDropTableNumber4];
                    i.itemMod8 = i.itemSuffixs4.itemAffixMod;
                    i.itemSuffixs5 = itemSuffixDropTable[itemSuffixDropTableNumber5];
                    i.itemMod10 = i.itemSuffixs5.itemAffixMod;
                    return i;
                default:
                    return null;
            }
        }
    }
}
