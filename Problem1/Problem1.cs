using System;
using System.Collections.Generic;

/*  Given a list of numbers and a number k, return whether any two numbers from the list add up to k.

    For example, given [10, 15, 3, 7] and k of 17, return true since 10 + 7 is 17.

    Bonus: Can you do this in one pass? */

namespace Problem1
{
	class Problem1
	{
        static void FindPairs(int[] arr, int k)
        {
            HashSet<int> s = new HashSet<int>();

            foreach (int i in arr)
            {
                int sum = k - i;

                if (s.Contains(sum))
                {
                    System.Console.WriteLine("Sets: {0} and {1}", sum, i);
                }

                s.Add(i);
            }
        }

        static void Main(string[] args)
        {
            int[] arr = new int[] {10, 15, 3, 7};
            int k = 17;

            FindPairs(arr, k);

            Console.ReadKey();
        }
	}
}
