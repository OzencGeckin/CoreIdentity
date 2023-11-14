using IdentityCoreTekrar.Models.Enums;
using IdentityCoreTekrar.Models.Interfaces;
using Microsoft.AspNetCore.Identity;

namespace IdentityCoreTekrar.Models.Entities
{
    public class AppUserRole : IdentityUserRole<int>, IEntity
    {      
            public AppUserRole()
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

        public virtual AppRole Role { get; set; }
        public virtual AppUser User { get; set; }
    }
}
