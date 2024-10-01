public class Solution {
    public bool IsAnagram(string s, string t)
    {
        if(s.Length != t.Length)
        {
            return false;
        }

        var letters = new int[26];
        for(var i = 0; i < s.Length; i++)
        {
            letters[s[i]-'a']++;
            letters[t[i]-'a']--;
        }

        foreach(var cnt in letters)
        {
            if(cnt < 0)
            {
                return false;
            }
        }

        return true;
    }
}