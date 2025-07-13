﻿namespace _03.WordSynonyms
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int wordsCount = int.Parse(Console.ReadLine());

            Dictionary<string, List<string>> wordsSynonyms = new();
            for (int i = 0; i < wordsCount; i++)
            {
                string word = Console.ReadLine();
                string synonym = Console.ReadLine();

                if(!wordsSynonyms.ContainsKey(word))
                {
                    wordsSynonyms[word] = new List<string>();
                }
                wordsSynonyms[word].Add(synonym);
            }

            foreach((string word, List<string> synonyms) in wordsSynonyms)
            {
                Console.WriteLine($"{word} - {string.Join(", ",synonyms)}");
            }
        }
    }
}
