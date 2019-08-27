using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using WorldModule;
public class CreativeInventory : MonoBehaviour
{
    public GameObject slotPrefab;
    World world;
    List<ItemSlot> slots = new List<ItemSlot>();
    // Start is called before the first frame update
    private void Start()
    {
        world = GameObject.Find("World").GetComponent<World>();
        for (int i = 1; i < world.blockType.Length; i++)
        {
            GameObject newSlot = Instantiate(slotPrefab,transform);
            ItemStack stack = new ItemStack((byte)i, 1024);
            ItemSlot slot = new ItemSlot(newSlot.GetComponent<UIItemSlot>(), stack);
            slot.isCreative = true;
        }
        for (int i = world.blockType.Length; i <= 100; i++)
        {
            GameObject newSlot = Instantiate(slotPrefab, transform);
            ItemSlot slot = new ItemSlot(newSlot.GetComponent<UIItemSlot>(), null);
            slot.isCreative = true;
        }
    }

    // Update is called once per frame
    void Update()
    {
        
    }
}
