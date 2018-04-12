using System.Collections.Generic;

namespace HomeTask4.WorkWithDictionary
{
    interface IInterfaceForDictionary
    {
        Dictionary<int, string> CustomSortByKey(Dictionary<int, string> dictionary);
        Dictionary<int, string> CustomSortByValue(Dictionary<int, string> dictionary);
        Dictionary<int, string> Reverse(Dictionary<int, string> dictionary);
        int GetFirstItem(Dictionary<int, string> dictionary);
        int GetLastItem(Dictionary<int, string> dictionary);
    }
}
