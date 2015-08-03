using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using RestauranteADONET.Dominio.Model;
using System.Data.Entity.ModelConfiguration.Conventions;
using RestauranteADONET.EntityFramework.Configuracao;
namespace RestauranteADONET.EntityFramework
{
    public class DbContexto:DbContext
    {
        public DbSet<Prato> Pratos { get; set; }
        public DbSet<Tipo> Tipos { get; set; }

        public DbContexto()
        :base("Restaurante")
        {

        }
        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            CreateDatabaseIfNotExists<DbContext> context;
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();


            modelBuilder.Properties()
                .Where(p => p.Name == p.ReflectedType + "Id")
                .Configure(p => p.IsKey());
            modelBuilder.Properties<string>()
                .Configure(p => p.HasColumnType("varchar"));
            modelBuilder.Properties<string>()
                .Configure(p => p.HasMaxLength(100));

            modelBuilder.Configurations.Add(new PratoConfiguracao());
            modelBuilder.Configurations.Add(new TipoConfiguracao());
            base.OnModelCreating(modelBuilder);
        }
    }
}
