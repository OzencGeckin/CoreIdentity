using IdentityCoreTekrar.Models.Enums;
using IdentityCoreTekrar.Models.Interfaces;
using Microsoft.AspNetCore.Identity;
using System.Security.Principal;

namespace IdentityCoreTekrar.Models.Entities
{
    public class AppUser : IdentityUser<int>, IEntity
    {
        public AppUser()
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

        public virtual AppUserProfile Profile { get; set; }
        public virtual ICollection<Order> Orders { get; set; }
        public virtual ICollection<AppUserRole> UserRoles { get; set; }
    }
}
