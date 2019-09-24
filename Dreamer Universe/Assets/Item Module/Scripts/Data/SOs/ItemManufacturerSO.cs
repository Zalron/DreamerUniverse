using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{
    enum ItemManufacturerType
    {

    }
    [CreateAssetMenu(fileName = "ItemSO", menuName = "ItemSO/ItemSO Manufacturer", order = 1)]
    public class ItemManufacturerSO : ScriptableObject
    {
        public string manufacturerName;
        public List<ItemNameSO> itemNames = new List<ItemNameSO>();
    }
}
