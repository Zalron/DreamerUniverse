using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemModule;
namespace CharacterModule
{
    public class CharacterDetailed
    {
        //Stats gain on level
        public const int lifeGainOnLevel = 6;
        public const int magicGainOnLevel = 6;
        public const int enegryGainOnLevel = 6;

        //Stats gain on every ten Attribute
        public const int lifeGainForTenStrength = 5;
        public const int evasionGainForTenDexterity = 5;
        public const int magicGainForTenIntelligence = 5;
        public const int energyGainForTenEnduance = 5;
        public const int Willpower = 5;

        public int addFromGear, addFromTree, addTotal;
        public int minusFromGear, minusFromTree, minusTotal;
        public int flatTotal;
        public int increasedFromGear, increasedFromTree, increasedTotal;
        public int decreasedFromGear, decreasedFromTree, decreasedTotal;
        public int additivePercentageTotal;
        public List<ItemMod> moreFromGear;
        public List<Skillnodes> moreFromTree;
        public List<ItemMod> lessFromGear;
        public List<Skillnodes> lessFromTree;
        public int total;

        #region Attributes
        //Attributes
        //Strength
        public int addFromGearStrength, addFromTreeStrength, addTotalStrength;
        public int minusFromGearStrength, minusFromTreeStrength, minusTotalStrength;
        public int flatTotalStrength;
        public int increasedFromGearStrength, increasedFromTreeStrength, increasedTotalStrength;
        public int decreasedFromGearStrength, decreasedFromTreeStrength, decreasedTotalStrength;
        public int additivePercentageTotalStrength;
        public int totalStrength;
        //Endurance
        public int addFromGearEndurance, addFromTreeEndurance, addTotalEndurance;
        public int minusFromGearEndurance, minusFromTreeEndurance, minusTotalEndurance;
        public int flatTotalEndurance;
        public int increasedFromGearEndurance, increasedFromTreeEndurance, increasedTotalEndurance;
        public int decreasedFromGearEndurance, decreasedFromTreeEndurance, decreasedTotalEndurance;
        public int additivePercentageTotalEndurance;
        public int totalEndurance;
        //Dexterity
        public int addFromGearDexterity, addFromTreeDexterity, addTotalDexterity;
        public int minusFromGearDexterity, minusFromTreeDexterity, minusTotalDexterity;
        public int flatTotalDexterity;
        public int increasedFromGearDexterity, increasedFromTreeDexterity, increasedTotalDexterity;
        public int decreasedFromGearDexterity, decreasedFromTreeDexterity, decreasedTotalDexterity;
        public int additivePercentageTotalDexterity;
        public int totalDexterity;
        //Luck
        public int addFromGearLuck, addFromTreeLuck, addTotalLuck;
        public int minusFromGearLuck, minusFromTreeLuck, minusTotalLuck;
        public int flatTotalLuck;
        public int increasedFromGearLuck, increasedFromTreeLuck, increasedTotalLuck;
        public int decreasedFromGearLuck, decreasedFromTreeLuck, decreasedTotalLuck;
        public int additivePercentageTotalLuck;
        public int totalLuck;
        //Intelligence
        public int addFromGearIntelligence, addFromTreeIntelligence, addTotalIntelligence;
        public int minusFromGearIntelligence, minusFromTreeIntelligence, minusTotalIntelligence;
        public int flatTotalIntelligence;
        public int increasedFromGearIntelligence, increasedFromTreeIntelligence, increasedTotalIntelligence;
        public int decreasedFromGearIntelligence, decreasedFromTreeIntelligence, decreasedTotalIntelligence;
        public int additivePercentageTotalIntelligence;
        public int totalIntelligence;
        //Willpower
        public int addFromGearWillpower, addFromTreeWillpower, addTotalWillpower;
        public int minusFromGearWillpower, minusFromTreeWillpower, minusTotalWillpower;
        public int flatTotalWillpower;
        public int increasedFromGearWillpower, increasedFromTreeWillpower, increasedTotalWillpower;
        public int decreasedFromGearWillpower, decreasedFromTreeWillpower, decreasedTotalWillpower;
        public int additivePercentageTotalWillpower;
        public int totalWillpower;
        #endregion

        #region Stats
        //Stats

