using System.Data.Entity;

namespace gestorMarcas.Models
{
    public class GestorMarcasContext : DbContext
    {
        public DbSet<VelocityRace> VelocityRaces { get; set; }

        static GestorMarcasContext()
        {
            System.Data.Entity.Database.SetInitializer(new DropCreateDatabaseIfModelChanges<GestorMarcasContext>());
        }
    }
}