using System.Diagnostics;
using System.Linq;

namespace Unit2
{
    internal class InsertionSortExample
    {
        public void Run()
        {
            var array = new[] {5, 2, 7, 6, 9, 4, 1, 5, 2, 4, 6, 7};
            var sortedArray = PerformInsertionSort(array);
            
            Debug.Assert(sortedArray.SequenceEqual(new [] {1, 2, 2, 4, 4, 5, 5, 6, 6, 7, 7, 9}));
        }

        private int[] PerformInsertionSort(int[] array)
        {
            var a = new int[array.Length];
            array.CopyTo(a, 0);
            
            for (var i = 1; i < a.Length; i++)
            {
                var j = i;

                while (j > 0 && a[j] < a[j - 1])
                {
                    var temp = a[j];
                    a[j] = a[j - 1];
                    a[j - 1] = temp;
                    j--;
                }
            }

            return a;
        }
    }
}