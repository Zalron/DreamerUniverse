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
        public List<ItemPartsSO> itemParts1 = new List<ItemPartsSO>();
        public List<ItemPartsSO> itemParts2 = new List<ItemPartsSO>();
        public List<ItemPartsSO> itemParts3 = new List<ItemPartsSO>();
        public List<ItemPartsSO> itemParts4 = new List<ItemPartsSO>();
        public List<ItemPartsSO> itemParts5 = new List<ItemPartsSO>();
        public List<ItemPartsSO> itemParts6 = new List<ItemPartsSO>();
        public List<ItemPartsSO> itemParts7 = new List<ItemPartsSO>();
        public List<ItemPartsSO> itemParts8 = new List<ItemPartsSO>();
        public List<ItemPartsSO> itemParts9 = new List<ItemPartsSO>();
        public List<ItemPartsSO> itemParts10 = new List<ItemPartsSO>();
    }
}
