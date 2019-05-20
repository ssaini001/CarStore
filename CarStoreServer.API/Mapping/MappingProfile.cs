using AutoMapper;
using CarStoreServer.API.Controllers.Resources;
using CarStoreServer.API.Models;

namespace CarStoreServer.API.Mapping
{
    public class MappingProfile:Profile
    {
        public MappingProfile()
        {
            CreateMap<Make, MakeResource>();
            CreateMap<Model,ModelResource>();
            CreateMap<Feature, FeatureResource>();
            
        }
    }
}