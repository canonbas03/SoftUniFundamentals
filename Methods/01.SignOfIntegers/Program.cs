namespace _01.SignOfIntegers
{
	internal class Program
	{
		static void Main(string[] args)
		{
			SignCheck(int.Parse(Console.ReadLine()));
		}
		static void SignCheck(int i)
		{
			if(i < 0)
			{
                Console.WriteLine($"The number {i} is negative. ");
			}
			else if(i > 0)
			{
                Console.WriteLine($"The number {i} is positive. ");
            }
			else
			{
                Console.WriteLine($"The number {i} is zero. ");
            }
		}
	}
}
