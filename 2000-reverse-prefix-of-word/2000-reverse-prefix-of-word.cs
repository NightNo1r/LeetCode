public class Solution {
    public string ReversePrefix(string word, char ch)
    {
        var indexOfCh = word.IndexOf(ch);
        var wordSpan = word.AsSpan();

        if(indexOfCh == -1)
        {
            return word;
        }

        var sb = new StringBuilder(wordSpan.Length);
        for(var i = indexOfCh; i >= 0; i--)
        {
            sb.Append(wordSpan[i]);
        }

        for(var i = indexOfCh + 1; i < wordSpan.Length; i++)
        {
            sb.Append(wordSpan[i]);
        }

        return sb.ToString();
    }
}