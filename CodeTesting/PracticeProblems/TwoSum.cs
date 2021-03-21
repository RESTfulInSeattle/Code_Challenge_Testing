using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Challenges.PracticeProblems
{
    /*Given an array of integers nums and an integer target, return indices of the two numbers such that they add up to target.
    You may assume that each input would have exactly one solution, and you may not use the same element twice.
    You can return the answer in any order.*/
    public static class TwoSum
    {
        public static int[] TwoSumFunction(int[] nums, int target)
        {
            if (nums.Length == 0) return new int[2] { 0, 0 };

            int[] returnArray = new int[2];

            Dictionary<int, int> values = new Dictionary<int, int>();

            for(int i = 0; i<nums.Length; i++)
            {
                int current = nums[i];
                int needed = target - current;

                if(values.ContainsKey(needed))
                {
                    int value;
                    values.TryGetValue(needed, out value);
                    returnArray[0] = value;
                    returnArray[1] = i;

                    return returnArray;
                }
                else
                {
                    values.Add(current, i);
                }
            }

            return returnArray;
        }
    }
}
