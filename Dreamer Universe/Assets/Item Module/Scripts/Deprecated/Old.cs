using System.Collections;
using System.Collections.Generic;
using UnityEngine;

public class Old
{
    //public enum OneHandedMelee
    //{
    //    SHORTSWORD,
    //    ONEHANDEDMACE,
    //    KNIFE,
    //    ONEHANDEDWARHAMMERS,
    //    ONEHANDEDAXE,
    //    SHIELD,
    //    RAPIER,
    //    ONEHANDEDCLUB,
    //}
    //public enum TwoHandedMelee
    //{
    //    LONGSWORD,
    //    TWOHANDEDMACE,
    //    TWOHANDEDWARHAMMER,
    //    HALBERD,
    //    TWOHANDEDAXE,
    //    TWOHANDEDCLUB,
    //    STAFF,
    //    SPEAR,
    //    CLAWS,
    //}
    //public enum OneHandedRanged
    //{
    //    WAND,
    //    THROWINGKNIFES,
    //    THROWINGAXES,
    //    PISTOL,
    //    HANDCROSSBOW,
    //}
    //public enum TwoHandedRanged
    //{
    //    BOW,
    //    CROSSBOW,
    //    MATCHLOCKRIFLE,
    //    CARBINE,
    //    BULLPUP,
    //    ASSAULTRIFLE,
    //    SNIPERRIFLE,
    //    MACHINEGUN,
    //    SHOTGUN,
    //    GRENADELAUNCHER,
    //    ROCKETLAUNCHER,
    //}
    //static OneHandedMelee oneHandedMelee;
    //static TwoHandedMelee twoHandedMelee;
    //static OneHandedRanged oneHandedRanged;
    //static TwoHandedRanged twoHandedRanged;
    //public static string ItemTypeGenerator()
    //{
    //    string ItemTypeString = null;
    //    int itemTypeGeneratorInt = Random.Range(1, 5);
    //    if (itemTypeGeneratorInt == 1)
    //    {
    //        oneHandedMelee = (OneHandedMelee)Random.Range(0, System.Enum.GetValues(typeof(OneHandedMelee)).Length);
    //        switch (oneHandedMelee)
    //        {
    //            case OneHandedMelee.ONEHANDEDMACE:
    //                ItemTypeString = "One Handed Mace";
    //                return ItemTypeString;
    //            case OneHandedMelee.ONEHANDEDAXE:
    //                ItemTypeString = "One Handed Axe";
    //                return ItemTypeString;
    //            case OneHandedMelee.ONEHANDEDWARHAMMERS:
    //                ItemTypeString = "One Handed Warhammer";
    //                return ItemTypeString;
    //            case OneHandedMelee.KNIFE:
    //                ItemTypeString = "Knife";
    //                return ItemTypeString;
    //            case OneHandedMelee.ONEHANDEDCLUB:
    //                ItemTypeString = "One Handed Club";
    //                return ItemTypeString;
    //            case OneHandedMelee.RAPIER:
    //                ItemTypeString = "Rapier";
    //                return ItemTypeString;
    //            case OneHandedMelee.SHIELD:
    //                ItemTypeString = "Shield";
    //                return ItemTypeString;
    //            case OneHandedMelee.SHORTSWORD:
    //                ItemTypeString = "Short Swords";
    //                return ItemTypeString;
    //            default:
    //                return "Not Done Yet";
    //        }
    //    }
    //    else if (itemTypeGeneratorInt == 2)
    //    {
    //        twoHandedMelee = (TwoHandedMelee)Random.Range(0, System.Enum.GetValues(typeof(TwoHandedMelee)).Length);
    //        switch (twoHandedMelee)
    //        {
    //            case TwoHandedMelee.TWOHANDEDMACE:
    //                ItemTypeString = "Two Handed Mace";
    //                return ItemTypeString;
    //            case TwoHandedMelee.TWOHANDEDAXE:
    //                ItemTypeString = "Two Handed Axes";
    //                return ItemTypeString;
    //            case TwoHandedMelee.TWOHANDEDCLUB:
    //                ItemTypeString = "Two Handed Club";
    //                return ItemTypeString;
    //            case TwoHandedMelee.TWOHANDEDWARHAMMER:
    //                ItemTypeString = "Two Handed Warhammer";
    //                return ItemTypeString;
    //            case TwoHandedMelee.STAFF:
    //                ItemTypeString = "Staff";
    //                return ItemTypeString;
    //            case TwoHandedMelee.SPEAR:
    //                ItemTypeString = "Spear";
    //                return ItemTypeString;
    //            case TwoHandedMelee.LONGSWORD:
    //                ItemTypeString = "Long Sword";
    //                return ItemTypeString;
    //            case TwoHandedMelee.HALBERD:
    //                ItemTypeString = "Halberd";
    //                return ItemTypeString;
    //            case TwoHandedMelee.CLAWS:
    //                ItemTypeString = "Claws";
    //                return ItemTypeString;
    //            default:
    //                return "Not Done Yet";
    //        }
    //    }
    //    else if (itemTypeGeneratorInt == 3)
    //    {
    //        oneHandedRanged = (OneHandedRanged)Random.Range(0, System.Enum.GetValues(typeof(OneHandedRanged)).Length);
    //        switch (oneHandedRanged)
    //        {
    //            case OneHandedRanged.HANDCROSSBOW:
    //                ItemTypeString = "Hand Crossbow";
    //                return ItemTypeString;
    //            case OneHandedRanged.PISTOL:
    //                ItemTypeString = "Pistol";
    //                return ItemTypeString;
    //            case OneHandedRanged.THROWINGAXES:
    //                ItemTypeString = "Throwing Axes";
    //                return ItemTypeString;
    //            case OneHandedRanged.THROWINGKNIFES:
    //                ItemTypeString = "Throwing Knifes";
    //                return ItemTypeString;
    //            case OneHandedRanged.WAND:
    //                ItemTypeString = "Wand";
    //                return ItemTypeString;
    //            default:
    //                return "Not Done Yet";
    //        }
    //    }
    //    else
    //    {
    //        return "ERROR";
    //    }
    //}
    //public static string ItemTypeString(ItemType itemTypes)
    //{
    //    string ItemTypeString;
    //    switch(itemTypes)
    //    {
    //        case ItemType.ITEM_WEAPON_MELEE_ONEHANDED_AXE:
    //            ItemTypeString = "One Handed Axe";
    //            return ItemTypeString;
    //        case ItemType.ITEM_WEAPON_MELEE_ONEHANDED_MACE:
    //            ItemTypeString = "One Handed Mace";
    //            return ItemTypeString;
    //        case ItemType.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER:
    //            ItemTypeString = "One Handed Warhammer";
    //            return ItemTypeString;
    //        case ItemType.ITEM_WEAPON_MELEE_ONEHANDED_KNIFE:
    //            ItemTypeString = "One Handed Knife";
    //            return ItemTypeString;
    //        case ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SWORD:
    //            ItemTypeString = "One Handed Sword";
    //            return ItemTypeString;
    //        case ItemType.ITEM_WEAPON_MELEE_TWOHANDED_AXE:
    //            ItemTypeString = "One Handed Sword";
    //            return ItemTypeString;
    //    }
    //    return "ERROR";
    //}
    //public static string RarityGeneratorString(ItemRarity rarity)
    //{
    //    string ItemRarityString;
    //    switch (rarity)
    //    {
    //        case ItemRarity.COMMON:
    //            ItemRarityString = "Common";
    //            return ItemRarityString;
    //        case ItemRarity.UNCOMMON:
    //            ItemRarityString = "Uncommon";
    //            return ItemRarityString;
    //        case ItemRarity.RARE:
    //            ItemRarityString = "Rare";
    //            return ItemRarityString;
    //        case ItemRarity.MASTERWORK:
    //            ItemRarityString = "Masterwork";
    //            return ItemRarityString;
    //        case ItemRarity.EXOTIC:
    //            ItemRarityString = "Exotic";
    //            return ItemRarityString;
    //        case ItemRarity.LEGENDARY:
    //            ItemRarityString = "Legendary";
    //            return ItemRarityString;
    //        case ItemRarity.UNQIUE:
    //            ItemRarityString = "Unqiue";
    //            return ItemRarityString;
    //        default:
    //            ItemRarityString = "ERROR";
    //            return ItemRarityString;
    //    }
    //}
    //public static string StringConvertItemName(ItemTypeName itemTypeName)
    //{
    //    string itemTypeNameString;
    //    switch (itemTypeName)
    //    {
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_VIKINGAXE:
    //            itemTypeNameString = "Viking Axe";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_BONEHACHET:
    //            itemTypeNameString = "Bone Hachet";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_WOODEDAXE:
    //            itemTypeNameString = "Wooded Axe";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_BLOODCLEAVER:
    //            itemTypeNameString = "Blood Cleaver";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_ENERGYCORRECTOR:
    //            itemTypeNameString = "Energy Corrector";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_RINGEDPERNACH:
    //            itemTypeNameString = "Rinded Pernach";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_BLACKJACK:
    //            itemTypeNameString = "Black Jack";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_MORNINGSTAR:
    //            itemTypeNameString = "Morning Star";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_IRONTEETH:
    //            itemTypeNameString = "Iron Teeth";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_BEDECKEDSHISHPAR:
    //            itemTypeNameString = "Bedecked Shishpar";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_NIGHTGADA:
    //            itemTypeNameString = "Night Gada";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_CLAWEDPICK:
    //            itemTypeNameString = "Clawed Pick";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_DOUBLEHEADER:
    //            itemTypeNameString = "Double Header";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_SKULLSINGER:
    //            itemTypeNameString = "Skull Singer";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_STONEBREAKER:
    //            itemTypeNameString = "Stone Breaker";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_WETKOPIS:
    //            itemTypeNameString = "Wet Kopis";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_BRONZEFALX:
    //            itemTypeNameString = "Bronze Falx";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_DUSTKHOPESH:
    //            itemTypeNameString = "Dust Khopesh";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_TUTONICSWORD:
    //            itemTypeNameString = "Tutonic Sword";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_OBSIDIANMAQUAHUITL:
    //            itemTypeNameString = "Obsidian Maquahuitl";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_STEELGLADIUS:
    //            itemTypeNameString = "Steel Gladius";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_BATTLEAXE:
    //            itemTypeNameString = "Battle Axe";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_LANDHOWITER:
    //            itemTypeNameString = "Land Howiter";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_GOLDENREAVER:
    //            itemTypeNameString = "Golden Reaver";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_DEMONSMALICE:
    //            itemTypeNameString = "Demons Malice";
    //            return itemTypeNameString;
    //        case ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_SEAOMEGA:
    //            itemTypeNameString = "Sea Omega";
    //            return itemTypeNameString;
    //        default:
    //            return "ERROR";
    //    }
    //}
    //public static string ConvertStringPrefixs(ItemPrefixs prefixs)
    //{
    //    string PrefixsString;
    //    switch (prefixs)
    //    {
    //        case ItemPrefixs.Clothed:
    //            PrefixsString = "Clothed";
    //            return PrefixsString;
    //        case ItemPrefixs.Jesters:
    //            PrefixsString = "Jesters";
    //            return PrefixsString;
    //        case ItemPrefixs.Kings:
    //            PrefixsString = "Kings";
    //            return PrefixsString;
    //        case ItemPrefixs.Marked:
    //            PrefixsString = "Marked";
    //            return PrefixsString;
    //        case ItemPrefixs.Rusted:
    //            PrefixsString = "Rusted";
    //            return PrefixsString;
    //        case ItemPrefixs.Upper:
    //            PrefixsString = "Upper";
    //            return PrefixsString;
    //        default:
    //            return "ERROR";
    //    }
    //}
    //public static string ConvertStringSuffixs(ItemSuffixs suffixs)
    //{
    //    string SuffixsString;
    //    switch (suffixs)
    //    {
    //        case ItemSuffixs.OfAccelerating:
    //            SuffixsString = "Of Accelerating";
    //            return SuffixsString;
    //        case ItemSuffixs.OfCursing:
    //            SuffixsString = "Of Cursing";
    //            return SuffixsString;
    //        case ItemSuffixs.OfDestruction:
    //            SuffixsString = "Of Destruction";
    //            return SuffixsString;
    //        case ItemSuffixs.OfFrost:
    //            SuffixsString = "Of Frost";
    //            return SuffixsString;
    //        case ItemSuffixs.OfRetarding:
    //            SuffixsString = "Of Retarding";
    //            return SuffixsString;
    //        default:
    //            return "ERROR";
    //    }
    //}
    //public static string CombineNameString(string itemPrefix, string itemName, string itemSuffix)
    //{
    //    string itemCombinedName = itemPrefix + " " + itemName + " " + itemSuffix;
    //    return itemCombinedName;
    //}
    //public static string AttackSpeedGenerator(int AttackSpeedInt)
    //{
    //    string AttackSpeedString;
    //    AttackSpeedString = "Attack Speed " + AttackSpeedInt;
    //    return AttackSpeedString;
    //}
    //public static string CriticalChanceGenerator(int CriticalChanceInt)
    //{
    //    string CriticalChanceString;
    //    CriticalChanceString = "Critical Chance " + CriticalChanceInt + "%";
    //    return CriticalChanceString;
    //}
    //public static string PhysicalDamageGenerator(int PhysicalDamageInt)
    //{
    //    string PhysicalDamageString;
    //    PhysicalDamageString = "Physical Damage " + PhysicalDamageInt;
    //    return PhysicalDamageString;
    //}
    //public static string MagicalDamageStringConverter(int MagicalDamageInt)
    //{
    //    string MagicalDamageString;
    //    MagicalDamageString = "Magical Damage " + MagicalDamageInt;
    //    return MagicalDamageString;
    //}
    //public int AttackSpeedOneHandedAxeInt = 3;
    //public int AttackSpeedOneHandedMaceInt = 3;
    //public int AttackSpeedOneHandedWarhammerInt = 4;
    //public int AttackSpeedOneHandedSwordInt = 7;
    //#region ItemStatCriticalChanceVariables

