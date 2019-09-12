using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{
   
    [CreateAssetMenu(fileName = "ItemSO", menuName = "ItemSO/ItemSO Name", order = 1)]
    public class ItemNameSO : ScriptableObject
    {
        public string ItemNameString;
        public ItemStatsSO itemStatModified;
        public int itemNameIntModifierMin;
        public int itemNameIntModifierMax;
        public ItemTypesSO itemType;
    }
}
