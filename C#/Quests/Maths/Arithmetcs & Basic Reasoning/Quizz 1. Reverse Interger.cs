public class Solution 
{
    public int Reverse(int x) 
    {
        int reverse = 0;

        while (x != 0)
        {
            int lastDigit = x % 10;

            // Check overflow before multiplying
            if (reverse > int.MaxValue / 10 || 
               (reverse == int.MaxValue / 10 && lastDigit > 7))
            {
                return 0;
            }

            if (reverse < int.MinValue / 10 || 
               (reverse == int.MinValue / 10 && lastDigit < -8))
            {
                return 0;
            }

            reverse = reverse * 10 + lastDigit;
            x /= 10;
        }

        return reverse;
    }
}
