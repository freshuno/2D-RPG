using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace InvincibleGame
{
    public class Character
    {
        public string Name { get; set; }
        public int Health { get; set; }
        public int AttackDamage { get; set; }
        public int Armor { get; set; }
        public int AbilityPower { get; set; }
        public int MagicResistance { get; set; }
        public int Speed { get; set; }
        public Character(string name, int health, int attackDamage, int armor, int abilityPower)
        {
            Name = name;
            Health = health;
            AttackDamage = attackDamage;
            Armor = armor;
            AbilityPower = abilityPower;
        }
    }
}