    //#region ItemStatCriticalChanceRarity
    //static readonly int CriticalChanceCommonInt = 1;
    //static readonly int CriticalChanceUncommonInt = 2;
    //static readonly int CriticalChanceRareInt = 3;
    //static readonly int CriticalChanceUniqueInt = 4;
    //static readonly int CriticalChanceMasterworkInt = 5;
    //static readonly int CriticalChanceExoticInt = 6;
    //static readonly int CriticalChanceLegendaryInt = 7;
    //#endregion

    //#region ItemStatCriticalChanceItemType
    //static readonly int CriticalChanceOneHandedAxeInt = 2;
    //static readonly int CriticalChanceOneHandedMaceInt = 3;
    //static readonly int CriticalChanceOneHandedWarhammerInt = 4;
    //static readonly int CriticalChanceOneHandedSwordInt = 2;
    //#endregion

    //#endregion

    //#region ItemStatPhysicalDamageVariables

    //#region ItemStatPhysicalDamageRarity
    //static readonly int PhysicalDamageCommonInt = 10;
    //static readonly int PhysicalDamageUncommonInt = 20;
    //static readonly int PhysicalDamageRareInt = 30;
    //static readonly int PhysicalDamageUnqiueInt = 40;
    //static readonly int PhysicalDamageMasterworkInt = 50;
    //static readonly int PhysicalDamageExoticInt = 60;
    //static readonly int PhysicalDamageLegendaryInt = 70;
    //#endregion

