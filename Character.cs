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
        public double Health { get; set; }
        public int AttackDamage { get; set; }
        public int Armor { get; set; }
        public int AbilityPower { get; set; }
        public int MagicResistance { get; set; }
        public int Speed { get; set; }
        public int Level { get; set; }
        public int Experience { get; set; }
        public Character(string name, double health, int attackDamage, int armor, int abilityPower)
        {
            Name = name;
            Health = health;
            AttackDamage = attackDamage;
            Armor = armor;
            AbilityPower = abilityPower;
            Experience = 0;
        }
        public void LevelUp()
        {
            Level++;
            Health += 10;
            AttackDamage += 1;
            Armor += 1;
            AbilityPower += 1;
            Experience = 0;
        }
    }
    public class Invincible : Character
    {
        public Invincible(string name, double health, int attackDamage, int armor, int abilityPower) : base(name, health, attackDamage, armor, abilityPower)
        {
            Level = 10;
        }
        public int punch()
        {
            return AttackDamage + Level;
        }
        public int kick()
        {
            return AttackDamage*Level;
        }

    }
    public class Conquest : Character
    {
        public Conquest(string name, double health, int attackDamage, int armor, int abilityPower) : base(name, health, attackDamage, armor, abilityPower)
        {
            Level = 30;

        }
        public int ability1()
        {
            return AttackDamage;
        }
        public int ability2()
        {
            return AttackDamage + 3;
        }
        public int ability3()
        {
            return AttackDamage + 6;
        }

    }
    public class Angstrom : Character
    {
        public Angstrom(string name, double health, int attackDamage, int armor, int abilityPower) : base(name, health, attackDamage, armor, abilityPower)
        {
            Level = 5;

        }
        public int ability1()
        {
            return AbilityPower * 2;
        }
        public int ability2()
        {
            return AbilityPower;
        }
        public int ability3()
        {
            return AbilityPower + 1;
        }
    }
}
