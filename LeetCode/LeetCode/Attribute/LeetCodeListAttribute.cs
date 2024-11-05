using System;

namespace LeetCode.Problems
{
    [AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
    sealed class LeetCodeListAttribute : Attribute
    {
        public LeetCodeListAttribute(string url)
        {
        }
    }
}
