﻿namespace _04.ReverseString
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string word = Console.ReadLine();
			string reversed = string.Empty;

			for (int i = word.Length - 1; i >= 0; i--)
			{
				reversed += word[i];
			}
			Console.WriteLine(reversed);
		}
	}
}
