using Microsoft.EntityFrameworkCore;
using System;
using Entidades;

namespace DAL
{
    public class Contexto: DbContext
    {
        public DbSet<Usuarios> Usuario { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder.UseSqlServer(@"Server=DESKTOP-SBR4M50\SQLEXPRESS; Database =SistemaOdontologicoDb;Trusted_Connection =true"));
        }

    }
}
