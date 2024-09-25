public class Solution {
    public int AccountBalanceAfterPurchase(int purchaseAmount)
    {
        purchaseAmount = purchaseAmount % 10 >= 5 ? (purchaseAmount/10+1)*10 : (purchaseAmount/10)*10;
        return 100 - purchaseAmount;
    }
}