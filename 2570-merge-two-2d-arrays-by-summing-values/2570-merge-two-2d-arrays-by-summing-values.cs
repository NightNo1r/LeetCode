public class Solution {
    public int[][] MergeArrays(int[][] nums1, int[][] nums2)
    {
        var result = new List<int[]>();
        var nums1Index = 0;
        var nums2Index = 0;
        while(nums1Index < nums1.Length &&
              nums2Index < nums2.Length)
        {
            if(nums1[nums1Index][0] == nums2[nums2Index][0])
            {
                result.Add(new int[] { nums1[nums1Index][0], nums1[nums1Index][1] + nums2[nums2Index][1] });
                nums1Index++;
                nums2Index++;
                continue;
            }

            if(nums1[nums1Index][0] < nums2[nums2Index][0])
            {
                result.Add(nums1[nums1Index]);
                nums1Index++;
                continue;
            }

            if(nums1[nums1Index][0] > nums2[nums2Index][0])
            {
                result.Add(nums2[nums2Index]);
                nums2Index++;
            }
        }

        for(var i = nums1Index; i < nums1.Length; i++)
        {
            result.Add(nums1[i]);
        }
        
        for(var i = nums2Index; i < nums2.Length; i++)
        {
            result.Add(nums2[i]);
        }

        return result.ToArray();
    }
}