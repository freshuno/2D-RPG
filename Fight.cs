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

namespace InvincibleGame
{
    public partial class Fight: Form
    {
        public Character invincible;
        public Fight(Character invincible, Character enemy)
        {
            InitializeComponent();
            GameBoard.playSound(@"e:\C#projects\InvincibleGame\Resources\Music\battleMusic.wav");
            FightingSequence(invincible, enemy);
        }
        public void FightingSequence(Character invincible, Character enemy)
        {
            FightHealthHero.Text = "Health: " + invincible.Health.ToString();
            FightADHero.Text = "Attack Damage: " + invincible.AttackDamage.ToString();
            FightArmorHero.Text = "Armor: " + invincible.Armor.ToString();
            FightAPHero.Text = "Ability Power: " + invincible.AbilityPower.ToString();
            FightHealthEnemy.Text = "Health: " + enemy.Health.ToString();
            FightADEnemy.Text = "Attack Damage: " + enemy.AttackDamage.ToString();
            FightArmorEnemy.Text = "Armor: " + enemy.Armor.ToString();
            FightAPEnemy.Text = "Ability Power: " + enemy.AbilityPower.ToString();
            HeroName.Text = invincible.Name;
            EnemyName.Text = enemy.Name;
            if (enemy.Name == "Angstrom")
            {
                fightImgAngstrom.Visible = true;
            }
            if (enemy.Name == "Conquest")
            {
                fightImgConquest.Visible = true;
            }
            this.invincible = invincible;

        }
    }
}
