using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task2
{
    public interface IBubbleSort<T>
        where T : struct
    {
        void Sort(IList<T> itemsToSort, Func<T, T, int> comparer);
    }
}
