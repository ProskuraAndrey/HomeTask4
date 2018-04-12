using HomeTask4.TaskWithDigitTwo;
using HomeTask4.WorkWithDictionary;
using HomeTask4.WorkWithList;
using System;
using System.Collections.Generic;

namespace HomeTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("\n******************Work with list*******************\n");

            List<int> _list = new List<int>();
            _list.Add(95);
            _list.Add(515);
            _list.Add(25);
            _list.Add(835);
            _list.Add(45);
            _list.Add(105);

            ListService ls = new ListService();

            Console.WriteLine("==========firstItem============");
            Console.WriteLine(ls.GetFirstItem(_list));
            Console.WriteLine("==========lastItem============");
            Console.WriteLine(ls.GetLastItem(_list));
            Console.WriteLine("==========sort============");
            var listSort = ls.CustomSort(_list);
            foreach (var item in listSort)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("===========reverse============");
            var listReverse = ls.Reverse(_list);
            foreach (var item in listReverse)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("\n******************Work with dictionary*******************\n");

            Dictionary<int, string> _dictionary = new Dictionary<int, string>
            {
                {5,"Dnipro" },
                {3, "Kharkiv" },
                {1, "Ternopil" },
                {9, "Kyiv" },
                {35, "Lviv" }

            };

            DictionaryService ds = new DictionaryService();
            //
            Console.WriteLine("===========sort by key============");
            var dictKey = ds.CustomSortByKey(_dictionary);
            foreach (var item in dictKey)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("============sort by value===========");
            var dictValue = ds.CustomSortByValue(_dictionary);
            foreach (var item in dictValue)
            {
                Console.WriteLine(item);
            }
            Console.WriteLine("============GetFirstItem===========");
            var firstItem = ds.GetFirstItem(_dictionary);
            Console.WriteLine(firstItem);
            Console.WriteLine("============GetLastItem===========");
            var lastItem = ds.GetLastItem(_dictionary);
            Console.WriteLine(lastItem);
            Console.WriteLine("============Reverse dictionary===========");
            var revDict = ds.Reverse(_dictionary);
            foreach (var item in revDict)
            {
                Console.WriteLine(item);
            }

            Console.WriteLine("=============Work with number======================\n");
            Console.Write("Enter the number :");
            int number = Convert.ToInt32(Console.ReadLine());

            Count _count = new Count();
            int rezult = _count.CountOperations(number);

            Console.WriteLine("This number has {0} operations with *2 and +1",rezult);
            Console.ReadLine();
        }
    }
}
