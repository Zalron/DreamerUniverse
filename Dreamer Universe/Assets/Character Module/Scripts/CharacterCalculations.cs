using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using ItemModule;
namespace CharacterModule
{
    static public class CharacterCalculations
    {
        static public int AttributeStatASIDTotalCalculator(int num, List<ItemMod> mods)
        {
            if (num > 0)
            {
                num = 0;
            }
            for (int i = 0; i < mods.Count; i++)
            {
                num += mods[i].itemModIntModifier;
            }
            return num;
        }
        static public int AttributeStatASIDGrossTotalCalculator(int numTotal, int numFromGear, int numFromTree)
        {
            if (numTotal > 0)
            {
                numTotal = 0;
            }
            numTotal += numFromGear;
            numTotal += numFromTree;
            return numTotal;
        }
        static public int AttributeStatASIDNetTotalCalculator(int numPlusTotal, int numMinusTotal)
        {
            int numTotal = 0;
            numTotal += numPlusTotal;
            numTotal -= numMinusTotal;
            return numTotal;
        }
        static public int AttributeStatMCalculator(int numTotal, List<ItemMod> moreMultiplicativeMods)
        {
            for (int i = 0; i < moreMultiplicativeMods.Count; i++)
            {
                float multiplicativePercentage = moreMultiplicativeMods[i].itemModIntModifier / 100 + 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            return numTotal;
        }
        static public int AttributeStatLCalculator(int numTotal, List<ItemMod> lessMultiplicativeMods)
        {
            for (int i = 0; i < lessMultiplicativeMods.Count; i++)
            {
                float multiplicativePercentage = lessMultiplicativeMods[i].itemModIntModifier / 100 - 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            return numTotal;
        }
        static public int AttributeStatMMCalculator(int numTotal, List<ItemMod> moreMultiplicativeMods1, List<ItemMod> moreMultiplicativeMods2)
        {
            for (int i = 0; i < moreMultiplicativeMods1.Count; i++)
            {
                float multiplicativePercentage = moreMultiplicativeMods1[i].itemModIntModifier / 100 + 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < moreMultiplicativeMods2.Count; i++)
            {
                float multiplicativePercentage = moreMultiplicativeMods2[i].itemModIntModifier / 100 + 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            return numTotal;
        }
        static public int AttributeStatMLCalculator(int numTotal, List<ItemMod> moreMultiplicativeMods, List<ItemMod> lessMultiplicativeMods)
        {
            for (int i = 0; i < moreMultiplicativeMods.Count; i++)
            {
                float multiplicativePercentage = moreMultiplicativeMods[i].itemModIntModifier / 100 + 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < lessMultiplicativeMods.Count; i++)
            {
                float multiplicativePercentage = lessMultiplicativeMods[i].itemModIntModifier / 100 - 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            return numTotal;
        }
        static public int AttributeStatLLCalculator(int numTotal, List<ItemMod> lessMultiplicativeMods1, List<ItemMod> lessMultiplicativeMods2)
        {
            for (int i = 0; i < lessMultiplicativeMods1.Count; i++)
            {
                float multiplicativePercentage = lessMultiplicativeMods1[i].itemModIntModifier / 100 - 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < lessMultiplicativeMods2.Count; i++)
            {
                float multiplicativePercentage = lessMultiplicativeMods2[i].itemModIntModifier / 100 - 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            return numTotal;
        }
        static public int AttributeStatMMLCalculator(int numTotal, List<ItemMod> moreMultiplicativeMods1, List<ItemMod> moreMultiplicativeMods2, List<ItemMod> lessMultiplicativeMods1)
        {
            for (int i = 0; i < moreMultiplicativeMods1.Count; i++)
            {
                float multiplicativePercentage = moreMultiplicativeMods1[i].itemModIntModifier / 100 + 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < moreMultiplicativeMods2.Count; i++)
            {
                float multiplicativePercentage = moreMultiplicativeMods2[i].itemModIntModifier / 100 + 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < lessMultiplicativeMods1.Count; i++)
            {
                float multiplicativePercentage = lessMultiplicativeMods1[i].itemModIntModifier / 100 - 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            return numTotal;
        }
        static public int AttributeStatLLMCalculator(int numTotal, List<ItemMod> lessMultiplicativeMods1, List<ItemMod> lessMultiplicativeMods2, List<ItemMod> moreMultiplicativeMods1)
        {
            for (int i = 0; i < moreMultiplicativeMods1.Count; i++)
            {
                float multiplicativePercentage = moreMultiplicativeMods1[i].itemModIntModifier / 100 + 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < lessMultiplicativeMods1.Count; i++)
            {
                float multiplicativePercentage = lessMultiplicativeMods1[i].itemModIntModifier / 100 - 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < lessMultiplicativeMods2.Count; i++)
            {
                float multiplicativePercentage = lessMultiplicativeMods2[i].itemModIntModifier / 100 - 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            return numTotal;
        }
        static public int AttributeStatMMLLCalculator(int numTotal, List<ItemMod> moreMultiplicativeMods1, List<ItemMod> moreMultiplicativeMods2, List<ItemMod> lessMultiplicativeMods1, List<ItemMod> lessMultiplicativeMods2)
        {
            for (int i = 0; i < moreMultiplicativeMods1.Count; i++)
            {
                float multiplicativePercentage = moreMultiplicativeMods1[i].itemModIntModifier / 100 + 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < moreMultiplicativeMods2.Count; i++)
            {
                float multiplicativePercentage = moreMultiplicativeMods2[i].itemModIntModifier / 100 + 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < lessMultiplicativeMods1.Count; i++)
            {
                float multiplicativePercentage = lessMultiplicativeMods1[i].itemModIntModifier / 100 - 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < lessMultiplicativeMods2.Count; i++)
            {
                float multiplicativePercentage = lessMultiplicativeMods2[i].itemModIntModifier / 100 - 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            return numTotal;
        }
        static public int AttributeStatMLTotalCalculator(int numTotal,
                                                         List<ItemMod> moreFromGear, List<ItemMod> moreFromTree,
                                                         List<ItemMod> lessFromGear, List<ItemMod> lessFromTree)
        {
            if (lessFromGear == null && moreFromTree == null && lessFromTree == null && moreFromGear != null)
            {
                numTotal = AttributeStatMCalculator(numTotal, moreFromGear);
                return numTotal;
            }
            else if(moreFromGear == null && moreFromTree == null && lessFromTree == null)
            {
                numTotal = AttributeStatLCalculator(numTotal, lessFromGear);
                return numTotal;
            }
            else if(moreFromGear == null && lessFromGear == null && lessFromTree == null)
            {
                numTotal = AttributeStatMCalculator(numTotal, moreFromTree);
                return numTotal;
            }
            else if(moreFromGear == null && lessFromGear == null && moreFromTree == null)
            {
                numTotal = AttributeStatLCalculator(numTotal, lessFromTree);
                return numTotal;
            }

            else if (moreFromTree == null && lessFromTree == null)
            {
                numTotal = AttributeStatMLCalculator(numTotal, moreFromGear, lessFromGear);
                return numTotal;
            }
            else if (moreFromGear == null && lessFromGear == null)
            {
                numTotal = AttributeStatMLCalculator(numTotal, moreFromTree, lessFromGear);
                return numTotal;
            }
            else if (moreFromGear == null && lessFromTree == null)
            {
                numTotal = AttributeStatMLCalculator(numTotal, moreFromTree, lessFromGear);
                return numTotal;
            }
            else if (lessFromGear == null && moreFromTree == null)
            {
                numTotal = AttributeStatMLCalculator(numTotal, moreFromGear, lessFromTree);
                return numTotal;
            }
            else if (moreFromGear == null && moreFromTree == null)
            {
                numTotal = AttributeStatMLCalculator(numTotal, moreFromTree, lessFromGear);
                return numTotal;
            }
            else if (lessFromGear == null && lessFromTree == null)
            {
                numTotal = AttributeStatMLCalculator(numTotal, moreFromTree, lessFromGear);
                return numTotal;
            }

            else if (moreFromGear == null)
            {
                numTotal = AttributeStatLLMCalculator(numTotal, lessFromGear, lessFromTree, moreFromTree);
                return numTotal;
            }
            else if (moreFromTree == null)
            {
                numTotal = AttributeStatLLMCalculator(numTotal, lessFromGear, lessFromTree, moreFromGear);
                return numTotal;
            }
            else if (lessFromGear == null)
            {
                numTotal = AttributeStatMMLCalculator(numTotal, moreFromGear, moreFromTree, lessFromGear);
                return numTotal;
            }
            else if (lessFromTree == null)
            {
                numTotal = AttributeStatMMLCalculator(numTotal, moreFromGear, moreFromTree, lessFromTree);
                return numTotal;
            }

            else
            {
                numTotal = AttributeStatMMLLCalculator(numTotal, moreFromGear, moreFromTree, lessFromGear, lessFromTree);
                return numTotal;
            }
        }
        static public int AttributeStatTotalCalculator(int numflatTotal, int numAdditivePercentageTotal, 
                                                       List<ItemMod> moreFromGear, List<ItemMod> moreFromTree, 
                                                       List<ItemMod> lessFromGear, List<ItemMod> lessFromTree)
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
                numTotal += AttributeStatMLTotalCalculator(numTotal, moreFromGear, moreFromTree, lessFromGear, lessFromTree);
                return numTotal;
            }

        }
        static public int AttributeStatCalculation(List<ItemMod> addFromGearMods, List<ItemMod> addFromTreeMods,
                                                   List<ItemMod> minusFromGearMods, List<ItemMod> minusFromTreeMods,
                                                   int addFromGear, int addFromTree, int addTotal,
                                                   int minusFromGear, int minusFromTree, int minusTotal,
                                                   int flatTotal,
                                                   List<ItemMod> increasedFromGearMods, List<ItemMod> increasedFromTreeMods,
                                                   List<ItemMod> decreasedFromGearMods, List<ItemMod> decreasedFromTreeMods,
                                                   int increasedFromGear, int increasedFromTree, int increasedTotal,
                                                   int decreasedFromGear, int decreasedFromTree, int decreasedTotal,
                                                   int additivePercentageTotal,
                                                   List<ItemMod> moreFromGearMods, List<ItemMod> moreFromTreeMods,
                                                   List<ItemMod> lessFromGearMods, List<ItemMod> lessFromTreeMods,
                                                   int total)
        {
            addFromGear = AttributeStatASIDTotalCalculator(addFromGear, addFromGearMods);
            addFromTree = AttributeStatASIDTotalCalculator(addFromTree, addFromTreeMods);
            addTotal = AttributeStatASIDGrossTotalCalculator(addTotal, addFromGear, addFromTree);
            minusFromGear = AttributeStatASIDTotalCalculator(minusFromGear, minusFromGearMods);
            minusFromTree = AttributeStatASIDTotalCalculator(minusFromTree, minusFromTreeMods);
            minusTotal = AttributeStatASIDGrossTotalCalculator(minusTotal, minusFromGear, minusFromTree);
            flatTotal = AttributeStatASIDNetTotalCalculator(addTotal, minusTotal);
            increasedFromGear = AttributeStatASIDTotalCalculator(increasedFromGear, increasedFromGearMods);
            increasedFromTree = AttributeStatASIDTotalCalculator(increasedFromTree, increasedFromTreeMods);
            increasedTotal = AttributeStatASIDGrossTotalCalculator(increasedTotal, increasedFromGear, increasedFromTree);
            decreasedFromGear = AttributeStatASIDTotalCalculator(decreasedFromGear, decreasedFromGearMods);
            decreasedFromTree = AttributeStatASIDTotalCalculator(decreasedFromTree, decreasedFromTreeMods);
            decreasedTotal = AttributeStatASIDGrossTotalCalculator(decreasedTotal, decreasedFromGear, decreasedFromTree);
            additivePercentageTotal = AttributeStatASIDNetTotalCalculator(increasedTotal, decreasedTotal);
            total = AttributeStatTotalCalculator(flatTotal, additivePercentageTotal, moreFromGearMods, moreFromTreeMods, lessFromGearMods, lessFromTreeMods);
            return total;
        }
    }
}
