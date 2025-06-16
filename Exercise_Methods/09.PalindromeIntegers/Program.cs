
namespace _09.PalindromeIntegers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command = string.Empty;
            List<int> list = new List<int>();
            while ((command = Console.ReadLine()) != "END")
            {
                list.Add(int.Parse(command));
            }
            FindPalindrome(list);
        }

        private static void FindPalindrome(List<int> list)
        {

            foreach (int i in list)
            {
                int first = i;
                int second = default;

                while(first!=0)
                {
                    int digit = first % 10;
                    second = second * 10 + digit;
                    first /= 10;
                }
                if(i == second)
                {
                    Console.WriteLine("true");
                }
                else
                {
                    Console.WriteLine("false");
                }
            }
        }
    }
}
