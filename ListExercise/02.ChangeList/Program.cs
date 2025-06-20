namespace _02.ChangeList
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = string.Empty;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] commands = command.Split();

                if (commands[0] == "Delete")
                {
                    int elementToDel = int.Parse(commands[1]);
                    for (int i = 0; i < list.Count; i++)
                    {
                        if (list[i] == elementToDel)
                        {
                            list.Remove(elementToDel);
                            i--;
                        }
                    }
                }
                else
                {
                    int elementToInsert = int.Parse(commands[1]);
                    int elementPos = int.Parse(commands[2]);
                    list.Insert(elementPos, elementToInsert);
                }
            }
        }
    }
}
