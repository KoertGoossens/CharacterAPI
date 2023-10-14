﻿using CharacterAPI.Models;

namespace CharacterAPI.Services.CharacterService
{
	public class CharacterService : ICharacterService
	{
		private static List<Character> characters = new List<Character>
		{
			new Character { Id = 0, Name = "Frodo" },
			new Character { Id = 1, Name = "Sam" }
		};

		public List<Character> GetAllCharacters()
		{
			return characters;
		}

		public Character GetCharacterById(int id)
		{
			var character = characters.FirstOrDefault(c => c.Id == id);

			if (character != null)
			{
				return character;
			}

			throw new Exception("Character not found.");
		}

		public List<Character> AddCharacter(Character newCharacter)
		{
			characters.Add(newCharacter);
			return characters;
		}
	}
}
