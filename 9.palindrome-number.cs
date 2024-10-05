/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        if (x < 0) {
            return false;
        }

        var amountOfDigits = (int)Math.Floor(Math.Log10(x) + 1);
        var firstDigit = 0;
        var lastDigit = 0;

        for (int i = 0; i < amountOfDigits / 2; i++) {
            firstDigit = (int)(x / Math.Pow(10, amountOfDigits - i - 1)) % 10;
            lastDigit = (int)(x / Math.Pow(10, i)) % 10;
            if (firstDigit != lastDigit) {
                return false;
            }
        }

        return true;
    }
}
// @lc code=end

