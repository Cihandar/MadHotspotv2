using Microsoft.Extensions.Configuration;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text;

namespace MadHotspotV2.Persistence
{
    static class Configuration
    {
       static public string ConnectionString
        {
            get
            {
                ConfigurationBuilder configurationBuilder = new ConfigurationBuilder();
                configurationBuilder.SetBasePath(Path.Combine(Directory.GetCurrentDirectory(), "../../Presentation/MadHotspotV2.WebUI"));
                configurationBuilder.AddJsonFile("appsettings.json");
                return configurationBuilder.Build().GetConnectionString("MadHotspotV2SqlConnection");
            }
        }
    }
}
