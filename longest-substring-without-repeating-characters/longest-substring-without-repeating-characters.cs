public class Solution {
    public int LengthOfLongestSubstring(string s) {
        var dist = s.Distinct();
        if (dist.Count() == 1 || dist.Count() == 2)
            return dist.Count();
        int maxans = 0;
        for(int i=0; i<s.Length;i++)
        {
            var temp = dist.ToList();
            int ans = 0;
            for(int j=i;j<s.Length;j++)
            {
                if(temp.Contains(s[j]))
                {
                    ans++;
                    temp.Remove(s[j]);
                }
                else break;
            }
            if (maxans < ans)
                maxans = ans;
            if (ans == dist.Count())
                return ans;
        }
        return maxans;
    }
}