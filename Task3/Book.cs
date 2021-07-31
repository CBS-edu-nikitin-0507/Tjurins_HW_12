using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Task3
{
    class Book
    {
        Title title = new Title();
        Content content = new Content();
        Author author = new Author();

        public void InitBookParts(string title, string content, string author)
        {
            this.title.BookTitle = title;
            this.content.BookContent = content;
            this.author.BookAuthor = author;
        }
        public string Title
        {
            set
            {
                this.title.BookTitle = value;
            }
        }
        public string Content
        {
            set
            {
                this.content.BookContent = value;
            }
        }
        public string Author
        {
            set
            {
                this.author.BookAuthor = value;
            }
        }

        public void PrintBook()
        {
            title.PrintTitle();
            content.PrintContent();
            author.PrintAuthor();
        }
    }
}
