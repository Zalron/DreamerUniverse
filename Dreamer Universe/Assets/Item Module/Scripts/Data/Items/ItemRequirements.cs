using UnityEngine;
namespace ItemModule
{
    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Requirements", order = 1)]

    public class ItemRequirements: ScriptableObject
    {
        public string ItemLevelString;
        public int ItemLevel;
        public int ItemLevelModifier;
    }
}
