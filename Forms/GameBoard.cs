using System.Media;
using Rpg2d.Classes;



namespace Rpg2d
{
    public partial class GameBoard : Form
    {
        int locationX;
        int locationY;
        string rotation = "left";
        Hero heroCharacter;
        Warlock warlockCharacter;
        Dragon dragonCharacter;
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
            //simpleSound.Play();
        }
        public void startGame()
        {
            heroCharacter = new Hero("Unnamed Hero", 1);
            warlockCharacter = new Warlock("Akrash", 5);
            dragonCharacter = new Dragon("Belmentor", 30);
            healthLabel.Text = "Health: " + heroCharacter.Health.ToString() +"/" + heroCharacter.MaxHealth.ToString();
            levelLabel.Text = "Level: " + heroCharacter.Level.ToString();
            expLabel.Text = "Experience: " + heroCharacter.Experience.ToString() +"/" + heroCharacter.Level*10;
            playSound(@"C:\Users\kizza\Desktop\rozne\c#project\2D-RPG\Resources\Music\ambientMusic.wav"); //temporary solution
            newZombieSpawn();
        }
        private void interaction()
        {
            if (Math.Abs(HeroModel.Location.X - WarlockModel.Location.X) < 50 && (Math.Abs(HeroModel.Location.Y - WarlockModel.Location.Y) < 100))
            {
                MessageBox.Show("Let's fight!");
                Fight fight = new Fight(heroCharacter, warlockCharacter);
                fight.ShowDialog();
                if(fight.enemyCharacter.Health <= 0)
                {
                    WarlockModel.Location = new Point(9999, 9999);
                }
                else
                {
                    warlockCharacter = new Warlock("Akrash", 5);
                }
                heroCharacter = fight.heroCharacter;
                levelLabel.Text = "Level: " + heroCharacter.Level.ToString();
                expLabel.Text = "Experience: " + heroCharacter.Experience.ToString() + "/" + heroCharacter.Level * 10;
                if (heroCharacter.Health <= 0)
                {
                    MessageBox.Show("You died!");
                    Application.Exit();
                }
                healthLabel.Text = "Health: " + heroCharacter.Health.ToString();
                playSound(@"C:\Users\kizza\Desktop\rozne\c#project\2D-RPG\Resources\Music\ambientMusic.wav"); //temporary solution
            }
            if (Math.Abs(HeroModel.Location.X - zombie.Location.X) < 50 && (Math.Abs(HeroModel.Location.Y - zombie.Location.Y) < 80))
            {
                MessageBox.Show("Let's fight!");
                Fight fight = new Fight(heroCharacter, zombieCharacter);
                fight.ShowDialog();
                newZombieSpawn();
                heroCharacter = fight.heroCharacter;
                levelLabel.Text = "Level: " + heroCharacter.Level.ToString();
                expLabel.Text = "Experience: " + heroCharacter.Experience.ToString() + "/" + heroCharacter.Level * 10;
                if (heroCharacter.Health <= 0)
                {
                    MessageBox.Show("You died!");
                    Application.Exit();
                }
                healthLabel.Text = "Health: " + heroCharacter.Health.ToString();
                playSound(@"C:\Users\kizza\Desktop\rozne\c#project\2D-RPG\Resources\Music\ambientMusic.wav"); //temporary solution
            }
            if (Math.Abs(HeroModel.Location.X - DragonModel.Location.X) < 50 && (Math.Abs(HeroModel.Location.Y - DragonModel.Location.Y) < 100))
            {
                MessageBox.Show("Let's fight!");
                Fight fight = new Fight(heroCharacter, dragonCharacter);
                fight.ShowDialog();
                if (fight.enemyCharacter.Health <= 0)
                {
                    DragonModel.Location = new Point(9999, 9999);
                }
                else
                {
                    dragonCharacter = new Dragon("Belmentor", 30);
                }
                heroCharacter = fight.heroCharacter;
                levelLabel.Text = "Level: " + heroCharacter.Level.ToString();
                expLabel.Text = "Experience: " + heroCharacter.Experience.ToString() + "/" + heroCharacter.Level * 10;
                if (heroCharacter.Health <= 0)
                {
                    MessageBox.Show("You died!");
                    Application.Exit();
                }
                healthLabel.Text = "Health: " + heroCharacter.Health.ToString();
                playSound(@"C:\Users\kizza\Desktop\rozne\c#project\2D-RPG\Resources\Music\ambientMusic.wav"); //temporary solution
            }
        }
        protected override bool ProcessCmdKey(ref Message msg, Keys keyData) //not blocking movement
        {
            move(this, new KeyEventArgs(keyData));
            return true;
        }
        private void move(object sender, KeyEventArgs e) {
            var location = HeroModel.Location;
            switch (e.KeyCode)
            {
                case Keys.W:
                    if(location.Y - 5 < 0)
                    {
                        break;
                    }
                    location.Y = location.Y - 5;
                    HeroModel.Location = location;
                    break;
                case Keys.S:
                    if (location.Y - 5 > 520)
                    {
                        break;
                    }
                    location.Y = location.Y + 5;
                    HeroModel.Location = location;
                    break;
                case Keys.A:
                    if (location.X - 5 < 0)
                    {
                        break;
                    }
                    location.X = location.X - 5;
                    HeroModel.Location = location;
                    if(rotation == "right")
                    {
                       HeroModel.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                       rotation = "left";
                    }
                    break;
                case Keys.D:
                    if (location.X - 5 > 1041)
                    {
                        break;
                    }
                    location.X = location.X + 5;
                    HeroModel.Location = location;
                    if (rotation == "left")
                    {
                        HeroModel.Image.RotateFlip(RotateFlipType.RotateNoneFlipX);
                        rotation = "right";
                    }
                    break;
            }
            interaction();
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void newZombieSpawn()
        {
            int currentLevel = heroCharacter.Level;
            int rndLevel;
            if (currentLevel < 5)
            {
                rndLevel = rnd.Next(1, 4);
            }
            else
            {
                rndLevel = rnd.Next(currentLevel - 2, currentLevel + 5);
            }
            do
            {
                locationX = rnd.Next(1, 500);
                locationY = rnd.Next(1, 500);
            } while (Math.Abs(HeroModel.Location.X - locationX) < 70 && (Math.Abs(HeroModel.Location.Y - locationY) < 120));
            zombieCharacter = new Zombie("Zombie",rndLevel);
            zombie.Location = new System.Drawing.Point(locationX, locationY);
        }
    }
}
