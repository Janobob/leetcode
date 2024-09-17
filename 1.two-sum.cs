/*
 * @lc app=leetcode id=1 lang=csharp
 *
 * [1] Two Sum
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] nums, int target) {
        for(int i = 0; i < nums.Length; i++){
            for(int j = 0; j < nums.Length; j++){
                if(i != j && nums[i] + nums[j] == target){
                    return new int[]{i, j};
                }
            }
        }
        
        return new int[0];
    }
}
// @lc code=end

