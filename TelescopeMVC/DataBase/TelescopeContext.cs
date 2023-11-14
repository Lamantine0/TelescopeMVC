using Microsoft.EntityFrameworkCore;
using TelescopeMVC.Models;

namespace TelescopeMVC.DataBase
{
    public class TelescopeContext : DbContext
    {
        public TelescopeContext(DbContextOptions<TelescopeContext> options)
            : base(options)
        {


        }

        public DbSet<Telescope> Telescopes { get; set; } = null!;

    }


}



