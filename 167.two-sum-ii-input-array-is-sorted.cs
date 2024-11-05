/*
 * @lc app=leetcode id=167 lang=csharp
 *
 * [167] Two Sum II - Input Array Is Sorted
 */

// @lc code=start
public class Solution {
    public int[] TwoSum(int[] numbers, int target) {
        int left = 0;
        int right = numbers.Length - 1;
        int sum = 0;

        while(left < right){
            sum = numbers[left] + numbers[right];
            if(sum == target){
                return new int[]{left + 1, right + 1};
            }else if(sum < target){
                left++;
            }else{
                right--;
            }
        }
        return new int[]{};
    }
}
// @lc code=end

