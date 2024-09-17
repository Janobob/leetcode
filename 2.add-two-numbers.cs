/*
 * @lc app=leetcode id=2 lang=csharp
 *
 * [2] Add Two Numbers
 */

// @lc code=start
/**
 * Definition for singly-linked list.
 * public class ListNode {
 *     public int val;
 *     public ListNode next;
 *     public ListNode(int val=0, ListNode next=null) {
 *         this.val = val;
 *         this.next = next;
 *     }
 * }
 */
public class Solution {
    public ListNode AddTwoNumbers(ListNode l1, ListNode l2) {
        var num1 = ConvertToNumber(l1);
        var num2 = ConvertToNumber(l2);
        var sum = num1 + num2;

        Console.WriteLine(num1);
        Console.WriteLine(num2);
        Console.WriteLine(sum);

        // Create the result linked list
        var result = new ListNode((int)(sum % 10)); // Cast BigInteger to int
        var original = result;
        sum /= 10;

        // Continue adding nodes for the rest of the sum
        while (sum != 0) {
            result.next = new ListNode((int)(sum % 10)); // Cast BigInteger to int
            sum /= 10;
            result = result.next;
        }

        return original;
    }

    public BigInteger ConvertToNumber(ListNode l) {
        BigInteger num = 0;
        BigInteger offset = 1;
        while (l != null) {
            num += (BigInteger)l.val * offset;
            offset *= 10;
            l = l.next;
        }
        return num;
    }
}
// @lc code=end

