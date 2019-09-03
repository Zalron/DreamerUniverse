using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WorldModule;
using Sirenix.Serialization;
using UnityEngine.Serialization;
public class CreativeInventory : MonoBehaviour
{
    public GameObject slotPrefab;
    World world;
    [System.NonSerialized, OdinSerialize] public List<ItemSlot> slots = new List<ItemSlot>();
    // Start is called before the first frame update
    private void Start()
    {
        // if(this.gameObject.activeSelf == true)
        // {
        //     this.gameObject.SetActive(false);
        // }
        world = GameObject.Find("World").GetComponent<World>();
        for (int i = 1; i <= 100; i++)
        {
            GameObject newSlot = Instantiate(slotPrefab, transform);
            if(i < world.blockType.Length)
            {
                ItemStack stack = new ItemStack((byte)i, 1024);
                ItemSlot slot = new ItemSlot(newSlot.GetComponent<UIItemSlot>(), stack);
                slot.isCreative = true;
                slots.Add(slot);
            }
            if(i > world.blockType.Length)
            {
                ItemSlot slot = new ItemSlot(newSlot.GetComponent<UIItemSlot>(), null);
                slot.isCreative = true;
                slots.Add(slot);
            }
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
