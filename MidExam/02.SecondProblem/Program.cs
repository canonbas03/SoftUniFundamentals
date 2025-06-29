namespace _02.SecondProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] friendsArr = Console.ReadLine().Split(", ").ToArray();

            string command;
            while ((command = Console.ReadLine()) != "Report")
            {
                string[] arguments = command.Split().ToArray();


                int index = default;
                string name = string.Empty;
                switch (arguments[0])
                {
                    case "Blacklist":
                        name = arguments[1];
                        if (friendsArr.Contains(name))
                        {
                            for (int i = 0; i < friendsArr.Length; i++)
                            {
                                if (friendsArr[i] == name)
                                {
                                    Console.WriteLine($"{name} was blacklisted.");
                                    friendsArr[i] = "Blacklisted";
                                }
                            }
                                    break;
                        }
                        Console.WriteLine($"{name} was not found.");
                        break;

                    case "Error":
                        index = int.Parse(arguments[1]);
                        if (index >= 0 && index < friendsArr.Length)
                        {
                            if (friendsArr[index] != "Lost" && friendsArr[index] != "Blacklisted")
                            {
                                string nameOfPerson = friendsArr[index];
                                friendsArr[index] = "Lost";
                                Console.WriteLine($"{nameOfPerson} was lost due to an error.");
                            }
                        }
                        break;

                    case "Change":
                        index = int.Parse(arguments[1]);
                        name = arguments[2];
                        if (index >= 0 && index < friendsArr.Length)
                        {
                            string nameOfPerson = friendsArr[index];
                            friendsArr[index] = name;
                            Console.WriteLine($"{nameOfPerson} changed his username to {name}.");
                        }
                        break;
                }
            }
            int blacklistedCount = 0;
            int lostCount = 0;

            foreach (string friend in friendsArr)
            {
                if( friend == "Blacklisted")
                {
                    blacklistedCount++;
                }
                else if ( friend == "Lost")
                {
                    lostCount++;
                }
            }

            Console.WriteLine($"Blacklisted names: {blacklistedCount}");
            Console.WriteLine($"Lost names: {lostCount}");
            Console.WriteLine(string.Join(" ",friendsArr));

        }
    }
}
