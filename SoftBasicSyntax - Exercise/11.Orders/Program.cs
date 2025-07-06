namespace _11.Orders
{
	internal class Program
	{
		static void Main(string[] args)
		{
			int orderCount = int.Parse(Console.ReadLine());

			double grandTotal = 0;
			for (int i = 1; i <= orderCount; i++) 
			{
				double totalPrice = 0;
				double pricePerCapsule = double.Parse(Console.ReadLine());
				int days = int.Parse(Console.ReadLine());
				int capsuleCount = int.Parse(Console.ReadLine());

				totalPrice = (days * capsuleCount) * pricePerCapsule;
				Console.WriteLine($"The price for the coffee is: ${totalPrice:f2}");
				grandTotal += totalPrice;
			}
			Console.WriteLine($"Total: ${grandTotal:f2}");
		}
	}
}
