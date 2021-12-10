using Microsoft.EntityFrameworkCore;


namespace LogAndReg.Models
{
    public class MyContext : DbContext
    {
        public MyContext(DbContextOptions options) : base(options) {}
        public DbSet<User> Users {get; set; }
    }
}