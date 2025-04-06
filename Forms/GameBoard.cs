using System.Media;
using System.Text.Json.Schema;
using Rpg2d.Classes;
using System.Text.Json;



namespace Rpg2d
{
    public partial class GameBoard : Form
    {
        int locationX;
        int locationY;
        int mapEnemyCount;
        bool isGameRunning = true;
        string rotation = "right";
        int currentLevel;
        Hero heroCharacter;
        Warlock warlockCharacter;
        Dragon dragonCharacter;
        Zombie zombieCharacter;
        Random rnd = new Random();
        private Image heroMoveImage = Image.FromFile(@"E:\C#projects\InvincibleGame\Resources\Img\knightMove.png");
        private Image heroStandImage = Image.FromFile(@"E:\C#projects\InvincibleGame\Resources\Img\heroStand.png");
        string saveFileName = "SaveFile.json";
        public GameBoard()
        {
            InitializeComponent();
            currentLevel = 1;
            StartGame(1, new Hero("Unnamed Hero", 1));
        }
        public GameBoard(Hero loadedHero, int Level)
        {
            InitializeComponent();
            currentLevel = Level;
            StartGame(Level, loadedHero);
        }
        public static void playSound(byte[] soundBytes)
        {
            if (soundBytes == null || soundBytes.Length == 0) return;

            using (MemoryStream ms = new MemoryStream(soundBytes))
            {
                SoundPlayer simpleSound = new SoundPlayer(ms);
                simpleSound.Play();
            }
        }
        public void StartGame(int Level, Hero LoadedHero)
        {
            heroCharacter = LoadedHero;
            healthLabel.Text = "Health: " + heroCharacter.Health.ToString() + "/" + heroCharacter.MaxHealth.ToString();
            levelLabel.Text = "Level: " + heroCharacter.Level.ToString();
            expLabel.Text = "Experience: " + heroCharacter.Experience.ToString() + "/" + heroCharacter.Level * 10;
            LoadLevel(Level);
        }
        private async void LoadLevel(int Level)
        {
            switch (Level)
            {
                case 1:
                    GameBoard.playSound(Rpg2D.Properties.Resources.forestLevelMusic);
                    currentLevel = 1;
                    this.BackgroundImage = Image.FromFile("E:\\C#projects\\InvincibleGame\\Resources\\Img\\backgroundForest.png");
                    warlockCharacter = new Warlock("Akrash", 5);
                    dragonCharacter = new Dragon("Belmentor", 15);
                    DragonModel.Location = new System.Drawing.Point(652, 457);
                    WarlockModel.Location = new System.Drawing.Point(671, 60);
                    PortalModel.Location = new System.Drawing.Point(888, 346);
                    mapEnemyCount = 2;
                    NewZombieSpawn();
                    while (isGameRunning || currentLevel == 1)
                    {
                        await Task.Delay(120);
                        EnemyRandomMove();
                    }
                    break;
                case 2:
                    currentLevel = 2;
                    GameBoard.playSound(Rpg2D.Properties.Resources.cityMusic);
                    this.BackgroundImage = Image.FromFile("E:\\C#projects\\InvincibleGame\\Resources\\Img\\backgroundCity.png");
                    PortalModel.Location = new System.Drawing.Point(400, 346);
                    DragonModel.Location = new System.Drawing.Point(9999, 9999);
                    WarlockModel.Location = new System.Drawing.Point(9999, 9999);
                    zombie.Location = new System.Drawing.Point(9999, 9999);
                    break;
            }
        }
        private void CheckIfLevelCleared()
        {
            if (mapEnemyCount == 0)
            {
                MessageBox.Show("Level cleared!");
                isGameRunning = false;
                Application.Restart();
            }
        }
        private void Interaction()
        {
            if (Math.Abs(HeroModel.Location.X - WarlockModel.Location.X) < 50 && (Math.Abs(HeroModel.Location.Y - WarlockModel.Location.Y) < 100))
            {
                MessageBox.Show("Let's fight!");
                Fight fight = new Fight(heroCharacter, warlockCharacter);
                fight.ShowDialog();
                if (fight.enemyCharacter.Health <= 0)
                {
                    WarlockModel.Location = new Point(9999, 9999);
                    mapEnemyCount--;
                }
                else
                {
                    warlockCharacter.Health = warlockCharacter.MaxHealth;
                }
                heroCharacter = fight.heroCharacter;
                levelLabel.Text = "Level: " + heroCharacter.Level.ToString();
                expLabel.Text = "Experience: " + heroCharacter.Experience.ToString() + "/" + heroCharacter.Level * 10;
                if (heroCharacter.Health <= 0)
                {
                    MessageBox.Show("You died!");
                    isGameRunning = false;
                    Application.Restart();
                }
                healthLabel.Text = "Health: " + heroCharacter.Health.ToString();
                GameBoard.playSound(Rpg2D.Properties.Resources.forestLevelMusic);
                CheckIfLevelCleared();
            }
            if (Math.Abs(HeroModel.Location.X - zombie.Location.X) < 50 && (Math.Abs(HeroModel.Location.Y - zombie.Location.Y) < 80))
            {
                MessageBox.Show("Let's fight!");
                Fight fight = new Fight(heroCharacter, zombieCharacter);
                fight.ShowDialog();
                NewZombieSpawn();
                heroCharacter = fight.heroCharacter;
                levelLabel.Text = "Level: " + heroCharacter.Level.ToString();
                expLabel.Text = "Experience: " + heroCharacter.Experience.ToString() + "/" + heroCharacter.Level * 10;
                if (heroCharacter.Health <= 0)
                {
                    MessageBox.Show("You died!");
                    isGameRunning = false;
                    Application.Restart();
                }
                healthLabel.Text = "Health: " + heroCharacter.Health.ToString();
                GameBoard.playSound(Rpg2D.Properties.Resources.forestLevelMusic);
            }
            if (Math.Abs(HeroModel.Location.X - DragonModel.Location.X) < 50 && (Math.Abs(HeroModel.Location.Y - DragonModel.Location.Y) < 100))
            {
                MessageBox.Show("Let's fight!");
                Fight fight = new Fight(heroCharacter, dragonCharacter);
                fight.ShowDialog();
                if (fight.enemyCharacter.Health <= 0)
                {
                    DragonModel.Location = new Point(9999, 9999);
                    mapEnemyCount--;
                }
                else
                {
                    dragonCharacter.Health = dragonCharacter.MaxHealth;
                }
                heroCharacter = fight.heroCharacter;
                levelLabel.Text = "Level: " + heroCharacter.Level.ToString();
                expLabel.Text = "Experience: " + heroCharacter.Experience.ToString() + "/" + heroCharacter.Level * 10;
                if (heroCharacter.Health <= 0)
                {
                    MessageBox.Show("You died!");
                    isGameRunning = false;
                    Application.Restart();
                }
                healthLabel.Text = "Health: " + heroCharacter.Health.ToString();
                GameBoard.playSound(Rpg2D.Properties.Resources.forestLevelMusic);
                CheckIfLevelCleared();
            }
            if (Math.Abs(HeroModel.Location.X - PortalModel.Location.X) < 50 && (Math.Abs(HeroModel.Location.Y - PortalModel.Location.Y) < 100))
            {
                if (currentLevel == 1)
                {
                    LoadLevel(2);
                }
                else if (currentLevel == 2)
                {
                    LoadLevel(1);
                }
            }
        }
        private void Move(object sender, KeyEventArgs e)
        {
            var location = HeroModel.Location;
            HeroModel.Image = heroMoveImage;
            switch (e.KeyCode)
            {
                case Keys.W:
                    if (location.Y - 5 < 0)
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
                    if (rotation == "right")
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
            Interaction();
        }
        private void ModelBackToIdle(object sender, KeyEventArgs e)
        {
            HeroModel.Image = heroStandImage;
        }
        private void ExitButton_Click(object sender, EventArgs e)
        {
            isGameRunning = false;
            Application.Restart();
        }
        private void NewZombieSpawn()
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
            zombieCharacter = new Zombie("Zombie", rndLevel);
            zombie.Location = new System.Drawing.Point(locationX, locationY);
        }
        private void EnemyRandomMove()
        {
            int rndMove = rnd.Next(1, 5);
            var location = zombie.Location;
            switch (rndMove)
            {
                case 1:
                    if (location.Y - 5 < 0)
                    {
                        break;
                    }
                    location.Y = location.Y - 3;
                    zombie.Location = location;
                    break;
                case 2:
                    if (location.Y - 5 > 520)
                    {
                        break;
                    }
                    location.Y = location.Y + 3;
                    zombie.Location = location;
                    break;
                case 3:
                    if (location.X - 5 < 0)
                    {
                        break;
                    }
                    location.X = location.X - 3;
                    zombie.Location = location;
                    break;
                case 4:
                    if (location.X - 5 > 1041)
                    {
                        break;
                    }
                    location.X = location.X + 3;
                    zombie.Location = location;
                    break;
            }
        }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            string saveString = JsonSerializer.Serialize(heroCharacter);
            MessageBox.Show("Game has been saved");
            File.WriteAllText(saveFileName, saveString);
        }
    }
}
