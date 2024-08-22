public class Solution {
    public int FindComplement(int num)
    {
        var bitsCount = GetBitsCount(num);
        int mask = (1 << bitsCount) - 1;
        return num ^ mask;
    }

    private byte GetBitsCount(int num)
    {
        byte ans = 0;
        while(num != 0)
        {
            num >>= 1;
            ans++;
        }

        return ans;
    }
}