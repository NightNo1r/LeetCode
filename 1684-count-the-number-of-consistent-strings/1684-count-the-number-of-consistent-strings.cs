public class Solution {
    public int CountConsistentStrings(string allowed, string[] words)
    {
        var result = 0;
        var allowedArr = new bool[26];
        foreach(var ch in allowed)
        {
            allowedArr[ch-'a'] = true;
        }

        foreach(var word in words)
        {
            var wordIsConsistent = true;
            for(var i = 0; i < word.Length; i++)
            {
                if(!allowedArr[word[i]-'a'])
                {
                    wordIsConsistent = false;
                    break;
                }
            }

            if(wordIsConsistent)
            {
                result++;
            }
        }

        return result;
    }
}