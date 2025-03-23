using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InvincibleGame
{
    public partial class Fight: Form
    {
        public Fight(Character invincible, Character enemy)
        {
            InitializeComponent();
            if(enemy.Name == "Angstrom")
            {
                AngstromFight(invincible, enemy);
            }
        }
        public void AngstromFight(Character invincible, Character enemy)
        {
            angstromFightImage.Visible = true;

        }
    }
}
