using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using RiseFood.Gestor.Domain;

namespace RiseFood.Gestor.Data.Mappings
{
    public class SupplieCategoryMapping : IEntityTypeConfiguration<SupplieCategory>
    {
        public void Configure(EntityTypeBuilder<SupplieCategory> builder)
        {
            builder.ToTable("si_s_gru");


            builder.HasKey(k => k.Code);

            builder.Property(c => c.Code)
                .HasColumnName("SG_COD")
                .HasColumnType("varchar(4)");

            builder.Property(c => c.CategoryName)
                .HasColumnName("SG_NOM")
                .HasColumnType("varchar(30)");

            builder.HasMany<Supplie>(c => c.Supplies)
                .WithOne(s => s.SupplieCategory)
                .HasForeignKey(s => s.SupplieCategoryCode);
        }
    }
}
