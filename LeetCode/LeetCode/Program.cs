using System;
using LeetCode.DataDefintions;
#region Problems
using static LeetCode.Problems.Problem.Unsorted;
using static LeetCode.Problems.Problem.DP;
using System.Collections.Generic;
using System.Reflection;
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
                [LeetCodeComment("impossible. need rewrite")]
                [LeetCodeComment("Console.WriteLine(sum) works tho")]
                [LeetCode(2, Status.Incomplete)]
                public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
                {
                    //defualt 
                    //var a1 = new ListNode(9, null);
                    //var a2 = new ListNode(9, a1);
                    //var a3 = new ListNode(9, a2);
                    //var a4 = new ListNode(9, a3);
                    //var a5 = new ListNode(9, a4);
                    //var a6 = new ListNode(9, a5);
                    //var a7 = new ListNode(9, a6);

                    //var b1 = new ListNode(9, null);
                    //var b2 = new ListNode(9, b1);
                    //var b3 = new ListNode(9, b2);
                    //var b4 = new ListNode(9, b3);
                    //var result = AddTwoNumbers(a7, b4);
                    //Console.WriteLine(result);



                    ListNode last = null;
                    ListNode result = last;
                    static void F(ListNode l1, ListNode l2, int additinoal)
                    {
                        if (l1 == null && l2 == null && additinoal == 0) return;
                        int l1Val = l1 == null ? 0 : l1.val;
                        int l2Val = l2 == null ? 0 : l2.val;
                        int sum = additinoal + l1Val + l2Val;
                        int resultAdditinoal = 0;
                        if (sum > 9)
                        {
                            int oneDigit = sum % 10;
                            resultAdditinoal = (sum - oneDigit) / 10;
                            sum = oneDigit;
                        }
                        //ListNode cur = new(sum);
                        //if (last != null)
                        //    last.next = cur;
                        //last = cur;
                        F(l1?.next, l2?.next, resultAdditinoal);
                    }
                    F(l1, l2, 0);
                    return result;
                }

                [LeetCode(1, Status.Complete)]
                public static int[] TwoSum(int[] nums, int target)
                {
                    //two pass hashtable O(n)
                    //Dictionary<int, int> dictionary = new();// value, idx
                    //int len = nums.Length;
                    //for (int i = 0; i < len; i++)
                    //{
                    //    dictionary[nums[i]] = i;
                    //}
                    //for (int i = 0; i < len; i++)
                    //{
                    //    int targetValue = target - nums[i];
                    //    if (dictionary.TryGetValue(targetValue, out int complementIdx) && complementIdx != i)
                    //    {
                    //        int[] result = new int[2];
                    //        result[0] = i;
                    //        result[1] = complementIdx;
                    //        return result;
                    //    }
                    //}
                    //return Array.Empty<int>();

                    //one pass hashtable O(n)
                    Dictionary<int, int> dictionary = new();// value, idx
                    int len = nums.Length;
                    for (int i = 0; i < len; i++)
                    {
                        int targetValue = target - nums[i];
                        if (dictionary.TryGetValue(targetValue, out int complementIdx) && complementIdx != i)
                        {
                            int[] result = new int[2];
                            result[0] = i;
                            result[1] = complementIdx;
                            return result;
                        }
                        dictionary[nums[i]] = i;
                    }
                    return Array.Empty<int>();

                    //brute force way O(n^2)
                    //int len = nums.Length;
                    //for (int i = 0; i < len - 1; i++)
                    //{
                    //    int targetValue = target - nums[i];
                    //    for (int j = i + 1; j < len; j++)
                    //    {
                    //        if (targetValue == nums[j])
                    //        {
                    //            int[] result = new int[2];
                    //            result[0] = i;
                    //            result[1] = j;
                    //            return result;
                    //        }
                    //    }
                    //}
                    //return Array.Empty<int>();
                }

                [LeetCode(121, Status.Complete_ButNotInAllWays, tag: Topic.DP | Topic.Array, CompletedWith: Topic.Array)]
                public static int MaxProfit(int[] prices)
                {
                    //brute force
                    //O(n^2)
                    //causes time limit on really large array of price
                    int pricesLength = prices.Length;
                    int profit = 0;
                    for (int i = 0; i < pricesLength - 1; i++)
                    {
                        int currentDayPrice = prices[i];
                        for (int j = i + 1; j < pricesLength; j++)
                        {
                            int distance = prices[j] - currentDayPrice;
                            if (distance > profit)
                                profit = distance;
                        }
                    }
                    return profit;
                    //dp
                }

                [LeetCode(20, Status.Incomplete)]
                public static bool IsValid(string s)
                {
                    Stack<char> charStack = new();
                    int length = s.Length;
                    for (int i = 0; i < length; i++)
                    {
                        char currentChar = s[i];
                        if (charStack.TryPeek(out char currentStackChar))
                        {
                            char GetTargetChar() => currentStackChar switch
                            {
                                '(' => ')',
                                '[' => ']',
                                '{' => '}',
                                _ => throw new NotImplementedException()
                            };
                            char targetChar = GetTargetChar();
                            if (currentChar == targetChar)
                                charStack.Pop();

                        }

                        if (currentChar == '(' || currentChar == '[' || currentChar == '{')
                            charStack.Push(currentChar);
                    }
                    return charStack.Count == 0;
                }

            }

        }
    }
    public class Program
    {
        public static bool IsProblemExists(uint number)
        {
            Console.WriteLine($"Checking {number}");
            bool found = false;
            void CheckStaticMethods(Type type)
            {
                MethodInfo[] methods = type.GetMethods(BindingFlags.Public | BindingFlags.Static);

                Console.WriteLine($"-Methods in {type.Name}-");
                foreach (MethodInfo method in methods)
                {
                    LeetCodeAttribute attribute = method.GetCustomAttribute<LeetCodeAttribute>();
                    if (attribute != null)
                    {
                        uint probleNumber = attribute.ProblemNumber;
                        uint problemNumberTemp = probleNumber;
                        string resultProblemNumber = string.Empty;
                        for (int i = 0; i < 5; i++)
                        {
                            if ((problemNumberTemp /= 10) <= 0)
                            {
                                for (int j = 0; j < 4 - i; j++)
                                {
                                    resultProblemNumber += "_";
                                }
                                resultProblemNumber += probleNumber;
                                break;
                            }
                        }
                        Console.Write($" {resultProblemNumber} ");
                        if (probleNumber == number) found = true;
                    }
                    else
                    {
                        Console.WriteLine("[WARNING] Function doesn't have LeetCodeAttribute!!");
                        Console.Write($"func name : ");
                    }
                    Console.WriteLine(method.Name);
                }

                Console.WriteLine();

                Type[] nestedTypes = type.GetNestedTypes(BindingFlags.Public | BindingFlags.Static);
                foreach (Type nestedType in nestedTypes)
                {
                    CheckStaticMethods(nestedType);
                }
            }
            Type problemType = typeof(Problems.Problem);
            CheckStaticMethods(problemType);
            return found;
        }
        public static void Main()
        {
            Console.WriteLine(IsProblemExists(121));
            //Console.WriteLine(MaxProfit(new int[] { 7, 6, 4, 3, 1 }));
            //Console.WriteLine(IsValid("]"));
            //static void InvokeWithProblemNumber(int number, params object[] @params)
            //{
            //
            //    //incomplete
            //}
        }
    }
}
