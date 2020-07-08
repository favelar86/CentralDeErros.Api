using Microsoft.EntityFrameworkCore;
using CentralDeErros.Api.Domain.Models;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace CentralDeErros.Api.Data.Map
{
    public class UsersMap : IEntityTypeConfiguration<Users>
    {
        public void Configure(EntityTypeBuilder<Users> builder)
        {
            builder.ToTable("USERS");

            builder.HasKey(x => x.UserId);

            builder.Property(x => x.Name)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(x => x.Email)
                .HasColumnType("varchar(200)")
                .IsRequired();

            builder.Property(x => x.Password)
                .HasColumnType("varchar(50)")
                .IsRequired();
        }
    }
}
