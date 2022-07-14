using Odws.Api.Domain.Common;

namespace Odws.Api.Domain.Entities
{
    public class Note:BaseEntity
    {
        public string? Name { get; set; }
        public string? Description { get; set; }
    }
}
