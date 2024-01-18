namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine($"5 + 3 = {Add(5,3)}");
            Console.WriteLine();
            Console.WriteLine($"5.2 + 3.5 = {Add(5.2m, 3.5m)}");
            Console.WriteLine();
            Console.WriteLine($"5 dollars + 3 dollars = {Add(5, 3, true)}");
            Console.WriteLine($"1 dollar + 0 dollars = {Add(1, 0, true)}");
        }

        public static int Add(int a, int b)
        {
            return a + b;
        }

        public static decimal Add(decimal a, decimal b)
        {
            return a + b;
        }

        public static string Add(int a, int b, bool isDollars)
        {
            if (a + b == 1 || a + b == -1)
            {
                return $"{a + b} dollar";
            }
            else
            {
                return $"{a + b} dollars";
            }
        }
    }
}
