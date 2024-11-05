using System;

namespace LeetCode.Problems
{
    public enum Status
    {
        Completed,
        Incomplete
    }
    [Flags]
    public enum Tag
    {
        None,
        Sort,
        Greedy,
        DP,
        Math
    }
    /// <summary>
    /// leetcode problem attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public sealed class LeetCodeAttribute : Attribute
    {
        public LeetCodeAttribute(uint value, Status status = Status.Incomplete, Tag tag = Tag.None)
        {
        }
    }

}
