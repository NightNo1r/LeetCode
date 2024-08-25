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
    public IList<int> PostorderTraversal(TreeNode root)
    {
        if(root is null)
        {
            return [];
        }

        var list = new List<int>();
        TraveseRecursive(root, list);
        return list;
    }

    private void TraveseRecursive(TreeNode root, List<int> list)
    {
        if(root.left != null)
        {
            TraveseRecursive(root.left, list);
        }

        if(root.right != null)
        {
            TraveseRecursive(root.right, list);
        }

        list.Add(root.val);
    }
}