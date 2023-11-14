using IdentityCoreTekrar.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityCoreTekrar.Models.Configurations
{
    public class CategoryConfiguration : BaseConfiguration<Category>
    {
        public override void Configure(EntityTypeBuilder<Category> builder)
        {
            base.Configure(builder);
            builder.HasMany(x => x.Products).WithOne(x => x.Category).HasForeignKey(x => x.CategoryID);
        }
    }
}
