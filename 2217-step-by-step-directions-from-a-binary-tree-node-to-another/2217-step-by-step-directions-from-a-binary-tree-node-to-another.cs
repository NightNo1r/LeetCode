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
    public string GetDirections(TreeNode root, int startValue, int destValue)
    {
        var pathToStart = GetDirection(root, startValue);
        var pathToDest = GetDirection(root, destValue);

        var diffIndex = 0;
        while(true)
        {
            if(diffIndex == pathToStart.Count)
            {
                break;
            }

            if(diffIndex == pathToDest.Count)
            {
                break;
            }

            if(pathToStart[diffIndex] != pathToDest[diffIndex])
            {
                break;
            }
            
            diffIndex++;
        }

        var wayFromStartToRoot = new string('U', pathToStart.Count - diffIndex);
        if(diffIndex == pathToDest.Count)
        {
            return wayFromStartToRoot;
        }

        var wayFromRootToDest = 
System.Runtime.InteropServices.CollectionsMarshal.AsSpan(pathToDest)[diffIndex..]; 
        if(diffIndex == pathToStart.Count)
        {
            return new string(wayFromRootToDest);
        }

        return $"{wayFromStartToRoot}{wayFromRootToDest}";
    }

    public List<char> GetDirection(TreeNode root, int target)
    {
        var way = new List<char>();
        if(root.val != target)
        {
            GetDirectionRecursive(root, target, way);
        }

        return way;
    }

    public bool GetDirectionRecursive(TreeNode root, int target, List<char> way)
    {
        if(root is null)
        {
            return false;
        }

        if(root.val == target)
        {
            return true;
        }

        way.Add('L');
        var leftIsNeeded = GetDirectionRecursive(root.left, target, way);
        if(leftIsNeeded)
        {
            return true;
        }

        way.RemoveAt(way.Count - 1);

        way.Add('R');
        var rightIsNeeded = GetDirectionRecursive(root.right, target, way);
        if(rightIsNeeded)
        {
            return true;
        }

        way.RemoveAt(way.Count - 1);
        return false;
    }
}