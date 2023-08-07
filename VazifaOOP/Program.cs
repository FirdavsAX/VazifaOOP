namespace VazifaOOP
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Hello, World!");

            Rectangle a = new Rectangle();

            a.SetHeight(12.2);
            a.SetWidth(10);
            a.Calculate();
            Console.WriteLine();
        }
    }
    class Rectangle
    {
        public double Height  { get; private set; }
        public double Width { get;private set; }

        public void SetHeight(double height)
        {
            if (height <= 0)
            {
                Console.WriteLine("Height can't be this format!");
                return;
            }
            Height = height;
            Console.WriteLine(Height);
        }
        public void SetWidth(double width)
        {
            if (width <= 0)
            {
                Console.WriteLine("width can't be this format!");
                return;
            }
            Width = width;
            Console.WriteLine(Width);
        }
        public void Calculate()
        {
            Console.WriteLine("result : " +  (Height*Width));
        }
        

    }
}