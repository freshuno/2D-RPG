namespace InvincibleGame
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
            mainMenuImage = new PictureBox();
            ExitButton = new Button();
            StartNewGameButton = new Button();
            ((System.ComponentModel.ISupportInitialize)mainMenuImage).BeginInit();
            SuspendLayout();
            // 
            // mainMenuImage
            // 
            mainMenuImage.Image = (Image)resources.GetObject("mainMenuImage.Image");
            mainMenuImage.Location = new Point(-27, -23);
            mainMenuImage.Name = "mainMenuImage";
            mainMenuImage.Size = new Size(916, 514);
            mainMenuImage.SizeMode = PictureBoxSizeMode.StretchImage;
            mainMenuImage.TabIndex = 0;
            mainMenuImage.TabStop = false;
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(74, 229);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(140, 23);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // StartNewGameButton
            // 
            StartNewGameButton.Location = new Point(74, 175);
            StartNewGameButton.Name = "StartNewGameButton";
            StartNewGameButton.Size = new Size(140, 23);
            StartNewGameButton.TabIndex = 3;
            StartNewGameButton.Text = "Start New Game";
            StartNewGameButton.UseVisualStyleBackColor = true;
            StartNewGameButton.Click += StartNewGameButton_Click;
            // 
            // MainMenu
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(StartNewGameButton);
            Controls.Add(ExitButton);
            Controls.Add(mainMenuImage);
            Name = "MainMenu";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)mainMenuImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox mainMenuImage;
        private Button ExitButton;
        private Button StartNewGameButton;
    }
}