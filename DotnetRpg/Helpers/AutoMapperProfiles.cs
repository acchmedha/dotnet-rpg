using AutoMapper;
using DotnetRpg.DTOs;
using DotnetRpg.Models;


namespace DotnetRpg.Helpers
{
    public class AutoMapperProfiles : Profile
    {
        public AutoMapperProfiles()
        {
            CreateMap<Character, CharacterDto>();
        }

        
    }
}
