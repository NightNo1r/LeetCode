public class Solution {
    public string MaximumTime(string time)
    {
        var sb = new StringBuilder(time);
        if(sb[4] == '?')
        {
            sb[4] = '9';
        }

        if(sb[3] == '?')
        {
            sb[3] = '5';
        }

        if(sb[0] == '?' && sb[1] == '?')
        {
            sb[0] = '2';
            sb[1] = '3';
        }

        if(sb[0] == '?')
        {
            if(sb[1] > '3')
            {
                sb[0] = '1';
            }
            else
            {
                sb[0] = '2';
            }
        }

        if(sb[1] == '?')
        {
            if(sb[0] == '2')
            {
                sb[1] = '3';
            }
            else
            {
                sb[1] = '9';
            }
        }

        return sb.ToString();
    }
}