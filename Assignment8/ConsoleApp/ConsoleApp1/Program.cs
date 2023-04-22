namespace ConsoleApp1
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyStack<int> myStack = new MyStack<int>();
            myStack.Push(1);
            myStack.Push(2);
            Console.WriteLine(myStack.Count());
            myStack.Pop();
            myStack.Pop();
            Console.WriteLine(myStack.Count());
        }
        class MyStack<T>
        {
            private List<T> myStack;
            public MyStack()
            {
                myStack = new List<T>();
            }
            public int Count()
            {
                return myStack.Count;
            }

            public T Pop()
            {
                if (myStack.Count == 0)
                {
                    throw new InvalidOperationException("The stack is empty.");
                }

                T item = myStack[myStack.Count - 1];
                myStack.RemoveAt(myStack.Count - 1);
                return item;
            }

            public void Push(T item)
            {
                myStack.Add(item);
            }
        }
    }
}