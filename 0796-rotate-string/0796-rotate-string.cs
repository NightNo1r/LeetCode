public class Solution {
    public bool RotateString(string s, string goal)
    {
        if(s.Length != goal.Length)
        {
            return false;
        }

        var doubledS = s + s;
        return doubledS.Contains(goal);
    }
}