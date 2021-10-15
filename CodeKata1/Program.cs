using System;
using System.Collections.Generic;

namespace CodeKata1
{
    class Program
    {
        static void Main(string[] args)
        {
            assert_equal(-1, chop(3, new List<int>() { }, 0));
            assert_equal(-1, chop(3, new List<int>() { 1 }, 0));
            assert_equal(0, chop(1, new List<int>() { 1 }, 0));
            assert_equal(0, chop(1, new List<int>() { 1, 3, 5 }, 0));
            assert_equal(1, chop(3, new List<int>() { 1, 3, 5 }, 0));
            assert_equal(2, chop(5, new List<int>() { 1, 3, 5 }, 0));
            assert_equal(-1, chop(0, new List<int>() { 1, 3, 5 }, 0));
            assert_equal(-1, chop(2, new List<int>() { 1, 3, 5 }, 0));
            assert_equal(-1, chop(4, new List<int>() { 1, 3, 5 }, 0));
            assert_equal(-1, chop(6, new List<int>() { 1, 3, 5 }, 0));
            assert_equal(0, chop(1, new List<int>() { 1, 3, 5, 7 }, 0));
            assert_equal(1, chop(3, new List<int>() { 1, 3, 5, 7 }, 0));
            assert_equal(2, chop(5, new List<int>() { 1, 3, 5, 7 }, 0));
            assert_equal(3, chop(7, new List<int>() { 1, 3, 5, 7 }, 0));
            assert_equal(-1, chop(0, new List<int>() { 1, 3, 5, 7 }, 0));
            assert_equal(-1, chop(2, new List<int>() { 1, 3, 5, 7 }, 0));
            assert_equal(-1, chop(4, new List<int>() { 1, 3, 5, 7 }, 0));
            assert_equal(-1, chop(6, new List<int>() { 1, 3, 5, 7 }, 0));
            assert_equal(-1, chop(8, new List<int>() { 1, 3, 5, 7 }, 0));
          }

        public static void assert_equal(int val1, int val2)
        {
            if (val1 == val2)
            {
                Console.WriteLine($"Success! {val1} is equal to {val2}");
            } else
            {
                Console.WriteLine($"Failure! {val1} is not equal to {val2}");
            }
        }

        private static int chop(int val, List<int> array, int startingIndex)
        {
            if (array.Count == 0)
            {
                return -1;
            }

            var middleIndex = array.Count / 2;
            var middleElement = array[middleIndex];
    
            if (middleElement == val)
            {
                return startingIndex + middleIndex;
            } else if (middleElement > val)
            {
                var subArray = new List<int>();
                for (int i = 0; i < middleIndex; i++)
                {
                    subArray.Add(array[i]);
                }
                return chop(val, subArray, 0);
            } else
            {
                var subArray = new List<int>();
                for (int i = middleIndex + 1; i < array.Count; i++)
                {
                    subArray.Add(array[i]);
                }
                return chop(val, subArray, middleIndex + 1);
            }
        }
    }
}
