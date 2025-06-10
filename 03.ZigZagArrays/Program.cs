namespace _03.ZigZagArrays
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int lines = int.Parse(Console.ReadLine());

			string[] arrayOne = new string[lines];
			string[] arrayTwo = new	string[lines];
			for (int i = 0; i < lines; i++)
			{
				string[] input = Console.ReadLine().Split();
				if(i % 2 == 0)
				{
					arrayOne[i] = input[0];
					arrayTwo[i] = input[1];
				}
				else
				{
					arrayOne[i] = input[1];
					arrayTwo[i] = input[0]; 
				}
			}

            Console.WriteLine(string.Join(" ", arrayOne));
            Console.WriteLine(string.Join(" ", arrayTwo));
        }
	}
}
