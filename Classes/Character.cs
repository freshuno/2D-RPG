using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace Rpg2d.Classes
{
    public abstract class Character
    {
        public string Name { get; set; }
        public string Type { get; set; }
        public double Health { get; set; }
        public double MaxHealth { get; set; }
        public int AttackDamage { get; set; }
        public int Armor { get; set; }
        public int AbilityPower { get; set; }
        public int MagicResistance { get; set; }
        public int Speed { get; set; } //not used for now
        public int Level { get; set; }
        public int Experience { get; set; }
        public Character(string name, int level)
        {
            Name = name;
            Level = level;
            Health = level * 10;
            MaxHealth = Health;
            AttackDamage = level;
            Armor = level*5;
        }
        public void LevelUp()
        {
            Experience = Experience - Level * 10;
            Level++;
            MaxHealth += 10;
            Health = MaxHealth;
            AttackDamage += 1;
            Armor += 1;
            AbilityPower += 1;
        }
        public abstract int UseAbility1();
        public abstract int UseAbility2();
        public abstract int UseAbility3();
    }
    public class Hero : Character
    {
        public Hero(string name, int level) : base(name, level)
        {
            Health = level * 15;
            MaxHealth = Health;
            AttackDamage = level + 3;
            Armor = level + 4;
        }
        public override int UseAbility1()
        {
            return AttackDamage + Level;
        }
        public override int UseAbility2()
        {
            return AttackDamage*Level;
        }
        public override int UseAbility3()
        {
            return AttackDamage + 2 * Level;
        }

    }
    public class Dragon : Character
    {
        public Dragon(string name, int level) : base(name, level)
        {
            AttackDamage = Level + 2;
            Type = "Dragon";
        }
        public override int UseAbility1()
        {
            return AttackDamage;
        }
        public override int UseAbility2()
        {
            return AttackDamage + 3;
        }
        public override int UseAbility3()
        {
            return AttackDamage + 6;
        }

    }
    public class Warlock : Character
    {
        public Warlock(string name, int level) : base(name, level)
        {

            AttackDamage = 0;
            AbilityPower = Level + 3;
            Type = "Warlock";

        }
        public override int UseAbility1()
        {
            return AbilityPower * 2;
        }
        public override int UseAbility2()
        {
            return AbilityPower;
        }
        public override int UseAbility3()
        {
            return AbilityPower + 1;
        }
    }
    public class Zombie : Character
    {
        public Zombie(string name, int level) : base(name, level)
        {
            AttackDamage = Level + 1;
            Type = "Zombie";

        }
        public override int UseAbility1()
        {
            return AttackDamage;
        }
        public override int UseAbility2()
        {
            return AttackDamage + 2;
        }
        public override int UseAbility3()
        {
            return AttackDamage + 3;
        }
    }
}
