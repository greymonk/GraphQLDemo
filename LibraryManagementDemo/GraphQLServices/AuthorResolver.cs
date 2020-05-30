namespace LibraryManagementDemo.GraphQLServices
{
    using System.Linq;
    using HotChocolate.Resolvers;
    using LibraryManagementDemo.Entities;
    using LibraryManagementDemo.Repositories.Interfaces;

    public class AuthorResolver
    {
        private readonly IAuthorRepository authorRepository;
        public AuthorResolver(IAuthorRepository authorRepository)
        {
            this.authorRepository = authorRepository;
        }

        public Author GetAuthor(Book book, IResolverContext resolver)
        {
            return authorRepository.GetAuthors().FirstOrDefault(author => author.Id == book.AuthorId);
        }
    }
}