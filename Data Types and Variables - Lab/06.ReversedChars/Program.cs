namespace _06.ReversedChars
{
	internal class Program
	{
		static void Main(string[] args)
		{
			List<char> list = new List<char>();

			for (int i = 0;i < 3; i++)
			{
				char ch = char.Parse(Console.ReadLine());
				list.Add(ch);
			}

			list.Reverse();

			foreach (char ch in list)
			{
				Console.Write(ch + " ");
			}
		}
	}
}
