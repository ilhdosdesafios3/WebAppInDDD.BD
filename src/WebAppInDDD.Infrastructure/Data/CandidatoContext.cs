using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using WebAppInDDD.ApplicationCore.Entity;

namespace WebAppInDDD.Infrastructure.Data
{
    public class CandidatoContext : DbContext
    {
        public CandidatoContext(DbContextOptions options) : base(options)
        {
        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Candidato>().ToTable("Tb_Candidato");
        }

        public DbSet<Candidato> Candidatos { get;set; }
    }
}
