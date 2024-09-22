/*
 * @lc app=leetcode id=440 lang=csharp
 *
 * [440] K-th Smallest in Lexicographical Order
 */

// @lc code=start
public class Solution {
    public int FindKthNumber(int n, int k) {
        var numbers = Enumerable.Range(1, n).Select(x => x.ToString()).OrderBy(x => x).ToList();
        return numbers.Select(x => int.Parse(x)).ElementAt(k - 1);
    }
}
// @lc code=end

