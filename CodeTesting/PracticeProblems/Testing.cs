using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Dynamic;
using System.Linq;
using System;


class MainClass
{
    // 1. Write a method that takes in a list of integers and returns their sum
    // For example sum([1, 3, 5]) should return 9. An empty list should sum to zero  (sum([]) == 0).
// SOLVE WITHOUT USING LOOPS!
public static int Sum(int[] values)
    {
        if (values.Length > 1)
        {
            return values[0] + Sum(values.Skip(1).Take(values.Length - 1).ToArray());
        }
        else
        {
            return values[0];
        }
    }

public static bool IsPalindrome(string input)
    {
        string input_no_whitespace = string.Concat(input.Where(c => !
        char.IsWhiteSpace(c)));
        int n = input_no_whitespace.Length;
        if (n > 1)
        {
            if (input_no_whitespace[0] == input_no_whitespace[n - 1])
            {
                return IsPalindrome(input_no_whitespace.Substring(1, n - 2));
            }
            else
            {
                return false;
            }
        }
        else
        {
            return true;
        }
    }

public static int StepWays(int steps)
    {
        if (steps == 0)
        {
            return 0;
        }
        else
        {
            int[] hop_config = new int[steps]; // jump 1, jump 2, ...
            for (int ii = 0; ii < hop_config.Length; ii++)
            {
                // 1 + 1 + 1 + 1 = 1 * 4^3 + 1 * 4^2 + 1 * 4 + 1 = 85 (homogeneous starting point)
                hop_config[ii] = 1; // homogeneous starting point, 1 stair at a  time
        }
        List<int> hop_config_cache = new List<int>();
        return StepWaysRecursion(hop_config_cache, hop_config);
    }
}
public static int StepWaysRecursion(List<int> hop_config_cache, int[]
hop_config)
{
    // Leave this execution counter inside of your recursive method
    _counter++;
    //Console.Write($" ==> { string.Join(" ==> ", hop_config)}");
    //Console.WriteLine("");
    int hop_sum = 0;
    for (int kk = 0; kk < hop_config.Length; kk++)
    {
        hop_sum += hop_config[kk];
    }
    if (hop_sum > hop_config.Length)
    {
        return hop_config_cache.Count;
    }
    int in_cache = add_to_cache(hop_config_cache, hop_config);
    if (in_cache == 1)
    { // if you hit number already visited, stop
        return hop_config_cache.Count;
    }
    else
    {
        // find right-most nonzero element
        int ii = hop_config.Length - 1;
        int last_nonzero = ii;
        while (ii >= 0)
        {
            if (hop_config[ii] > 0)
            {
                last_nonzero = ii;
                ii = -1;
            }
            else
            {
                ii--;
            }
        }
        // transfer unit hop from right to left under requirement no hop can be    4 - jump
        // 1 + 1 + 1 + 1 = 1 * 4^3 + 1 * 4^2 + 1 * 4 + 1 = 85      (homogeneous starting point)
    // 1 + 1 + 2 = 1 + 1 + 2 + 0 = (unit transfer from homogeneous startingpoint)
// 1 + 2 + 1 = 1 + 2 + 1 + 0 = (unit trasfer from last, right to left)
// 1 + 3 = 1 + 3 + 0 + 0 = (unit transfer from last, right to left,starting with right - most nonzero element)
// 2 + 2 = 2 + 2 + 0 + 0 = (same as above)
// 3 + 1 = 3 + 1 + 0 + 0 = (same as above)
int shift_origin = last_nonzero;
        int shift_destination = last_nonzero - 1;
        while (hop_config[shift_destination] >= 3)
        { // can't transfer to make     4 - jump
        // 3 + 1 = 3 + 1 + 0 + 0
        // 2 + 1 + 1 = 2 + 1 + 1 + 0 = left shift element from left-most,periodic boundary conditions
shift_origin--;
            shift_destination--;
            if (shift_destination < 0)
            {
                shift_destination += hop_config.Length;
            }
        }
        hop_config[shift_origin] -= 1;
        hop_config[shift_destination] += 1;
        // remove any gaps
        ii = 0;
        int jj;
        while (ii < hop_config.Length - 1)
        {
            if (hop_config[ii] == 0)
            {
                jj = ii + 1;
                while ((hop_config[jj] == 0) && (jj < hop_config.Length - 1))
                {
                    jj++;
                }
                if (jj < hop_config.Length)
                {
                    hop_config[ii] = hop_config[jj];
                    hop_config[jj] = 0;
                    ii = jj;
                }
                else
                {
                    ii = hop_config.Length - 1;
                }
            }
            else
            {
                ii++;
            }
        }
        return StepWaysRecursion(hop_config_cache, hop_config);
    }
}
public static int add_to_cache(List<int> hop_config_cache, int[] hop_config)
{
    // use base-4 representation cache
    int hop_config_int = 0;
    int b_scaling = 1;
    for (int ii = hop_config.Length - 1; ii >= 0; ii--)
    {
        hop_config_int += hop_config[ii] * b_scaling;
        b_scaling *= 4;
    }
    if (hop_config_cache.Contains(hop_config_int))
    {
        return 1;
    }
    else
    {
        hop_config_cache.Add(hop_config_int);
        return 0;
    }
}
static int _counter;
// For testing. Don't modify.
public static void Main(string[] args)
{
    Console.WriteLine("Sum 3 Numbers");
    int[] sumInput = new int[] { 1, 3, 5 };
    int sumExpected = 9;
    int sumResult = Sum(sumInput);
    Console.WriteLine("Expected: " + sumExpected.ToString());
    Console.WriteLine("Result: " + sumResult.ToString());
    Console.WriteLine((sumExpected == sumResult).ToString());
    Console.WriteLine();
    Console.WriteLine("Sum 5 Numbers");
    sumInput = new int[] { 1, 3, 5, 13, 0 };
    sumExpected = 22;
    sumResult = Sum(sumInput);
    Console.WriteLine("Expected: " + sumExpected.ToString());
    Console.WriteLine("Result: " + sumResult.ToString());
    Console.WriteLine((sumExpected == sumResult).ToString());
    Console.WriteLine();
    Console.WriteLine("Palindrome Tests");
    string palendromeInput = "enterprise";
    Console.WriteLine("Input: " + palendromeInput);
    Console.WriteLine(IsPalindrome(palendromeInput).ToString());
    Console.WriteLine();
    palendromeInput = "racecar";
    Console.WriteLine("Input: " + palendromeInput);
    Console.WriteLine(IsPalindrome(palendromeInput).ToString());
    Console.WriteLine();
    palendromeInput = "never odd or even";
    Console.WriteLine("Input: " + palendromeInput);
    Console.WriteLine(IsPalindrome(palendromeInput).ToString());
    Console.WriteLine();
    palendromeInput = "not a palindrome";
    Console.WriteLine("Input: " + palendromeInput);
    Console.WriteLine(IsPalindrome(palendromeInput).ToString());
    Console.WriteLine();
    Console.WriteLine("Stepways Tests");
    int stepwaysInput = 0;
    bool passed = false;
    Console.WriteLine("Input: " + stepwaysInput.ToString());
    Console.WriteLine(StepWays(stepwaysInput).ToString());
    if (StepWays(stepwaysInput) == 0) passed = true;
    Console.WriteLine(passed.ToString());
    Console.WriteLine();
    stepwaysInput = 4;
    passed = false;
    Console.WriteLine("Input: " + stepwaysInput.ToString());
    Console.WriteLine(StepWays(stepwaysInput).ToString());
    if (StepWays(stepwaysInput) == 7) passed = true;
    Console.WriteLine(passed.ToString());
    Console.WriteLine();
    stepwaysInput = 5;
    passed = false;
    Console.WriteLine("Input: " + stepwaysInput.ToString());
    Console.WriteLine(StepWays(stepwaysInput).ToString());
    if (StepWays(stepwaysInput) == 13) passed = true;
    Console.WriteLine(passed.ToString());
    Console.WriteLine();
    stepwaysInput = 15;
    passed = false;
    Console.WriteLine("Input: " + stepwaysInput.ToString());
    Console.WriteLine(StepWays(stepwaysInput).ToString());
    if (StepWays(stepwaysInput) == 5768) passed = true;
    Console.WriteLine(passed.ToString());
    Console.WriteLine();
}
}
