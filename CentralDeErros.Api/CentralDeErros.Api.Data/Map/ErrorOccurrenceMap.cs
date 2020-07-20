using Microsoft.EntityFrameworkCore;
using CentralDeErros.Api.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System.Security.Cryptography.X509Certificates;

namespace CentralDeErros.Api.Data.Map
{
    public class ErrorOccurrenceMap : IEntityTypeConfiguration<ErrorOccurrence>
    {
        public void Configure(EntityTypeBuilder<ErrorOccurrence> builder)
        {
            builder.ToTable("Error_OCCURRENCE");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.Origin)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(x => x.Details)
                .HasColumnType("varchar(2000)")
                .IsRequired();

            builder.Property(x => x.DateTime)
                .HasColumnType("smalldatetime")
                .IsRequired();

            builder.HasOne(u => u.User)
                .WithMany(er => er.ErrorOccurrences)
                .HasForeignKey(x => x.UserId);

            builder.HasOne(e => e.Error)
                .WithMany(er => er.ErrorOccurrence)
                .HasForeignKey(x => x.ErrorId);
        }
    }
}
