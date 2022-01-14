using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using TAT.ToDo.Entities.Concrete;

namespace TAT.ToDo.DataAccess.Concrete.EntityFrameworkCore.Configurations
{
    public class KullaniciMap : IEntityTypeConfiguration<Kullanici>
    {
        public void Configure(EntityTypeBuilder<Kullanici> builder)
        {
            builder.HasKey(I => I.Id);
            builder.Property(I => I.Id).UseIdentityColumn();

            builder.Property(I => I.Ad).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Soyad).HasMaxLength(100).IsRequired();
            builder.Property(I => I.Telefon).HasMaxLength(50);
            builder.Property(I => I.Email).HasMaxLength(100).IsRequired();

            builder.HasMany(I => I.Calismalar).WithOne(I => I.Kullanici).HasForeignKey
                (I => I.KullanıcıId);

        }
    }
}
