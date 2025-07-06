namespace _01.DayOfWeek
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] days = { "Monday", "Tuesday", "Wednesday", "Thursday", "Friday", "Saturday", "Sunday" };

			int index = int.Parse(Console.ReadLine());
			if(index <= 7 && index >0)
			Console.WriteLine(days[index-1]);

			else { Console.WriteLine("Invalid day!"); }
        }
	}
}
