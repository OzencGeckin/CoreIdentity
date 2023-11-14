using IdentityCoreTekrar.Models.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityCoreTekrar.Models.Configurations
{
    public class ProductConfiguration :BaseConfiguration<Product>
    {
        public override void Configure(EntityTypeBuilder<Product> builder)
        {
            base.Configure(builder);
            builder.HasMany(x=> x.OrderDetails).WithOne(x=>x.Product).HasForeignKey(x=>x.ProductID).IsRequired();
            builder.Property(x => x.UnitPrice).HasColumnType("money");
        }
    }
}
