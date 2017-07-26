using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace MembershipWebApi.Models
{
    public class EducationDetail
    {
        public Guid EducationDetailId { get; set; }
        public Guid Applicationid { get; set; }
        public Guid UserId { get; set; }
        public Guid InstituteId { get; set; }
        public DateTime AwardedAt { get; set; }
        public string MajorSubject { get; set; }
        public string MinorSubject { get; set; }
        public bool IsDeleted { get; set; }
        public DateTime CreatedAt { get; set; }
        public DateTime UpdatedAt { get; set; }
        public DateTime DeletedAt { get; set; }
    }
}
