public class Solution {
    Dictionary<string,int> Dict = new Dictionary<string,int>(){{"I",1},{"IV",4},{"V",5},{"IX",9},{"X",10},{"XL",40},{"L",50},{"XC",90},{"C",100},{"CD",400},{"D",500},{"CM",900},{"M",1000}};
    public string IntToRoman(int num) {
        string s = "";
        while(num > 0)
        {
            var rom = Dict.Reverse().Where(x => num - x.Value >=0).FirstOrDefault();
            s += rom.Key;
            num -= rom.Value;
        }
        return s;
    }
}