public class Solution {
    public int[] FrequencySort(int[] nums)
    {
        const int deviation = 100;
        var frequency = new int[201];
        for(var i = 0; i < nums.Length; i++)
        {
            frequency[nums[i]+deviation]++;
        }

        var list = new List<(int value, int frequency)>();
        for(var i = 0; i < frequency.Length; i++)
        {
            if(frequency[i] > 0)
            {
                list.Add((i-deviation, frequency[i]));
            }
        }

        list.Sort((left, right) =>
        {
            if(left.frequency > right.frequency)
            {
                return 1;
            }

            if(left.frequency < right.frequency)
            {
                return -1;
            }

            return right.value.CompareTo(left.value);
        });

        var answer = new int[nums.Length];
        var answerIndex = 0;
        for(var i = 0; i < list.Count; i++)
        {
            for(var j = 0; j < list[i].frequency; j++)
            {
                answer[answerIndex] = list[i].value;
                answerIndex++;
            }
        }

        return answer;
    }
}