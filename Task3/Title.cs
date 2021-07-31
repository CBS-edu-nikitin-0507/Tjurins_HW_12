using System;

namespace Task3
{
    public class Title
    {
        string bookTitle;

        public string BookTitle
        {
            get
            {
                if (bookTitle != null)
                    return bookTitle;
                else
                    return "N/A";
            }
            set
            {
                bookTitle = value;
            }
        }

        public void PrintTitle()
        {
            Console.ForegroundColor = ConsoleColor.DarkGreen;
            Console.WriteLine(BookTitle);
        }
    }
}