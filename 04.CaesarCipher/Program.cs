namespace _04.CaesarCipher
{
    internal class Program
    {
        static void Main(string[] args)
        {
            char[] text = Console.ReadLine().ToCharArray();
           
            for (int i = 0; i < text.Length; i++)
            {
                text[i] += (char)3;
            }
            Console.WriteLine(text);
        }
    }
}
