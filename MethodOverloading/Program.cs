namespace MethodOverloading
{
    public class Program
    {
        static void Main(string[] args)
        {
            
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
