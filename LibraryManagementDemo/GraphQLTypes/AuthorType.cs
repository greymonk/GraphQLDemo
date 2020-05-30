using HotChocolate.Types;
using LibraryManagementDemo.Entities;
using LibraryManagementDemo.GraphQLServices;

namespace LibraryManagementDemo.GraphQLTypes
{
    public class AuthorType : ObjectType<Author>
    {
        protected override void Configure(IObjectTypeDescriptor<Author> descriptor)
        {
            base.Configure(descriptor);

            descriptor.Name("Authors");
            descriptor.Field(field => field.Id).Type<IdType>();
            descriptor.Field(field => field.Name).Type<StringType>();
            descriptor.Field(field => field.Surname).Type<StringType>();
            descriptor.Field<BookResolver>(field => field.GetBooks(default, default));
            
            // here's how you can set non-null constraint
            //descriptor.Field(field => field.Id).Type<NonNullType<IdType>>();
        }
    }
}