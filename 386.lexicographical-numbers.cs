/*
 * @lc app=leetcode id=386 lang=csharp
 *
 * [386] Lexicographical Numbers
 */

// @lc code=start
public class Solution {
    public IList<int> LexicalOrder(int n) {
        var numbers = Enumerable.Range(1, n).Select(x => x.ToString()).OrderBy(x => x).ToList();
        return numbers.Select(x => int.Parse(x)).ToList();
    }
}
// @lc code=end

