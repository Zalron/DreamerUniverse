﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using UnityEngine.EventSystems;
using UnityEngine.UI;
namespace WorldModule
{
    public class DragAndDropHandler : MonoBehaviour
    {
        [SerializeField] private UIItemSlot cursorSlot = null;
        private ItemSlot cursorItemSlot;

        [SerializeField] private GraphicRaycaster m_Raycaster = null;
        private PointerEventData m_PointerEvenData;
        [SerializeField] private EventSystem m_EventSystem = null;

        World world;

        private void Start()
        {
            world = GameObject.Find("World").GetComponent<World>();
            cursorItemSlot = new ItemSlot(cursorSlot);
        }
        private void Update()
        {
            if (!world.inUI)
            {
                return;
            }
            cursorSlot.transform.position = Input.mousePosition;
            if (Input.GetButtonDown("Fire1"))
            {
                HandleSlotClick(CheckForSlot());
            }
        }
        private void HandleSlotClick(UIItemSlot clickedSlot)
        {
            if (clickedSlot == null)
            {
                return;
            }
            if (!cursorSlot.HasItem && !clickedSlot.HasItem)
            {
                return;
            }
            if (clickedSlot.itemSlot.isCreative)
            {
                cursorItemSlot.EmptySlot();
                cursorItemSlot.InsertStack(clickedSlot.itemSlot.stack);
            }
            if (!cursorSlot.HasItem && clickedSlot.HasItem)
            {
                cursorItemSlot.InsertStack(clickedSlot.itemSlot.TakeAll());
                return;
            }
            if (cursorSlot.HasItem && !clickedSlot.HasItem)
            {
                clickedSlot.itemSlot.InsertStack(cursorItemSlot.TakeAll());
                clickedSlot.UpdateSlot();
                return;
            }
            if (cursorSlot.HasItem && clickedSlot.HasItem)
            {
                if (cursorSlot.itemSlot.stack.id != clickedSlot.itemSlot.stack.id)
                {

                    ItemStack oldCursorSlot = cursorSlot.itemSlot.TakeAll();
                    ItemStack oldSlot = clickedSlot.itemSlot.TakeAll();

                    clickedSlot.itemSlot.InsertStack(oldCursorSlot);
                    cursorSlot.itemSlot.InsertStack(oldSlot);

                }
            }
        }
        private UIItemSlot CheckForSlot()
        {
            m_PointerEvenData = new PointerEventData(m_EventSystem);
            m_PointerEvenData.position = Input.mousePosition;

            List<RaycastResult> results = new List<RaycastResult>();
            m_Raycaster.Raycast(m_PointerEvenData, results);

            foreach (RaycastResult result in results)
            {
                if (result.gameObject.tag == "UIItemSlot")
                {
                    return result.gameObject.GetComponent<UIItemSlot>();
                }
            }
            return null;
        }
    }
}
