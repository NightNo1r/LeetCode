public class Solution {
    public string LongestPalindrome(string s) 
    {
        string pal = s;
        for(int i=0;i<s.Length;i++)
        {
            for(int j=0;j<s.Length-i;j++)
            {
                if (IsPalindrome(s.Substring(j,i+1)))
                {
                    pal = s.Substring(j,i+1);
                    break;
                }
                    
            }
        }   
        return pal;
    }
    public bool IsPalindrome(string str)
    {
        for(int i=0;i<str.Length;i++)
            if(str[i]!=str[^(i+1)])
                return false;
        return true;
    }
}