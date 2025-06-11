namespace _03.Calculations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string operation = Console.ReadLine();
			int number1 = int.Parse(Console.ReadLine());
			int number2 = int.Parse(Console.ReadLine());

			switch (operation)
			{
				case "add":
					CalculateAdd(number1, number2);
					break;
				case "subtract":
					CalculateSub(number1, number2);
					break;
				case "multiply":
					CalculateMul(number1, number2);
					break;
				case "divide":
					CalculateDiv(number1, number2);
					break;
				default:
					break;
			}
		}

		static void CalculateAdd(int num1, int num2)
		{
            Console.WriteLine(num1 + num2);
        }
		static void CalculateSub(int num1, int num2)
		{
            Console.WriteLine(num1 - num2);
        }
		static void CalculateMul(int num1, int num2)
		{
            Console.WriteLine(num1 * num2);
        }
		static void CalculateDiv(int num1, int num2)
		{
            Console.WriteLine(num1 / num2);
        }
	}
}
