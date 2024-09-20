public class Solution {
    public string Reformat(string s)
    {
        var digits = new Queue<char>();
        var letters = new Queue<char>();
        foreach(var ch in s)
        {
            if(char.IsDigit(ch))
            {
                digits.Enqueue(ch);
            }
            else if(char.IsLetter(ch))
            {
                letters.Enqueue(ch);
            }
        }

        var subtr = digits.Count - letters.Count;

        if(subtr < -1 || subtr > 1)
        {
            return string.Empty;
        }

        var sb = new StringBuilder(s.Length);
        if(subtr == -1)
        {
            while(letters.Count > 0)
            {
                sb.Append(letters.Dequeue());
                
                if(digits.Count > 0)
                {
                    sb.Append(digits.Dequeue());
                }
            }
        }
        else
        {
            while(digits.Count > 0)
            {
                sb.Append(digits.Dequeue());
                
                if(letters.Count > 0)
                {
                    sb.Append(letters.Dequeue());
                }
            }
        }

        return sb.ToString();
    }
}