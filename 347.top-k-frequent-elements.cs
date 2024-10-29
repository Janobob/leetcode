/*
 * @lc app=leetcode id=347 lang=csharp
 *
 * [347] Top K Frequent Elements
 */

// @lc code=start
public class Solution {
 public int[] TopKFrequent(int[] nums, int k) {
        // count amount of each number
        var map = new Dictionary<int, int>();
        foreach (var num in nums) {
            if (!map.ContainsKey(num)) {
                map[num] = 0;
            }
            map[num]++;
        }

        // order by descending, with heap because .OrderByDescending is slow :C
        var heap = new PriorityQueue<int, int>();
        foreach (var entry in map) {
            heap.Enqueue(entry.Key, entry.Value);
            if (heap.Count > k) {
                heap.Dequeue();
            }
        }

        var result = new int[k];
        for (int i = k - 1;  i >= 0; i--) {
            result[i] = heap.Dequeue();
        }

        return result;
    }
}
// @lc code=end

