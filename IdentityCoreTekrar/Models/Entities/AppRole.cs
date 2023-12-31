﻿using IdentityCoreTekrar.Models.Enums;
using IdentityCoreTekrar.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace IdentityCoreTekrar.Models.Entities
{
    public class AppRole : IdentityRole<int>, IEntity
    {
        public AppRole()
        {
            CreatedDate = DateTime.UtcNow;
            Status = DataStatus.Inserted;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }

        //Relational Properties

        public virtual ICollection<AppUserRole> UserRoles { get; set; }

    }
}

