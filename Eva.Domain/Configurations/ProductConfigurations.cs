using Eva.Domain._Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Eva.Domain.Configurations
{
    internal class ProductConfigurations : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {

            builder.HasKey(P => P.Id);
            builder.Property(P => P.Title).HasMaxLength(50);
            builder.Property(P => P.Description).HasMaxLength(250).IsRequired(false);
            builder.Property(P => P.Author).HasMaxLength(50).IsRequired(false);
            builder.Property(P => P.Price).HasColumnName("BookPrice");
            builder.HasCheckConstraint("BookPriceConstrain", "[BookPrice]> 0.0 And  [BookPrice] <1000.0 ");//To Determine what Constrains i need for the table


        }
    }
}
