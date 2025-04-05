namespace Rpg2d
{
    partial class MainMenu
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
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
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainMenu));
            ExitButton = new Button();
            StartNewGameButton = new Button();
            ContinueButton = new Button();
            gameLogo = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)gameLogo).BeginInit();
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(123, 234);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(140, 23);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // StartNewGameButton
            // 
            StartNewGameButton.Location = new Point(123, 176);
            StartNewGameButton.Name = "StartNewGameButton";
            StartNewGameButton.Size = new Size(140, 23);
            StartNewGameButton.TabIndex = 3;
            StartNewGameButton.Text = "Start New Game";
            StartNewGameButton.UseVisualStyleBackColor = true;
            StartNewGameButton.Click += StartNewGameButton_Click;
            // 
            // ContinueButton
            // 
            ContinueButton.Location = new Point(123, 205);
            ContinueButton.Name = "ContinueButton";
            ContinueButton.Size = new Size(140, 23);
            ContinueButton.TabIndex = 4;
            ContinueButton.Text = "Continue";
            ContinueButton.UseVisualStyleBackColor = true;
            ContinueButton.Click += ContinueButton_Click;
            // 
            // gameLogo
            // 
            gameLogo.BackColor = Color.Transparent;
            gameLogo.Image = (Image)resources.GetObject("gameLogo.Image");
            gameLogo.Location = new Point(108, 12);
            gameLogo.Name = "gameLogo";
            gameLogo.Size = new Size(174, 158);
            gameLogo.SizeMode = PictureBoxSizeMode.StretchImage;
            gameLogo.TabIndex = 5;
            gameLogo.TabStop = false;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(897, 520);
            Controls.Add(gameLogo);
            Controls.Add(ContinueButton);
            Controls.Add(StartNewGameButton);
            Controls.Add(ExitButton);
            DoubleBuffered = true;
            FormBorderStyle = FormBorderStyle.Fixed3D;
            Icon = (Icon)resources.GetObject("$this.Icon");
            Name = "MainMenu";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "TrueHero";
            Load += MainMenu_Load;
            ((System.ComponentModel.ISupportInitialize)gameLogo).EndInit();
            ResumeLayout(false);
        }

        #endregion
        private Button ExitButton;
        private Button StartNewGameButton;
        private Button ContinueButton;
        private PictureBox gameLogo;
    }
}