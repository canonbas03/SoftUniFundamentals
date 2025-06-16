



namespace _04.PasswordValidator
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string? password = Console.ReadLine();
            Console.WriteLine(PasswordValidator(password));
        }

        private static string PasswordValidator(string? password)
        {
            bool inDiapason = Contains6To10(password);
            bool onlyLetters = ContainsOnlyLettersDigits(password);
            bool doesContain2Digits = ContainsAtLeast2Digits(password);

            if (!inDiapason)
            {
                Console.WriteLine("Password must be between 6 and 10 characters");
            }
            if (!onlyLetters)
            {
                Console.WriteLine("Password must consist only of letters and digits");
            }
            if (!doesContain2Digits)
            {
                Console.WriteLine("Password must have at least 2 digits");
            }
            if (inDiapason && onlyLetters && doesContain2Digits)
            {
                return "Password is valid";
            }
            return string.Empty;
        }

        private static bool ContainsAtLeast2Digits(string password)
        {
            int counter = default;
            foreach (char c in password)
            {
                if (char.IsDigit(c))
                {
                    counter++;
                }
                if (counter >= 2)
                {
                    return true;
                }
            }
            return false;
        }

        private static bool ContainsOnlyLettersDigits(string password)
        {
            foreach (char c in password)
            {
                if (c >= '0' && c <= '9' || c >= 'a' && c <= 'z' || c >= 'A' && c <= 'Z')
                {
                    continue;
                }
                else
                {
                    return false;
                }
            }
            return true;
        }

        private static bool Contains6To10(string password)
        {
            if (password.Length >= 6 && password.Length <= 10)
            {
                return true;
            }
            return false;
        }
    }
}
