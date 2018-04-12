using HomeTask4.WorkWithList;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HomeTask4
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("******************Work with list*******************");

            List<int> _list = new List<int>();
            _list.Add(95);
            _list.Add(515);
            _list.Add(25);
            _list.Add(835);
            _list.Add(45);
            _list.Add(105);

            ListService ls = new ListService();
            
            Console.WriteLine(ls.GetFirstItem(_list));
            Console.WriteLine("======================");
            Console.WriteLine(ls.GetLastItem(_list));
            Console.WriteLine("======================");
            ls.CustomSort(_list);
            Console.WriteLine("=======================");
            ls.Reverse(_list);


            Console.ReadLine();
        }
    }
}
