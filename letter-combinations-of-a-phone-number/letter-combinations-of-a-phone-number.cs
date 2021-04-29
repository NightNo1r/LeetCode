public class Solution 
{
    List<string> Alph = new List<string>(){"abc","def","ghi","jkl","mno","pqrs","tuv","wxyz"};
    List<string> Ans = new List<string>();
    
    public IList<string> LetterCombinations(string digits) 
    {
        if(digits == "")
            return new List<string>();
        Merge(new List<string>(),0,digits);
        return Ans;
    }
    
    public void Merge(List<string> Merged,int cur, string digits)
    {
        if(cur == 0)
        {
            Merged.Add("");
        }
        int index = digits[cur] - '2';
        var newMerged = new List<string>();
        foreach(var m in Merged)
            foreach(var c in Alph[index])
                newMerged.Add(m.ToString()+c.ToString());
        if(cur+1 == digits.Length)
            Ans.AddRange(newMerged);
        else
            Merge(newMerged,cur+1,digits);
    }
}