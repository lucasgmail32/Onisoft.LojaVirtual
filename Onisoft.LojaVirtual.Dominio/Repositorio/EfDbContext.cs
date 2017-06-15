using System.Data.Entity;
using Onisoft.LojaVirtual.Dominio.Entidade;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Onisoft.LojaVirtual.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
        }
    }
}
