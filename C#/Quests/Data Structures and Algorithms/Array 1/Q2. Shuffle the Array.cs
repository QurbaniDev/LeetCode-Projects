public class Solution 
{    //Assisted by the solutions tab
    //The result array alternates between elements from the first half and second half of nums
    // Even indices (0, 2, 4...) ← first half [x1, x2, ..., xn]
    // Odd indices (1, 3, 5...) ← second half [y1, y2, ..., yn]
    public int[] Shuffle(int[] nums, int n)
    {
        int x = 0;
        int[] result = new int[nums.Length];
        for (int i = 0; i < result.Length; i++)
        {
            if (i % 2 == 0)
            {
                result[i] = nums[x];
                x++;
            }
            else
            {
                result[i] = nums[n];
                n++;
            }
        }
        return result;
    }
}