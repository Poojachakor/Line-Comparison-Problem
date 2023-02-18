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

            double LengthOfLine1 = Math.Sqrt(Math.Pow((x2 - x1), 2) + Math.Pow((y2 - y1), 2));
            Console.WriteLine("Welcome to the Line Comparison Problems");
            Console.WriteLine("Length of Line:" + LengthOfLine1);

            Console.ReadLine();
        }
    }
}