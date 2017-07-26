using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipWebApi.Models
{
    public class SelfDeclaration
    {
        public Guid SelfDeclarationId { get; set; }
        public Guid ApplicationTypeId { get; set; }
        public string Type { get; set; }
        public string Declaration { get; set; }
        public bool NotesRequired { get; set; }
        public bool OnlyNotes { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    }
}
