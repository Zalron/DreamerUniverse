using System.Collections;
using System.Collections.Generic;
using System.Linq;
using UnityEngine;
namespace RPGLootGenerator
{
    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item", order = 1)]
    public class Item : ScriptableObject
    {
        #region Item Variables
        public ItemName itemName;
        public ItemTypes itemType;
        public string itemCombinedNameString;
        public ItemRarities itemRarity;
        public ItemRequirements itemRequirements;
        public ItemStats itemStat1;
        public ItemStats itemStat2;
        public ItemStats itemStat3;
        public ItemStats itemStat4;
        public ItemStats itemStat5;
        public ItemStats itemStat6;
        public ItemAffixs itemPrefixs1;
        public ItemAffixs itemPrefixs2;
        public ItemAffixs itemPrefixs3;
        public ItemAffixs itemSuffixs1;
        public ItemAffixs itemSuffixs2;
        public ItemAffixs itemSuffixs3;
        public ItemMod itemMod1;
        public ItemMod itemMod2;
        public ItemMod itemMod3;
        public ItemMod itemMod4;
        public ItemMod itemMod5;
        public ItemMod itemMod6;
        #endregion
        public Item ItemGenerator(Item i, ItemName[] itemNameDropTable, ItemAffixs[] itemPrefixDropTable, ItemAffixs[] itemSuffixDropTable, ItemStats[] itemStatDropTable, ItemRarities[] itemRarityDropTable, ItemRequirements[] itemRequirementsDropTable)
        {
            if (itemNameDropTable == null || itemPrefixDropTable == null || itemSuffixDropTable == null || itemStatDropTable == null || itemRarityDropTable == null || itemRequirementsDropTable == null)
            {
                Debug.Log("A table doesn't have anything in it");
            }
            int itemNameDropTableNumber = Random.Range(0,itemNameDropTable.Length);
            i.itemName = itemNameDropTable[itemNameDropTableNumber];
            i.itemType = i.itemName.itemType;
            int itemRequirementsDropTableNumber = Random.Range(0, itemRequirementsDropTable.Length);
            i.itemRequirements = itemRequirementsDropTable[itemRequirementsDropTableNumber];
            int itemRarityDropTableNumber = Random.Range(0,itemRarityDropTable.Length);
            i.itemRarity = itemRarityDropTable[itemRarityDropTableNumber];
            i = itemRarity.RarityAffixGenerator(i, itemPrefixDropTable, itemSuffixDropTable);
            i.itemStat1 = itemStatDropTable[0];
            i.itemStat2 = itemStatDropTable[1];
            i.itemStat3 = itemStatDropTable[2];
            i.itemStat4 = itemStatDropTable[3];
            i.itemStat5 = itemStatDropTable[4];
            i.itemStat6 = itemStatDropTable[5];
            i.itemStat1 = itemStat1.ItemModStatGenerator(i, i.itemStat1, i.itemMod1, i.itemMod2, i.itemMod3, i.itemMod4, i.itemMod5, i.itemMod6);
            i.itemStat2 = itemStat2.ItemModStatGenerator(i, i.itemStat2, i.itemMod1, i.itemMod2, i.itemMod3, i.itemMod4, i.itemMod5, i.itemMod6);
            i.itemStat3 = itemStat3.ItemModStatGenerator(i, i.itemStat3, i.itemMod1, i.itemMod2, i.itemMod3, i.itemMod4, i.itemMod5, i.itemMod6);
            i.itemStat4 = itemStat4.ItemModStatGenerator(i, i.itemStat4, i.itemMod1, i.itemMod2, i.itemMod3, i.itemMod4, i.itemMod5, i.itemMod6);
            i.itemStat5 = itemStat5.ItemModStatGenerator(i, i.itemStat5, i.itemMod1, i.itemMod2, i.itemMod3, i.itemMod4, i.itemMod5, i.itemMod6);
            i.itemStat6 = itemStat6.ItemModStatGenerator(i, i.itemStat6, i.itemMod1, i.itemMod2, i.itemMod3, i.itemMod4, i.itemMod5, i.itemMod6);
            if (i.itemPrefixs1 == null && i.itemSuffixs1 == null)
            {
                i.itemCombinedNameString = ConvertString.CombineNameString("", i.itemName.ItemNameString, "");
            }
            else if (i.itemSuffixs1 == null)
            {
                i.itemCombinedNameString = ConvertString.CombineNameString(i.itemPrefixs1.itemAffixString, i.itemName.ItemNameString, "");
            }
            else if (i.itemPrefixs1 == null)
            {
                i.itemCombinedNameString = ConvertString.CombineNameString("", i.itemName.ItemNameString, i.itemSuffixs1.itemAffixString);
            }
            else
            {
                i.itemCombinedNameString = ConvertString.CombineNameString(i.itemPrefixs1.itemAffixString, i.itemName.ItemNameString, i.itemSuffixs1.itemAffixString);
            }
            return i;
            
        }
       
        
    }
}
