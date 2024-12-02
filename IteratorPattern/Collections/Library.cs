using IteratorPattern.Interfaces;
using IteratorPattern.Iterators;
using IteratorPattern.Models;
using System;

namespace IteratorPattern.Collections
{
    internal class Library
    {
        private Book[] _books = new Book[10];
        private int _count = 0;

        public void AddBook(Book book)
        {
            if (_count >= _books.Length)
            {
                Array.Resize(ref _books, _books.Length * 2);
            }
            _books[_count++] = book;
        }

        public IIterator<Book> GetIterator()
        {
            return new LibraryIterator(_books);
        }
    }
}
