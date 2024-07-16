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

        Console.WriteLine($"{pathToStart} -- {pathToDest}");

        var diffIndex = 0;
        while(true)
        {
            if(diffIndex == pathToStart.Length)
            {
                break;
            }

            if(diffIndex == pathToDest.Length)
            {
                break;
            }

            if(pathToStart[diffIndex] == pathToDest[diffIndex])
            {
                diffIndex++;
            }
            else
            {
                break;
            }
        }

        Console.WriteLine($"{diffIndex}");

        var wayFromStartToRoot = new string('U', pathToStart.Length - diffIndex);
        if(diffIndex == pathToDest.Length)
        {
            return wayFromStartToRoot;
        }

        var wayFromRootToDest = pathToDest.AsSpan()[diffIndex..]; 
        if(diffIndex == pathToStart.Length)
        {
            return new string(pathToDest.AsSpan()[diffIndex..]);
        }

        return $"{wayFromStartToRoot}{wayFromRootToDest}";
    }

    public string GetDirection(TreeNode root, int target)
    {
        if(root.val == target)
        {
            return string.Empty;
        }

        var way = new Stack<char>();
        GetDirectionRecursive(root, target, way);
        return new string(way.Reverse().ToArray());
    }

    public bool GetDirectionRecursive(TreeNode root, int target, Stack<char> way)
    {
        if(root is null)
        {
            return false;
        }

        if(root.val == target)
        {
            return true;
        }

        way.Push('L');
        var leftIsNeeded = GetDirectionRecursive(root.left, target, way);
        if(leftIsNeeded)
        {
            return true;
        }

        way.Pop();

        way.Push('R');
        var rightIsNeeded = GetDirectionRecursive(root.right, target, way);
        if(rightIsNeeded)
        {
            return true;
        }

        way.Pop();
        return false;
    }
}