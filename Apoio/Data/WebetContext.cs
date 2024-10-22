using Apoio.Models;
using Microsoft.EntityFrameworkCore;

namespace Apoio.Data
{
    public class WebetContext : DbContext
    {
        public WebetContext(DbContextOptions<WebetContext> options) : base(options)
        { }
        public DbSet<Apostador> Apostadores { get; set; }
        public DbSet<Aposta> Apostas { get; set; }
    
    }
}
