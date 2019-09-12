using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{
    [CreateAssetMenu(fileName = "ItemSO", menuName = "ItemSO/ItemSO Parts", order = 1)]
    public class ItemPartsSO : MonoBehaviour
    {
        public string partName;
        public ItemTypesSO itemTypeForParts;
        public ItemStatsSO itemModifing;
        public int partModifierMin;
        public int partModifierMax;
    }
}
