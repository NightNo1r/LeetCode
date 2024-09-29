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
            var index = ch-'a';
            if(arr[index] == 0)
            {
                return false;
            }

            arr[index]--;
        }

        foreach(var num in arr)
        {
            
        }

        return true;
    }
}