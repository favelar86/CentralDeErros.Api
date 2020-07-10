using Microsoft.EntityFrameworkCore;
using CentralDeErros.Api.Domain.Models;
using Microsoft.AspNetCore.Identity.EntityFrameworkCore;

namespace CentralDeErros.Api.Data.Map
{
    public class Context : IdentityDbContext
    {
        public DbSet<Environment> Environments { get; set; }
        public DbSet<Error> Errors { get; set; }
        public DbSet<ErrorOccurrence> ErrorOccurrences { get; set; }
        public DbSet<Level> Levels { get; set; }
        public DbSet<Situation> Situations { get; set; }
        public DbSet<Users> Users { get; set; }

       public Context(DbContextOptions<Context> options)
            : base(options)
        {

        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new EnvironmentMap());
            modelBuilder.ApplyConfiguration(new ErrorMap());
            modelBuilder.ApplyConfiguration(new ErrorOccurrenceMap());
            modelBuilder.ApplyConfiguration(new LevelMap());
            modelBuilder.ApplyConfiguration(new SituationMap());
            modelBuilder.ApplyConfiguration(new UsersMap());

            base.OnModelCreating(modelBuilder);
        }
        
    }
}
