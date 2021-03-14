using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Challenges
{
    public class MoveZeroes
    {
        /*Given an array nums, write a function to move all 0's 
         to the of it while maintaining the relative order of the non 
         zero elements
         1.  You must do this in-place without making a copy of the array
         2.  Minimize the total number of operations*/

         public static void MoveZeroes_Solution(ref int[] nums)
        {
            int count = nums.Length;

            for(int i=0;i<count;i++)
            {
                if(nums[i]==0 && i!= count-1)
                {
                    int last = nums[count - 1];
                    nums[count - 1] = nums[i];

                    for(int j=i;j<count-2;j++)
                    {
                        nums[j] = nums[j + 1];
                    }
                    nums[count - 2] = last;
                }
            }

            return;
        }
    }
}
