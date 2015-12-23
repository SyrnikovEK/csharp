using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace homework1
{
    public class Task3
    {
        public void DoSomething()
        {
            string s1, s2, s3 = "";
            Console.WriteLine("Input Title");
            s1 = Console.ReadLine();
            Console.WriteLine("Input Author");
            s2 = Console.ReadLine();
            Console.WriteLine("Input Content");
            s3 = Console.ReadLine();
            Book book1 = new Book(s1 , s2 , s3);
            book1.Show();
        }
    }

    public class Book
    {
        private Title BookTitle = new Title();
        private Author BookAuthor = new Author();
        private Content BookContent = new Content();

        public Book (string title, string author, string content)
        {
            BookTitle.TitleProperty = title;
            BookAuthor.AuthorProperty = author;
            BookContent.ContentProperty = content;
        }

        public void Show()
        {
            BookTitle.Show();
            BookAuthor.Show();
            BookContent.Show();
            Console.ForegroundColor = ConsoleColor.White;
        }
    }

    public class Title
    {
        private string title;

        public string TitleProperty
        {
            get
            {
                return title;
            }
            set
            {
                title = value;
            }
        }

        public Title (string title = "")
        {
            this.title = title;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Red;
            Console.WriteLine(title); ;
        }
    }
    public class Author
    {
        private string author;

        public string AuthorProperty
        {
            get
            {
                return author;
            }
            set
            {
                author = value;
            }
        }

        public Author (string author = "")
        {
            this.author = author;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(author); ;
        }
    }
    public class Content
    {
        private string content;

        public string ContentProperty
        {
            get
            {
                return content;
            }
            set
            {
                content = value;
            }
        }

        public Content (string content = "")
        {
            this.content = content;
        }

        public void Show()
        {
            Console.ForegroundColor = ConsoleColor.Blue;
            Console.WriteLine(content); ;
        }
    }
}
