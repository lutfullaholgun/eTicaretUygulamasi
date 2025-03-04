using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using eTicaretUygulamasi.EntityLayer; // AppUser modelini kullanabilmek için ekle!

namespace eTicaretUygulamasi.DataAccessLayer.Configurations
{
    internal class AppUserConfiguration : IEntityTypeConfiguration<AppUser>
    {
        public void Configure(EntityTypeBuilder<AppUser> builder)
        {
            builder.Property(a => a.Name).HasMaxLength(50).HasColumnType("varchar(50)").IsRequired();
            builder.Property(a => a.SurName).HasMaxLength(50).HasColumnType("varchar(50)").IsRequired();
            builder.Property(a => a.Password).HasMaxLength(50).HasColumnType("varchar(50)").IsRequired();
            builder.Property(a => a.Email).HasMaxLength(50).HasColumnType("varchar(50)").IsRequired();
            builder.Property(a => a.Phone).HasColumnType("varchar(15)").HasMaxLength(15);
            builder.Property(a => a.UserName).HasMaxLength(50).HasColumnType("varchar(50)");
        }
    }
}
