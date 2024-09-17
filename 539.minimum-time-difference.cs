/*
 * @lc app=leetcode id=539 lang=csharp
 *
 * [539] Minimum Time Difference
 */

// @lc code=start
public class Solution {
    public int FindMinDifference(IList<string> timePoints) {
        var times = timePoints.Select(x => TimeSpan.Parse(x)).OrderBy(t => t).ToList();
        var min = Int32.MaxValue;
        var totalMinutesInDay = 24 * 60;

        for (int i = 1; i < times.Count; i++) {
            var diff = times[i] - times[i - 1];
            var minutes = Convert.ToInt32(diff.TotalMinutes);
            min = Math.Min(min, minutes);
        }

        var circularDiff = totalMinutesInDay - Convert.ToInt32((times.Last() - times.First()).TotalMinutes);
        min = Math.Min(min, circularDiff);

        return min;
    }
}
// @lc code=end

