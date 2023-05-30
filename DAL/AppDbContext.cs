using Microsoft.EntityFrameworkCore;
using Senkadegala.Models;

namespace Senkadegala.DAL
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {






        }


        public DbSet<Member> Members { get; set; }

    }
}