        //Life
        public int addFromGearLife, addFromTreeLife, addTotalLife;
        public int minusFromGearLife, minusFromTreeLife, minusTotalLife;
        public int flatTotalLife;
        public int increasedFromGearLife, increasedFromTreeLife, increasedTotalLife;
        public int decreasedFromGearLife, decreasedFromTreeLife, decreasedTotalLife;
        public int additivePercentageTotalLife;
        public List<ItemMod> moreFromGearLife;
        public List<Skillnodes> moreFromTreeLife;
        public List<ItemMod> lessFromGearLife;
        public List<Skillnodes> lessFromTreeLife;
        public int multiplictivePercentageTotalLife;
        public int totalLife;
        //Life Regen Rate
        public int moreFromGearLifeRegenRate, moreFromTreeLifeRegenRate, moreTotalLifeRegenRate;
        public int lessFromGearLifeRegenRate, lessFromTreeLifeRegenRate, lessTotalLifeRegenRate;
        public int flatTotalLifeRegen;
        public int increasedFromGearLifeRegenRate, increasedFromTreeLifeRegenRate, increasedTotalLifeRegenRate;
        public int decreasedFromGearLifeRegenRate, decreasedFromTreeLifeRegenRate, decreasedTotalLifeRegenRate;
        public int additivePercentageTotalLifeRegenRate;
        public int totalLifeRegenRate;
        //Life Regen Delay
        public int moreFromGearLifeRegenDelay, moreFromTreeLifeRegenDelay, moreTotalLifeRegenDelay;
        public int lessFromGearLifeRegenDelay, lessFromTreeLifeRegenDelay, lessTotalLifeRegenDelay;
        public int flatTotalLifeRegenDelay;
        public int increasedFromGearLifeRegenDelay, increasedFromTreeLifeRegenDelay, increasedTotalLifeRegenDelay;
        public int decreasedFromGearLifeRegenDelay, decreasedFromTreeLifeRegenDelay, decreasedTotalLifeRegenDelay;
        public int additivePercentageTotalLifeRegenDelay;
        public int totalLifeRegenDelay;
        //Life Leech
        public int moreFromGearLifeLeech, moreFromTreeLifeLeech, moreTotalLifeLeech;
        public int lessFromGearLifeLeech, lessFromTreeLifeLeech, lessTotalLifeLeech;
        public int flatTotalLifeLeech;
        public int increasedFromGearLifeLeech, increasedFromTreeLifeLeech, increasedTotalLifeLeech;
        public int decreasedFromGearLifeLeech, decreasedFromTreeLifeLeech, decreasedTotalLifeLeech;
        public int additivePercentageTotalLifeLeech;
        public int totalLifeLeech;

        //Energy
        public int moreFromGearEnergy, moreFromTreeEnergy, moreTotalEnergy;
        public int lessFromGearEnergy, lessFromTreeEnergy, lessTotalEnergy;
        public int flatTotalEnergy;
        public int increasedFromGearEnergy, increasedFromTreeEnergy, increasedTotalEnergy;
        public int decreasedFromGearEnergy, decreasedFromTreeEnergy, decreasedTotalEnergy;
        public int additivePercentageTotalEnergy;
        public int totalEnergy;
        //Energy Recharge
        public int moreFromGearEnergyRechargeRate, moreFromTreeEnergyRechargeRate, moreTotalEnergyRechargeRate;
        public int lessFromGearEnergyRechargeRate, lessFromTreeEnergyRechargeRate, lessTotalEnergyRechargeRate;
        public int flatTotalEnergyRechargeRate;
        public int increasedFromGearEnergyRechargeRate, increasedFromTreeEnergyRechargeRate, increasedTotalEnergyRechargeRate;
        public int decreasedFromGearEnergyRechargeRate, decreasedFromTreeEnergyRechargeRate, decreasedTotalEnergyRechargeRate;
        public int additivePercentageTotalEnergyRechargeRate;
        public int totalEnergyRechargeRate;
        //Energy Recharge Delay
        public int moreFromGearEnergyRechargeDelay, moreFromTreeEnergyRechargeDelay, moreTotalEnergyRechargeDelay;
        public int lessFromGearEnergyRechargeDelay, lessFromTreeEnergyRechargeDelay, lessTotalEnergyRechargeDelay;
        public int flatTotalEnergyRechargeDelay;
        public int increasedFromGearEnergyRechargeDelay, increasedFromTreeEnergyRechargeDelay, increasedTotalEnergyRechargeDelay;
        public int decreasedFromGearEnergyRechargeDelay, decreasedFromTreeEnergyRechargeDelay, decreasedTotalEnergyRechargeDelay;
        public int additivePercentageTotalEnergyRechargeDelay;
        public int totalEnergyRechargeDelay;

