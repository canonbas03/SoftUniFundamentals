namespace M03.FloatingArythmethics
{
	internal class Program
	{
		static void Main(string[] args)
		{
			decimal eps = 0.000001m;

			double first = double.Parse(Console.ReadLine());
			double second = double.Parse(Console.ReadLine());

			decimal result = (decimal)(first - second);

			if(Math.Abs(result) < eps)
			{
                Console.WriteLine("True");
            }
			else
			{
                Console.WriteLine("False");
            }
		}
	}
}
