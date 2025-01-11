using System;

[AttributeUsage(AttributeTargets.Class, Inherited = false, AllowMultiple = false)]
public sealed class LeetCodeURLAttribute : Attribute
{
    public LeetCodeURLAttribute(string url)
    {
    }
}
