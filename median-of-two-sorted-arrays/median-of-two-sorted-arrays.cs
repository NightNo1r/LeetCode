public class Solution {
    public double FindMedianSortedArrays(int[] nums1, int[] nums2) {
        var list = new List<int>(nums1);
        list.AddRange(nums2);
        list.Sort();
        if ((list.Count & 1) == 1)
            return list[list.Count/2];
        else return 0.5*(list[list.Count/2-1]+list[list.Count/2]);
    }
}