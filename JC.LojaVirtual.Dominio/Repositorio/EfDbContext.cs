using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;

using System.Data.Entity.ModelConfiguration.Conventions;


using JC.LojaVirtual.Dominio.Entidade;

namespace JC.LojaVirtual.Dominio.Repositorio
{
    public class EfDbContext : DbContext
    {
        public DbSet<Produto> Produtos { get; set; }


        //Trabalha com Plurarização - Remove 'palavras/tabelas do SG' no plural
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();
            modelBuilder.Entity<Produto>().ToTable("Produtos");
            // base.OnModelCreating(modelBuilder);
        }
    }
}
