public class Solution 
{
    public int PivotInteger(int n) 
    {
        int sum = n * (n + 1) / 2;
        int x = (int)Math.Sqrt(sum);

        return (x * x == sum) ? x : -1;
    }
}