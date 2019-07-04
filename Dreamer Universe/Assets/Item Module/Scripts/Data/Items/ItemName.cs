using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemModule
{
   
    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Name", order = 1)]
    public class ItemName : ScriptableObject
    {
        public string ItemNameString;
        public int itemNameIntModifier;
        public ItemTypes itemType;
    }
}
