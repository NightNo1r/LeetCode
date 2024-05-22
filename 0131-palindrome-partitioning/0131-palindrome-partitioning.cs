public class Solution {
    public IList<IList<string>> Partition(string s)
    {
        var palindromePartitions = new List<IList<string>>();
        var currentSequence = new List<string>();
        Dfs(s, 0, palindromePartitions, currentSequence);

        return palindromePartitions;
    }

    public void Dfs(
        string s,
        int currentIndex,
        List<IList<string>> result,
        List<string> currentSequence)
    {
        if(currentIndex >= s.Length)
        {
            result.Add(currentSequence.ToList());
        }

        for(var i = currentIndex; i < s.Length; i++)
        {
            if(IsPalindrome(s, currentIndex, i))
            {
                currentSequence.Add(s.Substring(currentIndex, i - currentIndex + 1));
                Dfs(s, i + 1, result, currentSequence);
                currentSequence.RemoveAt(currentSequence.Count - 1);
            }
        }
    }

    public bool IsPalindrome(string s, int start, int end)
    {
        var span = s.AsSpan();
        while(start <= end)
        {
            if(span[start] != span[end])
            {
                return false;
            }

            start++;
            end--;
        }
        return true;
    }
}