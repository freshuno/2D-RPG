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
            SuspendLayout();
            // 
            // ExitButton
            // 
            ExitButton.Location = new Point(209, 280);
            ExitButton.Name = "ExitButton";
            ExitButton.Size = new Size(140, 23);
            ExitButton.TabIndex = 2;
            ExitButton.Text = "Exit";
            ExitButton.UseVisualStyleBackColor = true;
            ExitButton.Click += ExitButton_Click;
            // 
            // StartNewGameButton
            // 
            StartNewGameButton.Location = new Point(209, 229);
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
            BackgroundImage = (Image)resources.GetObject("$this.BackgroundImage");
            BackgroundImageLayout = ImageLayout.Stretch;
            ClientSize = new Size(552, 516);
            currentGameBoard.FormClosed += new FormClosedEventHandler(closeGameWindow);
            Controls.Add(StartNewGameButton);
            Controls.Add(ExitButton);
            DoubleBuffered = true;
            Name = "MainMenu";
            Text = "Form1";
            ResumeLayout(false);
        }

        #endregion
        private Button ExitButton;
        private Button StartNewGameButton;
    }
}