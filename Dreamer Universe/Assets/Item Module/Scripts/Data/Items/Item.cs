using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule {
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
        public ItemStats itemStat1;
        public ItemStats itemStat2;
        public ItemStats itemStat3;
        public ItemStats itemStat4;
        public ItemStats itemStat5;
        public ItemStats itemStat6;
        public ItemStats itemStat7;
        public ItemStats itemStat8;
        public ItemStats itemStat9;
        public ItemStats itemStat10;
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
        public ItemMods itemMod1;
        public ItemMods itemMod2;
        public ItemMods itemMod3;
        public ItemMods itemMod4;
        public ItemMods itemMod5;
        public ItemMods itemMod6;
        public ItemMods itemMod7;
        public ItemMods itemMod8;
        public ItemMods itemMod9;
        public ItemMods itemMod10;
        public Item(ItemName _itemName, ItemType _itemType, ItemRarities _itemRaritiy)
        {
            ItemName = _itemName;
            ItemType = _itemType;
            ItemRaritiy = _itemRaritiy;
        }
        public Item(ItemName _itemName, ItemType _itemType, ItemMaterial _itemMaterial, ItemManufacturer ItemManufacturer, ItemRarities _itemRaritiy, ItemQuality ItemQuality
                    )
        {
            ItemName = _itemName;
            ItemType = _itemType;
            ItemRaritiy = _itemRaritiy;
        }
    }
    public class ItemPart
    {
        public string ItemPartName;
        public ItemType ItemTypeForPart;
        public ItemStats ItemStatModifiying;
        public int ItemModifiyingInt;
        public ItemPart(string _itemPartName, ItemStats _ItemStatModifiying, int _itemModifiyingInt)
        {

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