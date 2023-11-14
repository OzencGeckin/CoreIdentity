using IdentityCoreTekrar.Models.Enums;
using IdentityCoreTekrar.Models.Interfaces;

namespace IdentityCoreTekrar.Models.Entities
{
    public abstract class BaseEntity : IEntity
    {
        public BaseEntity()
        {
            CreatedDate = DateTime.UtcNow;
            Status = DataStatus.Inserted;
        }
        public int ID { get; set; }
        public DateTime CreatedDate { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public DateTime? DeletedDate { get; set; }
        public DataStatus Status { get; set; }
    }
}
