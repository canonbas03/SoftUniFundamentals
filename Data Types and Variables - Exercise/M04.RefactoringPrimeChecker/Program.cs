namespace M04.RefactoringPrimeChecker
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int end = int.Parse(Console.ReadLine());

			for (int initial = 2; initial <= end; initial++)

			{

				bool isPrime = true;

				for (int divider = 2; divider < initial; divider++)

				{

					if (initial % divider == 0)

					{

						isPrime = false;

						break;

					}

				}

				Console.WriteLine("{0} -> {1}", initial, isPrime.ToString().ToLower());

			}
		}
	}
}
