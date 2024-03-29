﻿using dotnet_rpg.DTOs.Skill;
using dotnet_rpg.DTOs.Weapon;
using dotnet_rpg.Models;

namespace dotnet_rpg.DTOs.Character
{
    public class GetCharacterResponseDTO
    {
        public int Id { get; set; }
        public string? Name { get; set; }
        public int HitPoint { get; set; }
        public int Strength { get; set; }
        public int Defence { get; set; }
        public int Intelligence { get; set; }
        public RpgClass ClassType { get; set; }
        public GetWeaponDTO? Weapon { get; set; }
        public List<GetSkillDTO> Skills { get; set; }
        public int Fights { get; set; }
        public int Victories { get; set; }
        public int Defeats { get; set; }
    }
}
