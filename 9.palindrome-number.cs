/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        var xS = x.ToString();

        for(int i = 0; i < xS.Length / 2; i++) {
            if(xS[i] != xS[xS.Length - 1 - i]) {
                return false;
            }
        }

        return true;
    }
}
// @lc code=end

