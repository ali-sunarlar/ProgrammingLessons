using Microsoft.EntityFrameworkCore;

namespace EFCoreExample.Models
{
    public class KitaplikContext:DbContext
    {
        public DbSet<Kitap> Kitaplar { get; set; }
        public DbSet<Yazar> Yazarlar { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            optionsBuilder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=Kitaplik1;Trusted_Connection=True;");
        }

    }
}
