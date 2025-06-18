namespace _07.AdvancedManipulation
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<int> list = Console.ReadLine().Split().Select(int.Parse).ToList();

            string command = string.Empty;
            bool changeMade = false;
            while ((command = Console.ReadLine()) != "end")
            {
                string[] inputs = command.Split();

                switch (inputs[0])
                {
                    case "Add":
                        int numToAdd = int.Parse(inputs[1]);
                        list.Add(numToAdd);
                        changeMade = true;
                        break;
                    case "Remove":
                        int numToRemove = int.Parse(inputs[1]);
                        list.Remove(numToRemove);
                        changeMade = true;
                        break;
                    case "RemoveAt":
                        int removeAt = int.Parse(inputs[1]);
                        list.RemoveAt(removeAt);
                        changeMade = true;
                        break;
                    case "Insert":
                        int numToInsert = int.Parse(inputs[1]);
                        int insertAt = int.Parse(inputs[2]);
                        list.Insert(insertAt, numToInsert);
                        changeMade = true;
                        break;
                    case "Contains":
                        int numToCheck = int.Parse(inputs[1]);
                        if (list.Contains(numToCheck))
                        {
                            Console.WriteLine("Yes");
                            break;
                        }
                        Console.WriteLine("No such number");
                        break;
                    case "PrintEven":
                        foreach (int number in list)
                        {
                            if (number % 2 == 0)
                            {
                                Console.Write(number + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "PrintOdd":
                        foreach (int number in list)
                        {
                            if (number % 2 != 0)
                            {
                                Console.Write(number + " ");
                            }
                        }
                        Console.WriteLine();
                        break;
                    case "GetSum":
                        int sum = default;
                        foreach (int number in list)
                        {
                            sum += number;
                        }
                        Console.WriteLine(sum);
                        break;
                    case "Filter":
                        string condition = inputs[1];
                        int numberToCheck= int.Parse(inputs[2]);
                        switch (condition)
                        {
                            case ">":
                                foreach (int element in list)
                                {
                                    if(element > numberToCheck)
                                    {
                                        Console.Write(element + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case "<":
                                foreach (int element in list)
                                {
                                    if (element < numberToCheck)
                                    {
                                        Console.Write(element + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case ">=":
                                foreach (int element in list)
                                {
                                    if (element >= numberToCheck)
                                    {
                                        Console.Write(element + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                            case "<=":
                                foreach (int element in list)
                                {
                                    if (element <= numberToCheck)
                                    {
                                        Console.Write(element + " ");
                                    }
                                }
                                Console.WriteLine();
                                break;
                        }
                        break;
                }
            }
            if(changeMade)
            {
                Console.WriteLine(string.Join(" ", list));
            }
            
        }
    }
}

