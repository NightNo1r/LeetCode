public class Solution {
    public int NumRescueBoats(int[] people, int limit)
    {
        Array.Sort(people);

        var boatsCount = 0;
        var left = 0;
        var right = people.Length - 1;
        while(left <= right)
        {
            var temp = left == right ? people[left] : people[left] + people[right];

            if(temp <= limit)
            {
                left++;
            }

            right--;
            boatsCount++;
        }

        return boatsCount;
    }
}