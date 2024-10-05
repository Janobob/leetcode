/*
 * @lc app=leetcode id=9 lang=csharp
 *
 * [9] Palindrome Number
 */

// @lc code=start
public class Solution {
    public bool IsPalindrome(int x) {
        var xS = x.ToString();
        string xSR = Reverse(xS);
        for(int i = 0; i < xS.Length; i++){
            if(xS[i] != xSR[i]){
                return false;
            }
        }

        return true;
    }

    public string Reverse(string text)
    {
        if (text == null) return null;

        // this was posted by petebob as well 
        char[] array = text.ToCharArray();
        Array.Reverse(array);
        return new String(array);
    }
}
// @lc code=end

