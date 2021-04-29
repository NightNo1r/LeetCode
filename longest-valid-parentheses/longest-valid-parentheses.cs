public class Solution {
    public int LongestValidParentheses(string s) 
    {
        int n = s.Length;
        Stack<int> stk = new Stack<int>();
        stk.Push(-1);
        int result = 0;
        for (int i = 0; i < n; i++)
        {
            if (s[i] == '(') 
                stk.Push(i);
            else
            {
                if (stk.Count > 0)
                    stk.Pop();
                if (stk.Count > 0)
                    result = Math.Max(result, i - stk.Peek());
                else 
                    stk.Push(i);
            }
        }
        return result;
    }
}