using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Code_Challenges.PracticeProblems
{
    /*Given a set of numbers, find a subset that has a target sum
    1,2,3,4  target 7 expect 3, 4
    
     Problem Solving Framework

	• Clarify Requirements
		○ Input formats
		○ Data types
		○ outputs
	• Test Cases
		○ Take a TDD approach
	• Observables
		○ Mention certain aspects of the problem
		○ What if
	• Strategy
	• Implement
    • Verify


    */
    internal class SumToTarget
    {

    }
}


/*Given a set of numbers, find a subset that has a target sum
1,2,3,4  target 7 expect 3, 4

left to right 7-1 = 0, 
 
clarifying questions
is this going to be very large? 20 numbers
limits for memory? none
runtime limits?  not quadratic 

int

int[] as input?
ints positive?

int[] as output?

as walk through array get the number but also put in a hashset 

number off array , what do we need to make the sum 6 make the sum, check our
hashset to see if we have 6, if we don't 6, can we make six from what we have?
 


public static class problem
{
    private HashSet<int> seenNums;
    public static int[] SumToTarget(int[] nums, int target)
    {

        for (int i = 0; i < nums.Length; i++)
        {
            int currentNum = nums[i];
            int result = target - currentNum;
            if (result >= 0)
            {
                if (result == 0) return new int[] { result };
                int newTarget = result;
                int[] newArray = SubArray(nums, i, nums.Length - 1);
                int[] returnArray = SumToTarget(newArray, newTarget);
            }
        }
    }
}

*/