using System;
using System.Collections.Generic;
using System.Text;

namespace Code_Challenges
{
    /*Given two integer arrays nums1 and nums2, return an array of their intersection. 
     Each element in the result must be unique and you may return the result in any order.*/
    public static class ArrayIntersection
    {
        public static int[] Intersection(int[] nums1, int[] nums2)
        {
            if (nums1.Length == 0 || nums2.Length == 0) return new int[1] { 0 };

            //Build list of array 1, and use Contains method to verify if in array 2
            List<int> list1 = new List<int>();
            for(int i = 0; i<nums1.Length;i++)
            {
                list1.Add(nums1[i]);
            }

            //Build a return list of the intersection and use ToArray method for return array
            List<int> returnList = new List<int>();
            for(int i = 0; i<nums2.Length;i++)
            {
                if (list1.Contains(nums2[i]) && !returnList.Contains(nums2[i])) returnList.Add(nums2[i]);
            }

            return returnList.ToArray();
        }
    }
}
