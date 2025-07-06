namespace _06.ListManipulationCommands
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] inputs = command.Split();

                switch (inputs[0])
                {
                    case "Add":
                        int numToAdd = int.Parse(inputs[1]);
                        list.Add(numToAdd   );
                        break;
                    case "Remove":
                        int numToRemove = int.Parse(inputs[1]);
                        list.Remove(numToRemove);
                        break;
                    case "RemoveAt":
                        int removeAt = int.Parse(inputs[1]);
                        list.RemoveAt(removeAt);
                        break;
                    case "Insert":
                        int numToInsert = int.Parse(inputs[1]);
                        int insertAt = int.Parse(inputs[2]);
                        list.Insert(insertAt, numToInsert);
                        break;
                }
            }

            Console.WriteLine(string.Join(" ", list));
        }
    }
}
