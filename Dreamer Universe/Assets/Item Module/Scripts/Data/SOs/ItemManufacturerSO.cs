using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{
    [CreateAssetMenu(fileName = "ItemSO", menuName = "ItemSO/ItemSO Manufacturer", order = 1)]
    public class ItemManufacturerSO : ScriptableObject
    {
        public string manufacturerName;
        public List<ItemTypesSO> itemManufacturer = new List<ItemTypesSO>();
    }
}
