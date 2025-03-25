namespace InvincibleGame
{
    partial class GameBoard
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        ///  Required method for Designer support - do not modify
        ///  the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GameBoard));
            invincible = new PictureBox();
            angstrom = new PictureBox();
            label1 = new Label();
            label2 = new Label();
            healthLabel = new Label();
            conquest = new PictureBox();
            pictureBox1 = new PictureBox();
            levelLabel = new Label();
            ExitButton = new Button();
            expLabel = new Label();
            zombie = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)invincible).BeginInit();
            ((System.ComponentModel.ISupportInitialize)angstrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)conquest).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zombie).BeginInit();
            SuspendLayout();
            // 
            // invincible
            // 
            invincible.BackColor = Color.Transparent;
            invincible.Image = (Image)resources.GetObject("invincible.Image");
            invincible.Location = new Point(341, 175);
            invincible.Name = "invincible";
            invincible.Size = new Size(47, 96);
            invincible.SizeMode = PictureBoxSizeMode.StretchImage;
            invincible.TabIndex = 0;
            invincible.TabStop = false;
            // 
            // angstrom
            // 
            angstrom.Image = (Image)resources.GetObject("angstrom.Image");
            angstrom.Location = new Point(688, 22);
            angstrom.Name = "angstrom";
            angstrom.Size = new Size(65, 96);
            angstrom.SizeMode = PictureBoxSizeMode.StretchImage;
            angstrom.TabIndex = 1;
            angstrom.TabStop = false;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Location = new Point(21, 383);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Location = new Point(21, 398);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // healthLabel
            // 
            healthLabel.AutoSize = true;
            healthLabel.BackColor = Color.Transparent;
            healthLabel.Location = new Point(21, 285);
            healthLabel.Name = "healthLabel";
            healthLabel.Size = new Size(38, 15);
            healthLabel.TabIndex = 4;
            healthLabel.Text = "label3";
            // 
            // conquest
            // 
            conquest.BackColor = Color.Green;
            conquest.Image = (Image)resources.GetObject("conquest.Image");
            conquest.Location = new Point(588, 398);
            conquest.Name = "conquest";
            conquest.Size = new Size(65, 96);
            conquest.SizeMode = PictureBoxSizeMode.StretchImage;
            conquest.TabIndex = 5;
            conquest.TabStop = false;
            // 
            // pictureBox1
            // 
            pictureBox1.Image = (Image)resources.GetObject("pictureBox1.Image");
            pictureBox1.Location = new Point(0, 0);
            pictureBox1.Name = "pictureBox1";
            pictureBox1.Size = new Size(1091, 614);
            pictureBox1.SizeMode = PictureBoxSizeMode.StretchImage;
            pictureBox1.TabIndex = 6;
            pictureBox1.TabStop = false;
            // 
            // levelLabel
            // 
            levelLabel.AutoSize = true;
            levelLabel.Location = new Point(21, 310);
            levelLabel.Name = "levelLabel";
            levelLabel.Size = new Size(38, 15);
            levelLabel.TabIndex = 7;
            levelLabel.Text = "label3";
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(940, 545);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(75, 23);
            ExitButton.TabIndex = 8;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // expLabel
            // 
            expLabel.AutoSize = true;
            expLabel.Location = new Point(21, 335);
            expLabel.Name = "expLabel";
            expLabel.Size = new Size(38, 15);
            expLabel.TabIndex = 9;
            expLabel.Text = "label3";
            // 
            // zombie
            // 
            zombie.BackColor = Color.Transparent;
            zombie.Image = (Image)resources.GetObject("zombie.Image");
            zombie.Location = new Point(627, 243);
            zombie.Name = "zombie";
            zombie.Size = new Size(73, 82);
            zombie.SizeMode = PictureBoxSizeMode.StretchImage;
            zombie.TabIndex = 10;
            zombie.TabStop = false;
            // 
            // GameBoard
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(1087, 617);
            Controls.Add(zombie);
            Controls.Add(expLabel);
            Controls.Add(ExitButton);
            Controls.Add(levelLabel);
            Controls.Add(conquest);
            Controls.Add(healthLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(invincible);
            Controls.Add(angstrom);
            Controls.Add(pictureBox1);
            Name = "GameBoard";
            Text = "Form1";
            TransparencyKey = Color.Green;
            KeyDown += move;
            ((System.ComponentModel.ISupportInitialize)invincible).EndInit();
            ((System.ComponentModel.ISupportInitialize)angstrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)conquest).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)zombie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox invincible;
        private PictureBox angstrom;
        private Label label1;
        private Label label2;
        private Label healthLabel;
        private PictureBox conquest;
        private PictureBox pictureBox1;
        private Label levelLabel;
        private Button ExitButton;
        private Label expLabel;
        private PictureBox zombie;
    }
}
