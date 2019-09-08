using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{

    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Stats", order = 1)]
    public class ItemStats : ScriptableObject
    {
        public string itemStatString;
        public int itemStatInt;
        public string itemStatOnItemString;
        public bool isPercentage;
    }
}
