using Microsoft.EntityFrameworkCore;

namespace WebTest.Models
{
    public class ApplicationContext : DbContext
    {
        public ApplicationContext(DbContextOptions options) : base(options) { }
        public DbSet<UsersModel> Users { get; set; }
        protected override void OnModelCreating(ModelBuilder builder)
        {
            base.OnModelCreating(builder);

          // builder.Entity<UsersModel>().HasData(new UsersModel
          // {
          //     Id = new System.Guid("30FB2DD3-EA0E-4F05-B0DB-EF6341A593F0"),
          //     FirstName = "В космос ",
          //     LastName = "text text",
          //     SecondName = "text text text",
          //     Date1 = new System.DateTime(2010, 1, 18)
          // });
        }
    }
}
