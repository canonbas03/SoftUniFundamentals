namespace M01.SortNumbers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int num1 = int.Parse(Console.ReadLine());
			int num2 = int.Parse(Console.ReadLine());
			int num3 = int.Parse(Console.ReadLine());

			List<int> sortedList = new List<int>();

			sortedList.Add(num1);
			sortedList.Add(num2);
			sortedList.Add(num3);

			sortedList.Sort();
			sortedList.Reverse();

			foreach (int item in sortedList)
			{

				Console.WriteLine(item);
			}
		}
	}
}
