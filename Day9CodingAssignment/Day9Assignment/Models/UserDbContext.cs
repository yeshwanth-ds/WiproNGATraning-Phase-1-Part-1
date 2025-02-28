using Microsoft.EntityFrameworkCore;

namespace WebApplication9.Models
{
    public class UserDbContext : DbContext
    {
        public DbSet<User> Users { get; set; }

        public UserDbContext(DbContextOptions<UserDbContext> Op): base(Op) { }
    }
}
