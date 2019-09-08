using UnityEngine;
namespace PlayerModule { }
namespace ItemSubModule
{
    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Requirements", order = 1)]

    public class ItemLevel: ScriptableObject
    {
        public string ItemLevelString;
        public int ItemLevelint;
        public int ItemLevelIntModifierMin;
        public int ItemLevelIntModifierMax;
    }
}
