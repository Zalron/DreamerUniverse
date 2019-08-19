using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CharacterModule
{
    public enum Skillnodetype
    {
        Normal,
        Special,
    }
    public enum SkillModType
    {
        STRENGTHADD
    }
    [CreateAssetMenu(fileName = "Skillnode", menuName = "Character/Skillnode", order = 1)]
    public class Skillnodes : ScriptableObject
    {
        public int add, minus;
        public int increased, decreased;
        public int more, less;
        public Skillnodetype skillnodeType;
        //Stats
        //Life
        public int addLife, minusLife;
        public int increasedLife, decreasedLife;
        public int moreLife, lessLife;
        public int addLifeRegenRate, minusLifeRegenRate;
        public int increasedLifeRegenRate, decreasedLifeRegenRate;
        public int moreLifeRegenRate, lessLifeRegenRate;
        public int addLifeRegenDelay, minusLifeRegenDelay;
        public int increasedLifeRegenDelay, decreasedLifeRegenDelay;
        public int moreLifeRegenDelay, lessLifeRegenDelay;

        //Attributes
        public int strength;
        public int endurance;
        public int dexterity;
        public int luck;
        public int intelligence;
        public int willpower;
    }
}
