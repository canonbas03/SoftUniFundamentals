namespace _02.CommonElements
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string input = Console.ReadLine();
			string[] firstArray = input.Split();

			input = Console.ReadLine();
			string[] secondArray = input.Split();

			for (int i = 0; i < secondArray.Length; i++)
			{
				for (int j = 0; j < firstArray.Length; j++)
				{
					if (secondArray[i] == firstArray[j])
					{
						Console.Write(secondArray[i] + " ");
						break;
					}
				}
			}

		}
	}
}
