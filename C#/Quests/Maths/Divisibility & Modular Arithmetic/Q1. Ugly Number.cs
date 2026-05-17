using System.Diagnostics;
using System.Globalization;
using System.Threading.Channels;

public class Solution 
{ //doesnt work
    public bool IsUgly(int n) 
    {
        bool Ugly = true;

        if (n == 1 || n == 2 || n == 3 || n == 5)
        {
            Ugly = true;
        }
        else if (n < 1)
        {
            Ugly = false;
        }
        else
        {
            var Square = Math.Floor(Math.Sqrt(n));

            for (int i = 3; i <= Square; i += 2)
            {
                if (n % i == 0)
                Ugly = false;
            }
        }

        return Ugly;
    }
}

public class Solution 
{ //doesnt work
    public bool IsUgly(int n) 
    {   
        bool ugly = true;

        if (n <= 0 || n == 2 || n == 3 || n == 5 || n == 1)
        {
            ugly = true;
        }
        else
        {
            for (int  i = 1; i <= n; i++)
            {  
                 if (n % i == 0)
                {
                    if (i == 5 || i == 2 || i == 3)
                    {
                        ugly = true;
                    }  
                    else
                    {
                        ugly = false;
                    }
                }
                else if (n % i == 0)
                {
                    ugly = false;
                }
            }
        }

        return ugly;
    }
}
 
public class Solution 
{   //actually how to find an ugly number.
    public bool IsUgly(int n) 
    {
        if (n <= 0) return false;

        int[] factors = { 2, 3, 5 };

        foreach (int f in factors)
        {
            while (n % f == 0)
            {
                n /= f;
            } 
        }

        return n == 1;
    }
}