using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiseFood.Gestor.Domain;

namespace RiseFood.Gestor.Data.Mappings
{
    public class SupplieMapping : IEntityTypeConfiguration<Supplie>
    {
        public void Configure(EntityTypeBuilder<Supplie> builder)
        {
            builder.ToTable("si_insu");

            builder.HasKey(i => i.Id);

            builder.Property(i => i.Id)
                     .HasColumnName("IN_ID")
                     .HasColumnType("int(6)");

            builder.Property(i => i.Code)
               .HasColumnName("IN_NUME")
               .HasColumnType("varchar(20)");

            builder.Property(i => i.SupplieName)
               .HasColumnName("IN_NOM")
               .HasColumnType("varchar(50)");

            builder.Property(i => i.Price)
               .HasColumnName("IN_VALOR")
               .HasColumnType("decimal(10,2)");

            builder.Property(i => i.SupplieCategoryCode)
                .HasColumnName("IN_SUBGR")
                .HasColumnType("varchar(4)");
        }
    }
}
