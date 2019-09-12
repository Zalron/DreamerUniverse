using UnityEngine;
namespace PlayerModule { }
namespace ItemSubModule
{
    [CreateAssetMenu(fileName = "ItemSO", menuName = "ItemSO/ItemSO Requirements", order = 1)]

    public class ItemLevelSO: ScriptableObject
    {
        public string ItemLevelString;
        public int ItemLevelint;
        public int ItemLevelIntModifierMin;
        public int ItemLevelIntModifierMax;
    }
}
