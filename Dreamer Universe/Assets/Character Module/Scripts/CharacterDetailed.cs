using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CharacterModule
{
    public class CharacterDetailed
    {
        //Stats gain on level
        public const int lifeGainOnLevel = 6;
        public const int magicGainOnLevel = 6;
        public const int enegryGainOnLevel = 6;

        #region Attributes
        //Attributes
        //Strength
        public int flatFromGearStrength, flatFromTreeStrength, totalFlatStrength;
        public float increasedFromGearStrength, increasedFromTreeStrength, increasedTotalStrength;
        public float decreasedFromGearStrength, decreasedFromTreeStrength, decreasedTotalStrength;
        public float moreFromGearStrength, moreFromTreeStrength, moreTotalStrength;
        public float lessFromGearStrength, lessFromTreeStrength, lessTotalStrength;
        public int totalStrength;
        //Endurance
        public int flatFromGearEndurance, flatFromTreeEndurance, totalFlatEndurance;
        public float increasedFromGearEndurance, increasedFromTreeEndurance, increasedTotalEndurance;
        public float decreasedFromGearEndurance, decreasedFromTreeEndurance, decreasedTotalEndurance;
        public float moreFromGearEndurance, moreFromTreeEndurance, moreTotalEndurance;
        public float lessFromGearEndurance, lessFromTreeEndurance, lessTotalEndurance;
        public int totalEndurance;
        //Dexterity
        public int baseFromGearDexterity;
        public int baseFromTreeDexterity;
        public int totalBaseDexterity;
        public float increasedFromGearDexterity;
        public float increasedFromTreeDexterity;
        public float totalIncreasedDexterity;
        public int totalDexterity;
        //Luck
        public int baseFromGearLuck;
        public int baseFromTreeLuck;
        public int totalBaseLuck;
        public float increasedFromGearLuck;
        public float increasedFromTreeLuck;
        public float totalIncreasedLuck;
        public int totalLuck;
        //Intelligence
        public int baseFromGearIntelligence;
        public int baseFromTreeIntelligence;
        public int totalBaseIntelligence;
        public float increasedFromGearIntelligence;
        public float increasedFromTreeIntelligence;
        public float totalIncreasedIntelligence;
        public int totalIntelligence;
        //Willpower
        public int baseFromGearWillpower;
        public int baseFromTreeWillpower;
        public int totalBaseWillpower;
        public float increasedFromGearWillpower;
        public float increasedFromTreeWillpower;
        public float totalIncreasedWillpower;
        public int totalWillpower;
        #endregion

        #region Stats
        //Stats

        //Life
        public int baseFromGearLife;
        public int baseFromTreeLife;
        public int totalBaseLife;
        public float increasedFromGearLife;
        public float increasedFromTreeLife;
        public float totalIncreasedLife;
        public float totalLife;
        public int unreservedLife;
        public int reservedLife;
        //Life Regen
        public int baseLifeRegenFromGear;
        public int baseLifeRegenFromTree;
        public int totalBaseLifeRegen;
        public float increasedLifeRegenFromGear;
        public float increasedLifeRegenFromTree;
        public float totalIncreasedLifeRegen;
        public float totalLifeRegen;
        //Life Regen Delay
        public int baseLifeRegenDelayFromGear;
        public int baseLifeRegenDelayFromTree;
        public int totalBaseLifeRegenDelay;
        public float reducedLifeRegenDelayFromGear;
        public float reducedLifeRegenDelayFromTree;
        public float reducedLifeRegenDelay;
        public float totalLifeRegenDelay;
        //Life Leech
        public int baseLifeLeechFromGear;
        public int baseLifeLeechFromTree;
        public int totalBaseLifeLeech;
        public float increasedLifeLeechFromGear;
        public float increasedLifeLeechFromTree;
        public float totalIncreasedLifeLeech;
        public float totalLifeLeech;

        //Energy
        public int baseFromGearEnergy;
        public int baseFromTreeEnergy;
        public int totalBaseEnergy;
        public float increasedFromGearEnergy;
        public float increasedFromTreeEnergy;
        public float totalIncreasedEnergy;
        public float totalEnergy;
        public int unreservedEnergy;
        public int reservedEnergy;
        //Energy Recharge
        public int baseEnergyRechargeFromGear;
        public int baseEnergyRechargeFromTree;
        public int totalBaseEnergyRecharge;
        public float increasedEnergyRechargeFromGear;
        public float increasedEnergyRechargeFromTree;
        public float totalIncreasedEnergyRecharge;
        public float totalEnergyRecharge;
        //Energy Recharge Delay
        public int baseEnergyRechargeDelayFromGear;
        public int baseEnergyRechargeDelayFromTree;
        public int totalBaseEnergyRechargeDelay;
        public float reducedEnergyRechargeDelayFromGear;
        public float reducedEnergyRechargeDelayFromTree;
        public float totalReducedEnergyRechargeDelay;
        public float totalEnergyRechargeDelay;

        //Movement
        public int baseFromGearMovement;
        public int baseFromTreeMovement;
        public int totalBaseMovement;
        public float increasedFromGearMovement;
        public float increasedFromTreeMovement;
        public float totalIncreasedMovement;
        public float totalMovement;
        //Accuracy
        public int baseFromGearAccuracy;
        public int baseFromTreeAccuracy;
        public int totalBaseAccuracy;
        public float increasedFromGearAccuracy;
        public float increasedFromTreeAccuracy;
        public float totalIncreasedAccuracy;
        public float totalAccuracy;
        //Evasion
        public int baseFromGearEvasion;
        public int baseFromTreeEvasion;
        public int totalBaseEvasion;
        public float increasedFromGearEvasion;
        public float increasedFromTreeEvasion;
        public float totalIncreasedEvasion;
        public float totalEvasion;

        //Magic
        public int baseFromGearMagic;
        public int baseFromTreeMagic;
        public int totalBaseMagic;
        public float increasedFromGearMagic;
        public float increasedFromTreeMagic;
        public float totalIncreasedMagic;
        public float totalMagic;
        public int unreservedMagic;
        public int reservedMagic;
        //Magic Regen
        public int baseMagicRegenFromGear;
        public int baseMagicRegenFromTree;
        public int totalBaseMagicRegen;
        public float increasedMagicRegenFromGear;
        public float increasedMagicRegenFromTree;
        public float totalIncreasedMagicRegen;
        public float totalMagicRegen;
        //Magic Regen Delay
        public int baseMagicRegenDelayFromGear;
        public int baseMagicRegenDelayFromTree;
        public int totalBaseMagicRegenDelay;
        public float reducedMagicRegenDelayFromGear;
        public float reducedMagicRegenDelayFromTree;
        public float reducedMagicRegenDelay;
        public float totalMagicRegenDelay;
        //Magic Leech
        public int baseMagicLeechFromGear;
        public int baseMagicLeechFromTree;
        public int totalBaseMagicLeech;
        public float increasedMagicLeechFromGear;
        public float increasedMagicLeechFromTree;
        public float totalIncreasedMagicLeech;
        public float totalMagicLeech;

        //Shield
        public int baseFromGearShield;
        public int baseFromTreeShield;
        public int totalBaseShield;
        public float increasedFromGearShield;
        public float increasedFromTreeShield;
        public float totalIncreasedShield;
        public float totalShield;
        //Shield Recharge Rate
        public int shieldBaseRechargeRateFromGear;
        public int shieldBaseRechargeRateFromTree;
        public int totalBaseRechargeRate;
        public float increasedShieldRechargeRateFromGear;
        public float increasedShieldRechargeRateFromTree;
        public float totalShieldIncreasedRechargeDelay;
        public float totalShieldRechargeDelay;
        //Shield Recharge Delay
        public int shieldBaseRechargeDelayFromGear;
        public int shieldBaseRechargeDelayFromTree;
        public int totalBaseRechargeDelay;
        public float reducedShieldRechargeDelayFromGear;
        public float reducedShieldRechargeDelayFromTree;
        public float totalShieldReducedRechargeDelay;
        public float totalShieldRechargeRate;

        //Armour
        public int baseFromGearArmour;
        public int baseFromTreeArmour;
        public int totalBaseArmour;
        public float increasedFromGearArmour;
        public float increasedFromTreeArmour;
        public float totalIncreasedArmour;
        public float totalArmour;
        //Armour Recharge Rate
        public int armourBaseRechargeRateFromGear;
        public int armourBaseRechargeRateFromTree;
        public int totalArmourRechargeRate;
        public float increasedArmourRechargeRateFromGear;
        public float increasedArmourRechargeRateFromTree;
        public float totalIncreasedRechargeRate;
        public float totalRechargedRate;
        //Armour Recharge Delay
        public int armourBaseRechargeDelayFromGear;
        public int armourBaseRechargeDelayFromTree;
        public int totalArmourBaseRechargeDelay;
        public float reducedArmourRechargeDelayFromGear;
        public float reducedArmourRechargeDelayFromTree;
        public float totalReducedRechargeDelay;
        public float totalRechargedDelay;
        #endregion

        #region Resistances
        //Resistances

        //Radiation Resistance
        public int baseFromGearMagicRadiaionResistances;
        public int baseFromTreeMagicRadiaionResistances;
        public int totalBaseMagicRadiaionResistances;
        public float increasedFromGearMagicRadiaionResistances;
        public float increasedFromTreeMagicRadiaionResistances;
        public float totalIncreasedMagicRadiaionResistances;
        public float totalMagicRadiaionResistances;
        //Insanity Resistance
        public int baseFromGearMagicInsanityResistances;
        public int baseFromTreeMagicInsanityResistances;
        public int totalBaseMagicInsanityResistances;
        public float increasedFromGearMagicInsanityResistances;
        public float increasedFromTreeMagicInsanityResistances;
        public float totalIncreasedMagicInsanityResistances;
        public float totalMagicInsanityResistances;
        //Stiffness Resistance
        public int baseFromGearMagicStiffnessResistances;
        public int baseFromTreeMagicStiffnessResistances;
        public int totalBaseMagicStiffnessResistances;
        public float increasedFromGearMagicStiffnessResistances;
        public float increasedFromTreeMagicStiffnessResistances;
        public float totalIncreasedMagicStiffnessResistances;
        public float totalMagicStiffnessResistances;
        #endregion
    }
}
