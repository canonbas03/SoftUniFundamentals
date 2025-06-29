namespace _03.ThirdProblem
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string command;
            List<string> chat = new List<string>();
            while ((command = Console.ReadLine()) != "end")
            {
                List<string> arguments = command.Split().ToList();
                command = arguments[0];

                string message;
                switch (command)
                {
                    case "Chat":
                        message = arguments[1];
                        chat.Add(message);
                        break;
                    case "Delete":
                        message = arguments[1];
                        if (chat.Contains(message))
                        {
                            chat.Remove(message);
                        }
                        break;
                    case "Edit":
                        message = arguments[1];
                        string edit = arguments[2];
                        if (chat.Contains(message))
                        {
                            chat[chat.IndexOf(message)] = edit;
                        }
                        break;
                    case "Pin":
                        message = arguments[1];
                        if (chat.Contains(message))
                        {
                            chat.Remove(message);
                            chat.Add(message);
                        }
                        break;
                    case "Spam":
                        List<string> spams = arguments.GetRange(1, arguments.Count - 1);
                        chat.AddRange(spams);
                        break;
                }
            }
            Console.WriteLine(string.Join("\n", chat));
        }
    }
}
