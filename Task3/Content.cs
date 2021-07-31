using System;

namespace Task3
{
    public class Content
    {
        string bookContent;

        public string BookContent
        {
            get
            {
                if (bookContent != null)
                    return bookContent;
                else
                    return "N/A";
            }
            set
            {
                bookContent = value;
            }
        }

        public void PrintContent()
        {
            Console.ForegroundColor = ConsoleColor.DarkCyan;
            Console.WriteLine(BookContent);
        }
    }
}