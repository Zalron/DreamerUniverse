﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CharacterModule
{
    public enum CharacterSpecialisation
    {
        COMMANDER,
		SORCERER,
		GUARDIAN,
		ENGINEER,
		HONOUR_GUARD,
		VETERAN,
		CHAMPION,
		CLERIC,
		ACE,
		ADMIRAL,
		SIGNALLER,
		LOGICIAN,
		SENSOR,
		STANDARD_BEARER,
		OBSERVER,
		SMITH,
		DESTORYER,
		SAPPER,
		MARKSMAN,
		RIFLEMAN,
    }
    public enum CharacterType
    {
        Magical,
        Secular,
    }
    public enum CharacterLevel
    {
        Level_1,
        Level_2,
        Level_3,
        Level_4,
        Level_5,
        Level_6,
        Level_7,
        Level_8,
        Level_9,
        Level_10,
        Level_11,
        Level_12,
        Level_13,
        Level_14,
        Level_15,
        Level_16,
        Level_17,
        Level_18,
        Level_19,
        Level_20,
        Level_21,
        Level_22,
        Level_23,
        Level_24,
        Level_25,
        Level_26,
        Level_27,
        Level_28,
        Level_29,
        Level_30,
        Level_31,
        Level_32,
        Level_33,
        Level_34,
        Level_35,
        Level_36,
        Level_37,
        Level_38,
        Level_39,
        Level_40,
        Level_41,
        Level_42,
        Level_43,
        Level_44,
        Level_45,
        Level_46,
        Level_47,
        Level_48,
        Level_49,
        Level_50,
        Level_51,
        Level_52,
        Level_53,
        Level_54,
        Level_55,
        Level_56,
        Level_57,
        Level_58,
        Level_59,
        Level_60,
        Level_61,
        Level_62,
        Level_63,
        Level_64,
        Level_65,
        Level_66,
        Level_67,
        Level_68,
        Level_69,
        Level_70,
        Level_71,
        Level_72,
        Level_73,
        Level_74,
        Level_75,
        Level_76,
        Level_77,
        Level_78,
        Level_79,
        Level_80,
        Level_81,
        Level_82,
        Level_83,
        Level_84,
        Level_85,
        Level_86,
        Level_87,
        Level_88,
        Level_89,
        Level_90,
        Level_91,
        Level_92,
        Level_93,
        Level_94,
        Level_95,
        Level_96,
        Level_97,
        Level_98,
        Level_99,
        Level_100,
    }
    public class Characters
    {
        //Character Type and general
        public string name;
        public CharacterLevel characterLevel;
        public CharacterType characterType;
        public CharacterSpecialisation characterSpecialisation;

        //Skillpoint
        public int skillpoints;
        public int spentSkillPoints;

        //Attributes
        public int Strength;
        public int Dexterity;
        public int Intelligence;
        public int Luck;
        public int Enduance;
        public int Willpower;

        //Stats
        public int Life;
        public int Energy;
        public int Magic;
        public int Armour;
        public int Movement;
        public int Accuracy;
        public int Shields;

        //Stats gain on level
        public const int lifeGainOnLevel = 6;
        public const int magicGainOnLevel = 6;
        public const int enegryGainOnLevel = 6;

        //Resistances
        public int Radiation;
        public int Insanity;
        public int Stiffness;

        

        public Characters(string _name, CharacterLevel _characterLevel, CharacterType _characterType)
        {
            name = _name;
            characterType = _characterType;
            characterLevel = _characterLevel;
        }

        //

        //Stats gain on attributes

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
        public int baseFromGearEndurance;
        public int baseFromTreeEndurance;
        public int totalBaseEndurance;
        public float increasedFromGearEndurance;
        public float increasedFromTreeEndurance;
        public float totalIncreasedEndurance;
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

        

    }
}
