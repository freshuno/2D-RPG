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
        public MainMenu()
        {
            InitializeComponent();
            GameBoard.playSound(@"C:\Users\kizza\Desktop\rozne\c#project\2D-RPG\Resources\Music\mainMenuTheme.wav"); //temporary solution
        }
        private void StartNewGameButton_Click(object sender, EventArgs e)
        {
            GameBoard gameBoard = new GameBoard();
            gameBoard.FormClosed += new FormClosedEventHandler(closeGameWindow);
            gameBoard.Show();
            this.Hide();
            
        }
        void closeGameWindow(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
