using Estoque.Models;
using System.Data.Entity;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace Estoque.Dao
{
    public class EstoqueContext : DbContext
    {
        public EstoqueContext() : base("Estoque")
        {
            //Database.SetInitializer<EstoqueContext>( new DropCreateDatabaseIfModelChanges<EstoqueContext>());
        }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
        }

        public DbSet<Produto> Produtos { get; set; }

        public DbSet<CategoriaDoProduto> Categorias{ get; set; }

        public DbSet<Usuario> Usuarios { get; set; }
    }
}