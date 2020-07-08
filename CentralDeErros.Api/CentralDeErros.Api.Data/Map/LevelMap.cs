using Microsoft.EntityFrameworkCore;
using CentralDeErros.Api.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentralDeErros.Api.Data.Map
{
    public class LevelMap : IEntityTypeConfiguration<Level>
    {
        public void Configure(EntityTypeBuilder<Level> builder)
        {
            builder.ToTable("LEVEL");

            builder.HasKey(x => x.LevelId);

            builder.Property(x => x.LevelName)
                .HasColumnType("varchar(30)")
                .IsRequired();
        }
    }
}
