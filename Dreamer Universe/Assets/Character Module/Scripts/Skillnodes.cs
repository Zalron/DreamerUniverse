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
    [CreateAssetMenu(fileName = "Skillnode", menuName = "Character/Skillnode", order = 1)]
    public class Skillnodes : ScriptableObject
    {
        public Skillnodetype skillnodeType;
        public int lifeGained;
        public int energyGained;
        public int movementSpeedGained;
        public int magicGained;
        public int shieldGained;
        public int armourGained;

    }
}
