/*
 * @lc app=leetcode id=217 lang=csharp
 *
 * [217] Contains Duplicate
 */

// @lc code=start
public class Solution {
    public bool ContainsDuplicate(int[] nums) {
        var set = new Dictionary<int, int>();

        foreach(var num in nums){
            if(set.ContainsKey(num)){
                return true;
            }
            set.Add(num, 1);
        }

        return false;
    }
}
// @lc code=end

