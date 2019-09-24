using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{

    [CreateAssetMenu(fileName = "ItemSO", menuName = "ItemSO/ItemSO Parts", order = 1)]
    public class ItemPartsSO : ScriptableObject
    {
        public string partName;
        public ItemStatsSO itemStatModifing;
        public int partModifierMin;
        public int partModifierMax;
    }
}
