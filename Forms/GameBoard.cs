namespace InvincibleGame
{
    public partial class GameBoard : Form
    {
        string locationX;
        string locationY;
        public GameBoard()
        {
            InitializeComponent();
            startGame();
        }
        private void startGame()
        {
            Character invincibleCharacter = new Character();
            healthLabel.Text = "Health: " + invincibleCharacter.Health.ToString();
        }
        private void interaction()
        {
            if (Math.Abs(invincible.Location.X - angstrom.Location.X) < 50 && (Math.Abs(invincible.Location.Y - angstrom.Location.Y) < 100))
            {
                MessageBox.Show("You found me on X");
                new Form
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
