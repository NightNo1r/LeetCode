public class Solution {
    public string Convert(string s, int numRows) {
        if(s.Length <= numRows || numRows == 1)
            return s;
        var arr = new string[numRows];
        int i,step;
        i = step = 0;
        while(i<s.Length)
        {
            arr[step]+=s[i];
            if(step == numRows-1)
            {
                while(step > 0 && i < s.Length-1)
                {
                    --step;
                    ++i;
                    arr[step]+=s[i];
                }
            }
            ++step;
            ++i;
        }
        return string.Join("",arr);
    }
}