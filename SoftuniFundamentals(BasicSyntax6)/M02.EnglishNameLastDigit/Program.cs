namespace M02.EnglishNameLastDigit
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number = int.Parse(Console.ReadLine());

			int digit = number % 10;

			Dictionary<int, string> nameDict = new Dictionary<int, string>()
			{
				{0, "zero"},
				{1, "one"},
				{2, "two"},
				{3, "three"},
				{4, "four"},
				{5, "five"},
				{6, "six"},
				{7, "seven"},
				{8, "eight"},
				{9, "nine"},
			};

			if (nameDict.ContainsKey(digit))
			{
				Console.WriteLine(nameDict[digit]);
			}
		}
	}
}
