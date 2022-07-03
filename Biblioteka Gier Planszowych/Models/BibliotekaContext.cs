using Microsoft.EntityFrameworkCore;

namespace Biblioteka_Gier_Planszowych.Models
{
    public class BibliotekaContext : DbContext

    {
        public DbSet<Uzytkownik> Users { get; set; }
        public DbSet<Gra_Planszowa> Gra_Planszowa { get; set; }

        


        protected override void OnConfiguring (DbContextOptionsBuilder options)
        {
            options.UseSqlite(@"Data Source=C:\Users\Krzysztof\source\repos\Biblioteka Gier Planszowych.v2\BazaDanych\baza.db");
        }
    }
}
