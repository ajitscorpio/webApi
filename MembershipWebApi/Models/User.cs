using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipWebApi.Models
{
    public class User
    {
        public Guid UserId { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public Guid TempToken { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime LastLoginAt { get; set; }
        public DateTime CreatedAt { get; set; }
        public Nullable<DateTime> DeletedAt { get; set; }
        public DateTime UpdatedAt { get; set; }

    
    }


}
