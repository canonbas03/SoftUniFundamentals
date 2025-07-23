using System.Reflection.Metadata.Ecma335;

namespace _05.MultiplyBigNumber
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string bigNumber = Console.ReadLine();
            int multiplier = int.Parse(Console.ReadLine());

            char[] resultChars = new char[bigNumber.Length + 1];
            string result = string.Empty;
            if (multiplier == 0 || bigNumber == "0")
            {
                result = "0";
            }
            else
            {
                int carry = 0;
                for (int i = bigNumber.Length - 1; i >= 0; i--)
                {
                    int digit = int.Parse(bigNumber[i].ToString());
                    int product = digit * multiplier + carry;

                    resultChars[i + 1] = (char)((product % 10) + '0');
                    carry = product / 10;
                }

                if (carry != 0)
                {
                    resultChars[0] = (char)(carry + '0');
                }
                result = new string(resultChars).Trim();
            }
                Console.WriteLine(result);
        }
    }
}
