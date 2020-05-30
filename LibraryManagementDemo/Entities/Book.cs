using System;
using System.Collections.Generic;

namespace LibraryManagementDemo.Entities
{
    public partial class Book
    {
        public int Id { get; set; }
        public int? AuthorId { get; set; }
        public string Title { get; set; }
        public decimal? Price { get; set; }
    }
}
