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
    public IList<string> BinaryTreePaths(TreeNode root)
    {
        var currentPath = new LinkedList<int>();
        var allPaths = new List<string>();
        AddPathRecursively(root, currentPath, allPaths);

        return allPaths;
    }

    private void AddPathRecursively(
        TreeNode root,
        LinkedList<int> currentPath,
        List<string> allPaths)
    {
        if(root == null)
        {
            return;
        }

        currentPath.AddLast(root.val);

        if(root.left != null)
        {
            AddPathRecursively(root.left, currentPath, allPaths);
        }

        if(root.right != null)
        {
            AddPathRecursively(root.right, currentPath, allPaths);
        }

        if(root.left == null &&
           root.right == null)
        {
            allPaths.Add(string.Join("->", currentPath));
        }

        currentPath.RemoveLast();
    }
}