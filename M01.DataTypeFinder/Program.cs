namespace M01.DataTypeFinder
{
	internal class Program
	{
		static void Main(string[] args)
		{
			string command = "";
			while ((command = Console.ReadLine()) != "END")
			{
                if(int.TryParse(command, out int intVal))
				{
                    Console.WriteLine($"{command} is integer type");
                } 
				else if(float.TryParse(command, out float floatVal))
				{
                    Console.WriteLine($"{command} is floating point type");
                } 
				else if(char.TryParse(command, out char charVal))
				{
                    Console.WriteLine($"{command} is character type");
                }  
				else if(bool.TryParse(command, out bool boolVal))
				{
                    Console.WriteLine($"{command} is boolean type");
                }
				else
				{
					Console.WriteLine($"{command} is string type");
				}
			}
		}
	}
}
