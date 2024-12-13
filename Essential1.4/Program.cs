using System;

namespace Essential1._4
{
    internal class Program
    {
        public class Title
        {
            public string BookTitle { get; set; }

            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Blue;
                Console.WriteLine($"Name of book {BookTitle}");
                Console.ResetColor();
            }
        }

        public class Author
        {
            public string BookAuthor { get; set; }

            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Red;
                Console.WriteLine($"Name of author: {BookAuthor}");
                Console.ResetColor();
            }
        }

        public class Content
        {
            public string BookContent { get; set; }

            public void Show()
            {
                Console.ForegroundColor = ConsoleColor.Yellow;
                Console.WriteLine($"Name of content: {BookContent}");
                Console.ResetColor();
            }
        }

        public class Book
        {
            public Title Title { get; set; }
            public Author Author { get; set; }
            public Content Content { get; set; }

            public Book(Title title, Author author, Content content)
            {
                Title = title;
                Author = author;
                Content = content;
            }

            public void Show()
            {
                Title.Show();
                Author.Show();
                Content.Show();
            }
        }
        

        static void Main(string[] args)
        {
            Title title = new Title {BookTitle = "Football players" };
            Author author = new Author { BookAuthor = "Cristiano Messi" };
            Content content = new Content {BookContent =  "Sport" };


            Book book = new Book(title, author, content);

            book.Show();

            Console.ReadKey();
        }
    }
}
