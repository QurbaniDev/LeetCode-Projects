public class Solution 
{       //Mine, doesnt work
    public int[] FindErrorNums(int[] nums) 
    {
            int Duplicate = 0;
           int Replacement = 0;

        for(int i = 1; i < nums.Length; i++)
        {
            for (int z = 0; z < i; z++)
            {
                if (nums[i] == nums[z])
                {
                    Duplicate = nums[i];
                    //Replacement = nums[z] + 1;
                }
            }
        }
        return new int[] {Duplicate, Replacement};
    }
}

public class Solution 
{
    public int[] FindErrorNums(int[] nums) 
    {
        int[] tracker = new int[nums.Length + 1];
        int duplicate = 0;
        for (int i = 0; i < nums.Length; i++)
        {
            if (tracker[nums[i]] != 0)
            {
                duplicate = nums[i];
            }
            else
            {
                tracker[nums[i]] = nums[i];
            }
        }

        int missing = 0;
        for (int i = 1; i <= nums.Length; i++)
        {
            if (tracker[i] == 0)
            {
                missing = i;
                break;
            }
        }

        return [duplicate, missing];
    }
}