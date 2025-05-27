using System;

namespace _01.StudentInfo
{
	internal class Program
	{
		static void Main(string[] args)
		{
			float grade = float.Parse(Console.ReadLine());

			if (grade >= 3)
			{
				Console.WriteLine("Passed!");
			}
		}
	}
}
