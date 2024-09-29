public class Solution {
    public bool CanConstruct(string ransomNote, string magazine)
    {
        var arr = new int[26];
        foreach(var ch in magazine)
        {
            arr[ch-'a']++;
        }

        foreach(var ch in ransomNote)
        {
            arr[ch-'a']--;
        }

        foreach(var num in arr)
        {
            if(num < 0)
            {
                return false;
            }
        }

        return true;
    }
}