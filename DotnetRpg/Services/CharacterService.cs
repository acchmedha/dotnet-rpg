using AutoMapper;
using DotnetRpg.DTOs;
using DotnetRpg.Interfaces;
using DotnetRpg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetRpg.Services.CharacterService
{
    public class CharacterService : ICharacterService
    {

        private static List<CharacterDto> characters = new List<CharacterDto>
        {
            new CharacterDto(),
            new CharacterDto {Id = 1, Name = "Sam"}
        };
        private readonly IMapper _mapper;

        public CharacterService(IMapper mapper)
        {
            _mapper = mapper;
        }

        public async Task<List<CharacterDto>> AddCharacter(CharacterDto newCharacter)
        {
            characters.Add(_mapper.Map<CharacterDto>(newCharacter));
            return characters;
        }

        public async Task<List<CharacterDto>> GetAllCharacters()
        {
            return characters;
        }

        public async Task<CharacterDto> GetCharacterById(int id)
        {
            return _mapper.Map<CharacterDto>(characters.FirstOrDefault(c => c.Id == id));
        }

     
    }
}
