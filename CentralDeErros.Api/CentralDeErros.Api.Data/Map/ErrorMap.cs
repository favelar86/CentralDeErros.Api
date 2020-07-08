using Microsoft.EntityFrameworkCore;
using CentralDeErros.Api.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentralDeErros.Api.Data.Map
{
    public class ErrorMap : IEntityTypeConfiguration<Error>
    {
        public void Configure(EntityTypeBuilder<Error> builder)
        {
            builder.ToTable("Error");

            builder.HasKey(x => x.ErrorId);

            builder.Property(x => x.Code)
                .HasColumnType("int")
                .IsRequired();

            builder.Property(x => x.Title)
                .HasColumnType("varchar(100)")
                .IsRequired();

            builder.Property(x => x.Description)
                .HasColumnType("varchar(500)")
                .IsRequired();

            builder.HasOne<Environment>(e => e.Environment)
                .WithMany(er => er.Errors)
                .HasForeignKey(i => i.EnvironmentId);

            builder.HasOne<Level>(l => l.Level)
               .WithMany(er => er.Errors)
               .HasForeignKey(i => i.LevelId);

        }
    }
}
