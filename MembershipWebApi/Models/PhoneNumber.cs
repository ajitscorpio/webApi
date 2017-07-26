using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipWebApi.Models
{
    public class PhoneNumber
    {
        public Guid PhoneNumberId { get; set; }
        public Guid Applicationid { get; set; }
        public Guid UserId { get; set; }
        public Guid LookupMasterId { get; set; }
        public string phone { get; set; }
        public bool IsPrimary { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
