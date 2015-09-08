namespace ADTStack
{
    public class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> stack = new MyStack<int>();

            stack.Push(1);
            stack.Push(5);
            stack.Push(4);
            stack.Push(5);
            stack.Push(14);

            stack.Pop();

            //MyStack<string> stack = new MyStack<string>();

            //stack.Push("ank");
            //stack.TrimExcess();
        }
    }
}
