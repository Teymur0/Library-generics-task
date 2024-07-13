using Library_generics_task.Exceptions;

namespace Library_generics_task
{
    internal class Library
    {
        private int BookLimit;
        private List<Book> Books;
        public Library(int bookLimit)
        {
            BookLimit = bookLimit;
            Books = new List<Book>();
        }
        public void AddBook(Book book)
        {
            if (Books.Count < BookLimit)
            {
                Books.Add(book);
            }
            else
            {
                throw new CapacityLimitException("Library capacity reached.");
            }
        }
        public Book GetBookById(int id)
        {
            foreach (var book in Books)
            {
                if (book.Id == id)
                {
                    return book;
                }
            }
            throw new NotFoundException($"Book with id {id} not found.");
        }
        public List<Book> GetAllBooks()
        {
            List<Book> allBooks = new List<Book>(Books);
            return allBooks;
        }
        public void RemoveById(int id)
        {
            bool isRemoved = false;
            for (int i = 0; i < Books.Count; i++)
            {
                if (Books[i].Id == id)
                {
                    Books.RemoveAt(i);
                    isRemoved = true;
                    break;
                }
            }
            if (!isRemoved)
            {
                throw new NotFoundException($"Book with id {id} not found.");
            }
        }
    }

}

