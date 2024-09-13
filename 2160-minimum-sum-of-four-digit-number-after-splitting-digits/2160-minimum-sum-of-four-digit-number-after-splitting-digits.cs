public class Solution {
    public int MinimumSum(int num)
    {
        var arr = new int[4]
        {
            num / 1000,
            (num / 100) % 10,
            (num / 10) % 10,
            num % 10,
        };

        Array.Sort(arr);

        var firstNum = (arr[0] * 10) + arr[3];
        var secondNum = (arr[1] * 10) + arr[2];

        return firstNum + secondNum;
    }
}