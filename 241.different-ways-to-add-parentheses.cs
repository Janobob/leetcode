/*
 * @lc app=leetcode id=241 lang=csharp
 *
 * [241] Different Ways to Add Parentheses
 */

// @lc code=start
public class Solution {
    public IList<int> DiffWaysToCompute(string expression) {
        return Compute(expression);
    }

    public List<int> Compute(string expression){
        List<int> result = new List<int>();
        for(int i = 0; i < expression.Length; i++){
            // skip forward until operater is found
            if(expression[i] == '+' || expression[i] == '-' || expression[i] == '*'){

                // recursively compute left and right
                List<int> left = Compute(expression.Substring(0, i));
                List<int> right = Compute(expression.Substring(i+1));
                
                // combine left and right
                foreach(int l in left){
                    foreach(int r in right){
                        if(expression[i] == '+'){
                            result.Add(l + r);
                        }else if(expression[i] == '-'){
                            result.Add(l - r);
                        }else if(expression[i] == '*'){
                            result.Add(l * r);
                        }
                    }
                }
            }
        }
        if(result.Count == 0){
            result.Add(int.Parse(expression));
        }
        return result;
    }
}
// @lc code=end

