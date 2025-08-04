namespace _03.DegustationParty
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, Guest> guests = new();
            int dislikedFood = 0;
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Stop")
            {
                string[] arguments = input.Split("-");
                string command = arguments[0];
                string guestName = arguments[1];
                string meal = arguments[2];

                if (command == "Like")
                {
                    if (guests.ContainsKey(guestName))
                    {
                        if (!guests[guestName].LikedMeals.Contains(meal))
                        {
                            guests[guestName].LikedMeals.Add(meal);
                        }
                    }
                    else
                    {
                        Guest guest = new Guest();
                        guest.Name = guestName;
                        guest.LikedMeals.Add(meal);
                        guests.Add(guestName, guest);
                    }
                }
                else
                {
                    if (guests.ContainsKey(guestName))
                    {
                        if (guests[guestName].LikedMeals.Contains(meal))
                        {
                            guests[guestName].LikedMeals.Remove(meal);
                            Console.WriteLine($"{guestName} doesn't like the {meal}.");
                            dislikedFood++;
                        }
                        else
                        {
                            Console.WriteLine($"{guestName} doesn't have the {meal} in his/her collection.");
                        }

                    }
                    else
                    {
                        Console.WriteLine($"{guestName} is not at the party.");
                    }
                }
            }
            foreach (Guest guest in guests.Values)
            {
                Console.WriteLine($"{guest.Name}: {string.Join(", ", guest.LikedMeals)}");
            }
            Console.WriteLine($"Unliked meals: {dislikedFood}");
        }

        public class Guest
        {
            public string Name { get; set; }
            public List<string> LikedMeals = new List<string>();
        }
    }
}