        //Movement
        public int moreFromGearMovement, moreFromTreeMovement, moreTotalMovement;
        public int lessFromGearMovement, lessFromTreeMovement, lessTotalMovement;
        public int flatTotalMovement;
        public int increasedFromGearMovement, increasedFromTreeMovement, increasedTotalMovement;
        public int decreasedFromGearMovement, decreasedFromTreeMovement, decreasedTotalMovement;
        public int additivePercentageTotalMovement;
        public int totalMovement;
        //Accuracy
        public int moreFromGearAccuracy, moreFromTreeAccuracy, moreTotalAccuracy;
        public int lessFromGearAccuracy, lessFromTreeAccuracy, lessTotalAccuracy;
        public int flatTotalAccuracy;
        public int increasedFromGearAccuracy, increasedFromTreeAccuracy, increasedTotalAccuracy;
        public int decreasedFromGearAccuracy, decreasedFromTreeAccuracy, decreasedTotalAccuracy;
        public int additivePercentageTotalAccuracy;
        public int totalAccuracy;
        //Evasion
        public int moreFromGearEvasion, moreFromTreeEvasion, moreTotalEvasion;
        public int lessFromGearEvasion, lessFromTreeEvasion, lessTotalEvasion;
        public int flatTotalEvasion;
        public int increasedFromGearEvasion, increasedFromTreeEvasion, increasedTotalEvasion;
        public int decreasedFromGearEvasion, decreasedFromTreeEvasion, decreasedTotalEvasion;
        public int additivePercentageTotalEvasion;
        public int totalEvasion;

        //Magic
        public int moreFromGearMagic, moreFromTreeMagic, moreTotalMagic;
        public int lessFromGearMagic, lessFromTreeMagic, lessTotalMagic;
        public int flatTotalMagic;
        public int increasedFromGearMagic, increasedFromTreeMagic, increasedTotalMagic;
        public int decreasedFromGearMagic, decreasedFromTreeMagic, decreasedTotalMagic;
        public int additivePercentageTotalMagic;
        public int totalMagic;
        //Magic Regen
        public int moreFromGearMagicRegenRate, moreFromTreeMagicRegenRate, moreTotalMagicRegenRate;
        public int lessFromGearMagicRegenRate, lessFromTreeMagicRegenRate, lessTotalMagicRegenRate;
        public int flatTotalMagicRegenRate;
        public int increasedFromGearMagicRegenRate, increasedFromTreeMagicRegenRate, increasedTotalMagicRegenRate;
        public int decreasedFromGearMagicRegenRate, decreasedFromTreeMagicRegenRate, decreasedTotalMagicRegenRate;
        public int additivePercentageTotalMagicRegenRate;
        public int totalMagicRegenRate;
        //Magic Regen Delay
        public int moreFromGearMagicRegenDelay, moreFromTreeMagicRegenDelay, moreTotalMagicRegenDelay;
        public int lessFromGearMagicRegenDelay, lessFromTreeMagicRegenDelay, lessTotalMagicRegenDelay;
        public int flatTotalMagicRegenDelay;
        public int increasedFromGearMagicRegenDelay, increasedFromTreeMagicRegenDelay, increasedTotalMagicRegenDelay;
        public int decreasedFromGearMagicRegenDelay, decreasedFromTreeMagicRegenDelay, decreasedTotalMagicRegenDelay;
        public int additivePercentageTotalMagicRegenDelay;
        public int totalMagicRegenDelay;
        //Magic Leech
        public int moreFromGearMagicLeech, moreFromTreeMagicLeech, moreTotalMagicLeech;
        public int lessFromGearMagicLeech, lessFromTreeMagicLeech, lessTotalMagicLeech;
        public int flatTotalMagicLeech;
        public int increasedFromGearMagicLeech, increasedFromTreeMagicLeech, increasedTotalMagicLeech;
        public int decreasedFromGearMagicLeech, decreasedFromTreeMagicLeech, decreasedTotalMagicLeech;
        public int additivePercentageTotalMagicLeech;
        public int totalMagicLeech;

