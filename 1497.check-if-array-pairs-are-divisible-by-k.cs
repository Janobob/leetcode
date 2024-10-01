/*
 * @lc app=leetcode id=1497 lang=csharp
 *
 * [1497] Check If Array Pairs Are Divisible by k
 */

// @lc code=start
public class Solution {
    public bool CanArrange(int[] arr, int k) {
        var remainders = new Dictionary<int, int>();

        foreach (var num in arr) {
            var remainder = num % k;

            // keep the remainder positive
            remainder = remainder < 0 ? remainder + k : remainder;

            if(remainders.ContainsKey(remainder)) {
                remainders[remainder]++;
            } else {
                remainders[remainder] = 1;
            }
        }

        // check if the number of elements with remainder i is equal to the number of elements with remainder k - i
        for (int i = 1; i < k; i++) {
            if (!remainders.ContainsKey(i)) {
                remainders[i] = 0;
            }

            if (!remainders.ContainsKey(k - i)) {
                remainders[k - i] = 0;
            }

            if (remainders[i] != remainders[k - i]) {
                return false;
            }
        }

        // check if the number of elements with remainder 0 is even
        if (remainders.ContainsKey(0) && remainders[0] % 2 != 0) {
            return false;
        }

        return true;
    }
}
// @lc code=end

