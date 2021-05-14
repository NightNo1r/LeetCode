public class Solution 
{
    public IList<bool> KidsWithCandies(int[] candies, int extraCandies) 
    {
        var Bools = new List<bool>();
        for(int i=0;i<candies.Length;i++)
                Bools.Add(candies[i] + extraCandies >= candies.Max());
        return Bools;
    }
}