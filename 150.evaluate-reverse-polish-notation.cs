/*
 * @lc app=leetcode id=150 lang=csharp
 *
 * [150] Evaluate Reverse Polish Notation
 */

// @lc code=start
public class Solution {
    public int EvalRPN(string[] tokens) {
        var numberStack = new Stack<int>();

        foreach(var token in tokens){
            if(token == "+"){
                var right = numberStack.Pop();
                var left = numberStack.Pop();
                numberStack.Push(left + right);
            } else if(token == "-"){
                var right = numberStack.Pop();
                var left = numberStack.Pop();
                numberStack.Push(left - right);
            } else if(token == "*"){
                var right = numberStack.Pop();
                var left = numberStack.Pop();
                numberStack.Push(left * right);
            } else if(token == "/") {
                var right = numberStack.Pop();
                var left = numberStack.Pop();
                numberStack.Push(left / right);
            } else {
                numberStack.Push(getNumber(token));
            }
        }

        return numberStack.Pop();
    }

    
    private int getNumber(string token){
        int sign = 1;
        int index = 0;
        if(token[0] == '-'){
            sign = -1;
            index++;
        }
        int num = 0;
        while(index < token.Length){
            num = num * 10 + token[index++] - '0';
        }
        return sign * num;
    }
}
// @lc code=end

