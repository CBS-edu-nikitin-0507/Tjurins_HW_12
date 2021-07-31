using System;

namespace Task3
{
    public class Author
    {
        string bookAuthor;

        public string BookAuthor
        {
            get
            {
                if (bookAuthor != null)
                    return bookAuthor;
                else
                    return "N/A";
            }
            set
            {
                bookAuthor = value;
            }
        }

        public void PrintAuthor()
        {
            Console.ForegroundColor = ConsoleColor.DarkMagenta;
            Console.WriteLine(BookAuthor);
            Console.ForegroundColor = ConsoleColor.DarkGray;
        }
    }
}