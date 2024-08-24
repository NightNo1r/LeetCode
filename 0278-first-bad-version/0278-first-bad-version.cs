/* The isBadVersion API is defined in the parent class VersionControl.
      bool IsBadVersion(int version); */

public class Solution : VersionControl {
    public int FirstBadVersion(int n)
    {
        var min = 1;
        var max = n;

        while(max >= min)
        {
            var middle = min + (max - min) / 2;

            var isBad = IsBadVersion(middle);

            if(isBad)
            {
                max = middle - 1;
            }
            else
            {
                min = middle + 1;
            }
        }

        return min;
    }
}