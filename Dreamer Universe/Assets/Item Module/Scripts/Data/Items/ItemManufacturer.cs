using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{
    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Manufacturer", order = 1)]
    public class ItemManufacturer : ScriptableObject
    {
        public string manufacturerName;
        public List<ItemTypes> itemManufacturer = new List<ItemTypes>();
    }
}
