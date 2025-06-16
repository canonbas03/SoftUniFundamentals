
namespace _08.FactorialDivision
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());

            double result = Factorial(number1) / Factorial(number2);
            Console.WriteLine($"{result:f2}");
        }

        private static int Factorial(int number)
        {
            int result = 1;
            for (int i = number; i > 0; i--) 
            {
                result *= i;
            }
            return result;
        }
    }
}
