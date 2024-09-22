/*
 * @lc app=leetcode id=440 lang=csharp
 *
 * [440] K-th Smallest in Lexicographical Order
 */

// @lc code=start
public class Solution {
    public int FindKthNumber(int n, int k) {
        // start from 1, k = 0
        int curr = 1;
        k--; // decrement k to make it 0-based
        
        // as long as k is greater than 0, keep searching
        while (k > 0) {
            long steps = CalculateSteps(n, curr, curr + 1);
            // if steps <= k, k is in the subtree of curr
            if (steps <= k) {
                // move to next neighbor node
                curr++;
                k -= (int)steps;
                continue;
            }
            // if steps > k, k is in the subtree of curr * 10
            curr *= 10;
            k--;
        }
        
        // return the current node
        return curr;
    }

    // calculate steps between n1 and n2
    private long CalculateSteps(int n, long n1, long n2) {
        long steps = 0;
        while (n1 <= n) {
            steps += Math.Min(n + 1, n2) - n1;
            n1 *= 10;
            n2 *= 10;
        }
        return steps;
    }
}
// @lc code=end

