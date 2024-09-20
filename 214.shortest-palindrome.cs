/*
 * @lc app=leetcode id=214 lang=csharp
 *
 * [214] Shortest Palindrome
 */

// @lc code=start
public class Solution {
    public string ShortestPalindrome(string s) {
        // find largest palindrome substring starting from the beginning
        for (var i = 0; i < s.Length; i++) {
            if (isPalindrome(s.Substring(0, s.Length - i))) {
                // append the substring which is a palindrome to the beginning of the string
                return new string(s.Substring(s.Length - i).Reverse().ToArray()) + s;
            }
        }

        // if the string is already a palindrome, return the string
        return s;
    }

    public bool isPalindrome(string s) {
        var i = 0;
        var j = s.Length - 1;
        
        // Loop from start to middle of the string
        while (i < j) {
            if (s[i] != s[j]) {
                return false;
            }
            i++;
            j--;
        }
        return true;
    }   
}
// @lc code=end

