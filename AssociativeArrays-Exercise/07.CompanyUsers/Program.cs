namespace _07.CompanyUsers
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Dictionary<string, List<string>> companyEmployees = new();

            string input;
            while((input = Console.ReadLine()) != "End")
            {
                string[] arguments = input.Split(" -> ");
                string company = arguments[0];
                string employeeID = arguments[1];
                if (!companyEmployees.ContainsKey(company))
                {
                    companyEmployees[company] = new List<string>();
                }
                if (!companyEmployees[company].Contains(employeeID))
                {
                    companyEmployees[company].Add(employeeID);
                }
            }
            foreach(KeyValuePair<string, List<string>> pair in companyEmployees)
            {
                Console.WriteLine(pair.Key);
                foreach(string id in pair.Value)
                {
                    Console.WriteLine($"-- {id}");
                }
            }
        }
    }
}
