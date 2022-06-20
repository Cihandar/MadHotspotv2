using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Domain.Entities.Common
{
   public class BaseModelForCompany
    {
        public Guid Id { get; set; }
        public bool Deleted { get; set; }
        public DateTime DeletedTime { get; set; }
        public DateTime CreatedTime { get; set; }
    }
}
