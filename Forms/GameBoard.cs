using System.Media;
using InvincibleGame.Classes;



namespace InvincibleGame
{
    public partial class GameBoard : Form
    {
        int locationX;
        int locationY;
        string rotation = "right";
        Invincible invincibleCharacter;
        Angstrom angstromCharacter;
        Conquest conquestCharacter;
        Zombie zombieCharacter;
        Random rnd = new Random();
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
            invincibleCharacter = new Invincible("Invincible", 1);
            angstromCharacter = new Angstrom("Angstrom", 5);
            conquestCharacter = new Conquest("Conquest", 30);
            healthLabel.Text = "Health: " + invincibleCharacter.Health.ToString();
            levelLabel.Text = "Level: " + invincibleCharacter.Level.ToString();
            expLabel.Text = "Experience: " + invincibleCharacter.Experience.ToString() +"/" + invincibleCharacter.Level*10;
            playSound(@"C:\Users\kizza\Desktop\rozne\c#project\2D-RPG\Resources\Music\ambientMusic.wav"); //temporary solution
            newZombieSpawn();
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
                    angstromCharacter = new Angstrom("Angstrom", 5);
                }
                invincibleCharacter = fight.invincible;
                levelLabel.Text = "Level: " + invincibleCharacter.Level.ToString();
                expLabel.Text = "Experience: " + invincibleCharacter.Experience.ToString() + "/" + invincibleCharacter.Level * 10;
                if (invincibleCharacter.Health <= 0)
                {
                    MessageBox.Show("You died!");
                    Application.Exit();
                }
                healthLabel.Text = "Health: " + invincibleCharacter.Health.ToString();
                playSound(@"C:\Users\kizza\Desktop\rozne\c#project\2D-RPG\Resources\Music\ambientMusic.wav"); //temporary solution
            }
            if (Math.Abs(invincible.Location.X - zombie.Location.X) < 50 && (Math.Abs(invincible.Location.Y - zombie.Location.Y) < 80))
            {
                MessageBox.Show("Let's fight!");
                Fight fight = new Fight(invincibleCharacter, zombieCharacter);
                fight.ShowDialog();
                newZombieSpawn();
                invincibleCharacter = fight.invincible;
                levelLabel.Text = "Level: " + invincibleCharacter.Level.ToString();
                expLabel.Text = "Experience: " + invincibleCharacter.Experience.ToString() + "/" + invincibleCharacter.Level * 10;
                if (invincibleCharacter.Health <= 0)
                {
                    MessageBox.Show("You died!");
                    Application.Exit();
                }
                healthLabel.Text = "Health: " + invincibleCharacter.Health.ToString();
                playSound(@"C:\Users\kizza\Desktop\rozne\c#project\2D-RPG\Resources\Music\ambientMusic.wav"); //temporary solution
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
                    conquestCharacter = new Conquest("Conquest", 30);
                }
                invincibleCharacter = fight.invincible;
                levelLabel.Text = "Level: " + invincibleCharacter.Level.ToString();
                expLabel.Text = "Experience: " + invincibleCharacter.Experience.ToString() + "/" + invincibleCharacter.Level * 10;
                if (invincibleCharacter.Health <= 0)
                {
                    MessageBox.Show("You died!");
                    Application.Exit();
                }
                healthLabel.Text = "Health: " + invincibleCharacter.Health.ToString();
                playSound(@"C:\Users\kizza\Desktop\rozne\c#project\2D-RPG\Resources\Music\ambientMusic.wav"); //temporary solution
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
                    if(location.Y - 5 < 0)
                    {
                        break;
                    }
                    location.Y = location.Y - 5;
                    invincible.Location = location;
                    break;
                case Keys.S:
                    if (location.Y - 5 > 520)
                    {
                        break;
                    }
                    location.Y = location.Y + 5;
                    invincible.Location = location;
                    break;
                case Keys.A:
                    if (location.X - 5 < 0)
                    {
                        break;
                    }
                    location.X = location.X - 5;
                    invincible.Location = location;
                    //rotating invincible horizontally
                    if(rotation == "right")
                    {
                       invincible.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        rotation = "left";
                    }
                    break;
                case Keys.D:
                    if (location.X - 5 > 1041)
                    {
                        break;
                    }
                    location.X = location.X + 5;
                    invincible.Location = location;
                    if (rotation == "left")
                    {
                        invincible.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        rotation = "right";
                    }
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
        private void newZombieSpawn()
        {
            int rndLevel = rnd.Next(1, 11);
            do
            {
                locationX = rnd.Next(1, 500);
                locationY = rnd.Next(1, 500);
            } while (Math.Abs(invincible.Location.X - locationX) < 70 && (Math.Abs(invincible.Location.Y - locationY) < 120));
            zombieCharacter = new Zombie("Zombie",rndLevel);
            zombie.Location = new System.Drawing.Point(locationX, locationY);
        }
    }
}
