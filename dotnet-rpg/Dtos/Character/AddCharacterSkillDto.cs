using System;
namespace dotnet_rpg.Dtos.Character
{
    public class AddCharacterSkillDto
    {
        public AddCharacterSkillDto()
        {
        }
        public int CharacterId { get; set; }
        public int SkillId { get; set; }
    }
}

