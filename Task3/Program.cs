using System;

namespace Task3
{
    class Program
    {
        static void Main(string[] args)
        {
            Book book = new Book();
            Console.Write("Enter book title: ");
            string title = Console.ReadLine();
            Console.Clear();
            Console.Write("Enter book content: ");
            string content = Console.ReadLine();
            Console.Clear();
            Console.Write("Enter book author: ");
            string author = Console.ReadLine();
            Console.Clear();


            book.InitBookParts(title, content, author);
            book.PrintBook();

            Console.ReadLine();
        }
    }
}
