namespace _05.Login
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string? userName = Console.ReadLine();
			

			string errorMessage = "Incorrect password. Try again.";
			int invalidCounter = 0;

			string password = string.Empty;
			for (int i = userName.Length - 1; i >= 0; i--)
			{
				password += userName[i];
			}

			while(true)
			{
				string? userPassword = Console.ReadLine();
				if (userPassword != password)
				{
					if (invalidCounter == 3)
					{
						Console.WriteLine($"User {userName} blocked!");
						Environment.Exit(0);
					}
					Console.WriteLine(errorMessage);
					invalidCounter++;
				}
				else
				{
					Console.WriteLine($"User {userName} logged in.");
					Environment.Exit(0);
				}
			}
			
		}
	}
}
