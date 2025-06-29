namespace _01.Problem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            double budget = double.Parse(Console.ReadLine());
            int students = int.Parse(Console.ReadLine());
            double flourPrice = double.Parse(Console.ReadLine());
            double eggPrice = double.Parse(Console.ReadLine());
            double apronPrice = double.Parse(Console.ReadLine());

            double totalAprons = apronPrice * Math.Ceiling(students * 1.20);
            double totalEggs = students * eggPrice * 10;


            double total = totalAprons + totalEggs;

            for (int i = 1; i <= students; i++)
            {
                if(i % 5 != 0)
                {
                    total += flourPrice;
                }
            }

            if(total <= budget)
            {
                Console.WriteLine($"Items purchased for {total:f2}$.");
            }
            else
            {
                Console.WriteLine($"{total-budget:f2}$ more needed.");
            }
        }
    }
}
