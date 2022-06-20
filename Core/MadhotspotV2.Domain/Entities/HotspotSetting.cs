using MadHotspotV2.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Domain.Entities
{
    public class HotspotSetting : BaseModel
    {
        public bool FreeLoginActive { get; set; }
        public bool GuestEmailActive { get; set; }
        public bool GuestEmailRequired { get; set; }
        public bool GuestPhoneActive { get; set; }
        public bool GuestPhoneRequired { get; set; }
        public bool MeetingLoginActive { get; set; }
        public bool MeetingEmailActive { get; set; }
        public bool MeetingEmailRequired { get; set; }
        public bool MeetingPhoneActive { get; set; }
        public bool MeetingPhoneRequired { get; set; }
        public bool StaffLoginActive { get; set; }
        public string LogoUrl { get; set; }
        public string BackgroundImageUrl { get; set; }
    }
}
