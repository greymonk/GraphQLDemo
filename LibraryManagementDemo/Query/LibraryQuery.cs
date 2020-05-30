namespace LibraryManagementDemo.Query
{
    using System.Linq;
    using HotChocolate;
    using HotChocolate.Types;
    using HotChocolate.Types.Relay;
    using LibraryManagementDemo.Entities;
    using LibraryManagementDemo.Repositories.Interfaces;

    public class LibraryQuery
    {
        [UsePaging(SchemaType = typeof(GraphQLTypes.BookType))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Book> Books([Service] IBookRepository bookRepository)
        {
            return bookRepository.GetBooks();
        }

        [UsePaging(SchemaType = typeof(GraphQLTypes.AuthorType))]
        [UseFiltering]
        [UseSorting]
        public IQueryable<Author> Authors([Service] IAuthorRepository authorRepository)
        {
            return authorRepository.GetAuthors();
        }
    }
}