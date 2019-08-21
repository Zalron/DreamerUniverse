using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using ItemModule;
namespace CharacterModule
{
    static public class CharacterCalculations
    {
        static public int AttributeStatASIDCalculator(int numFromGear, int numFromTree)
        {
            int numTotal = 0;
            numTotal += numFromGear;
            numTotal += numFromTree;
            return numTotal;
        }
        static public int AttributeStatASIDTotalCalculator(int numPlusTotal, int numMinusTotal)
        {
            int numTotal = 0;
            numTotal += numPlusTotal;
            numTotal -= numMinusTotal;
            return numTotal;
        }
        static public int AttributeStatMLCalculator(int numTotal,
                                                    List<ItemMod> moreFromGear, List<Skillnodes> moreFromTree,
                                                    List<ItemMod> lessFromGear, List<Skillnodes> lessFromTree)
        {
            if (lessFromGear == null && moreFromTree == null && lessFromTree == null)
            {
                for (int i = 0; i < moreFromGear.Count; i++)
                {
                    float multiplicativePercentage = moreFromGear[i].itemModIntModifier / 100 + 1;
                    float numTotalf = 0;
                    numTotalf *= multiplicativePercentage;
                    Mathf.Round(numTotalf);
                    numTotal = (int)numTotalf;

                }
                return numTotal;
            }
            if (moreFromGear == null && moreFromTree == null && lessFromTree == null)
            {
                for (int i = 0; i < lessFromGear.Count; i++)
                {
                    float multiplicativePercentage = moreFromGear[i].itemModIntModifier / 100 - 1;
                    float numTotalf = 0;
                    numTotalf *= multiplicativePercentage;
                    Mathf.Round(numTotalf);
                    numTotal = (int)numTotalf;
                }
                return numTotal;
            }
            if (moreFromGear == null && lessFromGear == null && lessFromTree == null)
            {
                for (int i = 0; i < moreFromTree.Count; i++)
                {
                    float multiplicativePercentage = moreFromGear[i].itemModIntModifier / 100 + 1;
                    float numTotalf = 0;
                    numTotalf *= multiplicativePercentage;
                    Mathf.Round(numTotalf);
                    numTotal = (int)numTotalf;
                }
                return numTotal;
            }
            if (moreFromGear == null && lessFromGear == null && moreFromTree == null)
            {
                for (int i = 0; i < lessFromTree.Count; i++)
                {
                    float multiplicativePercentage = moreFromGear[i].itemModIntModifier / 100 - 1;
                    float numTotalf = 0;
                    numTotalf *= multiplicativePercentage;
                    Mathf.Round(numTotalf);
                    numTotal = (int)numTotalf;
                }
                return numTotal;
            }
            else if (moreFromTree == null && lessFromTree == null)
            {
                for (int i = 0; i < moreFromGear.Count; i++)
                {
                    float multiplicativePercentage = moreFromGear[i].itemModIntModifier / 100 + 1;
                    float numTotalf = 0;
                    numTotalf *= multiplicativePercentage;
                    Mathf.Round(numTotalf);
                    numTotal = (int)numTotalf;
                }
                for (int i = 0; i < lessFromGear.Count; i++)
                {
                    float multiplicativePercentage = moreFromGear[i].itemModIntModifier / 100 - 1;
                    float numTotalf = 0;
                    numTotalf *= multiplicativePercentage;
                    Mathf.Round(numTotalf);
                    numTotal = (int)numTotalf;
                }
                return numTotal;
            }
            else if (moreFromGear == null && lessFromTree == null)
            {
                for (int i = 0; i < moreFromTree.Count; i++)
                {
                    float multiplicativePercentage = moreFromGear[i].itemModIntModifier / 100 + 1;
                    float numTotalf = 0;
                    numTotalf *= multiplicativePercentage;
                    Mathf.Round(numTotalf);
                    numTotal = (int)numTotalf;
                }
                for (int i = 0; i < lessFromGear.Count; i++)
                {
                    float multiplicativePercentage = moreFromGear[i].itemModIntModifier / 100 - 1;
                    float numTotalf = 0;
                    numTotalf *= multiplicativePercentage;
                    Mathf.Round(numTotalf);
                    numTotal = (int)numTotalf;
                }
                return numTotal;
            }
            else if (lessFromTree == null)
            {
                for(int i = 0; i < moreFromGear.Count; i++)
                {
                    float multiplicativePercentage = moreFromGear[i].itemModIntModifier / 100 + 1;
                    float numTotalf = 0;
                    numTotalf *= multiplicativePercentage;
                    Mathf.Round(numTotalf);
                    numTotal = (int)numTotalf;
                }
                for (int i = 0; i < lessFromGear.Count; i++)
                {
                    float multiplicativePercentage = moreFromGear[i].itemModIntModifier / 100 - 1;
                    float numTotalf = 0;
                    numTotalf *= multiplicativePercentage;
                    Mathf.Round(numTotalf);
                    numTotal = (int)numTotalf;
                }
                for (int i = 0; i < moreFromTree.Count; i++)
                {
                    float multiplicativePercentage = moreFromGear[i].itemModIntModifier / 100 + 1;
                    float numTotalf = 0;
                    numTotalf *= multiplicativePercentage;
                    Mathf.Round(numTotalf);
                    numTotal = (int)numTotalf;
                }
                return numTotal;
            }
            else
            {
                for (int i = 0; i < moreFromGear.Count; i++)
                {
                    float multiplicativePercentage = moreFromGear[i].itemModIntModifier / 100 + 1;
                    float numTotalf = 0;
                    numTotalf *= multiplicativePercentage;
                    Mathf.Round(numTotalf);
                    numTotal = (int)numTotalf;
                }
                for (int i = 0; i < lessFromGear.Count; i++)
                {
                    float multiplicativePercentage = moreFromGear[i].itemModIntModifier / 100 - 1;
                    float numTotalf = 0;
                    numTotalf *= multiplicativePercentage;
                    Mathf.Round(numTotalf);
                    numTotal = (int)numTotalf;
                }
                for (int i = 0; i < moreFromTree.Count; i++)
                {
                    float multiplicativePercentage = moreFromGear[i].itemModIntModifier / 100 + 1;
                    float numTotalf = 0;
                    numTotalf *= multiplicativePercentage;
                    Mathf.Round(numTotalf);
                    numTotal = (int)numTotalf;
                }
                for (int i = 0; i < lessFromTree.Count; i++)
                {
                    float multiplicativePercentage = moreFromGear[i].itemModIntModifier / 100 - 1;
                    float numTotalf = 0;
                    numTotalf *= multiplicativePercentage;
                    Mathf.Round(numTotalf);
                    numTotal = (int)numTotalf;
                }
                return numTotal;
            }
        }
        static public int AttributeStatTotalCalculator(int numflatTotal, int numAdditivePercentageTotal, 
                                                       List<ItemMod> moreFromGear, List<Skillnodes> moreFromTree, 
                                                       List<ItemMod> lessFromGear, List<Skillnodes> lessFromTree)
        {
            int numTotal = 0;
            numTotal += numflatTotal;
            float percentage;
            percentage = numAdditivePercentageTotal / 100 + 1;
            float numPercentage;
            numPercentage = numTotal;
            numPercentage *= percentage;
            Mathf.RoundToInt(numPercentage);
            numTotal = (int)numPercentage;
            if (moreFromGear == null && lessFromGear == null && moreFromTree == null && lessFromTree == null)
            {
                return numTotal;
            }
            else
            {
                numTotal = AttributeStatMLCalculator(numTotal, moreFromGear, moreFromTree, lessFromGear, lessFromTree);
                return numTotal;
            }

        }
    }
}
