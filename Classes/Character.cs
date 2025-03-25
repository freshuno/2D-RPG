using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace InvincibleGame.Classes
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
        public Character(string name, int level)
        {
            Name = name;
            Level = level;
            Health = level * 10;
            AttackDamage = level;
            Armor = level;
            Experience = 0;
        }
        public void LevelUp()
        {
            Experience = Experience - Level * 10;
            Level++;
            Health += 10;
            AttackDamage += 1;
            Armor += 1;
            AbilityPower += 1;
        }
    }
    public class Invincible : Character
    {
        public Invincible(string name, int level) : base(name, level)
        {
            Name = name;
            Level = level;
            Health = level * 15;
            AttackDamage = level + 3;
            Armor = level + 4;
            Experience = 0;

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
        public Conquest(string name, int level) : base(name, level)
        {
            Name = name;
            Level = level;
            Health = level * 10;
            AttackDamage = level;
            Armor = level;
            Experience = 0;

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
        public Angstrom(string name, int level) : base(name, level)
        {
            Name = name;
            Level = level;
            Health = level * 10;
            AttackDamage = level;
            Armor = level;
            Experience = 0;
            AbilityPower = Level + 3;

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
    public class Zombie : Character
    {
        public Zombie(string name, int level) : base(name, level)
        {
            Name = name;
            Level = level;
            Health = level * 10;
            AttackDamage = level;
            Armor = level;
            Experience = 0;

        }
        public int ability1()
        {
            return AttackDamage;
        }
        public int ability2()
        {
            return AttackDamage + 2;
        }
        public int ability3()
        {
            return AttackDamage + 3;
        }
    }
}
