namespace _04.ArrayRotation
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] elements = Console.ReadLine().Split();
			int rotationNum = int.Parse(Console.ReadLine());

			for (int i = 0; i < rotationNum; i++)
			{
					string firstElement = elements[0];
				for (int j = 0; j < elements.Length -1; j++)
				{
					elements[j] = elements[j + 1];

				}
				elements[elements.Length - 1] = firstElement;
			}
            Console.WriteLine(string.Join(" ", elements));
        }
	}
}
