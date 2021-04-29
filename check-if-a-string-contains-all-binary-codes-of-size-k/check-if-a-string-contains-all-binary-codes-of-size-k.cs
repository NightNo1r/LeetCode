public class Solution {
    public bool HasAllCodes(string s, int k) {
        var result = new HashSet<string>();  
        for(int i = 0; i + k <= s.Length; i++)  
            result.Add(s.Substring(i, k));
        return result.Count() == (1<<k);
    }
}