/*
 * @lc app=leetcode id=71 lang=csharp
 *
 * [71] Simplify Path
 */

// @lc code=start
public class Solution {
    public string SimplifyPath(string path) {
        var parts = path.Split('/');
        var stack = new Stack<string>();

        foreach(var part in parts){
            if(part == ".."){
                if(stack.Any()){
                    stack.Pop();
                }
                continue;
            }

            if(part == "." || string.IsNullOrEmpty(part)){
                continue;
            }

            stack.Push(part);
        }

        var builder = new StringBuilder();
        foreach(var part in stack.Reverse()){
            builder.Append("/");
            builder.Append(part);
        }

        return builder.Length == 0 ? "/" : builder.ToString();
    }
}
// @lc code=end

