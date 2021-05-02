public class Solution {
    public bool CheckInclusion(string s1, string s2) 
    {
        var arr = new int[26];
        foreach(var ch in s1)
            arr[ch-'a']+=1;
        int start = 0, end = 0, need = s1.Length, N1 = s1.Length, N2 = s2.Length;
        for (end = 0; end < N2; end++) {
            if (end - start >= N1) 
            {
                arr[s2[start] - 'a'] += 1;
                if (arr[s2[start] - 'a'] > 0) 
                    need++;
                start++;
            }
            arr[s2[end] - 'a'] -= 1;
            if (arr[s2[end] - 'a'] >= 0) 
            {
                need--;
                if (need == 0)
                    return true;
            }
        }
        return false;
    }
}