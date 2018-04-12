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
            ls.CustomSort(_list);
            Console.WriteLine("===========reverse============");
            ls.Reverse(_list);

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
            ds.CustomSortByKey(_dictionary);
            Console.WriteLine("============sort by value===========");
            ds.CustomSortByValue(_dictionary);
            Console.WriteLine("============GetFirstItem===========");
            ds.GetFirstItem(_dictionary);
            Console.WriteLine("============GetLastItem===========");
            ds.GetLastItem(_dictionary);
            Console.WriteLine("============Reverse dictionary===========");
            ds.Reverse(_dictionary);

            Console.ReadLine();
        }
    }
}
