using System;
using System.Collections.Generic;
using System.Linq;

namespace HomeTask4.WorkWithList
{
   public class ListService : IInterfaceForList
    {

        public int GetFirstItem(List<int> list)
        {
            int _firstItem = list[0];
            return _firstItem;
        }

        public int GetLastItem(List<int> list)
        {
            int _count = list.Count - 1;
            int _lastItem = list[_count];
            return _lastItem;
        }

        public List<int> Reverse(List<int> list)
        {
            var _listReverse = list.OrderByDescending(x => x).ToList();
            foreach (var item in _listReverse)
            {
                Console.WriteLine(item);
            }
            return _listReverse;
        }

        public List<int> CustomSort(List<int> list)
        {
            var _sortedList = list.OrderBy(x => x).ToList();
            foreach (var item in _sortedList)
            {
                Console.WriteLine(item);
            }
            return _sortedList;
        }
    }
}
