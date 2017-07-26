using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipWebApi.Models
{
    public class ApplicationSelfDeclaration
    {
        public Guid ApplicationSelfDeclarationId { get; set; }
        public Guid ApplicationId { get; set; }
        public Guid SelfDeclarationId { get; set; }
        public string Notes { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
