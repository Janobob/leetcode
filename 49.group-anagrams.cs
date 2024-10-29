/*
 * @lc app=leetcode id=49 lang=csharp
 *
 * [49] Group Anagrams
 */

// @lc code=start
public class Solution {
    public IList<IList<string>> GroupAnagrams(string[] strs) {
        var dict = new Dictionary<string, IList<string>>();

        foreach (var s in strs) {
            var charCounts = new char[26];
            foreach (var c in s) {
                charCounts[c - 'a']++;
            }

            var key = new string(charCounts);

            if (!dict.ContainsKey(key)) {
                dict[key] = new List<string>();
            }
            dict[key].Add(s);
        }

        return dict.Values.ToList();
    }
}
// @lc code=end

