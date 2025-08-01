
using System;
using System.Reflection.PortableExecutable;
using System.Security.Cryptography.X509Certificates;

namespace _01.ActivationKeys
{
    internal class Program
    {
        public static string rawActivationKey { get; set; }
        static void Main(string[] args)
        {
            rawActivationKey = Console.ReadLine();
            string input = string.Empty;
            while ((input = Console.ReadLine()) != "Generate")
            {
                string[] arguments = input.Split(">>>");
                string instruction = arguments[0];
                switch (instruction)
                {
                    case "Contains":
                        string substring = arguments[1];
                        Console.WriteLine(Contains(substring));
                        break;
                    case "Flip":
                        string upperLowerStatus = arguments[1];
                        int startIndex = int.Parse(arguments[2]);
                        int endIndex = int.Parse(arguments[3]);
                        Flip(upperLowerStatus, startIndex, endIndex);
                        break;
                    case "Slice":
                        startIndex = int.Parse(arguments[1]);
                        endIndex = int.Parse(arguments[2]);
                        Slice(startIndex, endIndex);
                        break;
                }
            }
            Console.WriteLine($"Your activation key is: {rawActivationKey}");
        }


        private static string Contains(string substring)
        {
            if (rawActivationKey.Contains(substring))
            {
                return $"{rawActivationKey} contains {substring}";
            }
            return "Substring not found!";
        }
        private static void Flip(string upperLowerStatus, int startIndex, int endIndex)
        {
            if (upperLowerStatus == "Upper")
            {
                string prefix = rawActivationKey.Substring(0, startIndex);
                string middle = rawActivationKey.Substring(startIndex, endIndex - startIndex).ToUpper();
                string sufix = rawActivationKey.Substring(endIndex);

                rawActivationKey = prefix + middle + sufix;
            }
            else
            {
                string prefix = rawActivationKey.Substring(0, startIndex);
                string middle = rawActivationKey.Substring(startIndex, endIndex - startIndex).ToLower();
                string sufix = rawActivationKey.Substring(endIndex);
                rawActivationKey = prefix + middle + sufix;
            }
            Console.WriteLine(rawActivationKey);
        }
        private static void Slice(int startIndex, int endIndex)
        {
            rawActivationKey = rawActivationKey.Remove(startIndex, endIndex - startIndex);
            Console.WriteLine(rawActivationKey);

        }
    }
}
