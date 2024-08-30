public class Solution {
    public string DefangIPaddr(string address)
    {
        var sb = new StringBuilder(address.Length + 6);
        foreach(var ch in address)
        {
            if(ch != '.')
            {
                sb.Append(ch);
                continue;
            }

            sb.Append('[');
            sb.Append(ch);
            sb.Append(']');
        }

        return sb.ToString();
    }
}