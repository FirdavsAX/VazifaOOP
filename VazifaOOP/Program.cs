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
           

            Student student1 = new Student();

            student1.SetName("Ronald Tolkien");
            student1.SetRollNumber(12345);
            student1.SetMarks(2,3,4,4,4,5);
            
            student1.CalculateTotalPoint();
            
            Console.ReadKey();
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
    class Student
    {
        public string Name { get; private set; }
        public int RollNumber { get; private set; }
        public int[] Marks { get; private set; }

        public void SetName(string fullName)
        {
            if (string.IsNullOrEmpty(fullName))
            {
                Console.WriteLine("Name is empty");
                return;
            }
        }
        public void SetRollNumber(int rollNumber)
        {
            if(rollNumber <=0)
            {
                Console.WriteLine("Incorrect form!");
                return;
            }
            RollNumber = rollNumber;

        }
        public void SetMarks(params int[] marks)
        {
            if (marks.Length == 0)
            {
                Console.WriteLine("Marks are empty !");
                return;
            }
            Marks = marks;
        }

       public void CalculateTotalPoint()
        {
            Console.WriteLine("Your overage point : " + Marks.Sum() / Marks.Length);
        }
    }
}