    //#region ItemStatPhysicalDamageItemType
    //static readonly int PhysicalDamageOneHandedAxeInt = 50;
    //static readonly int PhysicalDamageOneHandedMaceInt = 7;
    //static readonly int PhysicalDamageOneHandedWarhammerInt = 6;
    //static readonly int PhysicalDamageOneHandedSwordInt = 10;
    //#endregion

    //#endregion

    //#region ItemStatMagicalDamageVariables

    //#region ItemStatMagicalDamageRarity
    //static readonly int MagicalDamageCommonInt = 5;
    //static readonly int MagicalDamageUncommonInt = 10;
    //static readonly int MagicalDamageRareInt = 15;
    //static readonly int MagicalDamageUnqiueInt = 20;
    //static readonly int MagicalDamageMasterworkInt = 25;
    //static readonly int MagicalDamageExoticInt = 30;
    //static readonly int MagicalDamageLegendaryInt = 35;
    //#endregion

    //#region ItemStatMagicalDamageItemType
    //static readonly int MagicalDamageOneHandedAxeInt = 8;
    //static readonly int MagicalDamageOneHandedMaceInt = 7;
    //static readonly int MagicalDamageOneHandedWarhammerInt = 6;
    //static readonly int MagicalDamageOneHandedSwordInt = 10;
    //#endregion

    //#endregion

    //#endregion

    //#region ItemStateFunctions

