/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 */

// @lc code=start
public class Solution {
    public bool IsAnagram(string s, string t) {
        var mapOrigin = new Dictionary<char, int>();

        if(s.Length != t.Length) {
            return false;
        }

        foreach(var c in s) {
            if(mapOrigin.ContainsKey(c)) {
                mapOrigin[c]++;
            } else {
                mapOrigin[c] = 1;
            }
        }

        foreach(var c in t) {
            if(mapOrigin.ContainsKey(c)) {
                if(--mapOrigin[c] < 0) {
                    return false;
                }
            } else {
                return false;
            }
        }

        return true;
    }
}
// @lc code=end

