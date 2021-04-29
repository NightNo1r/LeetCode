public class Solution {
    public string LongestCommonPrefix(string[] strs) {
        if (strs.Length == 0)
            return "";
        int slice = 1;
        var minl = strs.Min(x => x.Length);
        var minstr = strs.FirstOrDefault(x => x.Length == minl);
        while(slice <= minl)
        {
            for(int i=0; i<strs.Length;i++)
            {
                if(minstr.Substring(0,slice) != strs[i].Substring(0,slice))
                {
                    return minstr.Substring(0,slice-1);
                }
            }
            slice++;
        }
        return minstr;
    }
}