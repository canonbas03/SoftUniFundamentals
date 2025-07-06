namespace _03.Articles02
{
    internal class Program
    {
        static void Main(string[] args)
        {
            List<Article> articlesList = new List<Article>();
            int articlesCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < articlesCount; i++)
            {
                string[] initialValues = Console.ReadLine().Split(", ");
                Article article = new Article(initialValues[0], initialValues[1], initialValues[2]);
                articlesList.Add(article);
            }

            foreach (Article article in articlesList)
            {
                Console.WriteLine(article);
            }
        }
    }

    public class Article
    {
        public override string ToString()
        {
            return $"{Title} - {Content}: {Author}";
        }
        public string Title { get; set; }
        public string Content { get; set; }
        public string Author { get; set; }

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }
    }
}
