/**
 * Definition for a binary tree node.
 * public class TreeNode {
 *     public int val;
 *     public TreeNode left;
 *     public TreeNode right;
 *     public TreeNode(int val=0, TreeNode left=null, TreeNode right=null) {
 *         this.val = val;
 *         this.left = left;
 *         this.right = right;
 *     }
 * }
 */
public class Solution {
    public TreeNode RemoveLeafNodes(TreeNode root, int target)
    {
        var rootShouldBeRemoved = CheckNeedToRemoveRecursive(root, target);

        return rootShouldBeRemoved ? null : root;
    }

    public bool CheckNeedToRemoveRecursive(TreeNode root, int target)
    {
        if(root is null)
        {
            return true;
        }

        var leftShouldBeRemoved = CheckNeedToRemoveRecursive(root.left, target);
        if(leftShouldBeRemoved)
        {
            root.left = null;
        }

        var rightShouldBeRemoved = CheckNeedToRemoveRecursive(root.right, target);
        if(rightShouldBeRemoved)
        {
            root.right = null;
        }

        return leftShouldBeRemoved && rightShouldBeRemoved && root.val == target;
    }
}