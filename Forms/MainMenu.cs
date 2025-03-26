using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Rpg2d
{
    public partial class MainMenu: Form
    {
        private GameBoard currentGameBoard;
        public MainMenu()
        {
            InitializeComponent();
            GameBoard.playSound(Rpg2D.Properties.Resources.mainMenuMusic);
        }
        private void StartNewGameButton_Click(object sender, EventArgs e)
        {
            if (currentGameBoard != null)
            {
                currentGameBoard.Close();
                currentGameBoard.Dispose(); 
            }
            currentGameBoard = new GameBoard();
            currentGameBoard.FormClosed += new FormClosedEventHandler(GameWindowClosed);
            currentGameBoard.Show();
            this.Hide();
        }
        void GameWindowClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
