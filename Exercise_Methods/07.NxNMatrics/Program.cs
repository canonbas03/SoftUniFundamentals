
namespace _07.NxNMatrics
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int number = int.Parse(Console.ReadLine());

            MakeMatrics(number);
        }

        private static void MakeMatrics(int number)
        {
            for (int i = 0; i < number; i++)
            {
                for (int k = 0; k < number; k++)
                {
                    Console.Write(number + " ");
                }
                Console.WriteLine();
            }
        }
    }
}
