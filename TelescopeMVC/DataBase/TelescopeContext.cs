using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;
using TelescopeMVC.Models.TelescopeApp.Models;

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



