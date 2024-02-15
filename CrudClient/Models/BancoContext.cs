using Microsoft.EntityFrameworkCore;

namespace CrudClient.Models
{
    public class BancoContext : DbContext
    {
        public BancoContext(DbContextOptions<BancoContext>options):base(options) 
        { 
         
        }

        public DbSet<Client> Clients { get; set; }
    }
}
