namespace LibraryManagementDemo.GraphQLServices
{
    using System.Linq;
    using System.Collections.Generic;
    using HotChocolate.Resolvers;
    using LibraryManagementDemo.Entities;
    using LibraryManagementDemo.Repositories.Interfaces;

    public class BookResolver
    {
        private readonly IBookRepository bookRepository;
        public BookResolver(IBookRepository bookRepository)
        {
            this.bookRepository = bookRepository;
        }

        public IEnumerable<Book> GetBooks(Author author, IResolverContext resolver)
        {
            return bookRepository.GetBooks().Where(book => book.AuthorId == author.Id);
        }
    }
}