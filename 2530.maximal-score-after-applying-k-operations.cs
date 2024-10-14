/*
 * @lc app=leetcode id=2530 lang=csharp
 *
 * [2530] Maximal Score After Applying K Operations
 */

// @lc code=start
public class Solution {
    public long MaxKelements(int[] nums, int k) {
        // create a max heap
        var maxHeap = new PriorityQueue<int, int>();

        // add all elements to the max heap
        foreach (int num in nums) {
            maxHeap.Enqueue(num, -num);
        }

        // pop the max element from the heap and add it to the score
        long score = 0;
        while(k-- > 0) {
            int max = maxHeap.Dequeue();

            // case when max is 0
            // no need to continue
            if(max == 0) {
                break;
            }

            // because when max is 1 we can't divide it by 3
            // we can say to for all other numbers behind max aswell
            if(max == 1) {
                score += k + 1;
                break;
            } 

            // add the max element to the score and add the new max
            score += max;
            max = (max+2) / 3;
            maxHeap.Enqueue(max, -max);
        }   
    
        return score;
    }
}
// @lc code=end

