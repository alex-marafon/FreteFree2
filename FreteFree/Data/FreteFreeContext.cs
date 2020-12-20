using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using FreteFree.Models.Processo;
using FreteFree.Models.Motorista;

namespace FreteFree.Data
{
    public class FreteFreeContext : DbContext
    {
        public FreteFreeContext (DbContextOptions<FreteFreeContext> options)
            : base(options)
        {
        }

        public DbSet<FreteFree.Models.Processo.Empresa> Empresa { get; set; }

        public DbSet<FreteFree.Models.Motorista.OrdemCarregamento> OrdemCarregamento { get; set; }

        public DbSet<FreteFree.Models.Motorista.Motorista> Motorista { get; set; }




        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            ControleDePropriedades(modelBuilder);
        }


        private void ControleDePropriedades(ModelBuilder modelBuilder)
        {
            foreach (var entity in modelBuilder.Model.GetEntityTypes())
            {
                var properties = entity.GetProperties().Where(p => p.ClrType == typeof(string));
                foreach (var item in properties)
                {
                    if (string.IsNullOrEmpty(item.GetColumnType())
                        && !item.GetMaxLength().HasValue)
                    {
                        item.SetColumnType("NVARCHAR(100)");

                    }

                }
                var propertiesD = entity.GetProperties().Where(p => p.ClrType == typeof(decimal));
                foreach (var item in propertiesD)
                {

                    if (string.IsNullOrEmpty(item.GetColumnType())
                       && !item.GetMaxLength().HasValue)
                    {
                        item.SetColumnType("decimal(20)");
                    }
                }
            }
        }
    }
}
