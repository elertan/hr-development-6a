using System;
using System.Collections.Immutable;
using System.Diagnostics;
using System.Linq;

namespace Unit1
{
    internal class BinarySearchExample
    {
        public void Run()
        {
            var array = new[] {1, 5, 2, 5, 1, 3, 6, 7, 3, 2, 1, 8};
            var sortedArray = array.ToImmutableSortedSet().ToArray();

            var foundIndex = PerformBinarySearch(sortedArray, 3);
            Debug.Assert(foundIndex == 2);

            var foundIndex2 = PerformBinarySearch(sortedArray, 5);
            Debug.Assert(foundIndex2 == 3);
        }

        private int PerformBinarySearch(int[] array, int number)
        {
            var low = 0;
            var high = array.Length - 1;

            while (low <= high)
            {
                var middle = (low + high) / 2;
                if (number < array[middle])
                {
                    high = middle - 1;
                }
                else if (number > array[middle])
                {
                    low = middle + 1;
                }
                else
                {
                    return middle;
                }
            }

            return -1;
        }
    }
}