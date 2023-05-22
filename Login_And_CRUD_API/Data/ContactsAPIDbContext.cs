using Login_And_CRUD_API.Models;
using Microsoft.EntityFrameworkCore;

namespace Login_And_CRUD_API.Data
{
    public class ContactsAPIDbContext : DbContext
    {
        public ContactsAPIDbContext(DbContextOptions<ContactsAPIDbContext> options, ILogger<ContactsAPIDbContext> logger) : base(options)
        {

        }
        public DbSet<Contact> Contacts { get; set; }
    }
}
