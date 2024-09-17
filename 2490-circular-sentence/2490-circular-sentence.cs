public class Solution {
    public bool IsCircularSentence(string sentence)
    {
        for(var i = 1; i < sentence.Length; i++)
        {
            if(sentence[i-1] != ' ')
            {
                continue;
            }

            if(sentence[i-2] != sentence[i])
            {
                return false;
            }
        }
        
        return sentence[0] == sentence[sentence.Length-1];
    }
}