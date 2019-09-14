using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
using ItemSubModule;
namespace CharacterModule
{
    static public class CharacterCalculations
    {
        static public int AttributeStatASIDTotalCalculator(int num, List<ItemModSO> mods)
        {
            if (mods == null)
            {
                if (num < 0)
                {
                    num = 0;
                }
                for (int i = 0; i < mods.Count; i++)
                {
                    num += mods[i].itemModIntModifierMin;
                }
                return num;
            }
            return 0;
        }
        static public int AttributeStatASIDGrossTotalCalculator(int numTotal, int numFromGear, int numFromTree)
        {
            if (numTotal < 0)
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
        static public int AttributeStatMCalculator(int numTotal, List<ItemModSO> moreMultiplicativeMods)
        {
            for (int i = 0; i < moreMultiplicativeMods.Count; i++)
            {
                float multiplicativePercentage = moreMultiplicativeMods[i].itemModIntModifierMin / 100 + 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            return numTotal;
        }
        static public int AttributeStatLCalculator(int numTotal, List<ItemModSO> lessMultiplicativeMods)
        {
            for (int i = 0; i < lessMultiplicativeMods.Count; i++)
            {
                float multiplicativePercentage = lessMultiplicativeMods[i].itemModIntModifierMin / 100 - 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            return numTotal;
        }
        static public int AttributeStatMMCalculator(int numTotal, List<ItemModSO> moreMultiplicativeMods1, List<ItemModSO> moreMultiplicativeMods2)
        {
            for (int i = 0; i < moreMultiplicativeMods1.Count; i++)
            {
                float multiplicativePercentage = moreMultiplicativeMods1[i].itemModIntModifierMin / 100 + 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < moreMultiplicativeMods2.Count; i++)
            {
                float multiplicativePercentage = moreMultiplicativeMods2[i].itemModIntModifierMin / 100 + 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            return numTotal;
        }
        static public int AttributeStatMLCalculator(int numTotal, List<ItemModSO> moreMultiplicativeMods, List<ItemModSO> lessMultiplicativeMods)
        {
            for (int i = 0; i < moreMultiplicativeMods.Count; i++)
            {
                float multiplicativePercentage = moreMultiplicativeMods[i].itemModIntModifierMin / 100 + 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < lessMultiplicativeMods.Count; i++)
            {
                float multiplicativePercentage = lessMultiplicativeMods[i].itemModIntModifierMin / 100 - 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            return numTotal;
        }
        static public int AttributeStatLLCalculator(int numTotal, List<ItemModSO> lessMultiplicativeMods1, List<ItemModSO> lessMultiplicativeMods2)
        {
            for (int i = 0; i < lessMultiplicativeMods1.Count; i++)
            {
                float multiplicativePercentage = lessMultiplicativeMods1[i].itemModIntModifierMin / 100 - 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < lessMultiplicativeMods2.Count; i++)
            {
                float multiplicativePercentage = lessMultiplicativeMods2[i].itemModIntModifierMin / 100 - 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            return numTotal;
        }
        static public int AttributeStatMMLCalculator(int numTotal, List<ItemModSO> moreMultiplicativeMods1, List<ItemModSO> moreMultiplicativeMods2, List<ItemModSO> lessMultiplicativeMods1)
        {
            for (int i = 0; i < moreMultiplicativeMods1.Count; i++)
            {
                float multiplicativePercentage = moreMultiplicativeMods1[i].itemModIntModifierMin / 100 + 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < moreMultiplicativeMods2.Count; i++)
            {
                float multiplicativePercentage = moreMultiplicativeMods2[i].itemModIntModifierMin / 100 + 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < lessMultiplicativeMods1.Count; i++)
            {
                float multiplicativePercentage = lessMultiplicativeMods1[i].itemModIntModifierMin / 100 - 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            return numTotal;
        }
        static public int AttributeStatLLMCalculator(int numTotal, List<ItemModSO> lessMultiplicativeMods1, List<ItemModSO> lessMultiplicativeMods2, List<ItemModSO> moreMultiplicativeMods1)
        {
            for (int i = 0; i < moreMultiplicativeMods1.Count; i++)
            {
                float multiplicativePercentage = moreMultiplicativeMods1[i].itemModIntModifierMin / 100 + 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < lessMultiplicativeMods1.Count; i++)
            {
                float multiplicativePercentage = lessMultiplicativeMods1[i].itemModIntModifierMin / 100 - 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < lessMultiplicativeMods2.Count; i++)
            {
                float multiplicativePercentage = lessMultiplicativeMods2[i].itemModIntModifierMin / 100 - 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            return numTotal;
        }
        static public int AttributeStatMMLLCalculator(int numTotal, List<ItemModSO> moreMultiplicativeMods1, List<ItemModSO> moreMultiplicativeMods2, List<ItemModSO> lessMultiplicativeMods1, List<ItemModSO> lessMultiplicativeMods2)
        {
            for (int i = 0; i < moreMultiplicativeMods1.Count; i++)
            {
                float multiplicativePercentage = moreMultiplicativeMods1[i].itemModIntModifierMin / 100 + 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < moreMultiplicativeMods2.Count; i++)
            {
                float multiplicativePercentage = moreMultiplicativeMods2[i].itemModIntModifierMin / 100 + 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < lessMultiplicativeMods1.Count; i++)
            {
                float multiplicativePercentage = lessMultiplicativeMods1[i].itemModIntModifierMin / 100 - 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            for (int i = 0; i < lessMultiplicativeMods2.Count; i++)
            {
                float multiplicativePercentage = lessMultiplicativeMods2[i].itemModIntModifierMin / 100 - 1;
                float numTotalf = numTotal;
                numTotalf *= multiplicativePercentage;
                Mathf.Round(numTotalf);
                numTotal = (int)numTotalf;
            }
            return numTotal;
        }
        static public int AttributeStatMLTotalCalculator(int numTotal,
                                                         List<ItemModSO> moreFromGear, List<ItemModSO> moreFromTree,
                                                         List<ItemModSO> lessFromGear, List<ItemModSO> lessFromTree)
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
                                                       List<ItemModSO> moreFromGear, List<ItemModSO> moreFromTree, 
                                                       List<ItemModSO> lessFromGear, List<ItemModSO> lessFromTree)
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
        static public CharacterNumbers AttributeStatCalculation(CharacterNumbers characterNumbers)
        {
            characterNumbers.addFromGear = AttributeStatASIDTotalCalculator(characterNumbers.addFromGear, characterNumbers.addFromGearMods);
            characterNumbers.addFromTree = AttributeStatASIDTotalCalculator(characterNumbers.addFromTree, characterNumbers.addFromTreeMods);
            characterNumbers.addTotal = AttributeStatASIDGrossTotalCalculator(characterNumbers.addTotal, characterNumbers.addFromGear, characterNumbers.addFromTree);
            characterNumbers.minusFromGear = AttributeStatASIDTotalCalculator(characterNumbers.minusFromGear, characterNumbers.minusFromGearMods);
            characterNumbers.minusFromTree = AttributeStatASIDTotalCalculator(characterNumbers.minusFromTree, characterNumbers.minusFromTreeMods);
            characterNumbers.minusTotal = AttributeStatASIDGrossTotalCalculator(characterNumbers.minusTotal, characterNumbers.minusFromGear, characterNumbers.minusFromTree);
            characterNumbers.flatTotal = AttributeStatASIDNetTotalCalculator(characterNumbers.addTotal, characterNumbers.minusTotal);
            characterNumbers.increasedFromGear = AttributeStatASIDTotalCalculator(characterNumbers.increasedFromGear, characterNumbers.increasedFromGearMods);
            characterNumbers.increasedFromTree = AttributeStatASIDTotalCalculator(characterNumbers.increasedFromTree, characterNumbers.increasedFromTreeMods);
            characterNumbers.increasedTotal = AttributeStatASIDGrossTotalCalculator(characterNumbers.increasedTotal, characterNumbers.increasedFromGear, characterNumbers.increasedFromTree);
            characterNumbers.decreasedFromGear = AttributeStatASIDTotalCalculator(characterNumbers.decreasedFromGear, characterNumbers.decreasedFromGearMods);
            characterNumbers.decreasedFromTree = AttributeStatASIDTotalCalculator(characterNumbers.decreasedFromTree, characterNumbers.decreasedFromTreeMods);
            characterNumbers.decreasedTotal = AttributeStatASIDGrossTotalCalculator(characterNumbers.decreasedTotal, characterNumbers.decreasedFromGear, characterNumbers.decreasedFromTree);
            characterNumbers.additivePercentageTotal = AttributeStatASIDNetTotalCalculator(characterNumbers.increasedTotal, characterNumbers.decreasedTotal);
            characterNumbers.total = AttributeStatTotalCalculator(characterNumbers.flatTotal, characterNumbers.additivePercentageTotal, characterNumbers.moreFromGearMods, characterNumbers.moreFromTreeMods, characterNumbers.lessFromGearMods, characterNumbers.lessFromTreeMods);
            return characterNumbers;
        }
    }
}
