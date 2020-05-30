namespace LibraryManagementDemo.Repositories
{
    using System.Linq;
    using LibraryManagementDemo.Entities;
    using LibraryManagementDemo.GraphQLTypes;
    using LibraryManagementDemo.Repositories.Interfaces;

    public class AuthorRepository : IAuthorRepository
    {
        private readonly LibraryManagementDemoContext context;
        public AuthorRepository(LibraryManagementDemoContext context)
        {
            this.context = context;
        }

        public IQueryable<Author> GetAuthors()
        {
            return context.Author.AsQueryable();
        }

        public Author AddAuthor(AuthorInputType author)
        {
            var authorObj = new Author()
            {
                Name = author.Name,
                Surname = author.Surname,
            };

            context.Add(authorObj);
            context.SaveChanges();
            return authorObj;
        }

        public void DeleteAuthor(AuthorInputType author)
        {
            var authorObj = context.Author.FirstOrDefault(authorTmp => authorTmp.Id == author.Id);
            if (authorObj != null)
            {
                context.Author.Remove(authorObj);
                context.SaveChanges();
            }
        }

        public Author UpdateAuthor(AuthorInputType author)
        {
            var authorObj = context.Author.FirstOrDefault(authorTmp => authorTmp.Id == author.Id);

            if (authorObj != null)
            {
                authorObj.Name = author.Name;
                authorObj.Surname = author.Surname;

                context.Author.Update(authorObj);
                context.SaveChanges();
            }

            return authorObj ?? new Author();
        }
    }
}