namespace Rpg2d
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
            levelLabel = new Label();
            ExitButton = new Button();
            expLabel = new Label();
            zombie = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)HeroModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)WarlockModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)DragonModel).BeginInit();
            ((System.ComponentModel.ISupportInitialize)zombie).BeginInit();
            SuspendLayout();
            // 
            // HeroModel
            // 
            HeroModel.BackColor = Color.Transparent;
            HeroModel.Image = (Image)resources.GetObject("HeroModel.Image");
            HeroModel.Location = new Point(342, 175);
            HeroModel.Name = "HeroModel";
            HeroModel.Size = new Size(72, 82);
            HeroModel.SizeMode = PictureBoxSizeMode.StretchImage;
            HeroModel.TabIndex = 0;
            HeroModel.TabStop = false;
            // 
            // WarlockModel
            // 
            WarlockModel.BackColor = Color.Transparent;
            WarlockModel.Image = (Image)resources.GetObject("WarlockModel.Image");
            WarlockModel.Location = new Point(671, 60);
            WarlockModel.Name = "WarlockModel";
            WarlockModel.Size = new Size(73, 96);
            WarlockModel.SizeMode = PictureBoxSizeMode.StretchImage;
            WarlockModel.TabIndex = 1;
            WarlockModel.TabStop = false;
            // 
            // healthLabel
            // 
            healthLabel.AutoSize = true;
            healthLabel.BackColor = SystemColors.Control;
            healthLabel.Location = new Point(21, 285);
            healthLabel.Name = "healthLabel";
            healthLabel.Size = new Size(38, 15);
            healthLabel.TabIndex = 4;
            healthLabel.Text = "label3";
            // 
            // DragonModel
            // 
            DragonModel.BackColor = Color.Transparent;
            DragonModel.Image = (Image)resources.GetObject("DragonModel.Image");
            DragonModel.Location = new Point(652, 457);
            DragonModel.Name = "DragonModel";
            DragonModel.Size = new Size(83, 96);
            DragonModel.SizeMode = PictureBoxSizeMode.StretchImage;
            DragonModel.TabIndex = 5;
            DragonModel.TabStop = false;
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
            ExitButton.Location = new Point(836, 543);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(150, 23);
            ExitButton.TabIndex = 8;
            ExitButton.Text = "Exit to Main Menu";
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
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(998, 617);
            Controls.Add(expLabel);
            Controls.Add(levelLabel);
            Controls.Add(healthLabel);
            Controls.Add(WarlockModel);
            Controls.Add(DragonModel);
            Controls.Add(zombie);
            Controls.Add(HeroModel);
            Controls.Add(ExitButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            KeyPreview = true;
            Name = "GameBoard";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrueHero";
            TransparencyKey = Color.Green;
            KeyDown += move;
            KeyUp += modelBackToIdle;
            ((System.ComponentModel.ISupportInitialize)HeroModel).EndInit();
            ((System.ComponentModel.ISupportInitialize)WarlockModel).EndInit();
            ((System.ComponentModel.ISupportInitialize)DragonModel).EndInit();
            ((System.ComponentModel.ISupportInitialize)zombie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox HeroModel;
        private PictureBox WarlockModel;
        private Label healthLabel;
        private PictureBox DragonModel;
        private Label levelLabel;
        private Button ExitButton;
        private Label expLabel;
        private PictureBox zombie;
    }
}
