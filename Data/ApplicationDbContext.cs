using Microsoft.EntityFrameworkCore;
using PocketBook.Models;

namespace PocketBook.Data
{
    public class ApplicationDbContext : DbContext
    {
        //the dbset property will tell ef core that we have 
        //a table that needs to be created if it doesnt exist 
        public DbSet<User> Users {get; set;}

        public ApplicationDbContext (DbContextOptions<ApplicationDbContext> options)
            :base(options)
        {

        }
    }
}