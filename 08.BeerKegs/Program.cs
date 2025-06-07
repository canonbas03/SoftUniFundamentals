namespace _08.BeerKegs
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int kegNum = int.Parse(Console.ReadLine());
			double volumeBest = 0;

			string modelBest=string.Empty;
			for (int i = 0;i<kegNum;i++)
			{
				string model = Console.ReadLine();
				float radius = float.Parse(Console.ReadLine());
				int height = int.Parse(Console.ReadLine());

				double volume = Math.PI * Math.Pow(radius,2) * height;

				if(volume >= volumeBest)
				{
					modelBest = model;
					volumeBest = volume;
				}
			}
            Console.WriteLine(modelBest);
        }
	}
}
