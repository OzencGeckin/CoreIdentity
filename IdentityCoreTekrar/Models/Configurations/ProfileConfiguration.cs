using IdentityCoreTekrar.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityCoreTekrar.Models.Configurations
{
    public class ProfileConfiguration : BaseConfiguration<AppUserProfile>
    {
        public override void Configure(EntityTypeBuilder<AppUserProfile> builder)
        {
            base.Configure(builder);
        }
    }
}
