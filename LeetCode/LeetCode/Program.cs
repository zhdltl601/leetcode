using System;
using LeetCode.DataDefintions;
#region Problems
using static LeetCode.Problems.Problems;
using static LeetCode.Problems.Problems.Unsorted;
using static LeetCode.Problems.Problems.DP;
#endregion
namespace LeetCode
{
    namespace Problems
    {
        public static partial class Problems
        {
            /// <summary>
            /// lists from Tags are all Unsorted
            /// </summary>
            public static partial class Unsorted
            {
                [LeetCode(42, Status.Incomplete)]
                public static int Trap(int[] height)
                {
                    //Span<int> arr = height;
                    return default;
                }

                [LeetCode(2, Status.Incomplete)]
                public static ListNode AddTwoNumbers(ListNode l1, ListNode l2)
                {
                    ListNode result = null;
                    void F(ListNode l1, ListNode l2, int additinoal)
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
                        Console.WriteLine(sum + " ");
                        //ListNode cur = default;
                        //cur.val = sum;
                        F(l1?.next, l2?.next, resultAdditinoal);
                    }
                    F(l1, l2, 0);
                    return result;
                }
                public static ListNode AddTwoNumbers2(ListNode l1, ListNode l2)
                {
                    ListNode result = new ListNode();
                    void F(ListNode l1, ListNode l2, int additinoal)
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

                        Console.WriteLine(sum + " ");



                        F(l1?.next, l2?.next, resultAdditinoal);
                    }

                    F(l1, l2, 0);
                    return result;
                }
            }
        }
    }
    public class Program
    {
        public static void Main()
        {
            void C2()
            {
                //var a1 = new ListNode(9, null);
                //var a2 = new ListNode(9, a1);
                //var a3 = new ListNode(9, a2);
                //var a4 = new ListNode(9, a3);
                //var a5 = new ListNode(9, a4);
                //var a6 = new ListNode(9, a5);
                //var a7 = new ListNode(9, a6);
                //
                //var b1 = new ListNode(9, null);
                //var b2 = new ListNode(9, b1);
                //var b3 = new ListNode(9, b2);
                //var b4 = new ListNode(9, b3);
                //
                //var result = AddTwoNumbers(a7, b4);
                //Console.WriteLine(result);
            }

            //static void InvokeWithProblemNumber(int number, params object[] @params)
            //{
            //
            //    //incomplete
            //}
        }
    }
}
