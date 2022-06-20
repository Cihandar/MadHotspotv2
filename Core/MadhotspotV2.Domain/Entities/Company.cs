﻿using MadHotspotV2.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Domain.Entities
{
   public class Company : BaseModel
    { 
        public string CompanyName { get; set; }
        public string Email { get; set; }
        public string PhoneNumber { get; set; }
        public string AuthorizedPerson { get; set; }
        public string Password { get; set; }
        public bool Active { get; set; }
        public DateTime LicanceStartDate { get; set; }
        public DateTime LicanceEndDate { get; set; }
    }
}
