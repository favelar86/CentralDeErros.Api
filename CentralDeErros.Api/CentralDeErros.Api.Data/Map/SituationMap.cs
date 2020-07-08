using Microsoft.EntityFrameworkCore;
using CentralDeErros.Api.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentralDeErros.Api.Data.Map
{
    public class SituationMap : IEntityTypeConfiguration<Situation>
    {
        public void Configure(EntityTypeBuilder<Situation> builder)
        {
            builder.ToTable("SITUATION");

            builder.HasKey(x => x.SituationId);

            builder.Property(x => x.SituationName)
                .HasColumnType("varchar(30)")
                .IsRequired();
        }
    }
}
