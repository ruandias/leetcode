using System;
using System.Collections.Generic;

namespace _1.TwoSum
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] array = new int[] { 3, 2, 4 };

            int target = 6;

            int[] result = TwoSum(array, target);
        }

        public static int[] TwoSum(int[] nums, int target)
        {
            // FIRST SOLUTION
            //List<int> indexes = new List<int>();

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i; j < nums.Length; j++)
            //    {
            //        if (nums[i] + nums[j] == target)
            //        {
            //            indexes.Add(i);
            //            indexes.Add(j);
            //        }

            //    }
            //}

            //return indexes.ToArray();

            //SECOND SOLUTION

            //for (int i = 0; i < nums.Length; i++)
            //{
            //    for (int j = i; j < nums.Length; j++)
            //    {
            //        if (nums[i] + nums[j] == target)
            //        {
            //            return new int[] { i, j };
            //        }

            //    }
            //}

            //throw new Exception("Not Found");


            // THIRD SOLUTION

            Dictionary<int, int> hashtable = new Dictionary<int, int>();

            for (int i = 0; i < nums.Length; i++)
            {
                int complement = target - nums[i];

                if (hashtable.ContainsKey(complement))
                    return new int[] { hashtable[complement], i };
                else
                    hashtable[nums[i]] = i;
            }

            throw new Exception("Not Found");

        }
    }
}
