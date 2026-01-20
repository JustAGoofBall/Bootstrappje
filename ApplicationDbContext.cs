using Microsoft.EntityFrameworkCore;
using Worlde.Models;

namespace Worlde.Data
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        public DbSet<Word> Words { get; set; }
    }
}