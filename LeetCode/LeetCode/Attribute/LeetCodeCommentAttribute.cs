using System;

[AttributeUsage(AttributeTargets.Method, AllowMultiple = true)]
public sealed class LeetCodeCommentAttribute : Attribute
{
    public LeetCodeCommentAttribute(string comment)
    {
    }
}