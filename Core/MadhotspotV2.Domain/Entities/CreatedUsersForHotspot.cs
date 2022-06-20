using MadHotspotV2.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Domain.Entities
{
    public class CreatedUsersForHotspot : BaseModel
    {
        public string HotspotPassword { get; set; }
        public string FullName { get; set; }
        public string IdentityNumber { get; set; }
        public string PhoneNumber { get; set; }
        public string RoomNumber { get; set; }
        public double Price { get; set; } 
        public string Currency { get; set; }
        public int Day { get; set; }
        public DateTime StartDate { get; set; }
        public DateTime FinishDate { get; set; }
        public bool SendedMikroitk { get; set; }
        public bool Refund { get; set; }
        public double RefundPrice { get; set; }
        public string RefundCurrency { get; set; }
        public bool PriceList { get; set; }
        public Guid PriceListId { get; set; }
    }
}
