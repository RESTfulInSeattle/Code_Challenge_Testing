using System.IO;
using System;

namespace Code_Challenges.PracticeProblems
{
    public static class CountingValleys
    {
        // Complete the countingValleys function below.
        public static int CountingValleysFunction(int n, string s)
        {
            if (n != s.Length) return -1;
            int valleys = 0;
            int elevation = 0;

            for (int i = 0; i < n; i++)
            {
                if (s[i] == 'U')
                {
                    if(elevation == -1) valleys++;
                    elevation++;
                }
                else
                {
                    if (s[i] != 'D') return -1;
                    elevation--;
                }
            }

            return valleys;
        }
    }
}
