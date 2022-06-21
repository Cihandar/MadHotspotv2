using AutoMapper;
using System;
using System.Collections.Generic;
using System.Text;

namespace MadHotspotV2.Application.Repositories.Mappers
{
    public interface ICustomMapping
    {
        void CreateMappings(Profile configuration);
    }
}
