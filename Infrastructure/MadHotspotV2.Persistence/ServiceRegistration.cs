using MadHotspotV2.Persistence.Contexts;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.Extensions.Configuration;
using System.IO;
using MadHotspotV2.Persistence.Repositories.Companies;
using MadHotspotV2.Application.Repositories.Companies;

namespace MadHotspotV2.Persistence
{
   public static class ServiceRegistration
    {
        public static void  AddPersistenceServices(this IServiceCollection services)
        {
            services.AddDbContext<MadHotspotV2DbContext>(options => options.UseSqlServer(Configuration.ConnectionString));
            services.AddScoped<ICompanyReadRepository, CompanyReadRepository>();
            services.AddScoped<ICompanyWriteRepository, CompanyWriteRepository>();
        }
    }
}
