using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeTask4.WorkWithDictionary
{
    class DictionaryService : IInterfaceForDictionary
    {
        public Dictionary<int, string> CustomSortByKey(Dictionary<int, string> dictionary)
        {
            var _dictionarySortedByKey = dictionary.OrderBy(x => x.Key).ToDictionary(pair => pair.Key, pair => pair.Value);
            return _dictionarySortedByKey;
        }

        public Dictionary<int, string> CustomSortByValue(Dictionary<int, string> dictionary)
        {
            var _dictionarySortedByValue = dictionary.OrderBy(x => x.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            return _dictionarySortedByValue;
        }

        public int GetFirstItem(Dictionary<int, string> dictionary)
        {
            var _firstItemDictionary = dictionary.First().Key;
            return _firstItemDictionary;
        }

        public int GetLastItem(Dictionary<int, string> dictionary)
        {
            var _lastItemDictionary = dictionary.Last().Key;
            return _lastItemDictionary;
        }

        public Dictionary<int, string> Reverse(Dictionary<int, string> dictionary)
        {
            var _dictionaryReverse = dictionary.Reverse().ToDictionary(pair => pair.Key, pair => pair.Value);
            return _dictionaryReverse;
        }
    }
}
