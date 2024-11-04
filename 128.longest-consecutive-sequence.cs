/*
 * @lc app=leetcode id=128 lang=csharp
 *
 * [128] Longest Consecutive Sequence
 */

// @lc code=start
public class Solution {
    public int LongestConsecutive(int[] nums) {
        if (nums.Length == 0) return 0;

        var set = new HashSet<int>(nums);
        int max = 0;

        foreach (var num in set) {
            if (!set.Contains(num - 1)) {
                int currentNum = num;
                int currentMax = 1;

                while (set.Contains(currentNum + 1)) {
                    currentNum++;
                    currentMax++;
                }

                max = Math.Max(max, currentMax);
            }
        }

        return max;
    }
}
// @lc code=end

