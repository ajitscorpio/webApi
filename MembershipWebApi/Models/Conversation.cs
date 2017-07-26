using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipWebApi.Models
{
    public class Conversation
    {
        public Guid CommunicationId { get; set; }
        public string Subject { get; set; }
        public bool IsRead { get; set; }
        public Guid UserId { get; set; }
        public Guid AssignedTo { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
