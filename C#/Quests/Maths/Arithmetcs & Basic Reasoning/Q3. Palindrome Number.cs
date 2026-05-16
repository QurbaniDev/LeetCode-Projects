using System.Globalization;

public class Solution 
{
    public bool IsPalindrome(int x) 
    {
        int original = x;
        int reverse = 0;

        while (x != 0)
        {
            int lastDigit = x % 10;
            reverse = (reverse * 10) + lastDigit;
            x /= 10;
        }

        if (original == reverse && (original > -1 || reverse > -1))
        {
            return true;
        }
        else
        {
            return false;
        }
    }
}

