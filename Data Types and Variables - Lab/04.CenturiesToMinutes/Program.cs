namespace _04.CenturiesToMinutes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			uint centuries = uint.Parse(Console.ReadLine());

			uint years = (uint)(centuries * 100);
			uint days = (uint)(years * 365.2422);
			uint hours = (uint)(days * 24);
			uint minutes = (uint)(hours * 60);

			Console.WriteLine($"{centuries} centuries = {years} years = {days} " +
				$"days = {hours} hours = {minutes} minutes");
		}
	}
}
