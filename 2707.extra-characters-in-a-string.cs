/*
 * @lc app=leetcode id=2707 lang=csharp
 *
 * [2707] Extra Characters in a String
 */

// @lc code=start
public class Solution {
    public int MinExtraChar(string s, string[] dictionary) {
        foreach(var word in dictionary.OrderByDescending(x => x.Length)) {
            while (s.Contains(word)) {
                s = s.Replace(word, "");
            }
        }

        return s.Length;
    }
}
// @lc code=end

