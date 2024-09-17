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

        var result = new ListNode((int)(sum % 10)); // Cast long to int
        var original = result;
        while(sum / 10 != 0){
            sum = sum / 10;
            result.next = new ListNode((int)(sum % 10)); // Cast long to int
            result = result.next;
        }

        return original;
    }

    public long ConvertToNumber(ListNode l){
        long num = 0;
        long offset = 1;
        while(l != null){
            num = num + (long)l.val * offset;
            offset = offset * 10L;
            l = l.next;
        }
        return num;
    }
}
// @lc code=end

