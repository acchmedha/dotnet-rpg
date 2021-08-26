using DotnetRpg.DTOs;
using DotnetRpg.Interfaces;
using DotnetRpg.Models;
using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DotnetRpg.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CharacterController : ControllerBase
    {
        private readonly ICharacterService _characterService;

        public CharacterController(ICharacterService characterService)
        {
            _characterService = characterService;
        }

        [HttpGet("all")]
        public async Task<ActionResult<List<CharacterDto>>> Get()
        {
            return Ok(await _characterService.GetAllCharacters());
        } 

        [HttpGet("{id}")]
        public async Task<ActionResult<CharacterDto>> GetSingle(int id)
        {
            return Ok(await _characterService.GetCharacterById(id));
        }

        [HttpPost]
        public async Task<ActionResult<List<CharacterDto>>> AddCharacter(CharacterDto newCharacter)
        {
            return Ok(await _characterService.AddCharacter(newCharacter));
        }

    }
}
