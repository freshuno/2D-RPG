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
            HeroModel = new PictureBox();
            WarlockModel = new PictureBox();
            healthLabel = new Label();
            DragonModel = new PictureBox();
            pictureBox1 = new PictureBox();
            levelLabel = new Label();
            ExitButton = new Button();
            expLabel = new Label();
            zombie = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)HeroModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarlockModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DragonModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zombie).BeginInit();
            SuspendLayout();
            // 
            // HeroModel
            // 
            HeroModel.BackColor = Color.Transparent;
            HeroModel.Image = (Image)resources.GetObject("HeroModel.Image");
            HeroModel.Location = new Point(341, 175);
            HeroModel.Name = "HeroModel";
            HeroModel.Size = new Size(47, 96);
            HeroModel.SizeMode = PictureBoxSizeMode.StretchImage;
            HeroModel.TabIndex = 0;
            HeroModel.TabStop = false;
            // 
            // WarlockModel
            // 
            WarlockModel.Image = (Image)resources.GetObject("WarlockModel.Image");
            WarlockModel.Location = new Point(688, 22);
            WarlockModel.Name = "WarlockModel";
            WarlockModel.Size = new Size(65, 96);
            WarlockModel.SizeMode = PictureBoxSizeMode.StretchImage;
            WarlockModel.TabIndex = 1;
            WarlockModel.TabStop = false;
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
            // DragonModel
            // 
            DragonModel.BackColor = Color.Green;
            DragonModel.Image = (Image)resources.GetObject("DragonModel.Image");
            DragonModel.Location = new Point(588, 398);
            DragonModel.Name = "DragonModel";
            DragonModel.Size = new Size(65, 96);
            DragonModel.SizeMode = PictureBoxSizeMode.StretchImage;
            DragonModel.TabIndex = 5;
            DragonModel.TabStop = false;
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
            Controls.Add(DragonModel);
            Controls.Add(healthLabel);
            Controls.Add(HeroModel);
            Controls.Add(WarlockModel);
            Controls.Add(pictureBox1);
            Name = "GameBoard";
            Text = "Form1";
            TransparencyKey = Color.Green;
            KeyDown += move;
            ((System.ComponentModel.ISupportInitialize)HeroModel).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarlockModel).EndInit();
            ((System.ComponentModel.ISupportInitialize)DragonModel).EndInit();
            ((System.ComponentModel.ISupportInitialize)pictureBox1).EndInit();
            ((System.ComponentModel.ISupportInitialize)zombie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox HeroModel;
        private PictureBox WarlockModel;
        private Label healthLabel;
        private PictureBox DragonModel;
        private PictureBox pictureBox1;
        private Label levelLabel;
        private Button ExitButton;
        private Label expLabel;
        private PictureBox zombie;
    }
}
