using Microsoft.EntityFrameworkCore;
using CentralDeErros.Api.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentralDeErros.Api.Data.Map
{
    public class EnvironmentMap : IEntityTypeConfiguration<Environment>
    {
        public void Configure(EntityTypeBuilder<Environment> builder)
        {
            builder.ToTable("Environment");

            builder.HasKey(x => x.Id);

            builder.Property(x => x.EnvironmentName)
                .HasColumnType("varchar(200)")
                .IsRequired();
        }
    }
}
