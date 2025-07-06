namespace _04.ReverseArrayOfStrings
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string[] stringArr = Console.ReadLine().Split().ToArray();

			for (int i = 0; i < stringArr.Length / 2; i++)
			{
				string temp = stringArr[i];
				stringArr[i] = stringArr[stringArr.Length -1 -i];
				stringArr[stringArr.Length - 1 -i] = temp;
            }

			foreach (string str in stringArr)
			{
				Console.Write(str + " ");
			}
		}
	}
}
