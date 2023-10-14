﻿using CharacterAPI.Dtos.Character;
using CharacterAPI.Models;

namespace CharacterAPI.Services.CharacterService
{
	public interface ICharacterService
	{
		Task<ServiceResponse<List<GetCharacterDto>>> GetAllCharacters();
		Task<ServiceResponse<GetCharacterDto>> GetCharacterById(int id);
		Task<ServiceResponse<List<GetCharacterDto>>> AddCharacter(AddCharacterDto newCharacter);
		Task<ServiceResponse<GetCharacterDto>> UpdateCharacter(UpdateCharacterDto updatedCharacter);
		Task<ServiceResponse<List<GetCharacterDto>>> DeleteCharacter(int id);
	}
}
