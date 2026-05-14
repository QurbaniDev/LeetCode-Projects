public class Solution 
{
    public IList<int> FindDisappearedNumbers(int[] nums) 
    {
        var result = new List<int>();
        int n = nums.Length;
        
        // Step 1: Mark visited indices
        for (int i = 0; i < n; i++) 
        {
            // Get the original value (handle if already negated)
            int index = Math.Abs(nums[i]) - 1;  
            
            // TODO: Mark this index as visited (make negative if not already)
            if (nums[index] > 0) 
            {
                nums[index] = -nums[index];
            }
        }
        
        // Step 2: Find indices that were never marked
        for (int i = 0; i < n; i++) 
        {
            // TODO: If value is still positive, add (i+1) to result
            if (nums[i] > 0) 
            {
                result.Add(i + 1);
            }
        }
        
        return result;
    }
}