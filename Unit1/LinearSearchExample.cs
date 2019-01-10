using System.Diagnostics;

namespace Unit1
{
    internal class LinearSearchExample
    {
        public void Run()
        {
            var array = new[] {2, 3, 6, 4, 8, 6, 7, 1, 2};

            var foundIndex = PerformLinearSearch(array, 7);
            Debug.Assert(foundIndex == 6, "foundIndex == 6");

            var foundIndex2 = PerformLinearSearch(array, 1);
            Debug.Assert(foundIndex2 == 7, "foundIndex2 == 7");

            var foundIndex3 = PerformLinearSearch(array, 12);
            Debug.Assert(foundIndex3 == -1);
        }

        /// <summary>
        /// Performs a linear search on an array of integers
        /// </summary>
        /// <param name="array"></param>
        /// <param name="number"></param>
        /// <returns>The found index in the array for the given number, or -1 indicating that the number was not found.</returns>
        private int PerformLinearSearch(int[] array, int number)
        {
            for (var i = 0; i < array.Length; i++)
            {
                var currentNumber = array[i];
                if (currentNumber == number)
                {
                    return i;
                }
            }

            return -1;
        }
    }
}