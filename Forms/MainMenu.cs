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
    public partial class MainMenu: Form
    {
        public MainMenu()
        {
            InitializeComponent();
            GameBoard.playSound(@"e:\C#projects\InvincibleGame\Resources\Music\mainMenuTheme.wav"); //temporary solution
        }
        private void StartNewGameButton_Click(object sender, EventArgs e)
        {
            GameBoard gameBoard = new GameBoard();
            gameBoard.Show();
            this.Hide();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
