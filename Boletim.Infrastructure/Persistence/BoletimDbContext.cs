using Boletim.Core.Entities;
using Microsoft.EntityFrameworkCore;

namespace Boletim.Infrastructure.Persistence
{
    public  class BoletimDbContext : DbContext
    {
        public BoletimDbContext(DbContextOptions<BoletimDbContext> options) : base(options)
        {
        }

        public DbSet<Curso> Cursos { get; set; }

        public DbSet<Aluno> Alunos { get; set; }

        public DbSet<Resultado> Resultados { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Curso>()
                .HasKey(d => d.Id);

            modelBuilder.Entity<Aluno>()
                .HasKey(a => a.Id);

            modelBuilder.Entity<Aluno>()
                .HasOne(a => a.Curso)
                .WithMany(c => c.Alunos)
                .HasForeignKey(a => a.IdCurso)
                .OnDelete(DeleteBehavior.Restrict);

            modelBuilder.Entity<Resultado>()
                 .HasKey(a => a.Id);
        }
    }
}
