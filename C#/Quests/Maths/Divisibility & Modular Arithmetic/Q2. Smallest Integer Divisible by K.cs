using System.ComponentModel.DataAnnotations;

public class Solution 
{   //My own, inefficient an exceeds time limit on higher numbers
    public int SmallestRepunitDivByK(int k) 
    {
        if (k == 1)
        {
            return 1;
        }
        else if (k <= 0)
        {
            return -1;
        }

        int n = 1;
    
        while (true)
        {
            int length = (n == 0) ? 1 : (int)Math.Floor(Math.Log10(Math.Abs(n)) + 1);

            if (n % k != 0 && length != k)
            {
                n = n * 10 + 1;
            }
            else if (n % k != 0 && length == k)
            {
                n = -1;
                break;
            }
            else
            {   
                n = length;
                break;
            }
        }
        
        return n;     
    }
}

public class Solution 
{   //Modified, efficient.
    public int SmallestRepunitDivByK(int k) 
    {
        if (k % 2 == 0 || k % 5 == 0)
        {
            return -1;
        }

        int remainder = 0;

        for (int length = 1; length <= k; length++)
        {
            remainder = (remainder * 10 + 1) % k;

            if (remainder == 0)
            {
                return length;
            }
        }

        return -1;
    }
}