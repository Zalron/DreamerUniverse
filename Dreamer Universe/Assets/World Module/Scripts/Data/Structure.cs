﻿using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace WorldModule
{
    public static class Structure
    {
        public static Queue<BlockMod> GenerateMajorFlora (int index, Vector3 position, int minTrunkHeight, int maxTrunkHeight) {

            switch (index) {

                case 0:
                    return MakeTree(position, minTrunkHeight, maxTrunkHeight);

                case 1:
                    return MakeCacti(position, minTrunkHeight, maxTrunkHeight);

            }

            return new Queue<BlockMod>();

        }
        public static Queue<BlockMod> MakeTree(Vector3 position,  int minTrunkHeight, int maxTrunkHeight)
        {
            Queue<BlockMod> queue = new Queue<BlockMod>();
            int height = (int)(maxTrunkHeight * Terrian.TreeGeneration(new Vector2(position.x, position.z), 250f, 3f));
            if (height < minTrunkHeight)
            {
                height = minTrunkHeight;
            }
            for (int i = 1; i < height; i++)
            {
                queue.Enqueue(new BlockMod(new Vector3(position.x, position.y + i, position.z), 6));
            }
            for (int x = -2; x < 3; x++)
            {
                for (int y = 0; y < 5; y++)
                {
                    for (int z = -2; z < 3; z++)
                    {
                        queue.Enqueue(new BlockMod(new Vector3(position.x + x, position.y + height + y, position.z + z), 11));
                    }
                }
            }
            return queue;
        }
        public static Queue<BlockMod> MakeCacti (Vector3 position, int minTrunkHeight, int maxTrunkHeight) {

            Queue<BlockMod> queue = new Queue<BlockMod>();

            int height = (int)(maxTrunkHeight * Terrian.TreeGeneration(new Vector2(position.x, position.z), 23456f, 2f));

            if (height < minTrunkHeight)
                height = minTrunkHeight;

            for (int i = 1; i <= height; i++)
                queue.Enqueue(new BlockMod(new Vector3(position.x, position.y + i, position.z), 12));

            return queue;

        }
    }
}
