namespace _03.Elevator
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int persons = int.Parse(Console.ReadLine());
			int capacity = int.Parse(Console.ReadLine());

			Console.WriteLine(Math.Ceiling((double)persons / capacity));
		}
	}
}
