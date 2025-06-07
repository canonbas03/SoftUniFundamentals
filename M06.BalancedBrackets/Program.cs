namespace M06.BalancedBrackets
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int lineNum = int.Parse(Console.ReadLine());

			int leftBrCounter = 0;
			int rightBrCounter = 0;
			bool isClosed = true;
			for (int i = 0; i < lineNum; i++)
			{
				string input = Console.ReadLine();

				if (input == "(")
				{
					leftBrCounter++;
				}

				else if (input == ")")
				{
					rightBrCounter++;
					if (leftBrCounter == 1 && rightBrCounter == 1)
					{
						isClosed = true;
						leftBrCounter = 0;
						rightBrCounter = 0;
					}
					else
					{
						isClosed = false;
					}

				}
			}
			if (isClosed)
			{
				Console.WriteLine("BALANCED");
			}
			else
			{
				Console.WriteLine("UNBALANCED");
			}
		}
	}
}
