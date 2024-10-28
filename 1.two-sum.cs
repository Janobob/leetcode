/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        var dict = new Dictionary<int, int>();

        for(int i = 0; i < nums.Length; i++) {
            // calculate the complement
            int complement = target - nums[i];

            // when the complement is in the dictionary, look up the index of the complement
            if(dict.ContainsKey(complement)) {
                // return the index of the complement and the current index
                return new int[] {dict[complement], i};
            }
            dict[nums[i]] = i;
        }

        return new int[] {};
    }
}
// @lc code=end

