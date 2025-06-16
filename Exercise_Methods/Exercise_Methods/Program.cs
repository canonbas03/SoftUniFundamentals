
namespace _01.Same3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine(BiggestOfTree(number1, number2, number3));
        }

        private static int BiggestOfTree(int number1, int number2, int number3)
        {
            if (number1 <= number2 && number1 <= number3)
            {
                return number1;
            }
            else if (number2 <= number1 && number2 <= number3)
            {
                return number2;
            }
            return number3;
        }
    }
}
