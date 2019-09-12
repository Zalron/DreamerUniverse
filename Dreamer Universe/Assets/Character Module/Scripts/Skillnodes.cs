using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemSubModule;
namespace CharacterModule
{
    public enum SkillNodeType
    {
        NORMAL,
        SPECIAL,
    }
    [CreateAssetMenu(fileName = "Skillnode", menuName = "Character/Skillnode", order = 1)]
    public class Skillnodes : ScriptableObject
    {
        public SkillNodeType skillnodeType;
        public List<ItemModSO> skillnodeMods;

    }
}
