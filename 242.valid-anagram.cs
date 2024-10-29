/*
 * @lc app=leetcode id=242 lang=csharp
 *
 * [242] Valid Anagram
 */

// @lc code=start
public class Solution {
    public bool IsAnagram(string s, string t) {
        if(s.Length != t.Length) {
            return false;
        }

        var map = new int[26];

        foreach(var c in s) {
            if(map[c - 'a'] == 0) {
                map[c - 'a'] = 1;
            } else {
                map[c - 'a']++;
            }
        }

        foreach(var c in t) {
            if(map[c - 'a'] != 0) {
                if(--map[c - 'a'] < 0) {
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

