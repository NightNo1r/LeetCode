public class Solution {
    public bool IsPalindrome(int x) {
        if(x.ToString() == string.Join("",x.ToString().Reverse()))
            return true;
        return false;
    }
}