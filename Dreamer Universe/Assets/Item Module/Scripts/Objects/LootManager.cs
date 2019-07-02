using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace RPGLootGenerator
{
    public class LootManager : MonoBehaviour
    {
        public TextMeshProUGUI LootNames;
        public TextMeshProUGUI LootRarity;
        public TextMeshProUGUI LootTypes;
        public TextMeshProUGUI LootRequirements;
        public TextMeshProUGUI LootStats1;
        public TextMeshProUGUI LootStats2;
        public TextMeshProUGUI LootStats3;
        public TextMeshProUGUI LootStats4;
        public TextMeshProUGUI LootStats5;
        public TextMeshProUGUI LootStats6;
        public TextMeshProUGUI LootMods1;
        public TextMeshProUGUI LootMods2;
        public TextMeshProUGUI LootMods3;
        public TextMeshProUGUI LootMods4;
        public TextMeshProUGUI LootMods5;
        public TextMeshProUGUI LootMods6;

        public ItemRequirements[] itemRequirementsDropTable;
        public ItemRarities[] itemRarityDropTable;
        public ItemName[] itemNameDropTable;
        public ItemAffixs[] itemPrefixDropTable;
        public ItemAffixs[] itemSuffixDropTable;
        public ItemStats[] itemStatDropTable;

        public List<Item> items = new List<Item>();
        public Item item;
        void Start() // Start is called before the first frame update
        {

        }
        void Update() // Update is called once per frame
        {

        }
        public void GenerateRawLoot()
        {
            Item i = ScriptableObject.CreateInstance<Item>();
            i = i.ItemGenerator(i,itemNameDropTable, itemPrefixDropTable, itemSuffixDropTable, itemStatDropTable, itemRarityDropTable, itemRequirementsDropTable);
            LootNames.text = i.itemCombinedNameString;
            LootRarity.text = i.itemRarity.rarityName;
            LootTypes.text = i.itemType.ItemTypeName;
            LootRequirements.text = i.itemRequirements.ItemLevelString;
            LootStats1.text = i.itemStat1.itemStatOnItemString;
            LootStats2.text = i.itemStat2.itemStatOnItemString;
            LootStats3.text = i.itemStat3.itemStatOnItemString;
            LootStats4.text = i.itemStat4.itemStatOnItemString;
            LootStats5.text = i.itemStat5.itemStatOnItemString;
            LootStats6.text = i.itemStat6.itemStatOnItemString;
            if (i.itemMod1 == null && i.itemMod2 == null && i.itemMod3 == null && i.itemMod4 == null && i.itemMod5 == null && i.itemMod6 == null)
            {
                LootMods1.text = "";
                LootMods2.text = "";
                LootMods3.text = "";
                LootMods4.text = "";
                LootMods5.text = "";
                LootMods6.text = "";
            }
            else if (i.itemMod2 == null && i.itemMod3 == null && i.itemMod4 == null && i.itemMod5 == null && i.itemMod6 == null)
            {
                LootMods1.text = i.itemMod1.itemModOnItemString;
                LootMods2.text = "";
                LootMods3.text = "";
                LootMods4.text = "";
                LootMods5.text = "";
                LootMods6.text = "";
            }
            else if (i.itemMod3 == null && i.itemMod4 == null && i.itemMod5 == null && i.itemMod6 == null)
            {
                LootMods1.text = i.itemMod1.itemModOnItemString;
                LootMods2.text = i.itemMod2.itemModOnItemString;
                LootMods3.text = "";
                LootMods4.text = "";
                LootMods5.text = "";
                LootMods6.text = "";
            }
            else if (i.itemMod4 == null && i.itemMod5 == null && i.itemMod6 == null)
            {
                LootMods1.text = i.itemMod1.itemModOnItemString;
                LootMods2.text = i.itemMod2.itemModOnItemString;
                LootMods3.text = i.itemMod3.itemModOnItemString;
                LootMods4.text = "";
                LootMods5.text = "";
                LootMods6.text = "";
            }
            else if (i.itemMod5 == null || i.itemMod6 == null)
            {
                LootMods1.text = i.itemMod1.itemModOnItemString;
                LootMods2.text = i.itemMod2.itemModOnItemString;
                LootMods3.text = i.itemMod3.itemModOnItemString;
                LootMods4.text = i.itemMod4.itemModOnItemString;
                LootMods5.text = "";
                LootMods6.text = "";
            }
            else if (i.itemMod6 == null)
            {
                LootMods1.text = i.itemMod1.itemModOnItemString;
                LootMods2.text = i.itemMod2.itemModOnItemString;
                LootMods3.text = i.itemMod3.itemModOnItemString;
                LootMods4.text = i.itemMod4.itemModOnItemString;
                LootMods5.text = i.itemMod5.itemModOnItemString;
                LootMods6.text = "";
            }
            else
            {
                LootMods1.text = i.itemMod1.itemModOnItemString;
                LootMods2.text = i.itemMod2.itemModOnItemString;
                LootMods3.text = i.itemMod3.itemModOnItemString;
                LootMods4.text = i.itemMod4.itemModOnItemString;
                LootMods5.text = i.itemMod5.itemModOnItemString;
                LootMods6.text = i.itemMod6.itemModOnItemString;
            }
            items.Add(i);

        }
    }
}
