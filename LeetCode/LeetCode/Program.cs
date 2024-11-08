﻿using System;
#region Problems
using static LeetCode.Problems.Problem;
using static LeetCode.Problems.Problem.Unsorted;
using static LeetCode.Problems.Problem.MonotonicStack;
#endregion
namespace LeetCode
{
    namespace Problems
    {
        public static partial class Problem
        {
            /// <summary>
            /// lists from Tags are all Unsorted
            /// </summary>
            public static partial class Unsorted
            {
                [LeetCode(1143, Status.Completed)]
                public static int LongestCommonSubsequence(string text1, string text2)
                {
                    int n = text1.Length;
                    int m = text2.Length;
                    int[,] dp = new int[n + 1, m + 1];
                    for (int i = 1; i <= n; i++)
                    {
                        for (int j = 1; j <= m; j++)
                        {
                            if (text1[i - 1] == text2[j - 1])
                            {
                                dp[i, j] = dp[i - 1, j - 1] + 1;
                            }
                            else
                            {
                                dp[i, j] = Math.Max(dp[i - 1, j], dp[i, j - 1]);
                            }
                        }
                    }
                    return dp[n, m];
                }

                [LeetCode(42, Status.Incomplete)]
                public static int Trap(int[] height)
                {
                    return default;
                }
            }
        }
    }
    public class Program
    {
        public static void Main()
        {
            static void InvokeWithProblemNumber(int number, params object[] @params)
            {

                //incomplete
            }

        }
    }
}
