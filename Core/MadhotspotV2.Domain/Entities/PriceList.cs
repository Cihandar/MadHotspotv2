using MadHotspotV2.Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Domain.Entities
{
    public class PriceList : BaseModel
    {
        public string PriceListName { get; set; }
        public int Day { get; set; }
        public double TRYPrice { get; set; }
        public double EURPrice { get; set; }
        public double USDPrice { get; set; }
        public bool Active { get; set; }
    }
}
