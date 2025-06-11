namespace _09.GreaterOfTwo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string type = Console.ReadLine();

			if (type == "int")
			{
				int first = int.Parse(Console.ReadLine());
				int second = int.Parse(Console.ReadLine());
				Console.WriteLine(GetMax(first, second));
			}
			else if (type == "char")
			{
				char first = char.Parse(Console.ReadLine());
				char second = char.Parse(Console.ReadLine());
				Console.WriteLine(GetMax(first, second));
			}
			else
			{
				string first = Console.ReadLine();
				string second = Console.ReadLine();
				Console.WriteLine(GetMax(first, second));
			}
		}

		static int GetMax(int a, int b)
		{
			if (a > b)
			{
				return a;
			}
			return b;
		}

		static char GetMax(char a, char b)
		{
			if (a > b)
			{
				return a;
			}
			return b;
		}

		static string GetMax(string a, string b)
		{
			if (a.CompareTo(b) == 1)
			{
				return a;
			}
			return b;
		}
	}
}
