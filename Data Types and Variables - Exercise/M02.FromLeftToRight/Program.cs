namespace M02.FromLeftToRight
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int numbers = int.Parse(Console.ReadLine());
			for (int i = 0; i < numbers; i++)
			{

				string firstNumber = string.Empty;
				string secondNumber = string.Empty;
				string numberStack = Console.ReadLine();
				for (int j = 0; j < numberStack.Length; j++)
				{
					if (numberStack[j] != ' ')
					{
						firstNumber += numberStack[j];
					}
					else
					{
						for (int s = firstNumber.Length + 1; s < numberStack.Length; s++)
						{
							secondNumber += numberStack[s];
						}
						break;
					}
				}

				//Console.WriteLine(firstNumber);
				//Console.WriteLine(secondNumber);

				long intFirstNum = 0;
				long intSecondNum = 0;
				long.TryParse(firstNumber, out intFirstNum);
				long.TryParse(secondNumber, out intSecondNum);

				int totalOfDigits = 0;
				if (intFirstNum >= intSecondNum)
				{
					intFirstNum = Math.Abs(intFirstNum);
					while (intFirstNum > 0)
					{
						int lastDigit = (int)(intFirstNum % 10);
						totalOfDigits += lastDigit;
						intFirstNum /= 10;
					}
				}
				else
				{
					intSecondNum = Math.Abs(intSecondNum);
					while (intSecondNum > 0)
					{
						int lastDigit = (int)(intSecondNum % 10);
						totalOfDigits += lastDigit;
						intSecondNum /= 10;
					}
				}
				Console.WriteLine(totalOfDigits);
			}
		}
	}
}
