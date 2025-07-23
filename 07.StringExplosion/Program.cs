using System;

namespace _07.StringExplosion
{
    internal class Program
    {
        static void Main(string[] args)
        {
            string input = Console.ReadLine();
            string result = string.Empty;

            int explosionStrength = 0;

            for (int i = 0; i < input.Length; i++)
            {
                if (input[i] == '>')
                {
                    result += '>';
                    int strength = input[i + 1] - '0';
                    explosionStrength += strength;
                }
                else if(explosionStrength > 0)
                {
                    explosionStrength--;
                }
                else
                {
                    result += input[i];
                }
            }

            Console.WriteLine(result);
        }
    }
}
