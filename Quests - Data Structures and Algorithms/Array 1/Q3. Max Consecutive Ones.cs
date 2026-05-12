public class Solution 
{   //My own solution, using an abundance of if statements.
    public int FindMaxConsecutiveOnes(int[] nums) 
    {
           int output = 0;
           int outputalt = 0;
           int output2 = 0;

        for(int i = 0; i < nums.Length; i++)
        {
            if (nums[i] == 1)
            {
                output += 1;
                outputalt = output;
            }
            else if (nums[i] == 0)
            {
                output -= output;
            }

            if (output > output2 )
            {
                output2 = output;
            }
        }

            return output2;
    }
}

