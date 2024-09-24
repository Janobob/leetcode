/*
 * @lc app=leetcode id=3043 lang=csharp
 *
 * [3043] Find the Length of the Longest Common Prefix
 */

// @lc code=start
public class Solution {
    public int LongestCommonPrefix(int[] arr1, int[] arr2) {
        var longestCommonPrefixLength = 0;

        foreach (int x in arr1) {
            foreach (int y in arr2) {
                var strX = x.ToString();
                var strY = y.ToString();

                var commonPrefixLength = 0;
                for (int i = 0; i < Math.Min(strX.Length, strY.Length); i++) {
                    if (strX[i] == strY[i]) {
                        commonPrefixLength++;
                    } else {
                        break;
                    }
                }

                longestCommonPrefixLength = Math.Max(longestCommonPrefixLength, commonPrefixLength);
            }
        }

        return longestCommonPrefixLength;
    }
}
// @lc code=end

