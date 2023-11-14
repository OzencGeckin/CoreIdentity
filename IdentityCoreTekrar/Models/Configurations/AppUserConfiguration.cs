﻿using IdentityCoreTekrar.Models.Entities;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace IdentityCoreTekrar.Models.Configurations
{
    public class AppUserConfiguration:BaseConfiguration<AppUser>
    {
        public override void Configure(EntityTypeBuilder<AppUser> builder)
        {
            base.Configure(builder);
            builder.Ignore(x => x.ID);
            builder.HasOne(x => x.Profile).WithOne(x => x.AppUser).HasForeignKey<AppUserProfile>(x => x.ID);
            builder.HasMany(x => x.UserRoles).WithOne(x=> x.User).HasForeignKey(x => x.UserId).IsRequired();
            builder.HasMany(x => x.Orders).WithOne(x => x.AppUser).HasForeignKey(x => x.AppUserID);//Orderın 1 tane appuserı olr

        }
    }
}
