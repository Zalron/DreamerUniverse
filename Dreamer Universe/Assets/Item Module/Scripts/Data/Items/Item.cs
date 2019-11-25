using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule 
{
    public class Item
    {
        public ItemName ItemName;
        public ItemType ItemType;
        public ItemLevel ItemLevel;
        public ItemMaterial ItemMaterial;
        public ItemManufacturer ItemManufacturer;
        public ItemRarities ItemRaritiy;
        public ItemScore ItemScore;
        public ItemQuality ItemQuality;
        public ItemAffixs ItemPrefix1;
        public ItemAffixs ItemPrefix2;
        public ItemAffixs ItemPrefix3;
        public ItemAffixs ItemPrefix4;
        public ItemAffixs ItemPrefix5;
        public ItemAffixs ItemSuffix1;
        public ItemAffixs ItemSuffix2;
        public ItemAffixs ItemSuffix3;
        public ItemAffixs ItemSuffix4;
        public ItemAffixs ItemSuffix5;
        public ItemStats ItemStat1;
        public ItemStats ItemStat2;
        public ItemStats ItemStat3;
        public ItemStats ItemStat4;
        public ItemStats ItemStat5;
        public ItemStats ItemStat6;
        public ItemStats ItemStat7;
        public ItemStats ItemStat8;
        public ItemStats ItemStat9;
        public ItemStats ItemStat10;
        public ItemPart ItemPart1;
        public ItemPart ItemPart2;
        public ItemPart ItemPart3;
        public ItemPart ItemPart4;
        public ItemPart ItemPart5;
        public ItemPart ItemPart6;
        public ItemPart ItemPart7;
        public ItemPart ItemPart8;
        public ItemPart ItemPart9;
        public ItemPart ItemPart10;
        public ItemMods ItemMod1;
        public ItemMods ItemMod2;
        public ItemMods ItemMod3;
        public ItemMods ItemMod4;
        public ItemMods ItemMod5;
        public ItemMods ItemMod6;
        public ItemMods ItemMod7;
        public ItemMods ItemMod8;
        public ItemMods ItemMod9;
        public ItemMods ItemMod10;
        public Item(ItemName itemName, ItemType itemType, ItemRarities itemRaritiy)
        {
            ItemName = itemName;
            ItemType = itemType;
            ItemRaritiy = itemRaritiy;
        }
        public Item(ItemName itemName, ItemType itemType, ItemMaterial itemMaterial, ItemManufacturer itemManufacturer, ItemRarities itemRaritiy, ItemQuality itemQuality)
        {
            ItemName = itemName;
            ItemType = itemType;
            ItemRaritiy = itemRaritiy;
            ItemMaterial = itemMaterial;
            ItemManufacturer = itemManufacturer;
            ItemQuality = itemQuality;
        }

        public Item(ItemName itemName, ItemType itemType, ItemMaterial itemMaterial, ItemManufacturer itemManufacturer, ItemRarities itemRaritiy, ItemQuality itemQuality,
                    ItemAffixs itemPrefix1, ItemAffixs itemPrefix2, ItemAffixs itemPrefix3, ItemAffixs itemPrefix4, ItemAffixs itemPrefix5, ItemAffixs itemSuffix1, ItemAffixs itemSuffix2, ItemAffixs itemSuffix3, ItemAffixs itemSuffix4, ItemAffixs itemSuffix5, 
                    ItemStats itemStat1, ItemStats itemStat2, ItemStats itemStat3, ItemStats itemStat4, ItemStats itemStat5, ItemStats itemStat6, ItemStats itemStat7, ItemStats itemStat8, ItemStats itemStat9, ItemStats itemStat10)
        {
            ItemName = itemName;
            ItemType = itemType;
            ItemRaritiy = itemRaritiy;
            ItemMaterial = itemMaterial;
            ItemManufacturer = itemManufacturer;
            ItemQuality = itemQuality;
        }
    }
    public class ItemPart
    {
        public string ItemPartName;
        public ItemType ItemTypeForPart;
        public ItemStats ItemStatModifiying;
        public int ItemModifiyingInt;
        public ItemPart(string itemPartName, ItemStats itemStatModifiying, int itemModifiyingInt)
        {
            ItemPartName = itemPartName;
            ItemStatModifiying = itemStatModifiying;
            ItemModifiyingInt = itemModifiyingInt;
        }
    }
    public class ItemName
    {
        public string itemName;
        public string itemCombinedName;
        public int ItemNameInt;
    }
    public class ItemType
    {
        public string ItemTypeName;
        public int ItemTypeIntModifier;
        public ItemSubType ItemSubType;
    }
    public class ItemLevel
    {
        public string ItemLevelString;
        public int ItemLevelInt;
    }
    public class ItemMaterial
    {
        public string ItemMaterialName;
        public int ItemMaterialInt;
    }
    public class ItemStats
    {
        public int ItemStatInt;
        public string OnItemStatString;
        public ItemStatType ItemStatType;
    }
    public class ItemAffixs
    {
        public string ItemAffixString;
        public ItemAffix ItemAffixType;
        public ItemModSO ItemAffixMod;
    }
    public class ItemMods
    {
        public string ItemModString;
        public string ItemModOnItemString;
        public int ItemModInt;
        public ItemStats itemStatModifying;
    }
    public class ItemRarities
    {
        public int ItemRarityInt;
        public int ItemRarityAffixAllowed;
        public string ItemRarityName;
    }
    public class ItemManufacturer
    {
        public string ManufacturerName;
    }
    public class ItemScore
    {
        public int ItemScoreInt;
        public string ItemScoreString;
    }
    public class ItemRequirement
    {
        public string ItemRequirementString;
        public int ItemStrength;
        public int ItemDexterity;
        public int ItemIntelligence;
        public int ItemLuck;
        public int ItemEndurance;
        public int ItemWillpower;
    }
}