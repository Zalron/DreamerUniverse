using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule {
    public class Item
    {
        ItemName ItemName;
        ItemType ItemType;
        ItemLevel ItemLevel;
        ItemMaterial ItemMaterial;
        ItemScore ItemScore;
        ItemQuality ItemQuality;
        ItemAffixs ItemPrefix1;
        ItemAffixs ItemPrefix2;
        ItemAffixs ItemPrefix3;
        ItemAffixs ItemPrefix4;
        ItemAffixs ItemPrefix5;
        ItemAffixs ItemSuffix1;
        ItemAffixs ItemSuffix2;
        ItemAffixs ItemSuffix3;
        ItemAffixs ItemSuffix4;
        ItemAffixs ItemSuffix5;
        ItemStats itemStat1;
        ItemStats itemStat2;
        ItemStats itemStat3;
        ItemStats itemStat4;
        ItemStats itemStat5;
        ItemStats itemStat6;
        ItemStats itemStat7;
        ItemStats itemStat8;
        ItemStats itemStat9;
        ItemStats itemStat10;
        ItemPart ItemPart1;
        ItemPart ItemPart2;
        ItemPart ItemPart3;
        ItemPart ItemPart4;
        ItemPart ItemPart5;
        ItemPart ItemPart6;
        ItemPart ItemPart7;
        ItemPart ItemPart8;
        ItemPart ItemPart9;
        ItemPart ItemPart10;
        ItemMods itemMod1;
        ItemMods itemMod2;
        ItemMods itemMod3;
        ItemMods itemMod4;
        ItemMods itemMod5;
        ItemMods itemMod6;
        ItemMods itemMod7;
        ItemMods itemMod8;
        ItemMods itemMod9;
        ItemMods itemMod10;
    }
    public class ItemPart
    {
        public string ItemPartName;
        public ItemType ItemTypeForPart;
        public ItemStats ItemStatModifiying;
        public int ItemModifiyingInt;
    }
    public class ItemName
    {
        public string itemName;
        public string itemCombinedName;
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
        public string ItemMaterialInt;
    }
    public class ItemStats
    {
        public string ItemStatString;
        public string OnItemStatString;
        ItemStatType ItemStatType;
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
        public List<ItemType> itemManufacturerParts = new List<ItemType>();
    }
    public class ItemScore
    {
        public int ItemScoreInt;
        public string ItemScoreString;
    }
}