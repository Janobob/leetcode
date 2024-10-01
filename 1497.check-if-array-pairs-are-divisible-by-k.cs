/*
 * @lc app=leetcode id=1497 lang=csharp
 *
 * [1497] Check If Array Pairs Are Divisible by k
 */

// @lc code=start
public class Solution {
    public bool CanArrange(int[] arr, int k) {
        var initialLength = arr.Length;
        var pairs = new Dictionary<int, int>();
        

        foreach (var num in arr) {
            foreach(var remainder in arr.Reverse().Where(x => x != num)){
                if(num + remainder != 0 && (num + remainder) % k == 0){
                    pairs.Add(num, remainder);
                    Console.WriteLine(num + " " + remainder);
                    arr = arr.Where(x => x != num).ToArray();
                    arr = arr.Where(x => x != pairs[num]).ToArray();
                    break;
                }
            }
        }

        Console.WriteLine(pairs.Count);

        var left = pairs.Select(x => x.Key).ToList();
        var right = pairs.Select(x => x.Value).ToList();

        return left.Sum() % k == 0 && right.Sum() % k == 0;
    }
}
// @lc code=end

