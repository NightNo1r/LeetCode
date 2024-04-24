public class Solution {
    public int Tribonacci(int n)
    {
        var first = 0;
        var second = 1;
        var third = 1;

        for(var i = 2; i < n; i++)
        {
            var sum = first + second + third;
            first = second;
            second = third;
            third = sum;
        }

        return n == 0 ? 0 : third;
    }
}