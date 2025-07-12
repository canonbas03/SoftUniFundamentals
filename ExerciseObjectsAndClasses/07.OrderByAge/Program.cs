namespace _07.OrderByAge
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Person> people = new List<Person>();
            string input;
            while ((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split();

                Person person = new Person(arguments[0], arguments[1], int.Parse(arguments[2]));

                Person foundPerson = people.Find(p => p.ID == arguments[1]);
                if (foundPerson != null)
                {
                    foundPerson.Name = arguments[0];
                    foundPerson.ID = arguments[1];
                    foundPerson.Age = int.Parse(arguments[2]);
                }
                else
                {
                    people.Add(person);
                }
            }

            people = people.OrderBy(p => p.Age).ToList();
            people.ForEach(p => Console.WriteLine(p));

        }
    }

    public class Person
    {
        public Person(string name, string id, int age)
        {
            Name = name;
            ID = id;
            Age = age;
        }
        public string Name { get; set; }
        public string ID { get; set; }
        public int Age { get; set; }

        public override string ToString()
        {
            string result = $"{Name} with ID: {ID} is {Age} years old.";
            return result;
        }
    }
}

