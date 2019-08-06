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
    }
    public class Characters
    {
        //Stats
        public CharacterLevel characterLevel;
        public CharacterType characterType;
        public CharacterSpecialisation characterSpecialisation;
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
        public int magicResistances;

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
    }
}
