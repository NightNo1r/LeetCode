public class Solution {
    public string RemoveOuterParentheses(string s)
    {
        if(string.IsNullOrEmpty(s))
        {
            return s;
        }

        var parentheses = new Stack<char>();
        parentheses.Push(s[0]);
        var sb = new StringBuilder();
        var i = 1;
        do
        {
            if(s[i] == '(')
            {
                parentheses.Push(s[i]);
                if(parentheses.Count > 1)
                {
                    sb.Append(s[i]);
                }
            }
            else
            {
                parentheses.Pop();
                if(parentheses.Count != 0)
                {
                    sb.Append(')');
                }
            }
            
            i++;
        } while(i < s.Length);
        
        return sb.ToString();
    }
}