﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LeetCode
{
    namespace Problems
    {
        public static partial class Problems
        {
            public static partial class DP
            {
                [LeetCode(1143, Status.Complete)]
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
                [LeetCode(1143, Status.Incomplete)]
                public static int LengthOfLIS(int[] nums)
                {

                    return default;
                }
            }
        }
    }
}