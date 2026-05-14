public class Solution 
{
    public int PivotInteger(int n) 
    {
        int sum = 0;
        int temp = 0;
        int pivot = 0;

        if (n == 1)
        {
            pivot = 1;
        }
        else
        {
            for (int i = 0; i < n; i++) 
            {
                if (i < n)
                {
                    sum += i; 
                }
                else
                {
                    break;
                }
               
            }

            for (int z = 0; z < n; z++)
            {
                sum--;

                if (temp < sum)
                {
                    temp++;
                    continue;
                }
                else if (temp == sum)
                {
                    pivot = temp;
                    break;
                }
                else if (temp > sum)
                {
                    pivot = -1;
                    break;
                }
            }
        }
        
        return pivot;
    }
}