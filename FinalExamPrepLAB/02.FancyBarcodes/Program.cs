using System.Text.RegularExpressions;

namespace _02.FancyBarcodes
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string pattern = @"@#+[A-Z][A-Za-z0-9]{4,}[A-Z]@#+";
            uint barcodesCount = uint.Parse(Console.ReadLine());
            for (int i = 0; i < barcodesCount; i++)
            {
                string barcode = Console.ReadLine();
                if (Regex.IsMatch(barcode, pattern))
                {
                    char[] digits = barcode.Where(c => char.IsDigit(c)).ToArray();

                    string productGroup = digits.Length > 0 ? new string(digits) : "00";
                    Console.WriteLine($"Product group: {productGroup}");
                }
                else
                {
                    Console.WriteLine("Invalid barcode");
                }
            }
        }
    }
}

/*
 3
@#FreshFisH@#
@###Brea0D@###
@##Che4s6E@##
 */