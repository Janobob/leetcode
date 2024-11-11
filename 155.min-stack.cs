/*
 * @lc app=leetcode id=155 lang=csharp
 *
 * [155] Min Stack
 */

// @lc code=start
public class MinStack {

    private Node _root;

    record Node(int val, int min, Node prev) {}

    public MinStack() {
        _root = new(int.MaxValue,int.MaxValue,null);
    }
    
    public void Push(int val) {
        Node n = new(val, Math.Min(val, _root.min), _root);
        _root = n;
    }
    
    public void Pop() {
        _root = _root.prev;
    }
    
    public int Top() {
        return _root.val;
    }
    
    public int GetMin() {
        return _root.min;
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

