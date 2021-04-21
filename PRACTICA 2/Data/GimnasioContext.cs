using Microsoft.EntityFrameworkCore;


namespace Gimnasio.Data
{
    public class GimnasioContext : DbContext
    {
        public DbSet<Gimnasio> Gimnasios { get; set; }

        public GimnasioContext(DbContextOptions dco) : base(dco) {

        }
    }
}