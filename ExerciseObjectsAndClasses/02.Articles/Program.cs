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
            string[] initialValues = Console.ReadLine().Split(", ");

            Article article = new Article(initialValues[0], initialValues[1], initialValues[2]);
            article.Title = initialValues[0];
            article.Content = initialValues[1];
            article.Author = initialValues[2];

            int commandCount = int.Parse(Console.ReadLine());
            for (int i = 0; i < commandCount; i++)
            {
                string[] commands = Console.ReadLine().Split(": ");

                if (commands[0] == "Edit")
                {
                    article.Edit(commands[1]);
                }
                else if (commands[0] == "ChangeAuthor")
                {
                    article.ChangeAuthor(commands[1]);
                }
                else
                {
                    article.Rename(commands[1]);
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

        public Article(string title, string content, string author)
        {
            Title = title;
            Content = content;
            Author = author;
        }

        public void Edit(string newContent)
        {
            Content = newContent;
        }
        public void ChangeAuthor(string newAuthor)
        {
            Author = newAuthor;
        }
        public void Rename(string newName)
        {
            Title = newName;
        }
    }
}
