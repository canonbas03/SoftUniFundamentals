namespace _04.ListOperations
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string commands = string.Empty;
            while ((commands = Console.ReadLine()) != "End")
            {
                List<string> arguments = commands.Split().ToList();

                switch (arguments[0])
                {
                    case "Add":
                        int numToAdd = int.Parse(arguments[1]);
                        list.Add(numToAdd);
                        break;
                    case "Insert":
                        int numToInsert = int.Parse(arguments[1]);
                        int indexToInsert = int.Parse(arguments[2]);
                        if (indexToInsert >= 0 && indexToInsert < list.Count)
                        {
                            list.Insert(indexToInsert, numToInsert);
                            break;
                        }

                        Console.WriteLine("Invalid index");
                        break;
                    case "Remove":
                        int indexToRemove = int.Parse(arguments[1]);
                        if (indexToRemove >= 0 && indexToRemove < list.Count)
                        {
                            list.RemoveAt(indexToRemove);
                            break;
                        }
                        Console.WriteLine("Invalid index");
                        break;
                    case "Shift":
                        int count = int.Parse(arguments[2]);
                        count %= list.Count;
                        List<int> shiftPart;
                        if (arguments[1] == "left")
                        {
                            shiftPart = list.GetRange(0, count);
                            list.RemoveRange(0, count);
                            list.InsertRange(list.Count, shiftPart);
                            break;
                        }
                        else
                        {
                            shiftPart = list.GetRange(list.Count - count, count);
                            list.RemoveRange(list.Count - count, count);
                            list.InsertRange(0, shiftPart);
                            break;
                        }
                }
            }
            Console.WriteLine(string.Join(" ", list));
        }
    }
}
