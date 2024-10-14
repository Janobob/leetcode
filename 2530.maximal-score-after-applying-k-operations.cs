/*
 * @lc app=leetcode id=2530 lang=csharp
 *
 * [2530] Maximal Score After Applying K Operations
 */

// @lc code=start
public class Solution {
    public long MaxKelements(int[] nums, int k) {
        // create a max heap
        var maxHeap = new PriorityQueue<int, int>(Comparer<int>.Create((a, b) => b - a));

        // add all elements to the max heap
        foreach (var num in nums) {
            maxHeap.Enqueue(num, num);
        }


        long score = 0;
        for (int i = 0; i < k; i++) {
            int max = maxHeap.Dequeue();
            score += max;
            int q = (int)Math.Ceiling(max / 3.0);
            maxHeap.Enqueue(q, q);
        }   
    
        return score;
    }
}
// @lc code=end

