﻿namespace dotnet_rpg.DTOs.Weapon
{
    public class AddWeaponDTO
    {
        public string Name { get; set; } = string.Empty;
        public int Damage { get; set; }
        public int CharacterID { get; set; }
    }
}
