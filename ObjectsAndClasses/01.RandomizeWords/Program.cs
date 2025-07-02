internal class Program
{
    static void Main()
    {
        string[] words = Console.ReadLine().Split();

        Random random = new Random();
        for (int i = 0; i < words.Length; i++)
        {
            SwapElements(i,random.Next(0,words.Length), words);
        }

        foreach (string word in words)
        {
            Console.WriteLine(word);
        }
    }

    static void SwapElements(int firstIndex, int secondIndex, string[] elements)
    {
        string temp = elements[firstIndex];
        elements[firstIndex] = elements[secondIndex];
        elements[secondIndex] = temp;
    }
}