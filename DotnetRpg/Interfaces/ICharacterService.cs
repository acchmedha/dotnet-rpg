using DotnetRpg.DTOs;
using DotnetRpg.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetRpg.Interfaces
{
    public interface ICharacterService
    {
        Task<List<CharacterDto>> GetAllCharacters();
        Task<CharacterDto> GetCharacterById(int id);
        Task<List<CharacterDto>> AddCharacter(CharacterDto newCharacter);
        Task<List<CharacterDto>> UpdateCharacter(CharacterDto updatedCharacter);
    }
}
