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
            foreach (var item in _dictionarySortedByKey)
            {
                Console.WriteLine(item);
            }
            return _dictionarySortedByKey;
        }

        public Dictionary<int, string> CustomSortByValue(Dictionary<int, string> dictionary)
        {
            var _dictionarySortedByValue = dictionary.OrderBy(x => x.Value).ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (var item in _dictionarySortedByValue)
            {
                Console.WriteLine(item);
            }
            return _dictionarySortedByValue;
        }

        public void GetFirstItem(Dictionary<int, string> dictionary)
        {
            var _firstItemDictionary = dictionary.First();
            if (_firstItemDictionary.Key != 0)
            {
                Console.WriteLine(_firstItemDictionary);
            }
        }

        public void GetLastItem(Dictionary<int, string> dictionary)
        {
            var _lastItemDictionary = dictionary.Last();
            if (_lastItemDictionary.Key != 0)
            {
                Console.WriteLine(_lastItemDictionary);
            }
        }

        public Dictionary<int, string> Reverse(Dictionary<int, string> dictionary)
        {
            var _dictionaryReverse = dictionary.Reverse().ToDictionary(pair => pair.Key, pair => pair.Value);
            foreach (var item in _dictionaryReverse)
            {
                Console.WriteLine(item);
            }
            return _dictionaryReverse;
        }
    }
}
