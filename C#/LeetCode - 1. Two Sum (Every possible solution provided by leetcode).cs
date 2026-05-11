public class Solution { //Brute force
    public int[] TwoSum(int[] nums, int target) {
        for (int i = 0; i < nums.Length; i++) {
            for (int j = i + 1; j < nums.Length; j++) {
                if (nums[j] == target - nums[i]) {
                    return new int[] { i, j };
                }
            }
        }
        // Return an empty array if no solution is found
        return new int[] {};
    }
}

public class Solution { //Simplest
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (map.ContainsKey(complement)) {
                return new int[] { map[complement], i };
            }
            map[nums[i]] = i;
        }
        // Return an empty array if no solution is found
        return new int[] {};
    }
}

public class Solution { //Less simpler
    public int[] TwoSum(int[] nums, int target) {
        Dictionary<int, int> map = new Dictionary<int, int>();
        for (int i = 0; i < nums.Length; i++) {
            map[nums[i]] = i;
        }

        for (int i = 0; i < nums.Length; i++) {
            int complement = target - nums[i];
            if (map.ContainsKey(complement) && map[complement] != i) {
                return new int[] { i, map[complement] };
            }
        }

        // If no valid pair is found, return an empty array
        return new int[] {};
    }
}