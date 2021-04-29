using System.Text.RegularExpressions;
public class Solution {
    public int MyAtoi(string s) {
        Regex num = new Regex(@"^\s*([-+]?\d+)");
        var group = num.Match(s).Groups[1];
        if(group.Value.Length > 0)
        {
            int value;
            if(!Int32.TryParse(group.Value,out value) && group.Value[0] != '-')
                return Int32.MaxValue;
            else if (Int32.TryParse(group.Value,out value))
                return value;
            else
                return Int32.MinValue;
        }
        return 0;
    }
}