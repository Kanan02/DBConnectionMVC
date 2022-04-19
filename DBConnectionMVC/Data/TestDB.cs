using DBConnectionMVC.Models;
using Microsoft.EntityFrameworkCore;

namespace DBConnectionMVC.Data
{
    public class TestDB:DbContext
    {
        public TestDB(DbContextOptions<TestDB> options):base(options)
        {
           
             Database.EnsureCreated();
          
        }
        public DbSet<User> Users { get; set; }

    }
}
