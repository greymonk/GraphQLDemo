using HotChocolate.Types;
using LibraryManagementDemo.Entities;
using LibraryManagementDemo.GraphQLServices;

namespace LibraryManagementDemo.GraphQLTypes
{
    public class BookType : ObjectType<Book>
    {
        protected override void Configure(IObjectTypeDescriptor<Book> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Name("Books");
            descriptor.Field(field => field.Id).Type<IdType>();
            descriptor.Field(field => field.AuthorId).Type<IntType>();
            descriptor.Field(field => field.Title).Type<StringType>();
            descriptor.Field(field => field.Price).Type<DecimalType>();
            descriptor.Field<AuthorResolver>(field => field.GetAuthor(default, default));
        }
    }
}