        //Shield
        public int moreFromGearShield, moreFromTreeShield, moreTotalShield;
        public int lessFromGearShield, lessFromTreeShield, lessTotalShield;
        public int flatTotalShield;
        public int increasedFromGearShield, increasedFromTreeShield, increasedTotalShield;
        public int decreasedFromGearShield, decreasedFromTreeShield, decreasedTotalShield;
        public int additivePercentageTotalShield;
        public int totalShield;
        //Shield Recharge Rate
        public int moreFromGearShieldRechargeRate, moreFromTreeShieldRechargeRate, moreTotalShieldRechargeRate;
        public int lessFromGearShieldRechargeRate, lessFromTreeShieldRechargeRate, lessTotalShieldRechargeRate;
        public int flatTotalShieldRechargeRate;
        public int increasedFromGearShieldRechargeRate, increasedFromTreeShieldRechargeRate, increasedTotalShieldRechargeRate;
        public int decreasedFromGearShieldRechargeRate, decreasedFromTreeShieldRechargeRate, decreasedTotalShieldRechargeRate;
        public int additivePercentageTotalShieldRechargeRate;
        public int totalShieldRechargeRate;
        //Shield Recharge Delay
        public int moreFromGearShieldRechargeDelay, moreFromTreeShieldRechargeDelay, moreTotalShieldRechargeDelay;
        public int lessFromGearShieldRechargeDelay, lessFromTreeShieldRechargeDelay, lessTotalShieldRechargeDelay;
        public int flatTotalShieldRechargeDelay;
        public int increasedFromGearShieldRechargeDelay, increasedFromTreeShieldRechargeDelay, increasedTotalShieldRechargeDelay;
        public int decreasedFromGearShieldRechargeDelay, decreasedFromTreeShieldRechargeDelay, decreasedTotalShieldRechargeDelay;
        public int additivePercentageTotalShieldRechargeDelay;
        public int totalShieldRechargeDelay;

        //Armour
        public int moreFromGearArmour, moreFromTreeArmour, moreTotalArmour;
        public int lessFromGearArmour, lessFromTreeArmour, lessTotalArmour;
        public int flatTotalArmour;
        public int increasedFromGearArmour, increasedFromTreeArmour, increasedTotalArmour;
        public int decreasedFromGearArmour, decreasedFromTreeArmour, decreasedTotalArmour;
        public int additivePercentageTotalArmour;
        public int totalArmour;
        //Armour Recharge Rate
        public int moreFromGearArmourRechargeRate, moreFromTreeArmourRechargeRate, moreTotalArmourRechargeRate;
        public int lessFromGearArmourRechargeRate, lessFromTreeArmourRechargeRate, lessTotalArmourRechargeRate;
        public int flatTotalArmourRechargeRate;
        public int increasedFromGearArmourRechargeRate, increasedFromTreeArmourRechargeRate, increasedTotalArmourRechargeRate;
        public int decreasedFromGearArmourRechargeRate, decreasedFromTreeArmourRechargeRate, decreasedTotalArmourRechargeRate;
        public int additivePercentageTotalArmourRechargeRate;
        public int totalArmourRechargeRate;
        //Armour Recharge Delay
        public int moreFromGearArmourRechargeDelay, moreFromTreeArmourRechargeDelay, moreTotalArmourRechargeDelay;
        public int lessFromGearArmourRechargeDelay, lessFromTreeArmourRechargeDelay, lessTotalArmourRechargeDelay;
        public int flatTotalArmourRechargeDelay;
        public int increasedFromGearArmourRechargeDelay, increasedFromTreeArmourRechargeDelay, increasedTotalArmourRechargeDelay;
        public int decreasedFromGearArmourRechargeDelay, decreasedFromTreeArmourRechargeDelay, decreasedTotalArmourRechargeDelay;
        public int additivePercentageTotalArmourRechargeDelay;
        public int totalArmourRechargeDelay;
        #endregion

        #region DamageSources
        //Damage Sources

