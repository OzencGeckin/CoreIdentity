using IdentityCoreTekrar.Models.Interfaces;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityCoreTekrar.Models.Configurations
{
    public abstract class BaseConfiguration<T> : IEntityTypeConfiguration<T> where T : class, IEntity
    {
        public virtual void Configure(EntityTypeBuilder<T> builder)
        {
            builder.Property(x => x.CreatedDate).HasColumnName("Yaratılma Tarihi");
        }
    }
}
