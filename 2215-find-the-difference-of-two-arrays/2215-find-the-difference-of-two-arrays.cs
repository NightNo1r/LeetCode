public class Solution {
    public IList<IList<int>> FindDifference(int[] nums1, int[] nums2)
    {
        const int deviation = 1000;
        var nums1Frequency = new int[2001];
        var nums2Frequency = new int[2001];

        for(var i = 0; i < nums1.Length; i++)
        {
            nums1Frequency[nums1[i]+deviation]++;
        }

        for(var i = 0; i < nums2.Length; i++)
        {
            nums2Frequency[nums2[i]+deviation]++;
        }

        var result = new List<IList<int>>(2);
        result.Add(new List<int>());
        result.Add(new List<int>());

        for(var i = 0; i < nums1Frequency.Length; i++)
        {
            if(nums1Frequency[i] > 0 && nums2Frequency[i] == 0)
            {
                result[0].Add(i-deviation);
            }
            else if(nums2Frequency[i] > 0 && nums1Frequency[i] == 0)
            {
                result[1].Add(i-deviation);
            }
        }

        return result;
    }
}