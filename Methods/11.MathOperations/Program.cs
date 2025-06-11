namespace _11.MathOperations
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int number1 = int.Parse(Console.ReadLine());
			char @operator = char.Parse(Console.ReadLine());
			int number2 = int.Parse(Console.ReadLine());

            Console.WriteLine(Calculate(number1, @operator, number2));
        }

		static double Calculate(int a, char @operator, int b)
		{
			double result = 0;
			switch (@operator)
			{
				case '+':
					result = a + b;
					break;
				case '-':
					result = a - b;
					break;
				case '*':
					result = a * b;
					break;
				case '/':
					result = a / b;
					break;
			}
			return result;
		}
	}
}
