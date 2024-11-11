/*
 * @lc app=leetcode id=155 lang=csharp
 *
 * [155] Min Stack
 */

// @lc code=start
public class MinStack {

    private readonly Stack<int> _stack;
    private readonly Stack<int> _minStack;

    public MinStack() {
        _stack = new Stack<int>();
        _minStack = new Stack<int>();
    }
    
    public void Push(int val) {
        _stack.Push(val);
        val = Math.Min(val, _minStack.Count == 0 ? val : _minStack.Peek());
        _minStack.Push(val);
    }
    
    public void Pop() {
        _stack.Pop();
        _minStack.Pop();
    }
    
    public int Top() {
        return _stack.Peek();
    }
    
    public int GetMin() {
        return _minStack.Peek();
    }
}

/**
 * Your MinStack object will be instantiated and called as such:
 * MinStack obj = new MinStack();
 * obj.Push(val);
 * obj.Pop();
 * int param_3 = obj.Top();
 * int param_4 = obj.GetMin();
 */
// @lc code=end

