namespace ConsoleApp4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Color redColor = new Color(255, 0, 0);
            Color blueColor = new Color(0, 0, 255, 200);

            Ball ball1 = new Ball(10, redColor);
            Ball ball2 = new Ball(15, blueColor);

            ball1.Throw();
            ball1.Throw();
            ball1.Throw();

            ball2.Throw();
            ball2.Throw();
            ball2.Pop();
            ball2.Throw();

            Console.WriteLine($"Ball 1 [size: {ball1.Size}, color: {ball1.Color}] thrown {ball1.GetThrowCount()} times.");
            Console.WriteLine($"Ball 2 [size: {ball2.Size}, color: {ball2.Color}] thrown {ball2.GetThrowCount()} times.");
        }
    }

    public class Color
    {
        public int Red { get; set; }
        public int Green { get; set; }
        public int Blue { get; set; }
        public int Alpha { get; set; }

        public Color(int red, int green, int blue, int alpha)
        {
            Red = red;
            Green = green;
            Blue = blue;
            Alpha = alpha;
        }

        public Color(int red, int green, int blue) : this(red, green, blue, 255) { }

        public int GetGrayscale()
        {
            return (Red + Green + Blue) / 3;
        }
    }

    public class Ball
    {
        public int Size { get; set; }
        public Color Color { get; set; }
        
        private int throwCount;

        public Ball(int size, Color color)
        {
            Size = size;
            Color = color;
            throwCount = 0;
        }

        public void Pop()
        {
            Size = 0;
        }

        public void Throw()
        {
            if (Size != 0)
            {
                throwCount++;
            }
        }

        public int GetThrowCount()
        {
            return throwCount;
        }
    }
}