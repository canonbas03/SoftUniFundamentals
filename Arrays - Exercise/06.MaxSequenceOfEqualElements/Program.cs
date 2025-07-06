namespace _06.MaxSequenceOfEqualElements
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int[] elements = Console.ReadLine().Split().Select(int.Parse).ToArray();

			int bestEl = 0, bestCount = 0;
			for (int i = 0; i < elements.Length; i++)
			{
				int currentEl = elements[i];
				int counter = 1;


				for (int j = i + 1; j < elements.Length; j++)
				{
					if (currentEl == elements[j])
					{
						counter++;
					}
					else
					{
						break;
					}
				}
				if (counter > bestCount)
				{
					bestCount = counter;
					bestEl = currentEl;
				}
			}
			for (int i = 0;i < bestCount; i++)
			{
                Console.Write(bestEl + " ");
            }
		}
	}
}
