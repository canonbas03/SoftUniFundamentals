namespace _07.AppendArrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<string> list = Console.ReadLine()
                 .Split("|", StringSplitOptions.RemoveEmptyEntries)
                 .ToList();

            List<string> finalList = new List<string>();
            for (int i = list.Count - 1; i >= 0; i--)
            {
                List<string> partList = list[i].Split(" ",StringSplitOptions.RemoveEmptyEntries).ToList();

                finalList.AddRange(partList);
            }
            Console.WriteLine(string.Join(" ", finalList));
        }
    }
}
