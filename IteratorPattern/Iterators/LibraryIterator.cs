using IteratorPattern.Interfaces;
using IteratorPattern.Models;

namespace IteratorPattern.Iterators
{
    internal class LibraryIterator : IIterator<Book>
    {
        private readonly Book[] _books;
        private int _position = 0;

        public LibraryIterator(Book[] books)
        {
            _books = books;
        }

        public bool HasNext()
        {
            return _position < _books.Length && _books[_position] != null;
        }

        public Book Next()
        {
            return _books[_position++];
        }
    }
}
