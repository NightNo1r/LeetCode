public class Solution {
    public bool IsHappy(int n)
    {
        var numbers = new HashSet<int>();
        while(true)
        {
            var newValue = GetDigitsSquareSum(n);
            if(newValue == 1)
            {
                break;
            }

            if(!numbers.Add(newValue))
            {
                return false;
            }

            n = newValue;
        }

        return true;
    }

    private int GetDigitsSquareSum(int initialValue)
    {
        var sum = 0;
        while(initialValue > 0)
        {
            var lastDigit = initialValue % 10;
            sum += lastDigit * lastDigit;
            initialValue /= 10;
        }

        return sum;
    }
}