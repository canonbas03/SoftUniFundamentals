


namespace _10.TopNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());
            for (int i = 1; i <= number; i++)
            {
                if(isTopNumber(i))
                {
                    Console.WriteLine(i);
                }
            }
        }

        private static bool isTopNumber(int number)
        {
            bool divisibleBy8 = DivisibleBy8(number);
            bool holdsOddDigit = HoldsOdd(number);
            if (divisibleBy8 && holdsOddDigit)
            {
                return true;
            }
            return false;
        }

        private static bool HoldsOdd(int number)
        {
            while (number != 0)
            {
                int digit = number % 10;
                number /= 10;
                if (digit % 2 != 0)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool DivisibleBy8(int number)
        {
            int sumOfDigits = default;
            while (number != 0)
            {
                int digit = number % 10;
                sumOfDigits += digit;
                number /= 10;
            }
            if (sumOfDigits % 8 == 0)
            {
                return true;
            }
            return false;
        }
    }
}
