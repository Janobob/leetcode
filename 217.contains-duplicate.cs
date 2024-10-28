/*
 * @lc app=leetcode id=217 lang=csharp
 *
 * [217] Contains Duplicate
 */

// @lc code=start
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var set = new HashSet<int>();

        foreach(var num in nums){
            set.Add(num);
        }

        return set.Count != nums.Length;
    }
}
// @lc code=end

