public class Solution {
    public int Reverse(int x) {
        try
        {
            if (x < 0)
                return -Convert.ToInt32(string.Join("",(-x).ToString().Reverse()));
            return Convert.ToInt32(string.Join("",x.ToString().Reverse()));
        }
        catch (Exception)
        {
            return 0;
        }
        
    }
}