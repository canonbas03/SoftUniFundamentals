
namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            long number1 = long.Parse(Console.ReadLine());
            long number2 = long.Parse(Console.ReadLine());

            double result = Factorial(number1) / Factorial(number2);
            Console.WriteLine($"{result:f2}");
        }

        private static double Factorial(long number)
        {
            double factorial = number;
            for (long i = number -1; i > 0; i--) 
            {
                factorial *= i;
            }
            return factorial;
        }
    }
}
