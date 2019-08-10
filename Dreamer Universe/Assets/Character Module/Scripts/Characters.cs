using System.Collections;
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
        //Stats
        public CharacterLevel characterLevel;
        public CharacterType characterType;
        public CharacterSpecialisation characterSpecialisation;

        public int skillpoints;
        public int spentSkillPoints;

        public int life;
        public int energy;
        public int movementSpeed;
        public int magic;
        public int shield;
        public int armour;

        //Stats Extra
        //Life
        public int baseFromGearLife;
        public int baseFromTreeLife;
        public int totalBaseLife;
        public float totalIncreasedLife;
        public int totalLife;
        public int reservedLife;
        public int unreservedLife;
        public float increasedLifeRegen;
        public int lifeRegen;
        //Magic
        public int baseFromGearMagic;
        public int baseFromTreeMagic;
        public int totalBaseMagic;
        public float totalIncreasedMagic;
        public int totalMagic;
        public int reservedMagic;
        public int unreservedMagic;
        public float increasedMagicRegen;
        public int magicRegen;
        //Shield
        public int baseFromGearShield;
        public int baseFromTreeShield;
        public int totalBaseShield;
        public float totalIncreasedShield;
        public int totalShield;
        public int rechargeRate;
        public float increasedRechargeRate;
        public int rechargeDelay;
        public float reducedRechargeDelay;
        public int shieldRegen;
        //Armour
        public int baseFromGearArmour;
        public int baseFromTreeArmour;
        public int totalBaseArmour;
        public float totalIncreasedArmour;
        public int totalArmour;

        //Resistances
        public int magicRadiaionResistances;
        public int magicInsanityResistances;
        public int magicStiffnessResistances;

        //Attributes
        public int strength;
        public int endurance;
        public int dexterity;
        public int luck;
        public int intelligence;
        public int willpower;

        //Attributes Extra
        public int strengthRequired;
        public int enduranceRequired;
        public int dexterityRequired;
        public int luckRequired;
        public int intelligenceRequired;
        public int willpowerRequired;
        public Characters(CharacterLevel _characterLevel, CharacterType _characterType)
        {
            characterType = _characterType;
            characterLevel = _characterLevel;
        }
    }
}
