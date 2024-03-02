using TreeNode = BinaryTree.TreeNode<int>;

namespace Solution;

public static class Solution
{
    public static int SumOfLeftLeaves(TreeNode root)
    {
        return LeftLeavesSum(root, 0);
    }

    private static int LeftLeavesSum(TreeNode? node, int sum)
    {
        if (node is null) return 0;
        var left = node.left switch
        {
            null => 0,
            _ when node.left.left is null && node.left.right is null => node.left.val,
            _ => LeftLeavesSum(node.left, sum)
        };
        var right = LeftLeavesSum(node.right, sum);
        return left + right + sum;
    }
}
