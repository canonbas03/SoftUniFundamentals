namespace _09.PadawanEquipment
{
	internal class Program
	{
		static void Main(string[] args)
		{
			// Initial Lines
			double moneyInitial = double.Parse(Console.ReadLine());
			int studentNum = int.Parse(Console.ReadLine());

			double lightSaberPrice = double.Parse(Console.ReadLine());
			double robePrice = double.Parse(Console.ReadLine());
			double beltPrice = double.Parse(Console.ReadLine());

			double totalPrice = 0;

			// Light Saber Calculation
			totalPrice += lightSaberPrice * Math.Ceiling(studentNum * 1.1);

			// Robe Calculation
			totalPrice += robePrice * studentNum;

			// Belt Calculation
			int reduction = 0;
			for (int i = studentNum; i > 0; i--)
			{
				if (i % 6 == 0)
				{
					reduction++;
				}
			}
			totalPrice += beltPrice * (studentNum - reduction);

			// Final Check
			if(moneyInitial >= totalPrice)
			{
				Console.WriteLine($"The money is enough - it would cost {totalPrice:f2}lv.");
			}
			else
			{
				Console.WriteLine($"John will need {(totalPrice-moneyInitial):f2}lv more.");
			}
		}
	}
}
