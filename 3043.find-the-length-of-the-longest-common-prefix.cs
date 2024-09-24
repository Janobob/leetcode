/*
 * @lc app=leetcode id=3043 lang=csharp
 *
 * [3043] Find the Length of the Longest Common Prefix
 */

// @lc code=start
public class Solution {
    public int LongestCommonPrefix(int[] arr1, int[] arr2) {
        var strArr1 = arr1.Select(x => x.ToString()).OrderBy(x => x).ToList();
        var strArr2 = arr2.Select(x => x.ToString()).OrderBy(x => x).ToList();
        var longestCommonPrefixLength = 0;

        foreach (var strX in strArr1) {
            foreach (var strY in strArr2) {
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

