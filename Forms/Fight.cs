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
using InvincibleGame.Classes;

namespace InvincibleGame
{
    public partial class Fight : Form
    {
        public Invincible invincible;
        public Angstrom angstrom;
        public Conquest conquest;
        public Character enemy;
        public double damage;
        public Fight(Invincible Invincible, Angstrom Angstrom)
        {
            InitializeComponent();
            this.invincible = Invincible;
            this.angstrom = Angstrom;
            this.enemy = Angstrom;
            FightingSequence(invincible, angstrom);
        }
        public Fight(Invincible Invincible, Conquest Conquest)
        {
            InitializeComponent();
            this.invincible = Invincible;
            this.conquest = Conquest;
            this.enemy = Conquest;
            FightingSequence(invincible, conquest);
        }
        public void FightingSequence(Character invincible, Character enemy)
        {
            GameBoard.playSound(@"e:\C#projects\InvincibleGame\Resources\Music\battleMusic.wav");
            FightHealthHero.Text = "Health: " + invincible.Health.ToString();
            FightADHero.Text = "Attack Damage: " + invincible.AttackDamage.ToString();
            FightArmorHero.Text = "Armor: " + invincible.Armor.ToString();
            FightAPHero.Text = "Ability Power: " + invincible.AbilityPower.ToString();
            FightHealthEnemy.Text = "Health: " + enemy.Health.ToString();
            FightADEnemy.Text = "Attack Damage: " + enemy.AttackDamage.ToString();
            FightArmorEnemy.Text = "Armor: " + enemy.Armor.ToString();
            FightAPEnemy.Text = "Ability Power: " + enemy.AbilityPower.ToString();
            HeroName.Text = invincible.Name + "(" + invincible.Level + ")";
            EnemyName.Text = enemy.Name + "(" + enemy.Level + ")";
            if (enemy.Name == "Angstrom")
            {
                fightImgAngstrom.Visible = true;
            }
            if (enemy.Name == "Conquest")
            {
                fightImgConquest.Visible = true;
            }    
        }
        private async void ButtonSkill1_Click(object sender, EventArgs e) {
           damage = this.invincible.punch() - (this.enemy.Armor * 0.05);
           this.enemy.Health -= damage;
           FightHealthEnemy.Text = "Health: " + this.enemy.Health.ToString() + " (-" + damage + ")";
           ButtonSkill1.Enabled = false;
           ButtonSkill2.Enabled = false;
            if (this.enemy.Health <= 0)
            {
                MessageBox.Show("You won!");
                this.invincible.Experience += 10;
                if(this.invincible.Experience >= this.invincible.Level*10)
                {
                    this.invincible.LevelUp();
                    MessageBox.Show("You leveled up!");
                }
                this.Close();
            }
            await Task.Delay(500);
            enemyAttack();
        }
        private async void ButtonSkill2_Click(object sender, EventArgs e)
        {
            damage = this.invincible.kick() - (this.enemy.Armor * 0.05);
            this.enemy.Health -= damage;
            FightHealthEnemy.Text = $"Health: " + this.enemy.Health.ToString() + " (-" + damage + ")";
            ButtonSkill1.Enabled = false;
            ButtonSkill2.Enabled = false;
            if (this.enemy.Health <= 0)
            {
                MessageBox.Show("You won!");
                this.invincible.Experience += 10;
                if (this.invincible.Experience >= this.invincible.Level * 10)
                {
                    this.invincible.LevelUp();
                    MessageBox.Show("You leveled up!");
                }
                this.Close();
            }
            await Task.Delay(500);
            enemyAttack();
        }
        private void enemyAttack()
        {
            Random rnd = new Random();
            int skill = rnd.Next(1, 7);
            if (enemy.Name == "Angstrom")
            {
                switch (skill)
                {
                    case 1: case 2: case 3:
                        damage = angstrom.ability1() - (this.invincible.Armor * 0.05);
                        EnemyAbilityUseText.Visible = true;
                        EnemyAbilityUseText.Text = "Angstrom used ability 1!";
                        this.invincible.Health -= damage;
                        FightHealthHero.Text = "Health: " + this.invincible.Health.ToString() + " (-" + damage + ")";
                        break;
                    case 4: case 5:
                        damage = angstrom.ability2() - (this.invincible.Armor * 0.05);
                        EnemyAbilityUseText.Visible = true;
                        EnemyAbilityUseText.Text = "Angstrom used ability 2!";
                        this.invincible.Health -= damage;
                        FightHealthHero.Text = "Health: " + this.invincible.Health.ToString() + " (-" + damage + ")";
                        break;
                    case 6:
                        damage = angstrom.ability3() - (this.invincible.Armor * 0.05);
                        EnemyAbilityUseText.Visible = true;
                        EnemyAbilityUseText.Text = "Angstrom used ability 3!";
                        this.invincible.Health -= damage;
                        FightHealthHero.Text = "Health: " + this.invincible.Health.ToString() + " (-" + damage + ")";
                        break;
                }
            }
            if (enemy.Name == "Conquest")
            {
                switch (skill)
                {
                    case 1:
                    case 2:
                    case 3:
                        damage = conquest.ability1() - (this.invincible.Armor * 0.05);
                        EnemyAbilityUseText.Visible = true;
                        EnemyAbilityUseText.Text = "Conquest used ability 1!";
                        this.invincible.Health -= damage;
                        FightHealthHero.Text = "Health: " + this.invincible.Health.ToString() + " (-" + damage + ")";
                        break;
                    case 4:
                    case 5:
                        damage = conquest.ability2() - (this.invincible.Armor * 0.05);
                        EnemyAbilityUseText.Visible = true;
                        EnemyAbilityUseText.Text = "Conquest used ability 2!";
                        this.invincible.Health -= damage;
                        FightHealthHero.Text = "Health: " + this.invincible.Health.ToString() + " (-" + damage + ")";
                        break;
                    case 6:
                        damage = conquest.ability3() - (this.invincible.Armor * 0.05);
                        EnemyAbilityUseText.Visible = true;
                        EnemyAbilityUseText.Text = "Conquestm used ability 3!";
                        this.invincible.Health -= damage;
                        FightHealthHero.Text = "Health: " + this.invincible.Health.ToString() + " (-" + damage + ")";
                        break;
                }
            }
            if (this.invincible.Health <= 0)
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
