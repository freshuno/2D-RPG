using System.Media;



namespace InvincibleGame
{
    public partial class GameBoard : Form
    {
        string locationX;
        string locationY;
        Invincible invincibleCharacter;
        Angstrom angstromCharacter;
        Conquest conquestCharacter;
        public GameBoard()
        {
            InitializeComponent();
            startGame();
        }
        public static void playSound(string path)
        {
            SoundPlayer simpleSound = new SoundPlayer(path);
            simpleSound.Play();
        }
        public void startGame()
        {
            invincibleCharacter = new Invincible("Invincible", 100, 5, 10, 0);
            angstromCharacter = new Angstrom("Angstrom", 75, 3, 5, 5);
            conquestCharacter = new Conquest("Conquest", 300, 8, 15, 0);
            healthLabel.Text = "Health: " + invincibleCharacter.Health.ToString();
            LevelText.Text = "Level: " + invincibleCharacter.Level.ToString();
            playSound(@"e:\C#projects\InvincibleGame\Resources\Music\ambientMusic.wav"); //temporary solution
        }
        private void interaction()
        {
            if (Math.Abs(invincible.Location.X - angstrom.Location.X) < 50 && (Math.Abs(invincible.Location.Y - angstrom.Location.Y) < 100))
            {
                MessageBox.Show("Let's fight!");
                Fight fight = new Fight(invincibleCharacter, angstromCharacter);
                fight.ShowDialog();
                if(fight.enemy.Health <= 0)
                {
                    angstrom.Location = new Point(9999, 9999);
                }
                else
                {
                    angstromCharacter = new Angstrom("Angstrom", 75, 3, 5, 5);
                }
                    invincibleCharacter = fight.invincible;
                LevelText.Text = "Level: " + invincibleCharacter.Level.ToString();
                if (invincibleCharacter.Health <= 0)
                {
                    MessageBox.Show("You died!");
                    Application.Exit();
                }
                healthLabel.Text = "Health: " + invincibleCharacter.Health.ToString();
                playSound(@"e:\C#projects\InvincibleGame\Resources\Music\ambientMusic.wav"); //temporary solution
            }
            if (Math.Abs(invincible.Location.X - conquest.Location.X) < 50 && (Math.Abs(invincible.Location.Y - conquest.Location.Y) < 100))
            {
                MessageBox.Show("Let's fight!");
                Fight fight = new Fight(invincibleCharacter, conquestCharacter);
                fight.ShowDialog();
                if (fight.enemy.Health <= 0)
                {
                    conquest.Location = new Point(9999, 9999);
                }
                else
                {
                    conquestCharacter = new Conquest("Conquest", 300, 8, 15, 0);
                }
                    invincibleCharacter = fight.invincible;
                LevelText.Text = "Level: " + invincibleCharacter.Level.ToString();
                if (invincibleCharacter.Health <= 0)
                {
                    MessageBox.Show("You died!");
                    Application.Exit();
                }
                healthLabel.Text = "Health: " + invincibleCharacter.Health.ToString();
                playSound(@"e:\C#projects\InvincibleGame\Resources\Music\ambientMusic.wav"); //temporary solution
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData)
        {
            move(this, new KeyEventArgs(keyData));
            return true;
        }
        private void move(object sender, KeyEventArgs e) {
            var location = invincible.Location;
            switch (e.KeyCode)
            {
                case Keys.W:
                    location.Y = location.Y - 5;
                    invincible.Location = location;
                    break;
                case Keys.S:
                    location.Y = location.Y + 5;
                    invincible.Location = location;
                    break;
                case Keys.A:
                    location.X = location.X - 5;
                    invincible.Location = location;
                    break;
                case Keys.D:
                    location.X = location.X + 5;
                    invincible.Location = location;
                    break;
            }
            label1.Text = invincible.Location.ToString();
            label2.Text = angstrom.Location.ToString();
            interaction();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
    }
}
