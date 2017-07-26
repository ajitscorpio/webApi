using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipWebApi.Models
{
    public class Message
    {
        public Guid MessageId { get; set; }
        public Guid CommunicationId { get; set; }
        public Guid SenderId { get; set; }
        public Guid recieverId { get; set; }
        public string Body { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
