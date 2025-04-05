using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Media;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Windows.Forms.VisualStyles;
using Rpg2d.Classes;

namespace Rpg2d
{
    public partial class Fight : Form
    {
        public Hero heroCharacter;
        public Warlock warlockCharacter;
        public Dragon dragonCharacter;
        public Zombie zombieCharacter;
        public Character enemyCharacter;
        public double damage;
        public Fight(Hero Hero, Character Enemy)
        {
            InitializeComponent();
            this.heroCharacter = Hero;
            this.enemyCharacter = Enemy;
            FightingSequence(heroCharacter, enemyCharacter);
        }
        public void FightingSequence(Character invincible, Character enemy)
        {
            GameBoard.playSound(Rpg2D.Properties.Resources.fightMusic);
            FightHealthHero.Text = "Health: " + invincible.Health.ToString();
            FightADHero.Text = "Attack Damage: " + invincible.AttackDamage.ToString();
            FightArmorHero.Text = "Armor: " + invincible.Armor.ToString();
            FightAPHero.Text = "Ability Power: " + invincible.AbilityPower.ToString();
            FightHealthEnemy.Text = "Health: " + enemy.Health.ToString();
            FightADEnemy.Text = "Attack Damage: " + enemy.AttackDamage.ToString();
            FightArmorEnemy.Text = "Armor: " + enemy.Armor.ToString();
            FightAPEnemy.Text = "Ability Power: " + enemy.AbilityPower.ToString();
            HeroName.Text = invincible.Name + " (" + invincible.Level + ")";
            EnemyName.Text = enemy.Name + " (" + enemy.Level + ")";
            if (enemy.Type == "Warlock")
            {
                fightImgWarlock.Visible = true;
            }
            if (enemy.Type == "Dragon")
            {
                fightImgDragon.Visible = true;
            }
            if (enemy.Type == "Zombie")
            {
                fightImgZombie.Visible = true;
            }
        }
        private void Victory()
        {
            MessageBox.Show("You won!");
            this.heroCharacter.Experience += 10*this.enemyCharacter.Level;
            while (this.heroCharacter.Experience >= this.heroCharacter.Level * 10)
            {
                this.heroCharacter.LevelUp();
                MessageBox.Show("You leveled up!");
            }
            this.Close();
        }
        private async void ButtonSkill1_Click(object sender, EventArgs e) {
           damage = this.heroCharacter.UseAbility1() - (this.enemyCharacter.Armor * 0.05);
           this.enemyCharacter.Health -= damage;
           FightHealthEnemy.Text = "Health: " + this.enemyCharacter.Health.ToString() + " (-" + damage + ")";
           ButtonSkill1.Enabled = false;
           ButtonSkill2.Enabled = false;
            if (this.enemyCharacter.Health <= 0)
            {
                Victory();
                return;
            }
            await Task.Delay(500);
            EnemyAttack();
        }
        private async void ButtonSkill2_Click(object sender, EventArgs e)
        {
            damage = this.heroCharacter.UseAbility2() - (this.enemyCharacter.Armor * 0.05);
            this.enemyCharacter.Health -= damage;
            FightHealthEnemy.Text = $"Health: " + this.enemyCharacter.Health.ToString() + " (-" + damage + ")";
            ButtonSkill1.Enabled = false;
            ButtonSkill2.Enabled = false;
            if (this.enemyCharacter.Health <= 0)
            {
                Victory();
                return;
            }
            await Task.Delay(500);
            EnemyAttack();
        }
        private void EnemyAttack()
        {
            Random rnd = new Random();
            int skill = rnd.Next(1, 7);
            switch (skill)
            {
                case 1:
                case 2:
                case 3:
                    damage = enemyCharacter.UseAbility1() - (this.heroCharacter.Armor * 0.05);
                    EnemyAbilityUseText.Visible = true;
                    EnemyAbilityUseText.Text = $"{enemyCharacter.Name} used ability 1!";
                    this.heroCharacter.Health -= damage;
                    FightHealthHero.Text = "Health: " + this.heroCharacter.Health.ToString() + " (-" + damage + ")";
                    break;
                case 4:
                case 5:
                    damage = enemyCharacter.UseAbility2() - (this.heroCharacter.Armor * 0.05);
                    EnemyAbilityUseText.Visible = true;
                    EnemyAbilityUseText.Text = $"{enemyCharacter.Name} used ability 2!";
                    this.heroCharacter.Health -= damage;
                    FightHealthHero.Text = "Health: " + this.heroCharacter.Health.ToString() + " (-" + damage + ")";
                    break;
                case 6:
                    damage = enemyCharacter.UseAbility3() - (this.heroCharacter.Armor * 0.05);
                    EnemyAbilityUseText.Visible = true;
                    EnemyAbilityUseText.Text = $"{enemyCharacter.Name} used ability 3!";
                    this.heroCharacter.Health -= damage;
                    FightHealthHero.Text = "Health: " + this.heroCharacter.Health.ToString() + " (-" + damage + ")";
                    break;
            }
            if (this.heroCharacter.Health <= 0)
            {
                MessageBox.Show("You lost!");
                this.Close();
            }
            ButtonSkill1.Enabled = true;
            ButtonSkill2.Enabled = true;      
        }
        private void RunAwayButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("You ran away!");
            this.Close();
        }
    }
}
