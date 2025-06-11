namespace _06.CalcRectangleArea
{
	internal class Program
	{
		static void Main(string[] args)
		{
            Console.WriteLine(AreaCalculator());
        }

		static double AreaCalculator()
		{
			double width = double.Parse(Console.ReadLine());
			double height = double.Parse(Console.ReadLine());
			return (width * height);
		}
	}
}
