using System.Collections;
using System.Collections.Generic;
using UnityEngine;
namespace CharacterModule
{
    static public class CharacterCalculations
    {
        static public int AttributeStatFlatCalculator(int flatFromGearAttributeStat, int flatFromTreeAttributeStat)
        {
            int totalFlatAttributeStat = 0;
            totalFlatAttributeStat += flatFromGearAttributeStat;
            totalFlatAttributeStat += flatFromTreeAttributeStat;
            return totalFlatAttributeStat;
        }
        static public float AttributeStatIDMLCalculator(float IDMLFromGearAttributeStat, float IDMLFromTreeAttributeStat)
        {
            float IDMLAttributeStat = 0;
            IDMLAttributeStat += IDMLFromGearAttributeStat;
            IDMLAttributeStat += IDMLFromTreeAttributeStat;
            //Round 
            return IDMLAttributeStat;
        }
        static public float TotalAttributeStatIDMLCalculator(float IncreasedFromGearAttributeStat, float DecreasedAttributeStat, float MoreAttributeStat, float LessAttributeStat)
        {
            float totalIDMLAttributeState = 0;

            return totalIDMLAttributeState;
        }
        static public int AttributeTotalCalculator(int flatTotalAttribute, float IDMLTotalAttribute)
        {
            int TotalAttribute = 0;
            float TotalPercentage = 0f;
            TotalAttribute += flatTotalAttribute;
            TotalPercentage += IDMLTotalAttribute;
            Mathf.Floor(TotalPercentage);
            TotalAttribute += (int)TotalPercentage;
            return TotalAttribute;
        }
        static public float StatTotalCalculator()
        {

            Mathf.Round(TotalPercentage);
        }
    }
}