        //Physical Damage
        public int moreFromGearPhysicalDamage, moreFromTreePhysicalDamage, moreTotalPhysicalDamage;
        public int lessFromGearPhysicalDamage, lessFromTreePhysicalDamage, lessTotalPhysicalDamage;
        public int flatTotalPhysicalDamage;
        public int increasedFromGearPhysicalDamage, increasedFromTreePhysicalDamage, increasedTotalPhysicalDamage;
        public int decreasedFromGearPhysicalDamage, decreasedFromTreePhysicalDamage, decreasedTotalPhysicalDamage;
        public int additivePercentageTotalPhysicalDamage;
        public int totalPhysicalDamage;
        //One Handed Melee
        public int moreFromGearOneHandedMelee, moreFromTreeOneHandedMelee, moreTotalOneHandedMelee;
        public int lessFromGearOneHandedMelee, lessFromTreeOneHandedMelee, lessTotalOneHandedMelee;
        public int flatTotalOneHandedMelee;
        public int increasedFromGearOneHandedMelee, increasedFromTreeOneHandedMelee, increasedTotalOneHandedMelee;
        public int decreasedFromGearOneHandedMelee, decreasedFromTreeOneHandedMelee, decreasedTotalOneHandedMelee;
        public int additivePercentageTotalOneHandedMelee;
        public int totalOneHandedMelee;
        //Two Handed Melee
        public int moreFromGearTwoHandedMelee, moreFromTreeTwoHandedMelee, moreTotalTwoHandedMelee;
        public int lessFromGearTwoHandedMelee, lessFromTreeTwoHandedMelee, lessTotalTwoHandedMelee;
        public int flatTotalTwoHandedMelee;
        public int increasedFromGearTwoHandedMelee, increasedFromTreeTwoHandedMelee, increasedTotalTwoHandedMelee;
        public int decreasedFromGearTwoHandedMelee, decreasedFromTreeTwoHandedMelee, decreasedTotalTwoHandedMelee;
        public int additivePercentageTotalTwoHandedMelee;
        public int totalTwoHandedMelee;
        //One Handed Range
        public int moreFromGearOneHandedRange, moreFromTreeOneHandedRange, moreTotalOneHandedRange;
        public int lessFromGearOneHandedRange, lessFromTreeOneHandedRange, lessTotalOneHandedRange;
        public int flatTotalOneHandedRange;
        public int increasedFromGearOneHandedRange, increasedFromTreeOneHandedRange, increasedTotalOneHandedRange;
        public int decreasedFromGearOneHandedRange, decreasedFromTreeOneHandedRange, decreasedTotalOneHandedRange;
        public int additivePercentageTotalOneHandedRange;
        public int totalOneHandedRange;
        //Two Handed Range
        public int moreFromGearTwoHandedRange, moreFromTreeTwoHandedRange, moreTotalTwoHandedRange;
        public int lessFromGearTwoHandedRange, lessFromTreeTwoHandedRange, lessTotalTwoHandedRange;
        public int flatTotalTwoHandedRange;
        public int increasedFromGearTwoHandedRange, increasedFromTreeTwoHandedRange, increasedTotalTwoHandedRange;
        public int decreasedFromGearTwoHandedRange, decreasedFromTreeTwoHandedRange, decreasedTotalTwoHandedRange;
        public int additivePercentageTotalTwoHandedRange;
        public int totalTwoHandedRange;

        //Magic Damage

        //Cast Speed

        //Attack Speed

        //Knockback

        //Critical Chance

        //Damage Of Time

        //Area Of Effect

        //Stength Charges

        //Dexterity Charges

        //Intellagence Charges

        //Luck Charges

        //Enduance Charges

        //Willpower Charges

        #endregion

        #region Resistances
        //Magic Resistances

        //Magic Radiation Resistance
        public int increasedFromGearMagicRadiationResistance, increasedFromTreeMagicRadiationResistance, increasedTotalMagicRadiationResistance;
        public int decreasedFromGearMagicRadiationResistance, decreasedFromTreeMagicRadiationResistance, decreasedTotalMagicRadiationResistance;
        public int additivePercentageTotalMagicRadiationResistance;
        public int totalMagicRadiationResistance;
        //Magic Insanity Resistance
        public int increasedFromGearMagicInsanityResistance, increasedFromTreeMagicInsanityResistance, increasedTotalMagicInsanityResistance;
        public int decreasedFromGearMagicInsanityResistance, decreasedFromTreeMagicInsanityResistance, decreasedTotalMagicInsanityResistance;
        public int additivePercentageTotalMagicInsanityResistance;
        public int totalMagicInsanityResistance;
        //Magic Stiffness Resistance
        public int increasedFromGearMagicStiffnessResistance, increasedFromTreeMagicStiffnessResistance, increasedTotalMagicStiffnessResistance;
        public int decreasedFromGearMagicStiffnessResistance, decreasedFromTreeMagicStiffnessResistance, decreasedTotalMagicStiffnessResistance;
        public int additivePercentageTotalMagicStiffnessResistance;
        public int totalMagicStiffnessResistance;
        #endregion
    }
}
