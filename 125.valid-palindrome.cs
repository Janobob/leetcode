/*
 * @lc app=leetcode id=125 lang=csharp
 *
 * [125] Valid Palindrome
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(string s) {
        if(string.IsNullOrEmpty(s)){
            return false;
        }

        var left = 0;
        var right = s.Length - 1;

        while(left < right){
            if(!char.IsLetterOrDigit(s[left])){
                left++;
                continue;
            }
            if(!char.IsLetterOrDigit(s[right])){
                right--;
                continue;
            }

            // the real comparison
            if(ToLower(s[left]) != ToLower(s[right])){
                return false;
            }
            left++;
            right--;
        }

        return true;
    }

    // damn is char.ToLower() from .Net slow
    private static char ToLower(char c)
    {
        if (c is >= 'A' and <= 'Z')
            // for xeno 
            return (char)(c + (1 << 5));
        
        return c;
    }
}
// @lc code=end

