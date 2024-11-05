using System;

namespace LeetCode.Problems
{
    public enum Status
    {
        Completed,
        Incomplete
    }
    /// <summary>
    /// leetcode problem attribute
    /// </summary>
    [AttributeUsage(AttributeTargets.Method, Inherited = false, AllowMultiple = false)]
    public sealed class LeetCodeAttribute : Attribute
    {
        public readonly uint Value;
        public readonly Status Status;
        public LeetCodeAttribute(uint value, Status status = Status.Incomplete)
        {
            Value = value;
            Status = status;
        }
    }

}
