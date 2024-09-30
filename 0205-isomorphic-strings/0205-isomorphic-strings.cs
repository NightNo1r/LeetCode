public class Solution {
    public bool IsIsomorphic(string s, string t)
    {
        var alphabet = new char[256];
        var occurrences = new bool[256];
        for(var i = 0; i < s.Length; i++)
        {
            if(alphabet[s[i]] != default &&
               alphabet[s[i]] != t[i])
            {
                return false;
            }

            if(alphabet[s[i]] == t[i])
            {
                continue;
            }

            if(occurrences[t[i]] == true)
            {
                return false;
            }
            occurrences[t[i]] = true;
            
            alphabet[s[i]] = t[i];
        }

        return true;
    }
}