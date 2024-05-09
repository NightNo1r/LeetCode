public class Solution {
    public long MaximumHappinessSum(int[] happiness, int k)
    {
        var sum = 0L;
        Array.Sort(happiness, new ReverseComparer());

        for(var i = 0; i < k; i++)
        {
            sum += i < happiness[i] ? happiness[i] - i : 0;
        }
        
        return sum;
    }

    public class ReverseComparer : IComparer<int>
    {
        public int Compare(int left, int right) => right.CompareTo(left);
    }
}