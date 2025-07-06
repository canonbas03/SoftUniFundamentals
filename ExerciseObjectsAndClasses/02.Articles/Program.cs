namespace _02.Articles
{
    /*
Fight club, love story, Martin Scorsese
2
Edit: underground fight club that evolves into much more
ChangeAuthor: Chuck Palahniuk
     */
    internal class Program
    {
        static void Main(string[] args)
        {
            string[] initialValues = Console.ReadLine().Split();

            Article article = new Article();
            article.Title = initialValues[0];
            article.Content = initialValues[1];
            article.Author = initialValues[2];

            int commandCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandCount; i++)
            {
                string[] commands = Console.ReadLine().Split(": ");

                if (commands[0] == "Edit")
                {
                    article.Content = commands[1];
                }
                else if (commands[0] == "ChangeAuthor")
                {
                    article.Author = commands[1];
                }
                else
                {
                    article.Title = commands[1];
                }
            }
            Console.WriteLine(article);

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

        public static void Edit(string newContent)
        {

        }
    }
}
