using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CharacterModule
{
    public enum SkillNodeType
    {
        NORMAL,
        SPECIAL,
    }
    public enum SkillModType
    {
        STRENGTH,
        ENDURANCE,
        DEXTERITY,
        LUCK,
        INTELLIGENCE,
        WILLPOWER
    }
    [CreateAssetMenu(fileName = "Skillnode", menuName = "Character/Skillnode", order = 1)]
    public class Skillnodes : ScriptableObject
    {
        public SkillNodeType skillnodeType;
        public SkillModType skilModType;
        public int add, minus;
        public int increased, decreased;
        public int more, less;
    }
}
