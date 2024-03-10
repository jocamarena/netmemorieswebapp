using Microsoft.EntityFrameworkCore;
using WebApplication1.Models;

namespace WebApplication1.Data
{
    public class ApplicationDBContext : DbContext
    {
        public ApplicationDBContext(DbContextOptions<ApplicationDBContext> options) : base(options)
        {
        }
        public DbSet<Memory> Memories { get; set; }
        public DbSet<Author> Authors { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Memory>()
                .HasOne(m => m.Author)
                .WithMany(a => a.Memories);
                //.HasForeignKey(m => m.AuthorID);
                modelBuilder.Entity<Author>().HasData(
                                       new Author
                                       {
                        ID = 1,
                        Name = "John Doe"
                    },
                                                          new Author
                                                          {
                        ID = 2,
                        Name = "Jane Doe"
                    }
                                                                         );
            modelBuilder.Entity<Memory>().HasData(
                                                      new Memory
                                                      {
                        ID = 1,
                        Description = "First Memory",
                        Date = new DateOnly(2023, 3, 9),
                        AuthorID = 1
                    },
                                                                                            new Memory
                                                                                            {
                        ID = 2,
                        Description = "Second Memory",
                        Date = new DateOnly(2023, 3, 9),
                        AuthorID = 2
                    }
                                                                                                                                             );
        }
    }
}
