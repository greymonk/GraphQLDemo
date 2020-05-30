namespace LibraryManagementDemo.Repositories.Interfaces
{
    using System.Linq;
    using LibraryManagementDemo.Entities;
    using LibraryManagementDemo.GraphQLTypes;

    public interface IBookRepository
    {
        IQueryable<Book> GetBooks();
        Book AddBook(BookInputType book);
        Book UpdateBook(BookInputType book);
        void DeleteBook(BookInputType book);
    }
}