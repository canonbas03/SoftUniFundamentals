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
			bool isProblem = false;
			for (int i = 0; i < lineNum; i++)
			{
				string input = Console.ReadLine();

				if (input == "(")
				{
					leftBrCounter++;
					isProblem = true;
				}

				else if (input == ")")
				{
					rightBrCounter++;
					if (leftBrCounter == 1 && rightBrCounter == 1)
					{
						isClosed = true;
						leftBrCounter = 0;
						rightBrCounter = 0;
						isProblem = false;
					}
					else
					{
						isClosed = false;
					}
				
				}
			}
			if (isClosed && !isProblem)
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
