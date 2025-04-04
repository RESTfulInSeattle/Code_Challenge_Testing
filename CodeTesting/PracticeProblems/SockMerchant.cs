﻿using System;
using System.Collections.Generic;

namespace Code_Challenges.PracticeProblems
{
    /*
     John works at a clothing store. He has a large pile of socks that he must pair by color for sale. Given an array of integers representing the color of each sock, determine how many pairs of socks with matching colors there are.

    For example, there are  socks with colors . There is one pair of color  and one of color . There are three odd socks left, one of each color. The number of pairs is .

    Function Description

    Complete the sockMerchant function in the editor below. It must return an integer representing the number of matching pairs of socks that are available.

    sockMerchant has the following parameter(s):

    n: the number of socks in the pile
    ar: the colors of each sock
    Input Format

    The first line contains an integer , the number of socks represented in . 
    The second line contains  space-separated integers describing the colors  of the socks in the pile.

    Constraints

     where 
    Output Format

    Return the total number of matching pairs of socks that John can sell.

    Sample Input

    9
    10 20 20 10 10 30 50 10 20
    Sample Output

    3
     */

    /*
    public class SockMerchant
    {
        static void Main(string[] args)
        {
            int[] input = new int[] { 1, 1, 3, 1, 2, 1, 3, 3, 3, 3};
            int n = 10;

            Console.WriteLine(SockMerchantSolution.SockMerchant(n, input).ToString());
            Console.ReadLine();
        }
    }
    */
    public class SockMerchantSolution
    {
        // Complete the sockMerchant function below.
        public static int SockMerchant(int n, int[] ar)
        {
            int returnValue = 0;

            Dictionary<int, int> processed = ProcessInput(n, ar);

            foreach (KeyValuePair<int, int> kvp in processed)
            {
                returnValue = returnValue + GetCount(kvp);
            }

            return returnValue;
        }

        private static int GetCount(KeyValuePair<int, int> kvp)
        {
            int number = kvp.Value;
            if (number > 1)
            {
                return (number - number % 2) / 2;
            }
            else
            {
                return 0;
            }
        }

        private static Dictionary<int, int> ProcessInput(int n, int[] ar)
        {
            Dictionary<int, int> returnDictionary = new Dictionary<int, int>();

            for (int i = 0; i < n; i++)
            {
                if (returnDictionary.ContainsKey(ar[i]))
                {
                    returnDictionary[ar[i]] = returnDictionary[ar[i]] + 1;
                }
                else
                {
                    returnDictionary.Add(ar[i], 1);
                }
            }

            return returnDictionary;
        }
        
    }
}
