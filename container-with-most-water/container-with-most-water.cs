public class Solution {
    public int MaxArea(int[] height) {
        int max = 0;
        int left, right;
        left = 0; right = height.Length - 1;
        while(left < right)
        {
            if(Math.Min(height[left],height[right])*(right-left) > max)
                max = Math.Min(height[left],height[right])*(right-left);
            if (height[left]<=height[right])
                ++left;
            else --right;
            
        }
        return max;
    }
}