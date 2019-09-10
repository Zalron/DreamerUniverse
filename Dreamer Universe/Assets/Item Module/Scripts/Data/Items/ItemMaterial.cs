using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace ItemSubModule
{
    [CreateAssetMenu(fileName = "Item", menuName = "Item/Item Material", order = 1)]
    public class ItemMaterial : ScriptableObject
    {
        public string itemMaterialName;
        public int ItemMaterialModifierMin;
        public int ItemMaterialModifierMax;
    }
}
