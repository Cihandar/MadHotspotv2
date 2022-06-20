using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Domain.Entities.Common
{
    public class BaseModel
    {
        public Guid Id { get; set; }
        public Guid CompanyId { get; set; }
        public int CompanyCode { get; set; }
        public bool Deleted { get; set; }
        public DateTime DeletedTime { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
