using MadHotspotV2.Domain.Entities;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Persistence.Contexts
{
    public class MadHotspotV2DbContext : DbContext
    {
        public MadHotspotV2DbContext(DbContextOptions options) : base(options)
        {}

        public DbSet<AppUser> AppUsers { get; set; }
        public DbSet<Company> Companies { get; set; }
        public DbSet<CompanyUser> CompanyUsers { get; set; }
        public DbSet<CreatedUsersForHotspot> CreatedUsersForHotspots { get; set; }
        public DbSet<CustomerInfo> CustomerInfos { get; set; }
        public DbSet<HotspotSetting> HotspotSettings { get; set; }
        public DbSet<PriceList> PriceLists { get; set; }
        public DbSet<Setting> Settings { get; set; }

    }
}
