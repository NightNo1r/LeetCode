public class Solution {
    public int OpenLock(string[] deadends, string target)
    {
        var travesed = new HashSet<string>();
        var queue = new Queue<(string, int)>();
        queue.Enqueue(("0000", 0));

        while(queue.Count > 0)
        {
            var (start, stepsCount) = queue.Dequeue();

            if(start == target)
            {
                return stepsCount;
            }

            if(Array.Exists(deadends, x => x == start))
            {
                continue;
            }

            if(travesed.Add(start))
            {
                EnqueueAll(queue, start, stepsCount);
            }
        }

        return -1;
    }

    private void EnqueueAll(
        Queue<(string, int)> queue,
        string start,
        int count)
    {
        var sb = new StringBuilder(start);
        var nextStepsCount = count+1;

        for(var i = 0; i < 4; i++)
        {
            GetNextDigitForIndex(sb, i);
            queue.Enqueue((sb.ToString(), nextStepsCount));
            GetPrevDigitForIndex(sb, i);
        }

        for(var i = 0; i < 4; i++)
        {
            GetPrevDigitForIndex(sb, i);
            queue.Enqueue((sb.ToString(), nextStepsCount));
            GetNextDigitForIndex(sb, i);
        }
    }

    private StringBuilder GetNextDigitForIndex(StringBuilder sb, int indexOfValueToIncrease)
    {
        sb[indexOfValueToIncrease]++;

        if(sb[indexOfValueToIncrease] > '9')
        {
            sb[indexOfValueToIncrease] = '0';
        }

        return sb;
    }

    private StringBuilder GetPrevDigitForIndex(StringBuilder sb, int indexOfValueToDecrease)
    {
        sb[indexOfValueToDecrease]--;

        if(sb[indexOfValueToDecrease] < '0')
        {
            sb[indexOfValueToDecrease] = '9';
        }

        return sb;
    }
}