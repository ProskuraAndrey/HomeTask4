using System.Collections.Generic;

namespace HomeTask4
{
    interface IInterfaceForList 
    {
        List<int> CustomSort(List<int> list);
        List<int> Reverse(List<int> list);
        int GetFirstItem(List<int> list);
        int GetLastItem(List<int> list);
    }
}
