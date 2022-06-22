using AutoMapper;
using MadHotspotV2.Application.Mappers.AutoMapper;
using MadHotspotV2.Application.Dtos.Companies;
using MadHotspotV2.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;

namespace MadHotspotV2.Application.Mappers
{
    public class AutoMapperProfile : Profile
    {
        public AutoMapperProfile()
        {
            LoadStandardMapping();
            LoadCustomMappings();
        }

        private void LoadStandardMapping()
        {
            var mapForm = MapperProfileHelper.LoadStandardMappings(Assembly.GetExecutingAssembly());
            foreach (var map in mapForm)
            {
                CreateMap(map.Source, map.Destination).ReverseMap();
            }
        }

        private void LoadCustomMappings()
        {
            var mapForm = MapperProfileHelper.LoadCustomMappings(Assembly.GetExecutingAssembly());
            foreach (var map in mapForm)
            {
                map.CreateMappings(this);
            }
        }
    }
}
