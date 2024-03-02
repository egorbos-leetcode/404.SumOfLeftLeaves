using BinaryTree;

namespace Solution.Tests;

public class UnitTest
{
    [Fact]
    public void Test()
    {
#pragma warning disable CS8604 // Possible null reference argument.
        Assert.Equal(4, Solution.SumOfLeftLeaves(TreeNode.BuildTree<int>([1, 2, 3, 4, 5])));
        Assert.Equal(24, Solution.SumOfLeftLeaves(TreeNode.BuildTree<int>([3, 9, 20, null, null, 15, 7]))); 
        Assert.Equal(0, Solution.SumOfLeftLeaves(TreeNode.BuildTree<int>([1])));
#pragma warning restore CS8604 // Possible null reference argument.
    }
}