/*
 * @lc app=leetcode id=238 lang=csharp
 *
 * [238] Product of Array Except Self
 */

// @lc code=start
public class Solution {
    public int[] ProductExceptSelf(int[] nums) {
        int[] prefix = new int[nums.Length];
        int[] suffix = new int[nums.Length];
        int[] result = new int[nums.Length];

        prefix[0] = 1;
        suffix[nums.Length - 1] = 1;

        for(int i = 1; i < nums.Length; i++){
            prefix[i] = prefix[i - 1] * nums[i - 1];
        }

        for(int i = nums.Length - 2; i >= 0; i--){
            suffix[i] = suffix[i + 1] * nums[i + 1];
        }

        for(int i = 0; i < nums.Length; i++){
            result[i] = prefix[i] * suffix[i];
        }

        return result;
    }
}
// @lc code=end

