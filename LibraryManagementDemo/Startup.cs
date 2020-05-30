namespace LibraryManagementDemo
{
    using HotChocolate;
    using HotChocolate.AspNetCore;
    using LibraryManagementDemo.GraphQLTypes;
    using LibraryManagementDemo.Repositories;
    using LibraryManagementDemo.Repositories.Interfaces;
    using Microsoft.AspNetCore.Builder;
    using Microsoft.AspNetCore.Hosting;
    using Microsoft.AspNetCore.Mvc;
    using Microsoft.EntityFrameworkCore;
    using Microsoft.Extensions.Configuration;
    using Microsoft.Extensions.DependencyInjection;

    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            services.AddMvc().SetCompatibilityVersion(CompatibilityVersion.Version_2_2);

            services
            .AddDbContext<Entities.LibraryManagementDemoContext>
            (options => options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection")));

            services.AddScoped<IBookRepository, BookRepository>();
            services.AddScoped<IAuthorRepository, AuthorRepository>();

            services.AddDataLoaderRegistry().AddGraphQL
            (gql => SchemaBuilder.New()
                .AddServices(gql)
                .AddType<BookType>()
                .AddType<AuthorType>()
                .AddQueryType<Query.LibraryQuery>()
                .Create()
            );
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IHostingEnvironment env)
        {
            if (env.IsDevelopment())
                app.UseDeveloperExceptionPage();

            app.UseGraphQL();
            app.UsePlayground();
        }
    }
}