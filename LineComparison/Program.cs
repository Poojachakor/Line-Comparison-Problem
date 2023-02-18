namespace LineComparison
{
    internal class Program
    {
        static void Main(string[] args)
        {


            Console.WriteLine("Enter the value for cooridinate x1");
            int x1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for cooridinate y1");
            int y1 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for cooridinate x2");
            int x2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for cooridinate y2");
            int y2 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for cooridinate x3");
            int x3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for cooridinate y3");
            int y3 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for cooridinate x4");
            int x4 = Convert.ToInt32(Console.ReadLine());
            Console.WriteLine("Enter the value for cooridinate y4");
            int y4 = Convert.ToInt32(Console.ReadLine());

            double first = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            double second = Math.Sqrt(Math.Pow((x4 - x3), 2) + Math.Pow((y4 - y3), 2));
            Console.WriteLine("Welcome to the Line Comparison Problems");
            Console.WriteLine("Length of Line1:" + first);
            Console.WriteLine("Length of Line2:" + second);

            double compare = first.CompareTo(second);

            if (compare >= 0)
            {
                Console.WriteLine("First line is greater than second line");
            }
            else
            {
                Console.WriteLine("Second line is greater than first line");
            }
            Console.ReadLine();
        }
    }
}