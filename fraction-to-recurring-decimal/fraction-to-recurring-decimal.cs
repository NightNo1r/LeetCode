
public class Solution 
{
    public string FractionToDecimal(int numerator, int denominator) 
    {
        if(numerator == 0)
            return "0";
        StringBuilder ans = new StringBuilder();
        long lnumerator = Math.Abs((long)numerator);
        long ldenominator = Math.Abs((long)denominator);
        if(Math.Sign(numerator) * Math.Sign(denominator) < 0)
            ans.Insert(0,"-");
        ans.Append(lnumerator/ldenominator);
        lnumerator%=ldenominator;
        if(lnumerator == 0)
            return ans.ToString();
        ans.Append(".");
        var Numerators = new HashSet<long>();
        while(lnumerator != 0)
        {
            if(!Numerators.Add(lnumerator))
            {
                int count = 0;
                long presentnum = lnumerator;
                do
                {
                    count++;
                    lnumerator = (lnumerator * 10) % ldenominator;
                }
                while(presentnum != lnumerator);
                ans.Insert(ans.Length - count, "(");
                ans.Append(")");
                break;
            }
            lnumerator *= 10;
            ans.Append(lnumerator/ldenominator);
            lnumerator%=ldenominator;
        }
        return ans.ToString();
    }
}