using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace Backend
{
    public class FrotaContext : DbContext
    {

        public DbSet<Carro> Carros { get; set; }

       //ADICIONADO VIA REFLECTION NO DBCONTEXT
       public DbSet<Marca> Marcas { get; set; }
        public DbSet<Pais> Paises { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
           // modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder
                .UseLazyLoadingProxies()
                .UseSqlServer(@"Server=.\SQLEXPRESS;Database=FrotaDB;Trusted_Connection = true");
        }
    }
}
