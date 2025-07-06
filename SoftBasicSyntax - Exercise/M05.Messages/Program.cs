namespace M05.Messages
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int symbolCount = int.Parse(Console.ReadLine());
			string word = string.Empty;
			while (symbolCount >0)
			{
				int code = int.Parse(Console.ReadLine());

				if(code==0)
				{
					word += " ";
					symbolCount--;
					continue;
				}

				int mainDigit = code % 10;
				int digitLen = code.ToString().Length;

				int offset = (mainDigit - 2) * 3;
				if (mainDigit == 8 || mainDigit == 9)
				{
					offset++;
				}

				int letterIndex = (offset + digitLen -1) + 97;
				word += (char)(letterIndex);
				//Console.WriteLine((char)(letterIndex));
				symbolCount--;
			}
			Console.WriteLine(word);
		}
	}
}
