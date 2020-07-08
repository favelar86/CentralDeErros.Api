using Microsoft.EntityFrameworkCore;
using CentralDeErros.Api.Domain.Models;

namespace CentralDeErros.Api.Data.Map
{
    public class Context : DbContext
    {
        public DbSet<Environment> Environments { get; set; }
        public DbSet<Error> Errors { get; set; }
        public DbSet<ErrorOccurrence> ErrorOccurrences { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Situation> Situations { get; set; }
        public DbSet<Users> Users { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=DESKTOP-8CPD74L\SQLEXPRESS;Database=CentralDeErros;Trusted_Connection=True");
                base.OnConfiguring(optionsBuilder);
        }
        
    }
}
