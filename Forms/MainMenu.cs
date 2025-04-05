using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using System.Windows.Forms;
using Rpg2d.Classes;

namespace Rpg2d
{
    public partial class MainMenu : Form
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

        private void ContinueButton_Click(object sender, EventArgs e)
        {
            if (currentGameBoard != null)
            {
                currentGameBoard.Close();
                currentGameBoard.Dispose();
            }
            string saveFileName = "SaveFile.json";
            string saveString = File.ReadAllText(saveFileName);
            Hero savedHero = JsonSerializer.Deserialize<Hero>(saveString)!;
            currentGameBoard = new GameBoard(savedHero, 2);
            currentGameBoard.FormClosed += new FormClosedEventHandler(GameWindowClosed);
            currentGameBoard.Show();
            this.Hide();

        }

        private void MainMenu_Load(object sender, EventArgs e)
        {

        }
    }
}
