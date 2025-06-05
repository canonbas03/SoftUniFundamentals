namespace _04.CenturiesToMinutes
{
	internal class Program
	{
		static void Main(string[] args)
		{
			uint yearIndex = 100;
			double dayIndex = 365.2422;
			sbyte hourIndex = 24;
			sbyte minuteIndex = 60;

			int centuries = int.Parse(Console.ReadLine());

			Console.WriteLine($"{centuries} centuries = {centuries * yearIndex} years = {(int)(centuries * yearIndex * dayIndex)} " +
				$"days = {(int)(centuries * yearIndex * dayIndex * hourIndex)} hours = {(int)(centuries * yearIndex * dayIndex * hourIndex * minuteIndex)} minutes");
		}
	}
}
