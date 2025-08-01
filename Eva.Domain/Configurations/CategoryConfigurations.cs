﻿using Eva.Domain._Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Eva.Domain.Configurations
{
    internal class CategoryConfigurations : IEntityTypeConfiguration<Categories>
    {
        public void Configure(EntityTypeBuilder<Categories> builder)
        {
        
            builder.HasKey(C => C.Id);
            builder.Property(C => C.CategoryName).HasColumnType("Varchar(50)").IsRequired(true);
            builder.Property<DateTime>("CreatedAt").HasDefaultValueSql("GetDate()");

            builder.HasMany(c => c.Products).WithOne(P=>P.Category).HasForeignKey(p=>p.CategoryId);

        }
    }
}
