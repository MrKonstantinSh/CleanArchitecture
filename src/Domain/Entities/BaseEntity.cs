using CleanArchitecture.Domain.Common;

namespace CleanArchitecture.Domain.Entities
{
    public abstract class BaseEntity : AuditableEntity
    {
        public int Id { get; set; }
    }
}