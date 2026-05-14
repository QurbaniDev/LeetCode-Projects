using System.Diagnostics;
using System.Globalization;

public class Solution 
{
     public bool CanMakeArithmeticProgression(int[] arr)
    {
        bool result = false;   
        Array.Sort(arr);

        if (arr.Length <= 2)
        {
            result = true;
        }
        else if (arr.Length > 2)
        {
            for(int i = 1; i < arr.Length - 1; i++)
            {
                int x = i - 1;
                int y = i + 1;

                if ((arr[i] - arr[x]) == (arr[y] - arr[i]))
                {
                    result = true;
                }
                else
                {
                    result = false;
                    break;
                }
            }
        }

        return result;
    }
}
