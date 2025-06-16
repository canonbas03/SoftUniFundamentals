

namespace _05.AddAndSubtract
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number1 = int.Parse(Console.ReadLine());
            int number2 = int.Parse(Console.ReadLine());
            int number3 = int.Parse(Console.ReadLine());

            Console.WriteLine(SubtractTwo(SumTwo(number1,number2),number3));
        }

        private static int SubtractTwo(int a, int b)
        {
           return a - b;    
        }

        private static int SumTwo(int a, int b)
        {
            return a + b;
        }
    }
}
