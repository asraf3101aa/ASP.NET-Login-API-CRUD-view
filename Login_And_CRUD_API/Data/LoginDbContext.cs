using Login_And_CRUD_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Login_And_CRUD_API.Data
{
    public class LoginDbContext: DbContext
    {
        public LoginDbContext(DbContextOptions options) : base(options)
        {

        }
        public DbSet<User> Users { get; set; }
    }
}
