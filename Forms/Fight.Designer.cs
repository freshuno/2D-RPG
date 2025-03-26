using System.Diagnostics.Tracing;

namespace Rpg2d
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
            fightImgHero = new PictureBox();
            fightImgWarlock = new PictureBox();
            fightImgDragon = new PictureBox();
            FightHealthHero = new Label();
            FightADHero = new Label();
            FightArmorHero = new Label();
            FightAPHero = new Label();
            FightAPEnemy = new Label();
            FightArmorEnemy = new Label();
            FightADEnemy = new Label();
            FightHealthEnemy = new Label();
            HeroName = new Label();
            EnemyName = new Label();
            ButtonSkill1 = new Button();
            EnemyAbilityUseText = new Label();
            ButtonSkill2 = new Button();
            RunAwayButton = new Button();
            fightImgZombie = new PictureBox();
            ((System.ComponentModel.ISupportInitialize)fightImgHero).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fightImgWarlock).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fightImgDragon).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fightImgZombie).BeginInit();
            SuspendLayout();
            // 
            // fightImgHero
            // 
            fightImgHero.BackColor = Color.Transparent;
            fightImgHero.Image = (Image)resources.GetObject("fightImgHero.Image");
            fightImgHero.Location = new Point(85, 36);
            fightImgHero.Name = "fightImgHero";
            fightImgHero.Size = new Size(207, 307);
            fightImgHero.SizeMode = PictureBoxSizeMode.StretchImage;
            fightImgHero.TabIndex = 0;
            fightImgHero.TabStop = false;
            // 
            // fightImgWarlock
            // 
            fightImgWarlock.Image = (Image)resources.GetObject("fightImgWarlock.Image");
            fightImgWarlock.Location = new Point(498, 36);
            fightImgWarlock.Name = "fightImgWarlock";
            fightImgWarlock.Size = new Size(246, 307);
            fightImgWarlock.SizeMode = PictureBoxSizeMode.StretchImage;
            fightImgWarlock.TabIndex = 1;
            fightImgWarlock.TabStop = false;
            fightImgWarlock.Visible = false;
            // 
            // fightImgDragon
            // 
            fightImgDragon.BackColor = Color.Transparent;
            fightImgDragon.Image = (Image)resources.GetObject("fightImgDragon.Image");
            fightImgDragon.Location = new Point(471, 36);
            fightImgDragon.Name = "fightImgDragon";
            fightImgDragon.Size = new Size(274, 307);
            fightImgDragon.SizeMode = PictureBoxSizeMode.StretchImage;
            fightImgDragon.TabIndex = 2;
            fightImgDragon.TabStop = false;
            fightImgDragon.Visible = false;
            // 
            // FightHealthHero
            // 
            FightHealthHero.AutoSize = true;
            FightHealthHero.Location = new Point(11, 36);
            FightHealthHero.Name = "FightHealthHero";
            FightHealthHero.Size = new Size(38, 15);
            FightHealthHero.TabIndex = 3;
            FightHealthHero.Text = "label1";
            // 
            // FightADHero
            // 
            FightADHero.AutoSize = true;
            FightADHero.Location = new Point(11, 61);
            FightADHero.Name = "FightADHero";
            FightADHero.Size = new Size(38, 15);
            FightADHero.TabIndex = 4;
            FightADHero.Text = "label2";
            // 
            // FightArmorHero
            // 
            FightArmorHero.AutoSize = true;
            FightArmorHero.Location = new Point(11, 86);
            FightArmorHero.Name = "FightArmorHero";
            FightArmorHero.Size = new Size(38, 15);
            FightArmorHero.TabIndex = 5;
            FightArmorHero.Text = "label3";
            // 
            // FightAPHero
            // 
            FightAPHero.AutoSize = true;
            FightAPHero.Location = new Point(12, 110);
            FightAPHero.Name = "FightAPHero";
            FightAPHero.Size = new Size(38, 15);
            FightAPHero.TabIndex = 6;
            FightAPHero.Text = "label4";
            // 
            // FightAPEnemy
            // 
            FightAPEnemy.AutoSize = true;
            FightAPEnemy.Location = new Point(751, 110);
            FightAPEnemy.Name = "FightAPEnemy";
            FightAPEnemy.Size = new Size(38, 15);
            FightAPEnemy.TabIndex = 10;
            FightAPEnemy.Text = "label4";
            // 
            // FightArmorEnemy
            // 
            FightArmorEnemy.AutoSize = true;
            FightArmorEnemy.Location = new Point(750, 86);
            FightArmorEnemy.Name = "FightArmorEnemy";
            FightArmorEnemy.Size = new Size(38, 15);
            FightArmorEnemy.TabIndex = 9;
            FightArmorEnemy.Text = "label3";
            // 
            // FightADEnemy
            // 
            FightADEnemy.AutoSize = true;
            FightADEnemy.Location = new Point(750, 61);
            FightADEnemy.Name = "FightADEnemy";
            FightADEnemy.Size = new Size(38, 15);
            FightADEnemy.TabIndex = 8;
            FightADEnemy.Text = "label2";
            // 
            // FightHealthEnemy
            // 
            FightHealthEnemy.AutoSize = true;
            FightHealthEnemy.Location = new Point(750, 36);
            FightHealthEnemy.Name = "FightHealthEnemy";
            FightHealthEnemy.Size = new Size(38, 15);
            FightHealthEnemy.TabIndex = 7;
            FightHealthEnemy.Text = "label1";
            // 
            // HeroName
            // 
            HeroName.AutoSize = true;
            HeroName.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeroName.Location = new Point(123, -1);
            HeroName.Name = "HeroName";
            HeroName.Size = new Size(106, 37);
            HeroName.TabIndex = 11;
            HeroName.Text = "label1";
            // 
            // EnemyName
            // 
            EnemyName.AutoSize = true;
            EnemyName.Font = new Font("Microsoft Sans Serif", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnemyName.Location = new Point(551, -1);
            EnemyName.Name = "EnemyName";
            EnemyName.Size = new Size(106, 37);
            EnemyName.TabIndex = 13;
            EnemyName.Text = "label1";
            // 
            // ButtonSkill1
            // 
            ButtonSkill1.Location = new Point(70, 409);
            ButtonSkill1.Name = "ButtonSkill1";
            ButtonSkill1.Size = new Size(75, 23);
            ButtonSkill1.TabIndex = 14;
            ButtonSkill1.Text = "Punch";
            ButtonSkill1.UseVisualStyleBackColor = true;
            ButtonSkill1.Click += ButtonSkill1_Click;
            // 
            // EnemyAbilityUseText
            // 
            EnemyAbilityUseText.AutoSize = true;
            EnemyAbilityUseText.Location = new Point(350, 86);
            EnemyAbilityUseText.Name = "EnemyAbilityUseText";
            EnemyAbilityUseText.Size = new Size(38, 15);
            EnemyAbilityUseText.TabIndex = 15;
            EnemyAbilityUseText.Text = "label1";
            EnemyAbilityUseText.Visible = false;
            // 
            // ButtonSkill2
            // 
            ButtonSkill2.Location = new Point(183, 409);
            ButtonSkill2.Name = "ButtonSkill2";
            ButtonSkill2.Size = new Size(75, 23);
            ButtonSkill2.TabIndex = 16;
            ButtonSkill2.Text = "Kick";
            ButtonSkill2.UseVisualStyleBackColor = true;
            ButtonSkill2.Click += ButtonSkill2_Click;
            // 
            // RunAwayButton
            // 
            RunAwayButton.Location = new Point(750, 461);
            RunAwayButton.Name = "RunAwayButton";
            RunAwayButton.Size = new Size(75, 23);
            RunAwayButton.TabIndex = 17;
            RunAwayButton.Text = "Run Away";
            RunAwayButton.UseVisualStyleBackColor = true;
            RunAwayButton.Click += RunAwayButton_Click;
            // 
            // fightImgZombie
            // 
            fightImgZombie.BackColor = Color.Transparent;
            fightImgZombie.Image = (Image)resources.GetObject("fightImgZombie.Image");
            fightImgZombie.Location = new Point(471, 39);
            fightImgZombie.Name = "fightImgZombie";
            fightImgZombie.Size = new Size(274, 307);
            fightImgZombie.SizeMode = PictureBoxSizeMode.StretchImage;
            fightImgZombie.TabIndex = 18;
            fightImgZombie.TabStop = false;
            fightImgZombie.Visible = false;
            // 
            // Fight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 496);
            Controls.Add(FightAPEnemy);
            Controls.Add(FightArmorEnemy);
            Controls.Add(FightADEnemy);
            Controls.Add(FightHealthEnemy);
            Controls.Add(FightAPHero);
            Controls.Add(FightArmorHero);
            Controls.Add(FightADHero);
            Controls.Add(FightHealthHero);
            Controls.Add(fightImgZombie);
            Controls.Add(RunAwayButton);
            Controls.Add(ButtonSkill2);
            Controls.Add(EnemyAbilityUseText);
            Controls.Add(ButtonSkill1);
            Controls.Add(EnemyName);
            Controls.Add(HeroName);
            Controls.Add(fightImgHero);
            Controls.Add(fightImgDragon);
            Controls.Add(fightImgWarlock);
            Name = "Fight";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)fightImgHero).EndInit();
            ((System.ComponentModel.ISupportInitialize)fightImgWarlock).EndInit();
            ((System.ComponentModel.ISupportInitialize)fightImgDragon).EndInit();
            ((System.ComponentModel.ISupportInitialize)fightImgZombie).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox fightImgHero;
        private PictureBox fightImgWarlock;
        private PictureBox fightImgDragon;
        private Label FightHealthHero;
        private Label FightADHero;
        private Label FightArmorHero;
        private Label FightAPHero;
        private Label FightAPEnemy;
        private Label FightArmorEnemy;
        private Label FightADEnemy;
        private Label FightHealthEnemy;
        private Label HeroName;
        private Label EnemyName;
        private Button ButtonSkill1;
        private Label EnemyAbilityUseText;
        private Button ButtonSkill2;
        private Button RunAwayButton;
        private PictureBox fightImgZombie;
    }
}