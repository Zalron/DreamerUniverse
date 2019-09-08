using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{
   
    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Name", order = 1)]
    public class ItemName : ScriptableObject
    {
        public string ItemNameString;
        public ItemStats itemStatModified;
        public int itemNameIntModifierMin;
        public int itemNameIntModifierMax;
        public ItemTypes itemType;
    }
}
