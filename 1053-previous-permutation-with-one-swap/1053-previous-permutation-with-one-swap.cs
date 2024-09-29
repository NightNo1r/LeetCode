public class Solution {
    public int[] PrevPermOpt1(int[] arr)
    {
        for(var i = arr.Length - 2; i >= 0; i--)
        {
            var localMax = 0;
            var localMaxIndex = -1;
            for(var j = arr.Length - 1; j > i; j--)
            {
                if(localMax <= arr[j] &&
                   arr[j] < arr[i])
                {
                    localMax = arr[j];
                    localMaxIndex = j;
                }
            }

            if(localMax > 0)
            {
                var temp = arr[localMaxIndex];
                arr[localMaxIndex] = arr[i];
                arr[i] = temp;
                return arr;
            }
        }

        return arr;
    }
}