namespace LibraryManagementDemo.Repositories
{
    using System.Linq;
    using LibraryManagementDemo.Entities;
    using LibraryManagementDemo.GraphQLTypes;
    using LibraryManagementDemo.Repositories.Interfaces;

    public class BookRepository : IBookRepository
    {
        private readonly LibraryManagementDemoContext context;
        public BookRepository(LibraryManagementDemoContext context)
        {
            this.context = context;
        }

        public IQueryable<Book> GetBooks()
        {
            return context.Book.AsQueryable();
        }

        public Book AddBook(BookInputType book)
        {
            var bookObj = new Book()
            {
                AuthorId = book.AuthorId,
                Title = book.Title,
                Price = book.Price
            };

            context.Add(bookObj);
            context.SaveChanges();
            return bookObj;
        }

        public void DeleteBook(BookInputType book)
        {
            var bookObj = context.Book.FirstOrDefault(bookTmp => bookTmp.Id == book.Id);
            if (bookObj != null)
            {
                context.Book.Remove(bookObj);
                context.SaveChanges();
            }
        }

        public Book UpdateBook(BookInputType book)
        {
            var bookObj = context.Book.FirstOrDefault(bookTmp => bookTmp.Id == book.Id);

            if (bookObj != null)
            {
                bookObj.AuthorId = book.AuthorId;
                bookObj.Title = book.Title;
                bookObj.Price = book.Price;

                context.Book.Update(bookObj);
                context.SaveChanges();
            }
            
            return bookObj ?? new Book();
        }
    }
}