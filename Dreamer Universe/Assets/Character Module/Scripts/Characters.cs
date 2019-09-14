using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemSubModule;
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
        Level_1, Level_2, Level_3, Level_4, Level_5, Level_6, Level_7, Level_8, Level_9,
        Level_10, Level_11, Level_12, Level_13, Level_14, Level_15, Level_16, Level_17, Level_18, Level_19,
        Level_20, Level_21, Level_22, Level_23, Level_24, Level_25, Level_26, Level_27, Level_28, Level_29,
        Level_30, Level_31, Level_32, Level_33, Level_34, Level_35, Level_36, Level_37, Level_38, Level_39,
        Level_40, Level_41, Level_42, Level_43, Level_44, Level_45, Level_46, Level_47, Level_48, Level_49,
        Level_50, Level_51, Level_52, Level_53, Level_54, Level_55, Level_56, Level_57, Level_58, Level_59,
        Level_60, Level_61, Level_62, Level_63, Level_64, Level_65, Level_66, Level_67, Level_68, Level_69,
        Level_70, Level_71, Level_72, Level_73, Level_74, Level_75, Level_76, Level_77, Level_78, Level_79,
        Level_80, Level_81, Level_82, Level_83, Level_84, Level_85, Level_86, Level_87, Level_88, Level_89,
        Level_90, Level_91, Level_92, Level_93, Level_94, Level_95, Level_96, Level_97, Level_98, Level_99,
        Level_100,
    }
    public class Characters
    {
        //Character Type and general
        public string name;
        public CharacterLevel characterLevel;
        public CharacterType characterType;
        public CharacterSpecialisation characterSpecialisation;

        //Stats gain on level
        public const int lifeGainOnLevel = 6;
        public const int magicGainOnLevel = 6;
        public const int enegryGainOnLevel = 6;

        //Stats gain on every ten Attribute
        public const int lifeGainForTenStrength = 5;
        public const int evasionGainForTenDexterity = 5;
        public const int magicGainForTenIntelligence = 5;
        public const int energyGainForTenEnduance = 5;
        //Skillpoint
        public int skillpoints;
        public int spentSkillPoints;

        //Attributes
        public CharacterNumbers Strength;
        public CharacterNumbers Dexterity;
        public CharacterNumbers Intelligence;
        public CharacterNumbers Luck;
        public CharacterNumbers Endurance;
        public CharacterNumbers Willpower;

        //Stats
        public CharacterNumbers Life;
        public CharacterNumbers LifeRegen;
        public CharacterNumbers LifeRegenDelay;
        public CharacterNumbers LifeLeech;
        public CharacterNumbers UnreservedLife;
        public CharacterNumbers ReservedLife;
        public CharacterNumbers Energy;
        public CharacterNumbers EnergyRechange;
        public CharacterNumbers EnergyRechangeDelay;
        public CharacterNumbers UnreservedEnergy;
        public CharacterNumbers ReservedEnergy;
        public CharacterNumbers Movement;
        public CharacterNumbers Accuracy;
        public CharacterNumbers Shields;
        public CharacterNumbers Magic;
        public CharacterNumbers MagicRegen;
        public CharacterNumbers MagicRegenDelay;
        public CharacterNumbers MagicLeech;
        public CharacterNumbers UnreservedMagic;
        public CharacterNumbers ReservedMagic;
        public CharacterNumbers Shield;
        public CharacterNumbers ShieldRecharge;
        public CharacterNumbers ShieldRechargeDelay;
        public CharacterNumbers Armour;
        public CharacterNumbers ArmourRegen;
        public CharacterNumbers ArmourRegenDelay;

        //Resistances
        public CharacterNumbers Radiation;
        public CharacterNumbers Insanity;
        public CharacterNumbers Stiffness;

        //Gear
        public ItemSO Weapon1;
        public ItemSO Weapon2;
        public ItemSO Weapon3;
        public ItemSO Weapon4;
        public ItemSO Head;
        public ItemSO Chest;
        public ItemSO Arms;
        public ItemSO Belt;
        public ItemSO Legs;
        public ItemSO Hands;
        public ItemSO Shoulders;
        public ItemSO Backpack;
        public ItemSO Ring1;
        public ItemSO Ring2;
        public ItemSO Necklace;
        public ItemSO Equipment1;
        public ItemSO Equipment2;
        public ItemSO Equipment3;
        public ItemSO Equipment4;
        public ItemSO Equipment5;
        public ItemSO Equipment6;

        // Inventory
        public void TotalCharacterInit()
        {
            Strength = new CharacterNumbers(null, null, null, null, 0, 0, 0, 0, 0, 0, 0, null, null, null, null, 0, 0, 0, 0, 0, 0, 0, null, null, null, null, 0);
            Dexterity = new CharacterNumbers(null, null, null, null, 0, 0, 0, 0, 0, 0, 0, null, null, null, null, 0, 0, 0, 0, 0, 0, 0, null, null, null, null, 0);
            Intelligence = new CharacterNumbers(null, null, null, null, 0, 0, 0, 0, 0, 0, 0, null, null, null, null, 0, 0, 0, 0, 0, 0, 0, null, null, null, null, 0);
            Luck = new CharacterNumbers(null, null, null, null, 0, 0, 0, 0, 0, 0, 0, null, null, null, null, 0, 0, 0, 0, 0, 0, 0, null, null, null, null, 0);
            Endurance = new CharacterNumbers(null, null, null, null, 0, 0, 0, 0, 0, 0, 0, null, null, null, null, 0, 0, 0, 0, 0, 0, 0, null, null, null, null, 0);
            Willpower = new CharacterNumbers(null, null, null, null, 0, 0, 0, 0, 0, 0, 0, null, null, null, null, 0, 0, 0, 0, 0, 0, 0, null, null, null, null, 0);

            Life = new CharacterNumbers(null, null, null, null, 0, 0, 0, 0, 0, 0, 0, null, null, null, null, 0, 0, 0, 0, 0, 0, 0, null, null, null, null, 0);
            LifeRegen = new CharacterNumbers(null, null, null, null, 0, 0, 0, 0, 0, 0, 0, null, null, null, null, 0, 0, 0, 0, 0, 0, 0, null, null, null, null, 0);
        }
        public void TotalCharacterCalculation()
        {
            
            Strength = CharacterCalculations.AttributeStatCalculation(Strength);
            Endurance = CharacterCalculations.AttributeStatCalculation(Endurance);
        }

        public Characters(string _name, CharacterLevel _characterLevel, CharacterType _characterType)
        {
            name = _name;
            characterType = _characterType;
            characterLevel = _characterLevel;
        }
    }
}
