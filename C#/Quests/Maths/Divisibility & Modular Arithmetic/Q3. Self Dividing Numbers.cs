public class Solution 
{      //DOES NOT WORK (so close)
    public IList<int> SelfDividingNumbers(int left, int right) 
    {
        List<int> CanSelfDiv = new List<int>();

        for(int i = left; i <= right; i++)
        {
            char[] chars = left.ToString().ToCharArray(); 
            bool AllDiv = true;
            for (int j = 0; j < chars.Length; j++)
            {   
                if (left % chars[j] != 0)
                {
                    AllDiv = false;
                }
            }

            if(AllDiv)
            {
                CanSelfDiv.Add(left);
                left += 1;
                continue;
            }
        }

        return CanSelfDiv;
    }
}

public class Solution 
{   //WORKS
    public IList<int> SelfDividingNumbers(int left, int right) 
    {
        List<int> result = new List<int>();

        for (int i = left; i <= right; i++)
        {
            int num = i;
            bool allDiv = true;

            foreach (char c in num.ToString())
            {
                int digit = c - '0';

                if (digit == 0 || i % digit != 0)
                {
                    allDiv = false;
                    break;
                }
            }

            if (allDiv)
            {
                result.Add(i);
            }
        }

        return result;
    }
}

public class Solution 
{   //Also works, no changing to strings or chars however.
    public IList<int> SelfDividingNumbers(int left, int right) 
    {
        List<int> result = new List<int>();

        for (int i = left; i <= right; i++)
        {
            int num = i;
            int temp = num;
            bool valid = true;

            while (temp > 0)
            {
                int digit = temp % 10;

                if (digit == 0 || num % digit != 0)
                {
                    valid = false;
                    break;
                }

                temp /= 10;
            }

            if (valid)
            {
                result.Add(i);
            }
        }

        return result;
    }
}