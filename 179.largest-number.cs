/*
 * @lc app=leetcode id=179 lang=csharp
 *
 * [179] Largest Number
 */

// @lc code=start
public class Solution {
    public string LargestNumber(int[] nums) {
        var strNums = nums.Select(n => n.ToString()).ToList();
        strNums.Sort((a, b) => (b + a).CompareTo(a + b));

        // check for special case
        if (strNums[0] == "0"){
            return "0";
        }

        return string.Join("", strNums);
    }
}
// @lc code=end

