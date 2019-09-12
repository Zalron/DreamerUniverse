using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{
    [CreateAssetMenu(fileName = "ItemSO", menuName = "ItemSO/ItemSO Material", order = 1)]
    public class ItemMaterialSO : ScriptableObject
    {
        public string itemMaterialName;
        public int ItemMaterialModifierMin;
        public int ItemMaterialModifierMax;
    }
}
