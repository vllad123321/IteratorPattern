using System;
using IteratorPattern.Collections;
using IteratorPattern.Models;

namespace IteratorPattern
{
    internal class Program
    {
        private static void Main(string[] args)
        {
            var library = new Library();

            // Добавляем книги в библиотеку
            library.AddBook(new Book("1984", "George Orwell", 1949));
            library.AddBook(new Book("To Kill a Mockingbird", "Harper Lee", 1960));
            library.AddBook(new Book("The Great Gatsby", "F. Scott Fitzgerald", 1925));

            // Получаем итератор и проходим по библиотеке
            var iterator = library.GetIterator();

            Console.WriteLine("Books in the library:");
            while (iterator.HasNext())
            {
                var book = iterator.Next();
                Console.WriteLine(book);
            }
        }
    }
}
