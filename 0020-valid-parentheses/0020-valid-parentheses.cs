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

            var neededOpeningBracket = GetOpeningBracketFor(ch);
            var actualOpeningBracket = parentheses.Pop();

            if(neededOpeningBracket != actualOpeningBracket)
            {
                return false;
            }
        }

        return true;
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