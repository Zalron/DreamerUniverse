﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace WorldModule
{
    public class ItemStack
    {
        public byte id;
        public int amount;
        public ItemStack(byte _id, int _amount)
        {
            id = _id;
            amount = _amount;
        }
    }
}
