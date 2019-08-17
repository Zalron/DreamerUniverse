using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
namespace CharacterModule
{
    static public class CharacterCalculations
    {
        static public int AttributeStatIDMLCalculator(int numFromGear, int numFromTree)
        {
            int numTotal = 0;
            numTotal += numFromGear;
            numTotal += numFromTree;
            return numTotal;
        }
        static public int AttributeStatIDMLTotalCalculator(int numPlusTotal, int numMinusTotal)
        {
            int numTotal = 0;
            numTotal += numPlusTotal;
            numTotal -= numMinusTotal;
            return numTotal;
        }
        static public int AttributeStatTotalCalculator(int numflatTotal, int numAdditivePercentageTotal)
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
            return numTotal;
        }
    }
}
