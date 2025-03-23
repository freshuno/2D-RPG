using System.Media;



namespace InvincibleGame
{
    public partial class GameBoard : Form
    {
        string locationX;
        string locationY;
        Character invincibleCharacter;
        Character angstromCharacter;
        Character conquestCharacter;
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
            invincibleCharacter = new Character("Invincible", 100, 5, 10, 0);
            angstromCharacter = new Character("Angstrom", 75, 3, 5, 4);
            conquestCharacter = new Character("Conquest", 300, 8, 15, 0);
            healthLabel.Text = "Health: " + invincibleCharacter.Health.ToString();
            playSound(@"e:\C#projects\InvincibleGame\Resources\Music\ambientMusic.wav"); //temporary solution
        }
        private void interaction()
        {
            if (Math.Abs(invincible.Location.X - angstrom.Location.X) < 50 && (Math.Abs(invincible.Location.Y - angstrom.Location.Y) < 100))
            {
                MessageBox.Show("Let's fight!");
                Fight fight = new Fight(invincibleCharacter, angstromCharacter);
                fight.ShowDialog();
                angstrom.Location = new Point(9999, 9999);
                invincibleCharacter = fight.invincible;
                playSound(@"e:\C#projects\InvincibleGame\Resources\Music\ambientMusic.wav"); //temporary solution
            }
            if (Math.Abs(invincible.Location.X - conquest.Location.X) < 50 && (Math.Abs(invincible.Location.Y - conquest.Location.Y) < 100))
            {
                MessageBox.Show("Let's fight!");
                Fight fight = new Fight(invincibleCharacter, conquestCharacter);
                fight.ShowDialog();
                conquest.Location = new Point(9999, 9999);
                invincibleCharacter = fight.invincible;
                playSound(@"e:\C#projects\InvincibleGame\Resources\Music\ambientMusic.wav"); //temporary solution
            }
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
    }
}
