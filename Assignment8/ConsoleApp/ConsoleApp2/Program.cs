namespace ConsoleApp2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            MyList<int> myList = new MyList<int>();

            myList.Add(5);
            myList.Add(10);
            myList.Add(15);
            myList.InsertAt(0, 0);

            Console.WriteLine("List contents:");
            for (int i = 0; i < myList.Count(); i++)
            {
                Console.WriteLine(myList.Find(i));
            }

            myList.DeleteAt(1);
            myList.Remove(0);

            Console.WriteLine("List contents after deletions:");
            for (int i = 0; i < myList.Count(); i++)
            {
                Console.WriteLine(myList.Find(i));
            }

            Console.WriteLine($"Contains 15? {myList.Contains(15)}");
            Console.WriteLine($"Contains 20? {myList.Contains(20)}");

            myList.Clear();

            Console.WriteLine("List contents after clearing:");
            for (int i = 0; i < myList.Count(); i++)
            {
                Console.WriteLine(myList.Find(i));
            }
        }
    }
    public class MyList<T>
    {
        private List<T> myList;

        public MyList()
        {
            myList = new List<T>();
        }

        public void Add(T element)
        {
            myList.Add(element);
        }

        public T Remove(int index)
        {
            T item = myList[index];
            myList.RemoveAt(index);
            return item;
        }

        public bool Contains(T element)
        {
            return myList.Contains(element);
        }

        public void Clear()
        {
            myList.Clear();
        }

        public void InsertAt(T element, int index)
        {
            myList.Insert(index, element);
        }

        public void DeleteAt(int index)
        {
            myList.RemoveAt(index);
        }

        public T Find(int index)
        {
            return myList[index];
        }
        public int Count()
        {
            return myList.Count;
        }
    }

}