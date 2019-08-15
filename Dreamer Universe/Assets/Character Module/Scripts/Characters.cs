using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemModule;
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
        public int LifeRegen;
        public int LifeRegenDelay;
        public int LifeLeech;
        public int Energy;
        public int Magic;
        public int MagicRegen;
        public int MagicRegenDelay;
        public int MagicLeech;
        public int Armour;
        public int ArmourRegen;
        public int ArmourRegenDelay;
        public int Movement;
        public int Accuracy;
        public int Shields;

        //Resistances
        public int Radiation;
        public int Insanity;
        public int Stiffness;

        //Gear
        public Item Weapon1;
        public Item Weapon2;
        public Item Head;
        public Item Chest;
        public Item Arms;
        public Item Belt;
        public Item Legs;
        public Item Hands;
        public Item Shoulders;
        public Item Backpack;
        public Item Ring1;
        public Item Ring2;
        public Item Necklace;
        public Item Equipment1;
        public Item Equipment2;
        public Item Equipment3;
        public Item Equipment4;
        public Item Equipment5;
        public Item Equipment6;

        public Characters(string _name, CharacterLevel _characterLevel, CharacterType _characterType)
        {
            name = _name;
            characterType = _characterType;
            characterLevel = _characterLevel;
        }
    }
}
