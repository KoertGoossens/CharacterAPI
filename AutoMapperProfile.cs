using AutoMapper;
using CharacterAPI.Dtos.Character;
using CharacterAPI.Models;

namespace CharacterAPI
{
	public class AutoMapperProfile : Profile
	{
		public AutoMapperProfile()
		{
			CreateMap<Character, GetCharacterDto>();
			CreateMap<AddCharacterDto, Character>();
		}
	}
}
