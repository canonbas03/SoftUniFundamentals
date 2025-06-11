namespace _02.Grades
{
	internal class Program
	{
		static void Main(string[] args)
		{
			GradeResult(double.Parse(Console.ReadLine()));
		}

		static void GradeResult(double grade)
		{
			string result = string.Empty;
			if(grade >= 2 && grade <= 2.99)
			{
				result = "Fail";
			}
			else if (grade >= 3 && grade <= 3.49)
			{
				result = "Poor";
			}
			else if (grade >= 3.5 && grade <= 4.49)
			{
				result = "Good";
			}
			else if (grade >= 4.5 && grade <= 5.49)
			{
				result = "Very good";
			}
			else if (grade >= 5.5 && grade <= 6)
			{
				result = "Excellent";
			}

            Console.WriteLine(result);
        }
	}
}

/*
 * · 2.00 – 2.99 - "Fail"

· 3.00 – 3.49 - "Poor"

· 3.50 – 4.49 - "Good"

· 4.50 – 5.49 - "Very good"

· 5.50 – 6.00 - "Excellent
 */