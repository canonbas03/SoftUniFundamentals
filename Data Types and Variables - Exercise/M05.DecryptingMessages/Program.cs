namespace M05.DecryptingMessages
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int key = int.Parse(Console.ReadLine());
			int lineNum = int.Parse(Console.ReadLine());
			string finalWord = string.Empty;
			for (int i = 0; i < lineNum; i++)
			{
				char ch = char.Parse(Console.ReadLine());
				char decrypted = (char)((int)(ch) + key);

				finalWord += decrypted;
			}
            Console.WriteLine(finalWord);
        }
	}
}
