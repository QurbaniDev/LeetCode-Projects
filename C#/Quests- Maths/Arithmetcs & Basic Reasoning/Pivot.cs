public class Solution 
{
    public int PivotInteger(int n)
    {
        if (n == 1)
            return 1;

        int pivot = 2;
        int low = 1;
        int high = n;
        
        while (n >= pivot)
        {
            int lowSum = 0;
            for (int i = low; i <= pivot; ++i)
                lowSum += i;

            int highSum = 0;
            for (int i = high; i >= pivot; --i)
                highSum += i;

            if (highSum == lowSum)
                return pivot;

            pivot++;
        }

        return -1;
    }
}
