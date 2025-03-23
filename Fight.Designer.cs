namespace InvincibleGame
{
    partial class Fight
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Fight));
            fightImg1 = new PictureBox();
            angstromFightImage = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)fightImg1).BeginInit();
            ((System.ComponentModel.ISupportInitialize)angstromFightImage).BeginInit();
            SuspendLayout();
            // 
            // fightImg1
            // 
            fightImg1.Image = (Image)resources.GetObject("fightImg1.Image");
            fightImg1.Location = new Point(55, 36);
            fightImg1.Name = "fightImg1";
            fightImg1.Size = new Size(135, 307);
            fightImg1.SizeMode = PictureBoxSizeMode.StretchImage;
            fightImg1.TabIndex = 0;
            fightImg1.TabStop = false;
            // 
            // angstromFightImage
            // 
            angstromFightImage.Image = (Image)resources.GetObject("angstromFightImage.Image");
            angstromFightImage.Location = new Point(585, 36);
            angstromFightImage.Name = "angstromFightImage";
            angstromFightImage.Size = new Size(193, 307);
            angstromFightImage.SizeMode = PictureBoxSizeMode.StretchImage;
            angstromFightImage.TabIndex = 1;
            angstromFightImage.TabStop = false;
            angstromFightImage.Visible = false;
            // 
            // Fight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(800, 450);
            Controls.Add(angstromFightImage);
            Controls.Add(fightImg1);
            Name = "Fight";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)fightImg1).EndInit();
            ((System.ComponentModel.ISupportInitialize)angstromFightImage).EndInit();
            ResumeLayout(false);
        }

        #endregion

        private PictureBox fightImg1;
        private PictureBox angstromFightImage;
    }
}