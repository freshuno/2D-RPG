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
            ((System.ComponentModel.ISupportInitialize)invincible).BeginInit();
            ((System.ComponentModel.ISupportInitialize)angstrom).BeginInit();
            SuspendLayout();
            // 
            // invincible
            // 
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
            label1.Location = new Point(21, 323);
            label1.Name = "label1";
            label1.Size = new Size(38, 15);
            label1.TabIndex = 2;
            label1.Text = "label1";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(21, 354);
            label2.Name = "label2";
            label2.Size = new Size(38, 15);
            label2.TabIndex = 3;
            label2.Text = "label2";
            // 
            // healthLabel
            // 
            healthLabel.AutoSize = true;
            healthLabel.Location = new Point(21, 285);
            healthLabel.Name = "healthLabel";
            healthLabel.Size = new Size(38, 15);
            healthLabel.TabIndex = 4;
            healthLabel.Text = "label3";
            // 
            // Form1
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(healthLabel);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(invincible);
            Controls.Add(angstrom);
            Name = "Form1";
            Text = "Form1";
            KeyDown += move;
            ((System.ComponentModel.ISupportInitialize)invincible).EndInit();
            ((System.ComponentModel.ISupportInitialize)angstrom).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox invincible;
        private PictureBox angstrom;
        private Label label1;
        private Label label2;
        private Label healthLabel;
    }
}
