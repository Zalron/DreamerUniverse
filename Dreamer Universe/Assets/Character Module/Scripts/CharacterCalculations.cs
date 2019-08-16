using System.Collections;
using System.Collections.Generic;
using System;
using UnityEngine;
namespace CharacterModule
{
    static public class CharacterCalculations
    {
        static public int AttributeStatMCalculator(int moreFromGearStrength, int moreFromTreeStrength)
        {
            int moreTotalStrength = 0;
            moreTotalStrength += moreFromGearStrength;
            moreTotalStrength += moreFromTreeStrength;
            return moreTotalStrength;
        }
        static public int AttributeStatLCalculator(int lessFromGearStrength, int lessFromTreeStrength)
        {
            int lessTotalStrength = 0;
            lessTotalStrength += lessFromGearStrength;
            lessTotalStrength += lessFromTreeStrength;
            return lessTotalStrength;
        }
        static public int AttributeStatMLCalculator(int moreTotalStrength, int lessTotalStrength)
        {

        }
    }
}
