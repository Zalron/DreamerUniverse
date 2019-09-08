using System.Collections;
using System.Collections.Generic;
using System.Text;
using UnityEngine;
namespace ItemSubModule
{
    public static class ConvertString
    {
        public static string ItemStatStringGenerator(int ItemStatInt, string ItemStatString)
        {
            string ItenStatStringComplete = ItemStatInt + " " +  ItemStatString;
            return ItenStatStringComplete;
        }
        public static string ItemModStringGenerator(int ItemModInt, string ItemModString)
        {
            string ItenModStringComplete = ItemModInt + " " + ItemModString;
            return ItenModStringComplete;
        }
        public static string CombineNameString(string itemPrefix, string itemName, string itemSuffix)
        {
            string itemCombinedName = itemPrefix + " " + itemName + " " + itemSuffix;
            return itemCombinedName;
        }
    }
}
