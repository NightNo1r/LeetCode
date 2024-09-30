public class Solution {
    public bool WordPattern(string pattern, string s)
    {
        var map = new Dictionary<char, string>();
        var words = s.Split(' ');
        if(words.Length != pattern.Length)
        {
            return false;
        }
        for(var i = 0; i < pattern.Length; i++)
        {
            if(!map.ContainsKey(pattern[i]))
            {
                if(map.ContainsValue(words[i]))
                {
                    return false;
                }

                map.Add(pattern[i], words[i]);
                continue;
            }

            if(map[pattern[i]] != words[i])
            {
                return false;
            }
        }

        return true;
    }
}