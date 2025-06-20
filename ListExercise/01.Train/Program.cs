using System.Numerics;

namespace _01.Train
{
    /*
0 0 0 10 2 4
10
Add 10
10
10
10
8
6
end

32 54 21 12 4 0 23
75
Add 10
Add 0
30
10
75
end
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> wagons = Console.ReadLine().Split().Select(int.Parse).ToList();
            int maxCapacity = int.Parse(Console.ReadLine());

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] values = command.Split();

                if (values[0] == "Add")
                {
                    wagons.Add(int.Parse(values[1]));
                }
                else
                {
                    for (int i = 0; i < wagons.Count; i++)
                    {
                        if ((wagons[i] + int.Parse(values[0])) <= maxCapacity)
                        {
                            wagons[i] += int.Parse(values[0]);
                            break;
                        }

                    }
                }
            }
            Console.WriteLine(string.Join(" ", wagons));
        }
    }
}
