namespace _01.SecretChat
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string initialMessage = Console.ReadLine();

            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Reveal")
            {
                string[] arguments = input.Split(":|:", StringSplitOptions.RemoveEmptyEntries);
                string instruction = arguments[0];

                switch (instruction)
                {
                    case "InsertSpace":
                        int index = int.Parse(arguments[1]);
                        initialMessage = InsertSpace(initialMessage, index);
                        break;
                    case "Reverse":
                        string substring = arguments[1];
                        initialMessage = Reverse(initialMessage, substring);
                        break;
                    case "ChangeAll":
                        substring = arguments[1];
                        string replacement = arguments[2];
                        initialMessage = ChangeAll(initialMessage, substring, replacement);
                        break;
                }
            }

            Console.WriteLine($"You have a new text message: {initialMessage}");
        }

        private static string ChangeAll(string message, string substring, string replacement)
        {
            message = message.Replace(substring, replacement);
            Console.WriteLine(message);
            return message;
        }

        private static string Reverse(string message, string substring)
        {
            int index = message.IndexOf(substring);
            if (index >= 0)
            {
                string beforePart = message.Substring(0, index);
                string afterPart = message.Substring(index + substring.Length);
                string reversed = new string(substring.Reverse().ToArray());
                message = beforePart + afterPart + reversed;
                Console.WriteLine(message);
                return message;
            }
            else
            {
                Console.WriteLine("error");
            }

            return message;
        }

        public static string InsertSpace(string message, int index)
        {
            message = message.Insert(index, " ");
            Console.WriteLine(message);
            return message;
        }
    }
}
