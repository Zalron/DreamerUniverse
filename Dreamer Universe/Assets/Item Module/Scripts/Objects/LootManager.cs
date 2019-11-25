using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using TMPro;
namespace ItemSubModule
{
    public class LootManager : MonoBehaviour
    {
        public TextMeshProUGUI LootNames;
        public TextMeshProUGUI LootRarity;
        public TextMeshProUGUI LootTypes;
        public TextMeshProUGUI LootRequirements;
        public TextMeshProUGUI LootQuality;
        public TextMeshProUGUI LootMaterial;
        public TextMeshProUGUI LootManufacturer;
        public TextMeshProUGUI LootStats1;
        public TextMeshProUGUI LootStats2;
        public TextMeshProUGUI LootStats3;
        public TextMeshProUGUI LootStats4;
        public TextMeshProUGUI LootStats5;
        public TextMeshProUGUI LootStats6;
        public TextMeshProUGUI LootStats7;
        public TextMeshProUGUI LootStats8;
        public TextMeshProUGUI LootStats9;
        public TextMeshProUGUI LootStats10;
        public TextMeshProUGUI LootMods1;
        public TextMeshProUGUI LootMods2;
        public TextMeshProUGUI LootMods3;
        public TextMeshProUGUI LootMods4;
        public TextMeshProUGUI LootMods5;
        public TextMeshProUGUI LootMods6;
        public TextMeshProUGUI LootMods7;
        public TextMeshProUGUI LootMods8;
        public TextMeshProUGUI LootMods9;
        public TextMeshProUGUI LootMods10;
        public TextMeshProUGUI LootParts1;
        public TextMeshProUGUI LootParts2;
        public TextMeshProUGUI LootParts3;
        public TextMeshProUGUI LootParts4;
        public TextMeshProUGUI LootParts5;
        public TextMeshProUGUI LootParts6;
        public TextMeshProUGUI LootParts7;
        public TextMeshProUGUI LootParts8;
        public TextMeshProUGUI LootParts9;
        public TextMeshProUGUI LootParts10;

        public ItemLevelSO[] itemRequirementsDropTable;
        public ItemRaritiesSO[] itemRarityDropTable;
        public ItemNameSO[] itemNameDropTable;
        public ItemAffixsSO[] itemPrefixDropTable;
        public ItemAffixsSO[] itemSuffixDropTable;
        public ItemStatsSO[] itemStatDropTable;

        public List<Item> items = new List<Item>();
        public ItemSO item;
        void Start() // Start is called before the first frame update
        {

        }
        void Update() // Update is called once per frame
        {

        }
        public void GenerateRawLoot()
        {
            ItemSO i = ScriptableObject.CreateInstance<ItemSO>();
            i = ItemCalculations.ItemGenerator(i, itemNameDropTable, itemPrefixDropTable, itemSuffixDropTable, itemStatDropTable, itemRarityDropTable, itemRequirementsDropTable);
            LootNames.text = i.itemName.ItemNameString;
            //Item Ni = new Item();
        }
    }
}
