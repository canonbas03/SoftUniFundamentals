namespace _01.ValidUsernames
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] usernames = Console.ReadLine().Split(", ");

            foreach (string username in usernames)
            {
                if (username.Length >= 3 && username.Length <= 16)
                {
                    bool isValid = username.All(character => char.IsLetterOrDigit(character) || character == '-' || character == '_');
                    //bool isLegal = true;
                    //foreach (char ch in username)
                    //{
                    //    if (char.IsLetterOrDigit(ch) || ch == '-' || ch == '_')
                    //    {

                    //    }
                    //    else
                    //    {
                    //        isLegal = false;
                    //        continue;
                    //    }
                    //}
                    if (isValid)
                    {
                        Console.WriteLine(username);
                    }
                }
            }
        }
    }
}
