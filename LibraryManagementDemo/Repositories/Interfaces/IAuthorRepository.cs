namespace LibraryManagementDemo.Repositories.Interfaces
{
    using System.Linq;
    using LibraryManagementDemo.Entities;
    using LibraryManagementDemo.GraphQLTypes;

    public interface IAuthorRepository
    {
        IQueryable<Author> GetAuthors();
        Author AddAuthor(AuthorInputType author);
        Author UpdateAuthor(AuthorInputType author);
        void DeleteAuthor(AuthorInputType author);
    }
}