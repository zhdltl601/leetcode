using System;

public enum Status
{
    Complete,
    Complete_ButNeedImprovement,
    Complete_ButNotInAllWays,
    Incomplete
}
[Flags]
public enum Topic
{
    None,
    Sort,
    Greedy,
    DP,
    Math,
    Array
}
/// <summary>
/// leetcode problem attribute
/// </summary>
[AttributeUsage(AttributeTargets.Method | AttributeTargets.Class | AttributeTargets.Struct
    , Inherited = false
    , AllowMultiple = false)]
public sealed class LeetCodeAttribute : Attribute
{
    public uint ProblemNumber { get; private set; }
    public LeetCodeAttribute(uint value, Status status, Topic tag = Topic.None, Topic CompletedWith = Topic.None)
    {
        ProblemNumber = value;
    }
}
