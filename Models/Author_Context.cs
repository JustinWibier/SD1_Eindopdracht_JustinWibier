using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SoftwareDevelopment1_Eindopdracht.Models
{
    public class Author_Context : DbContext
    {

        public DbSet<Author> Authors { get; set; }
        public DbSet<Book> Books { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            options.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB; Initial Catalog=MYDB;\r\nIntegrated Security=True; Connect Timeout=30; Encrypt=False;\r\nTrustServerCertificate=False; ApplicationIntent=ReadWrite;\r\nMultiSubnetFailover=False");
            options.UseLazyLoadingProxies();
        }

        protected override void OnModelCreating(ModelBuilder Builder)
        {
            Builder.Entity<Author>().HasData(
                new Author { Name = "yumi", Lastname = "Argento", Id = 1 },
                new Author { Name = "carlis", Infix = "von", Lastname = "krauft", Id = 2 }
                );
            Builder.Entity<Book>().HasData(
                new Book { Id = 1, Title = "How to build a well",
                    Description = "A Book on how you build a well",});
            Builder.Entity<Book>().HasMany(b => b.Authors).WithMany(a => a.Books).UsingEntity(pivotTable => 
            pivotTable.HasData(
               new {BooksId = 1, AuthorsId = 1},
               new { BooksId = 1, AuthorsId = 2 })
            );
        }
    }
}
