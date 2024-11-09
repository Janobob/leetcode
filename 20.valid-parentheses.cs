/*
 * @lc app=leetcode id=20 lang=csharp
 *
 * [20] Valid Parentheses
 */

// @lc code=start
public class Solution {
    public bool IsValid(string s) {
        // stack for open parantheses
        var paranthesesStack = new Stack<char>();

        foreach(char c in s){
            // push open parantheses to stack
            if(c == '(' || c == '[' || c == '{'){
                paranthesesStack.Push(c);
            } else {
                // don't pop from empty stack
                if(paranthesesStack.Count == 0){
                    return false;
                }

                // pop from stack and compare if counterpart
                // otherwise the parantheses are invalid
                char top = paranthesesStack.Pop();
                if(c == ')' && top != '('){
                    return false;
                }
                if(c == ']' && top != '['){
                    return false;
                }
                if(c == '}' && top != '{'){
                    return false;
                }
            }
        }

        // return true if stack is empty
        return paranthesesStack.Count == 0;
    }
}
// @lc code=end

