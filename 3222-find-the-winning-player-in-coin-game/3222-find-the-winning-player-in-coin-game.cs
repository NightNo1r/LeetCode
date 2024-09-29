public class Solution {
    public string LosingPlayer(int x, int y)
    {
        var turns = Math.Min(x, y/4);

        return turns % 2 == 0 ? "Bob" : "Alice";
    }
}