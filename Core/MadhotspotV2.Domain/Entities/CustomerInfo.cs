using MadHotspotV2.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Domain.Entities
{
    public class CustomerInfo:BaseModel
    {
        public string RoomNumber { get; set; }
        public string BirthDate { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public bool KvkkPermission { get; set; }
        public bool ContactPermission { get; set; }
    }
}
