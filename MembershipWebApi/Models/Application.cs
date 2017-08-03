using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipWebApi.Models
{
    public class Application
    {
        public Guid ApplicationId { get; set; }
        public Guid ApplicationTypeId { get; set; }
        public Guid UserId { get; set; }
        public Guid state { get; set; }
        public string Token { get; set; }
        public bool IsDeleted { get; set; } = false;
        public DateTime CreatedAt { get; set; } = DateTime.Now;
        public DateTime UpdatedAt { get; set; } = DateTime.Now;
        public Nullable<DateTime> DeletedAt { get; set; } 

    }
}
