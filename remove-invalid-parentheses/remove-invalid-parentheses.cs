public class Solution 
{
    HashSet<string> Hash = new HashSet<string>();
    HashSet<string> Visited = new HashSet<string>();
    public IList<string> RemoveInvalidParentheses(string s) 
    {
        int left = 0, right = 0, len = s.Length;
        for(int i=0;i<len;i++)
        {
            if(s[i] == '(')
                left++;
            else if (s[i] == ')')
            {
                if(left > 0)
                    left--;
                else 
                    right++;
            }
        }
        if(left+right == len)
            return new List<string>(){""};
        Helper(s,left,right);
        return Hash.ToList();
    }
    
    public void Helper(string s, int left, int right)
    {
        if(!Visited.Add(s))
            return;
        if(left == 0 && right == 0)
        {
            if(!Hash.Contains(s) && Valid(s))
                Hash.Add(s);
            return;
        }
        if(left > 0)
        {
            int index = s.IndexOf('(');
            while(index != -1)
            {
                Helper(s.Remove(index,1),left - 1,right);
                index = s.IndexOf('(',index+1);
            }
        }
        if(right > 0)
        {
            int index = s.IndexOf(')');
            while(index != -1)
            {
                Helper(s.Remove(index,1),left,right - 1);
                index = s.IndexOf(')',index+1);
            }
        }
        return;
    }
    
    public bool Valid(string s)
    {
        int left = 0, len = s.Length;
        for(int i=0;i<len;i++)
        {
            if(s[i] == '(')
                left++;
            else if (s[i] == ')')
            {
                if(left > 0)
                    left--;
                else 
                    return false;
            }
        }
        return left == 0;
    }
}