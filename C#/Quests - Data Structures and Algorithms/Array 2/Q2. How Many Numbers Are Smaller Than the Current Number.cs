using System.ComponentModel.Design;

public class Solution 
{   // Google search on Linq
    public int[] SmallerNumbersThanCurrent(int[] nums) 
    {
        var counts = nums.Select(currentNum => nums.Where(n => n < currentNum).Count());

        return counts.ToArray();
    }
}

public class Solution 
{   // Shorter Linq
    public int[] SmallerNumbersThanCurrent(int[] nums) => nums.Select(m => nums.Count(n => n < m)).ToArray();
}
