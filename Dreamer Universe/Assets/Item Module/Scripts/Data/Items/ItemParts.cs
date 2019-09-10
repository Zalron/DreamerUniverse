using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{
    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Parts", order = 1)]
    public class ItemParts : MonoBehaviour
    {
        public string partName;
        public ItemTypes itemTypeForParts;
        public ItemStats itemModifing;
        public int partModifierMin;
        public int partModifierMax;
    }
}
