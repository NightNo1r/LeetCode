public class Solution {
    public bool IsValid(string s)
    {
        var parentheses = new Stack<char>();

        foreach(var ch in s)
        {
            if(ch == '(' ||
               ch == '[' ||
               ch == '{')
            {
                parentheses.Push(ch);
                continue;
            }

            if(parentheses.Count == 0)
            {
                return false;
            }

            var neededOpeningBracket = GetOpeningBracketFor(ch);
            var actualOpeningBracket = parentheses.Pop();

            if(neededOpeningBracket != actualOpeningBracket)
            {
                return false;
            }
        }

        return parentheses.Count == 0;
    }

    private char GetOpeningBracketFor(char closingBracket) =>
        closingBracket switch
        {
            ')' => '(',
            ']' => '[',
            '}' => '{',
            _ => throw new ArgumentOutOfRangeException(nameof(closingBracket)),
        };
}