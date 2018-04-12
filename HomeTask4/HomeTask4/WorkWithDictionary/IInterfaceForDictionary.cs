using System.Collections.Generic;

namespace HomeTask4.WorkWithDictionary
{
    interface IInterfaceForDictionary
    {
        Dictionary<int, string> CustomSortByKey(Dictionary<int, string> dictionary);
        Dictionary<int, string> CustomSortByValue(Dictionary<int, string> dictionary);
        Dictionary<int, string> Reverse(Dictionary<int, string> dictionary);
        void GetFirstItem(Dictionary<int, string> dictionary);
        void GetLastItem(Dictionary<int, string> dictionary);
    }
}
