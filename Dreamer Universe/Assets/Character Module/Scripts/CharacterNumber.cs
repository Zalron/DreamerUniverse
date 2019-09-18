using System.Collections;
using System.Collections.Generic;
using UnityEngine;
using ItemSubModule;
namespace CharacterModule
{
    public enum CharacterNumberTypes
    {
        //Attributes
        Strength,
        Endurance,
        Dexterity,
        Luck,
        Intelligence,
        Willpower,
        //Stats
        //Damage Stats
        //
    }
    public class CharacterNumbers
    {
        CharacterNumberTypes characterNumberTypes;
        public List<ItemModSO> addFromGearMods, addFromTreeMods;
        public List<ItemModSO> minusFromGearMods, minusFromTreeMods;
        public int addFromGear, addFromTree, addTotal;
        public int minusFromGear, minusFromTree, minusTotal;
        public int flatTotal;
        public List<ItemModSO> increasedFromGearMods, increasedFromTreeMods;
        public List<ItemModSO> decreasedFromGearMods, decreasedFromTreeMods;
        public int increasedFromGear, increasedFromTree, increasedTotal;
        public int decreasedFromGear, decreasedFromTree, decreasedTotal;
        public int additivePercentageTotal;
        public List<ItemModSO> moreFromGearMods, moreFromTreeMods;
        public List<ItemModSO> lessFromGearMods, lessFromTreeMods;
        public int total;
        public CharacterNumbers(List<ItemModSO> _addFromGearMods, List<ItemModSO> _addFromTreeMods,
                                List<ItemModSO> _minusFromGearMods, List<ItemModSO> _minusFromTreeMods,
                                int _addFromGear, int _addFromTree, int _addTotal,
                                int _minusFromGear, int _minusFromTree, int _minusTotal,
                                int _flatTotal,
                                List<ItemModSO> _increasedFromGearMods, List<ItemModSO> _increasedFromTreeMods,
                                List<ItemModSO> _decreasedFromGearMods, List<ItemModSO> _decreasedFromTreeMods,
                                int _increasedFromGear, int _increasedFromTree, int _increasedTotal,
                                int _decreasedFromGear, int _decreasedFromTree, int _decreasedTotal,
                                int _additivePercentageTotal,
                                List<ItemModSO> _moreFromGearMods, List<ItemModSO> _moreFromTreeMods,
                                List<ItemModSO> _lessFromGearMods, List<ItemModSO> _lessFromTreeMods,
                                int _total)
        {
            addFromGearMods = _addFromGearMods; addFromTreeMods = _addFromTreeMods;
            minusFromGearMods = _minusFromGearMods; minusFromTreeMods = _minusFromTreeMods;
            addFromGear = _addFromGear; addFromTree = _addFromTree; addTotal = _addTotal;
            minusFromGear = _minusFromGear; minusFromTree = _minusFromTree; minusTotal = _minusTotal;
            flatTotal = _flatTotal;
            increasedFromGearMods = _increasedFromGearMods; increasedFromTreeMods = _increasedFromTreeMods;
            decreasedFromGearMods = _decreasedFromGearMods; decreasedFromTreeMods = _decreasedFromTreeMods;
            increasedFromGear = _increasedFromGear; increasedFromTree = _increasedFromTree; increasedTotal = _increasedTotal;
            decreasedFromGear = _decreasedFromGear; decreasedFromTree = _decreasedFromTree; decreasedTotal = _decreasedTotal;
            additivePercentageTotal = _additivePercentageTotal;
            moreFromGearMods = _moreFromGearMods; moreFromTreeMods = _moreFromTreeMods;
            lessFromGearMods = _lessFromGearMods; lessFromTreeMods = _lessFromTreeMods;
            total = _total;
        }
        public CharacterNumbers(List<ItemModSO> _increasedFromGearMods, List<ItemModSO> _increasedFromTreeMods,
                                List<ItemModSO> _decreasedFromGearMods, List<ItemModSO> _decreasedFromTreeMods,
                                int _increasedFromGear, int _increasedFromTree, int _increasedTotal,
                                int _decreasedFromGear, int _decreasedFromTree, int _decreasedTotal,
                                int _additivePercentageTotal,
                                List<ItemModSO> _moreFromGearMods, List<ItemModSO> _moreFromTreeMods,
                                List<ItemModSO> _lessFromGearMods, List<ItemModSO> _lessFromTreeMods,
                                int _total)
        {
            increasedFromGearMods = _increasedFromGearMods; increasedFromTreeMods = _increasedFromTreeMods;
            decreasedFromGearMods = _decreasedFromGearMods; decreasedFromTreeMods = _decreasedFromTreeMods;
            increasedFromGear = _increasedFromGear; increasedFromTree = _increasedFromTree; increasedTotal = _increasedTotal;
            decreasedFromGear = _decreasedFromGear; decreasedFromTree = _decreasedFromTree; decreasedTotal = _decreasedTotal;
            additivePercentageTotal = _additivePercentageTotal;
            moreFromGearMods = _moreFromGearMods; moreFromTreeMods = _moreFromTreeMods;
            lessFromGearMods = _lessFromGearMods; lessFromTreeMods = _lessFromTreeMods;
            total = _total;
        }
    }
}