    //#region ItemAttackSpeedFunctions
    //public static int AttackSpeedGenerator(ItemRarity itemRarity, ItemType itemType, ItemRequirement itemRequirements)
    //{
    //    int AttackSpeedInt = 1;
    //    AttackSpeedInt += AttackSpeedItemTypeGenerator(AttackSpeedInt, itemType);
    //    AttackSpeedInt += AttackSpeedRarityGenerator(AttackSpeedInt, itemRarity);
    //    AttackSpeedInt += AttackSpeedRequirementGenerator(AttackSpeedInt, itemRequirements);
    //    return AttackSpeedInt;
    //}
    //public static int AttackSpeedItemTypeGenerator(int AttackSpeedInt, ItemType itemType)
    //{
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_AXE)
    //    {
    //        AttackSpeedInt += AttackSpeedOneHandedAxeInt;
    //        return AttackSpeedInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_MACE)
    //    {
    //        AttackSpeedInt += AttackSpeedOneHandedMaceInt;
    //        return AttackSpeedInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER)
    //    {
    //        AttackSpeedInt += AttackSpeedOneHandedWarhammerInt;
    //        return AttackSpeedInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SWORD)
    //    {
    //        AttackSpeedInt += AttackSpeedOneHandedSwordInt;
    //        return AttackSpeedInt;
    //    }
    //    return AttackSpeedInt;
    //}
    //public static int AttackSpeedRarityGenerator(int AttackSpeedInt, ItemRarity itemRarity)
    //{

    //    if (itemRarity == ItemRarity.COMMON)
    //    {
    //        AttackSpeedInt += AttackSpeedCommonInt;
    //        return AttackSpeedInt;
    //    }
    //    if (itemRarity == ItemRarity.UNCOMMON)
    //    {
    //        AttackSpeedInt += AttackSpeedUncommonInt;
    //        return AttackSpeedInt;
    //    }
    //    if (itemRarity == ItemRarity.RARE)
    //    {
    //        AttackSpeedInt += AttackSpeedRareInt;
    //        return AttackSpeedInt;
    //    }
    //    if (itemRarity == ItemRarity.UNQIUE)
    //    {
    //        AttackSpeedInt += AttackSpeedUnqiueInt;
    //        return AttackSpeedInt;
    //    }
    //    if (itemRarity == ItemRarity.MASTERWORK)
    //    {
    //        AttackSpeedInt += AttackSpeedMasterworkInt;
    //        return AttackSpeedInt;
    //    }
    //    if (itemRarity == ItemRarity.EXOTIC)
    //    {
    //        AttackSpeedInt += AttackSpeedExoticInt;
    //        return AttackSpeedInt;
    //    }
    //    if (itemRarity == ItemRarity.LEGENDARY)
    //    {
    //        AttackSpeedInt += AttackSpeedLegendaryInt;
    //        return AttackSpeedInt;
    //    }
    //    return 0;
    //}
    //public static int AttackSpeedRequirementGenerator(int AttackSpeedInt, ItemRequirement itemRequirements)
    //{
    //    AttackSpeedInt += (int)itemRequirements;
    //    return AttackSpeedInt;
    //}
    //#endregion

    //#region ItemCriticalChanceFunctions 
    //public static int CriticalChanceGenerator(ItemRarity itemRarity, ItemType itemType, ItemRequirement itemRequirements)
    //{
    //    int CriticalChanceInt = 1;
    //    CriticalChanceInt += CriticalChanceItemTypeGenerator(CriticalChanceInt, itemType);
    //    CriticalChanceInt += CriticalChanceRarityGenerator(CriticalChanceInt, itemRarity);
    //    CriticalChanceInt += CriticalChanceRequirementGenerator(CriticalChanceInt, itemRequirements);
    //    return CriticalChanceInt;
    //}
    //public static int CriticalChanceRarityGenerator(int CriticalChanceInt, ItemRarity itemRarity)
    //{
    //    if (itemRarity == ItemRarity.COMMON)
    //    {
    //        CriticalChanceInt += CriticalChanceCommonInt;
    //        return CriticalChanceInt;
    //    }
    //    if (itemRarity == ItemRarity.UNCOMMON)
    //    {
    //        CriticalChanceInt = CriticalChanceUncommonInt;
    //        return CriticalChanceInt;
    //    }
    //    if (itemRarity == ItemRarity.RARE)
    //    {
    //        CriticalChanceInt = CriticalChanceRareInt;
    //        return CriticalChanceInt;
    //    }
    //    if (itemRarity == ItemRarity.UNQIUE)
    //    {
    //        CriticalChanceInt = CriticalChanceUniqueInt;
    //        return CriticalChanceInt;
    //    }
    //    if (itemRarity == ItemRarity.MASTERWORK)
    //    {
    //        CriticalChanceInt = CriticalChanceMasterworkInt;
    //        return CriticalChanceInt;
    //    }
    //    if (itemRarity == ItemRarity.EXOTIC)
    //    {
    //        CriticalChanceInt = CriticalChanceExoticInt;
    //        return CriticalChanceInt;
    //    }
    //    if (itemRarity == ItemRarity.LEGENDARY)
    //    {
    //        CriticalChanceInt = CriticalChanceLegendaryInt;
    //        return CriticalChanceInt;
    //    }
    //    return 0;
    //}
    //public static int CriticalChanceItemTypeGenerator(int criticalChanceInt, ItemType itemType)
    //{
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_AXE)
    //    {
    //        criticalChanceInt += CriticalChanceOneHandedAxeInt;
    //        return criticalChanceInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_MACE)
    //    {
    //        criticalChanceInt += CriticalChanceOneHandedMaceInt;
    //        return criticalChanceInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER)
    //    {
    //        criticalChanceInt += CriticalChanceOneHandedWarhammerInt;
    //        return criticalChanceInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SWORD)
    //    {
    //        criticalChanceInt += CriticalChanceOneHandedSwordInt;
    //        return criticalChanceInt;
    //    }
    //    return 0;
    //}
    //public static int CriticalChanceRequirementGenerator(int CriticalChanceInt, ItemRequirement itemRequirements)
    //{
    //    CriticalChanceInt += (int)itemRequirements;
    //    return CriticalChanceInt;
    //}
    //#endregion

    //#region ItemPhysicalDamageFunctions

    //public static int PhysicalDamageGenerator(ItemRarity itemRarity, ItemType itemType, ItemRequirement itemRequirements)
    //{
    //    int PhysicalDamageInt = 1;
    //    PhysicalDamageInt += PhysicalDamageItemTypeGenerator(PhysicalDamageInt, itemType);
    //    PhysicalDamageInt += PhysicalDamageRarityGenerator(PhysicalDamageInt, itemRarity);
    //    PhysicalDamageInt += PhysicalDamageRequirementGenerator(PhysicalDamageInt, itemRequirements);
    //    return PhysicalDamageInt;
    //}
    //public static int PhysicalDamageRarityGenerator(int physicalDamageInt, ItemRarity itemRarity)
    //{
    //    if (itemRarity == ItemRarity.COMMON)
    //    {
    //        physicalDamageInt += PhysicalDamageCommonInt;
    //        return physicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.UNCOMMON)
    //    {
    //        physicalDamageInt += PhysicalDamageUncommonInt;
    //        return physicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.RARE)
    //    {
    //        physicalDamageInt += PhysicalDamageRareInt;
    //        return physicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.UNQIUE)
    //    {
    //        physicalDamageInt += PhysicalDamageUnqiueInt;
    //        return physicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.MASTERWORK)
    //    {
    //        physicalDamageInt += PhysicalDamageMasterworkInt;
    //        return physicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.EXOTIC)
    //    {
    //        physicalDamageInt += PhysicalDamageExoticInt;
    //        return physicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.LEGENDARY)
    //    {
    //        physicalDamageInt += PhysicalDamageLegendaryInt;
    //        return physicalDamageInt;
    //    }
    //    return 0;
    //}
    //public static int PhysicalDamageItemTypeGenerator(int physicalDamageInt, ItemType itemType)
    //{
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_AXE)
    //    {
    //        physicalDamageInt += PhysicalDamageOneHandedAxeInt;
    //        return physicalDamageInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_MACE)
    //    {
    //        physicalDamageInt += PhysicalDamageOneHandedMaceInt;
    //        return physicalDamageInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER)
    //    {
    //        physicalDamageInt += PhysicalDamageOneHandedWarhammerInt;
    //        return physicalDamageInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SWORD)
    //    {
    //        physicalDamageInt += PhysicalDamageOneHandedSwordInt;
    //        return physicalDamageInt;
    //    }
    //    return 0;
    //}
    //public static int PhysicalDamageRequirementGenerator(int physicalDamageInt, ItemRequirement itemRequirements)
    //{
    //    physicalDamageInt += (int)itemRequirements;
    //    return physicalDamageInt;
    //}
    //#endregion

    //#region ItemMagicDamageFunctions

    //public static int MagicalDamageGenerator(ItemRarity itemRarity, ItemType itemType, ItemRequirement itemRequirements)
    //{
    //    int MagicalDamageInt = 0;
    //    MagicalDamageInt += MagicalDamageRarityGenerator(MagicalDamageInt, itemRarity);
    //    MagicalDamageInt += MagicalDamageItemTypeGenerator(MagicalDamageInt, itemType);
    //    MagicalDamageInt += MagicalDamageRequirementGenerator(MagicalDamageInt, itemRequirements);
    //    return MagicalDamageInt;
    //}
    //public static int MagicalDamageRarityGenerator(int magicalDamageInt, ItemRarity itemRarity)
    //{
    //    if (itemRarity == ItemRarity.COMMON)
    //    {
    //        magicalDamageInt += MagicalDamageCommonInt;
    //        return magicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.UNCOMMON)
    //    {
    //        magicalDamageInt += MagicalDamageUncommonInt;
    //        return magicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.RARE)
    //    {
    //        magicalDamageInt += MagicalDamageRareInt;
    //        return magicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.UNQIUE)
    //    {
    //        magicalDamageInt += MagicalDamageUnqiueInt;
    //        return magicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.MASTERWORK)
    //    {
    //        magicalDamageInt += MagicalDamageMasterworkInt;
    //        return magicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.EXOTIC)
    //    {
    //        magicalDamageInt += MagicalDamageExoticInt;
    //        return magicalDamageInt;
    //    }
    //    if (itemRarity == ItemRarity.LEGENDARY)
    //    {
    //        magicalDamageInt += MagicalDamageLegendaryInt;
    //        return magicalDamageInt;
    //    }
    //    return 0;
    //}
    //public static int MagicalDamageItemTypeGenerator(int magicalDamageInt, ItemType itemType)
    //{
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_AXE)
    //    {
    //        magicalDamageInt += MagicalDamageOneHandedAxeInt;
    //        return magicalDamageInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_MACE)
    //    {
    //        magicalDamageInt += MagicalDamageOneHandedMaceInt;
    //        return magicalDamageInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER)
    //    {
    //        magicalDamageInt += MagicalDamageOneHandedWarhammerInt;
    //        return magicalDamageInt;
    //    }
    //    if (itemType == ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SWORD)
    //    {
    //        magicalDamageInt += MagicalDamageOneHandedSwordInt;
    //        return magicalDamageInt;
    //    }
    //    return 0;
    //}
    //public static int MagicalDamageRequirementGenerator(int magicalDamageInt, ItemRequirement itemRequirements)
    //{
    //    magicalDamageInt += (int)itemRequirements;
    //    return magicalDamageInt;
    //}
    //#endregion

    //#endregion
    //public enum ItemType
    //{
    //    //one handed melee
    //    ITEM_WEAPON_MELEE_ONEHANDED_SWORD,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE,
    //    ITEM_WEAPON_MELEE_ONEHANDED_KNIFE,
    //    ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER,
    //    ITEM_WEAPON_MELEE_ONEHANDED_AXE,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SHIELD,
    //    ITEM_WEAPON_MELEE_ONEHANDED_RAPIER,
    //    ITEM_WEAPON_MELEE_ONEHANDED_CLUB,
    //    //Two handed melee
    //    ITEM_WEAPON_MELEE_TWOHANDED_SWORD,
    //    ITEM_WEAPON_MELEE_TWOHANDED_MACE,
    //    ITEM_WEAPON_MELEE_TWOHANDED_WARHAMMER,
    //    ITEM_WEAPON_MELEE_TWOHANDED_HALBERD,
    //    ITEM_WEAPON_MELEE_TWOHANDED_AXE,
    //    ITEM_WEAPON_MELEE_TWOHANDED_CLUB,
    //    ITEM_WEAPON_MELEE_TWOHANDED_STAFF,
    //    ITEM_WEAPON_MELEE_TWOHANDED_SPEAR,
    //    ITEM_WEAPON_MELEE_TWOHANDED_CLAWS,
    //    //One handed ranged
    //    WAND,
    //    THROWINGKNIFES,
    //    THROWINGAXES,
    //    PISTOL,
    //    HANDCROSSBOW,
    //    //Two handed ranged
    //    BOW,
    //    CROSSBOW,
    //    MATCHLOCKRIFLE,
    //    CARBINE,
    //    BULLPUP,
    //    ASSAULTRIFLE,
    //    SNIPERRIFLE,
    //    MACHINEGUN,
    //    SHOTGUN,
    //    GRENADELAUNCHER,
    //    ROCKETLAUNCHER,
    //}
    //public static ItemType ItemTypeGenerator(ItemTypeName itemTypeName)
    //{
    //    ItemType itemType;
    //    if (itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_BLOODCLEAVER ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_VIKINGAXE ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_WOODEDAXE ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_BONEHACHET)
    //    {
    //        itemType = ItemType.ITEM_WEAPON_MELEE_ONEHANDED_AXE;
    //        return itemType;
    //    }
    //    if (itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_BLACKJACK ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_IRONTEETH ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_NIGHTGADA ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_MORNINGSTAR ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_RINGEDPERNACH ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_ENERGYCORRECTOR ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_BEDECKEDSHISHPAR)
    //    {
    //        itemType = ItemType.ITEM_WEAPON_MELEE_ONEHANDED_MACE;
    //        return itemType;
    //    }
    //    if (itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_CLAWEDPICK ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_DOUBLEHEADER ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_SKULLSINGER ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_STONEBREAKER)
    //    {
    //        itemType = ItemType.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER;
    //        return itemType;
    //    }
    //    if (itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_BRONZEFALX ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_TUTONICSWORD ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_DUSTKHOPESH ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_STEELGLADIUS ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_OBSIDIANMAQUAHUITL)
    //    {
    //        itemType = ItemType.ITEM_WEAPON_MELEE_ONEHANDED_SWORD;
    //        return itemType;
    //    }
    //    if (itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_SEAOMEGA ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_BATTLEAXE ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_LANDHOWITER ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_DEMONSMALICE ||
    //        itemTypeName == ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_GOLDENREAVER)
    //    {
    //        itemType = ItemType.ITEM_WEAPON_MELEE_TWOHANDED_AXE;
    //        return itemType;
    //    }
    //    return 0;
    //public static ItemTypeName GenerateOneHandedAxesNames()
    //{
    //    ItemTypeName oneHandedAxesNames;
    //    oneHandedAxesNames = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_COUNTSTART + 1, (int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_AXE_COUNTEND);
    //    return oneHandedAxesNames;
    //}
    //public static ItemTypeName GenerateOneHandedMacesNames()
    //{
    //    ItemTypeName oneHandedMacesNames;
    //    oneHandedMacesNames = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_COUNTSTART + 1, (int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_MACE_COUNTEND);
    //    return oneHandedMacesNames;
    //}
    //public static ItemTypeName GenerateOneHandedWarHammerNames()
    //{
    //    ItemTypeName oneHandedWarHammerNames;
    //    oneHandedWarHammerNames = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_COUNTSTART + 1, (int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_COUNTEND);
    //    return oneHandedWarHammerNames;
    //}
    //public static ItemTypeName GenerateOneHandedSwordsNames()
    //{
    //    ItemTypeName oneHandedSwordNames;
    //    oneHandedSwordNames = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_COUNTSTART + 1, (int)ItemTypeName.ITEM_WEAPON_MELEE_ONEHANDED_SWORD_COUNTEND);
    //    return oneHandedSwordNames;
    //}
    //public static ItemTypeName GenerateTwoHandedAxeNames()
    //{
    //    ItemTypeName twoHandedAxeNames;
    //    twoHandedAxeNames = (ItemTypeName)Random.Range((int)ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_COUNTSTART + 1, (int)ItemTypeName.ITEM_WEAPON_MELEE_TWOHANDED_AXE_COUNTEND);
    //    return twoHandedAxeNames;
    //}
    //}
    //public enum ItemTypeName
    //{
    //    ITEM_COUNTSTART,
    //    ITEM_WEAPON_MELEE_ONEHANDED_AXE_COUNTSTART,
    //    ITEM_WEAPON_MELEE_ONEHANDED_AXE_VIKINGAXE,
    //    ITEM_WEAPON_MELEE_ONEHANDED_AXE_BONEHACHET,
    //    ITEM_WEAPON_MELEE_ONEHANDED_AXE_WOODEDAXE,
    //    ITEM_WEAPON_MELEE_ONEHANDED_AXE_BLOODCLEAVER,
    //    ITEM_WEAPON_MELEE_ONEHANDED_AXE_COUNTEND,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE_COUNTSTART,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE_MORNINGSTAR,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE_BLACKJACK,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE_IRONTEETH,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE_RINGEDPERNACH,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE_ENERGYCORRECTOR,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE_BEDECKEDSHISHPAR,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE_NIGHTGADA,
    //    ITEM_WEAPON_MELEE_ONEHANDED_MACE_COUNTEND,
    //    ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_COUNTSTART,
    //    ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_CLAWEDPICK,
    //    ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_SKULLSINGER,
    //    ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_DOUBLEHEADER,
    //    ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_STONEBREAKER,
    //    ITEM_WEAPON_MELEE_ONEHANDED_WARHAMMER_COUNTEND,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SWORD_COUNTSTART,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SWORD_BRONZEFALX,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SWORD_TUTONICSWORD,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SWORD_DUSTKHOPESH,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SWORD_WETKOPIS,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SWORD_STEELGLADIUS,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SWORD_OBSIDIANMAQUAHUITL,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SWORD_COUNTEND,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_COUNTSTART,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_HEXSCUTUM,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_ODENROUNDSHEILD,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_BUCKERLER,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_NAKHTUAASHEILD,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_PAINTEDKITESHEILD,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_HEATERSHEILD,
    //    ITEM_WEAPON_MELEE_ONEHANDED_SHIELD_COUNTEND,
    //    ITEM_WEAPON_MELEE_TWOHANDED_AXE_COUNTSTART,
    //    ITEM_WEAPON_MELEE_TWOHANDED_AXE_BATTLEAXE,
    //    ITEM_WEAPON_MELEE_TWOHANDED_AXE_LANDHOWITER,
    //    ITEM_WEAPON_MELEE_TWOHANDED_AXE_GOLDENREAVER,
    //    ITEM_WEAPON_MELEE_TWOHANDED_AXE_DEMONSMALICE,
    //    ITEM_WEAPON_MELEE_TWOHANDED_AXE_SEAOMEGA,
    //    ITEM_WEAPON_MELEE_TWOHANDED_AXE_COUNTEND,
    //    ITEM_COUNTEND
    //}
    //public void ItemGenerator()
    //{
    //    itemName = ItemName.GenerateItemName();
    //    itemType = ItemTypes.ItemTypeGenerator(itemName);
    //    itemRarity = ItemRarities.RarityGenerator();
    //    switch (itemRarity)
    //    {
    //        case ItemRarity.COUNTSTART:
    //            break;
    //        case ItemRarity.COMMON:
    //            itemCombinedNameString = itemNameString;
    //            break;
    //        case ItemRarity.UNCOMMON:
    //            itemPrefixs1 = ItemAffixs.GeneratePrefixs();
    //            itemPrefix1String = ConvertString.ConvertStringPrefixs(itemPrefixs1);
    //            break;
    //        case ItemRarity.RARE:
    //            itemPrefixs1 = ItemAffixs.GeneratePrefixs();
    //            itemSuffixs1 = ItemAffixs.GenerateSuffixs();
    //            itemPrefix1String = ConvertString.ConvertStringPrefixs(itemPrefixs1);
    //            itemSuffix1String = ConvertString.ConvertStringSuffixs(itemSuffixs1);
    //            break;
    //        case ItemRarity.UNQIUE:
    //            itemPrefixs1 = ItemAffixs.GeneratePrefixs();
    //            itemSuffixs1 = ItemAffixs.GenerateSuffixs();
    //            itemPrefixs2 = ItemAffixs.GeneratePrefixs();
    //            itemPrefix1String = ConvertString.ConvertStringPrefixs(itemPrefixs1);
    //            itemSuffix1String = ConvertString.ConvertStringSuffixs(itemSuffixs1);
    //            break;
    //        case ItemRarity.MASTERWORK:
    //            itemPrefixs1 = ItemAffixs.GeneratePrefixs();
    //            itemSuffixs1 = ItemAffixs.GenerateSuffixs();
    //            itemPrefixs2 = ItemAffixs.GeneratePrefixs();
    //            itemSuffixs2 = ItemAffixs.GenerateSuffixs();
    //            itemPrefix1String = ConvertString.ConvertStringPrefixs(itemPrefixs1);
    //            itemSuffix1String = ConvertString.ConvertStringSuffixs(itemSuffixs1);
    //            break;
    //        case ItemRarity.EXOTIC:
    //            itemPrefixs1 = ItemAffixs.GeneratePrefixs();
    //            itemSuffixs1 = ItemAffixs.GenerateSuffixs();
    //            itemPrefixs2 = ItemAffixs.GeneratePrefixs();
    //            itemSuffixs2 = ItemAffixs.GenerateSuffixs();
    //            itemPrefixs3 = ItemAffixs.GeneratePrefixs();
    //            itemPrefix1String = ConvertString.ConvertStringPrefixs(itemPrefixs1);
    //            itemSuffix1String = ConvertString.ConvertStringSuffixs(itemSuffixs1);
    //            break;
    //        case ItemRarity.LEGENDARY:
    //            itemPrefixs1 = ItemAffixs.GeneratePrefixs();
    //            itemSuffixs1 = ItemAffixs.GenerateSuffixs();
    //            itemPrefixs2 = ItemAffixs.GeneratePrefixs();
    //            itemSuffixs2 = ItemAffixs.GenerateSuffixs();
    //            itemPrefixs3 = ItemAffixs.GeneratePrefixs();
    //            itemSuffixs3 = ItemAffixs.GenerateSuffixs();
    //            itemPrefix1String = ConvertString.ConvertStringPrefixs(itemPrefixs1);
    //            itemSuffix1String = ConvertString.ConvertStringSuffixs(itemSuffixs1);
    //            break;
    //        case ItemRarity.COUNTEND:
    //            break;
    //        default:
    //            break;
    //    }
    //    itemRequirements = ItemRequirements.RequirementsGenerator();
    //    if ()
    //    {
    //        itemStat1 = ItemStatType.AttackSpeed;
    //        itemStat2 = ItemStatType.CriticalChance;
    //        itemStat3 = ItemStatType.PhysicalDamage;
    //        itemStat4 = ItemStatType.MagicalDamage;
    //        itemStat5 = 0;
    //        itemStat6 = 0;
    //        itemStatInt1 = ItemStats.AttackSpeedGenerator(itemRarity, itemType, itemRequirements);
    //        itemStatInt2 = ItemStats.CriticalChanceGenerator(itemRarity, itemType, itemRequirements);
    //        itemStatInt3 = ItemStats.MagicalDamageGenerator(itemRarity, itemType, itemRequirements);
    //        itemStatInt4 = ItemStats.PhysicalDamageGenerator(itemRarity, itemType, itemRequirements);
    //        itemStatInt5 = 0;
    //        itemStatInt6 = 0;
    //        itemStats1String = ConvertString.AttackSpeedGenerator(itemStatInt1);
    //        itemStats2String = ConvertString.CriticalChanceGenerator(itemStatInt2);
    //        itemStats3String = ConvertString.PhysicalDamageGenerator(itemStatInt3);
    //        itemStats4String = ConvertString.AttackSpeedGenerator(itemStatInt4);
    //        itemStats5String = "";
    //        itemStats6String = "";
    //    }
    //    itemNameString = ConvertString.StringConvertItemName(itemName);
    //    itemCombinedNameString = ConvertString.CombineNameString(itemPrefix1String, itemNameString, itemSuffix1String);
    //    itemRarityString = ConvertString.RarityGeneratorString(itemRarity);
    //    itemTypeString = ConvertString.ItemTypeString(itemType);
    //    itemRequirementsString = ConvertString.RequirementsStringConvertor(itemRequirements);
    //}
    //public enum ItemRarity
    //{
    //    COUNTSTART,
    //    COMMON,
    //    UNCOMMON,
    //    RARE,
    //    MASTERWORK,
    //    EXOTIC,
    //    LEGENDARY,
    //    ANCIENT,
    //    UNQIUE,
    //    COUNTEND,
    //}
    //public enum ItemRequirement
    //{
    //    COUNTSTART,
    //    Lvl_1 = 1, Lvl_2 = 2, Lvl_3 = 3, Lvl_4 = 4, Lvl_5 = 5, Lvl_6 = 6, Lvl_7 = 7, Lvl_8 = 8, Lvl_9 = 9,
    //    Lvl_10 = 10, Lvl_11 = 11, Lvl_12 = 12, Lvl_13 = 13, Lvl_14 = 14, Lvl_15 = 15, Lvl_16 = 16, Lvl_17 = 17, Lvl_18 = 18, Lvl_19 = 19,
    //    Lvl_20 = 20, Lvl_21 = 21, Lvl_22 = 22, Lvl_23 = 23, Lvl_24 = 24, Lvl_25 = 25, Lvl_26 = 26, Lvl_27 = 27, Lvl_28 = 28, Lvl_29 = 29,
    //    Lvl_30 = 30, Lvl_31 = 31, Lvl_32 = 32, Lvl_33 = 33, Lvl_34 = 34, Lvl_35 = 35, Lvl_36 = 36, Lvl_37 = 37, Lvl_38 = 38, Lvl_39 = 39,
    //    Lvl_40 = 40, Lvl_41 = 41, Lvl_42 = 42, Lvl_43 = 43, Lvl_44 = 44, Lvl_45 = 45, Lvl_46 = 46, Lvl_47 = 47, Lvl_48 = 48, Lvl_49 = 49,
    //    Lvl_50 = 50, Lvl_51 = 51, Lvl_52 = 52, Lvl_53 = 53, Lvl_54 = 54, Lvl_55 = 55, Lvl_56 = 56, Lvl_57 = 57, Lvl_58 = 58, Lvl_59 = 59,
    //    Lvl_60 = 60, Lvl_61 = 61, Lvl_62 = 62, Lvl_63 = 63, Lvl_64 = 64, Lvl_65 = 65, Lvl_66 = 66, Lvl_67 = 67, Lvl_68 = 68, Lvl_69 = 69,
    //    Lvl_70 = 70, Lvl_71 = 71, Lvl_72 = 72, Lvl_73 = 73, Lvl_74 = 74, Lvl_75 = 75, Lvl_76 = 76, Lvl_77 = 77, Lvl_78 = 78, Lvl_79 = 79,
    //    Lvl_80 = 80, Lvl_81 = 81, Lvl_82 = 82, Lvl_83 = 83, Lvl_84 = 84, Lvl_85 = 85, Lvl_86 = 86, Lvl_87 = 87, Lvl_88 = 88, Lvl_89 = 89,
    //    Lvl_90 = 90, Lvl_91 = 91, Lvl_92 = 92, Lvl_93 = 93, Lvl_94 = 94, Lvl_95 = 95, Lvl_96 = 96, Lvl_97 = 97, Lvl_98 = 98, Lvl_99 = 99,
    //    Lvl_100 = 100,
    //    COUNTEND,
    //}
    //public static string RequirementsStringConvertor(ItemRequirement requirements)
    //{
    //    string ItemRequirementsString;
    //    switch (requirements)
    //    {
    //        case ItemRequirement.Lvl_1:
    //            ItemRequirementsString = "Level 1";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_2:
    //            ItemRequirementsString = "Level 2";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_3:
    //            ItemRequirementsString = "Level 3";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_4:
    //            ItemRequirementsString = "Level 4";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_5:
    //            ItemRequirementsString = "Level 5";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_6:
    //            ItemRequirementsString = "Level 6";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_7:
    //            ItemRequirementsString = "Level 7";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_8:
    //            ItemRequirementsString = "Level 8";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_9:
    //            ItemRequirementsString = "Level 9";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_10:
    //            ItemRequirementsString = "Level 10";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_11:
    //            ItemRequirementsString = "Level 11";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_12:
    //            ItemRequirementsString = "Level 12";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_13:
    //            ItemRequirementsString = "Level 13";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_14:
    //            ItemRequirementsString = "Level 14";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_15:
    //            ItemRequirementsString = "Level 15";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_16:
    //            ItemRequirementsString = "Level 16";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_17:
    //            ItemRequirementsString = "Level 17";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_18:
    //            ItemRequirementsString = "Level 18";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_19:
    //            ItemRequirementsString = "Level 19";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_20:
    //            ItemRequirementsString = "Level 20";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_21:
    //            ItemRequirementsString = "Level 21";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_22:
    //            ItemRequirementsString = "Level 22";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_23:
    //            ItemRequirementsString = "Level 23";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_24:
    //            ItemRequirementsString = "Level 24";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_25:
    //            ItemRequirementsString = "Level 25";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_26:
    //            ItemRequirementsString = "Level 26";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_27:
    //            ItemRequirementsString = "Level 27";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_28:
    //            ItemRequirementsString = "Level 28";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_29:
    //            ItemRequirementsString = "Level 29";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_30:
    //            ItemRequirementsString = "Level 30";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_31:
    //            ItemRequirementsString = "Level 31";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_32:
    //            ItemRequirementsString = "Level 32";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_33:
    //            ItemRequirementsString = "Level 33";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_34:
    //            ItemRequirementsString = "Level 34";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_35:
    //            ItemRequirementsString = "Level 35";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_36:
    //            ItemRequirementsString = "Level 36";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_37:
    //            ItemRequirementsString = "Level 37";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_38:
    //            ItemRequirementsString = "Level 38";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_39:
    //            ItemRequirementsString = "Level 39";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_40:
    //            ItemRequirementsString = "Level 40";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_41:
    //            ItemRequirementsString = "Level 41";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_42:
    //            ItemRequirementsString = "Level 42";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_43:
    //            ItemRequirementsString = "Level 43";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_44:
    //            ItemRequirementsString = "Level 44";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_45:
    //            ItemRequirementsString = "Level 45";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_46:
    //            ItemRequirementsString = "Level 46";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_47:
    //            ItemRequirementsString = "Level 47";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_48:
    //            ItemRequirementsString = "Level 48";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_49:
    //            ItemRequirementsString = "Level 49";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_50:
    //            ItemRequirementsString = "Level 50";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_51:
    //            ItemRequirementsString = "Level 51";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_52:
    //            ItemRequirementsString = "Level 52";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_53:
    //            ItemRequirementsString = "Level 53";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_54:
    //            ItemRequirementsString = "Level 54";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_55:
    //            ItemRequirementsString = "Level 55";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_56:
    //            ItemRequirementsString = "Level 56";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_57:
    //            ItemRequirementsString = "Level 57";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_58:
    //            ItemRequirementsString = "Level 58";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_59:
    //            ItemRequirementsString = "Level 59";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_60:
    //            ItemRequirementsString = "Level 60";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_61:
    //            ItemRequirementsString = "Level 61";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_62:
    //            ItemRequirementsString = "Level 62";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_63:
    //            ItemRequirementsString = "Level 63";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_64:
    //            ItemRequirementsString = "Level 64";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_65:
    //            ItemRequirementsString = "Level 65";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_66:
    //            ItemRequirementsString = "Level 66";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_67:
    //            ItemRequirementsString = "Level 67";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_68:
    //            ItemRequirementsString = "Level 68";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_69:
    //            ItemRequirementsString = "Level 69";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_70:
    //            ItemRequirementsString = "Level 70";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_71:
    //            ItemRequirementsString = "Level 71";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_72:
    //            ItemRequirementsString = "Level 72";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_73:
    //            ItemRequirementsString = "Level 73";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_74:
    //            ItemRequirementsString = "Level 74";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_75:
    //            ItemRequirementsString = "Level 75";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_76:
    //            ItemRequirementsString = "Level 76";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_77:
    //            ItemRequirementsString = "Level 77";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_78:
    //            ItemRequirementsString = "Level 78";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_79:
    //            ItemRequirementsString = "Level 79";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_80:
    //            ItemRequirementsString = "Level 80";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_81:
    //            ItemRequirementsString = "Level 81";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_82:
    //            ItemRequirementsString = "Level 82";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_83:
    //            ItemRequirementsString = "Level 83";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_84:
    //            ItemRequirementsString = "Level 84";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_85:
    //            ItemRequirementsString = "Level 85";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_86:
    //            ItemRequirementsString = "Level 86";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_87:
    //            ItemRequirementsString = "Level 87";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_88:
    //            ItemRequirementsString = "Level 88";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_89:
    //            ItemRequirementsString = "Level 89";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_90:
    //            ItemRequirementsString = "Level 90";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_91:
    //            ItemRequirementsString = "Level 91";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_92:
    //            ItemRequirementsString = "Level 92";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_93:
    //            ItemRequirementsString = "Level 93";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_94:
    //            ItemRequirementsString = "Level 94";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_95:
    //            ItemRequirementsString = "Level 95";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_96:
    //            ItemRequirementsString = "Level 96";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_97:
    //            ItemRequirementsString = "Level 97";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_98:
    //            ItemRequirementsString = "Level 98";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_99:
    //            ItemRequirementsString = "Level 99";
    //            return ItemRequirementsString;
    //        case ItemRequirement.Lvl_100:
    //            ItemRequirementsString = "Level 100";
    //            return ItemRequirementsString;
    //        default:
    //            ItemRequirementsString = "ERROR";
    //            return ItemRequirementsString;
    //    }
    //}
    //#region Item Constructor
    //public Item(ItemName itemName, ItemRarities itemRarity, ItemRequirements itemRequirements, ItemTypes itemType,
    //            ItemStats itemStat1, ItemStats itemStat2, ItemStats itemStat3, ItemStats itemStat4, ItemStats itemStat5, ItemStats itemStat6,
    //            ItemMod itemMod1, ItemMod itemMod2, ItemMod itemMod3, ItemMod itemMod4, ItemMod itemMod5, ItemMod itemMod6,
    //            ItemAffixs itemPrefixs1, ItemAffixs itemPrefixs2, ItemAffixs itemPrefixs3, ItemAffixs itemSuffixs1, ItemAffixs itemSuffixs2, ItemAffixs itemSuffixs3)
    //{
    //    this.itemName = itemName;
    //    this.itemRarity = itemRarity;
    //    itemName.itemType = itemType;
    //    this.itemRequirements = itemRequirements;
    //    this.itemStat1 = itemStat1;
    //    this.itemStat2 = itemStat2;
    //    this.itemStat3 = itemStat3;
    //    this.itemStat4 = itemStat4;
    //    this.itemStat5 = itemStat5;
    //    this.itemStat6 = itemStat6;
    //    this.itemMod1 = itemMod1;
    //    this.itemMod2 = itemMod2;
    //    this.itemMod3 = itemMod3;
    //    this.itemMod4 = itemMod4;
    //    this.itemMod5 = itemMod5;
    //    this.itemMod6 = itemMod6;
    //    this.itemPrefixs1 = itemPrefixs1;
    //    this.itemPrefixs2 = itemPrefixs2;
    //    this.itemPrefixs3 = itemPrefixs3;
    //    this.itemSuffixs1 = itemSuffixs1;
    //    this.itemSuffixs2 = itemSuffixs2;
    //    this.itemSuffixs3 = itemSuffixs3;
    //    this.itemCombinedNameString = itemCombinedNameString;
    //    ItemGenerator();
    //}
    //#endregion
    //public enum ItemStatType
    //{
    //    CountStart,
    //    AttackSpeed,
    //    CriticalChance,
    //    PhysicalDamage,
    //    MagicalDamage,
    //    Armour,
    //    BlockChance,
    //    MagicGeneration,
    //    MovementSpeed,
    //    Evasion,
    //    ReloadSpeed,
    //    MagazineSize,
    //    CountEnd,
    //}
}

