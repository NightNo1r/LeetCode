public class Solution {
    public int NumWaterBottles(int numBottles, int numExchange)
    {
        var sum = numBottles;

        while(numBottles >= numExchange)
        {
            var remainder = numBottles % numExchange;

            numBottles /= numExchange;
            sum += numBottles;

            numBottles += remainder;
        }

        return sum;
    }
}