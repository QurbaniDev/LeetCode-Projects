using System.Runtime.InteropServices.Marshalling;
using System.Security.Cryptography.X509Certificates;

public class Solution 
{
    //uses System.Linq;
    public int[] GetConcatenation(int[] nums) 
    {
        int[] ans = nums.Concat(nums).ToArray();

        return ans;
    }
}

public class Solution 
{
    //Collection Expressions - spread operator (..)
    public int[] GetConcatenation(int[] nums) 
    {
        int[] ans = [.. nums, .. nums];

        return ans;
    }
}

public class Solution 
{
    //Array.Copy for perfomance and very large arrays
    public int[] GetConcatenation(int[] nums) 
    {
        int[] ans = new int[nums.Length * 2];
        Array.Copy(nums, 0, ans, 0, nums.Length);
        Array.Copy(nums, 0, ans, nums.Length, nums.Length);
        return ans;
    }
}

public class Solution 
{
    //For loop (how leetcode expected it)
    public int[] GetConcatenation(int[] nums) 
    {
        int n = nums.Length;
        int[] ans = new int[2 * n];

        for (int i = 0; i < n; i++)
        {
            // Fill first half
            ans[i] = nums[i];
            
            // Fill second half
            ans[i + n] = nums[i];
        }

        return ans;
    }
}