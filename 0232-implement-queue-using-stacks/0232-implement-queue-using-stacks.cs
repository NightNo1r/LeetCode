public class MyQueue {

    private readonly Stack<int> first;
    private readonly Stack<int> second;

    public MyQueue() {
        first = new Stack<int>();
        second = new Stack<int>();
    }
    
    public void Push(int x) {
        while(second.Count > 0)
        {
            first.Push(second.Pop());
        }
        first.Push(x);

        while(first.Count > 0)
        {
            second.Push(first.Pop());
        }
    }
    
    public int Pop() {
        second.Pop();
    }
    
    public int Peek() {
        return second.Peek();
    }
    
    public bool Empty() {
        return second.Count == 0;
    }
}

/**
 * Your MyQueue object will be instantiated and called as such:
 * MyQueue obj = new MyQueue();
 * obj.Push(x);
 * int param_2 = obj.Pop();
 * int param_3 = obj.Peek();
 * bool param_4 = obj.Empty();
 */