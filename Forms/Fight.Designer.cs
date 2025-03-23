using System.Diagnostics.Tracing;

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
            fightImgInvincible = new PictureBox();
            fightImgAngstrom = new PictureBox();
            fightImgConquest = new PictureBox();
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
            ((System.ComponentModel.ISupportInitialize)fightImgInvincible).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fightImgAngstrom).BeginInit();
            ((System.ComponentModel.ISupportInitialize)fightImgConquest).BeginInit();
            SuspendLayout();
            // 
            // fightImgInvincible
            // 
            fightImgInvincible.BackColor = Color.Transparent;
            fightImgInvincible.Image = (Image)resources.GetObject("fightImgInvincible.Image");
            fightImgInvincible.Location = new Point(123, 36);
            fightImgInvincible.Name = "fightImgInvincible";
            fightImgInvincible.Size = new Size(135, 307);
            fightImgInvincible.SizeMode = PictureBoxSizeMode.StretchImage;
            fightImgInvincible.TabIndex = 0;
            fightImgInvincible.TabStop = false;
            // 
            // fightImgAngstrom
            // 
            fightImgAngstrom.Image = (Image)resources.GetObject("fightImgAngstrom.Image");
            fightImgAngstrom.Location = new Point(551, 36);
            fightImgAngstrom.Name = "fightImgAngstrom";
            fightImgAngstrom.Size = new Size(193, 307);
            fightImgAngstrom.SizeMode = PictureBoxSizeMode.StretchImage;
            fightImgAngstrom.TabIndex = 1;
            fightImgAngstrom.TabStop = false;
            fightImgAngstrom.Visible = false;
            // 
            // fightImgConquest
            // 
            fightImgConquest.BackColor = Color.Transparent;
            fightImgConquest.Image = (Image)resources.GetObject("fightImgConquest.Image");
            fightImgConquest.Location = new Point(471, 36);
            fightImgConquest.Name = "fightImgConquest";
            fightImgConquest.Size = new Size(274, 307);
            fightImgConquest.SizeMode = PictureBoxSizeMode.StretchImage;
            fightImgConquest.TabIndex = 2;
            fightImgConquest.TabStop = false;
            fightImgConquest.Visible = false;
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
            HeroName.Font = new Font("Ninjago", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            HeroName.Location = new Point(123, -1);
            HeroName.Name = "HeroName";
            HeroName.Size = new Size(134, 34);
            HeroName.TabIndex = 11;
            HeroName.Text = "label1";
            // 
            // EnemyName
            // 
            EnemyName.AutoSize = true;
            EnemyName.Font = new Font("Ninjago", 24F, FontStyle.Bold, GraphicsUnit.Point, 0);
            EnemyName.Location = new Point(551, -1);
            EnemyName.Name = "EnemyName";
            EnemyName.Size = new Size(134, 34);
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
            RunAwayButton.Click += this.RunAwayButton_Click;
            // 
            // Fight
            // 
            AutoScaleDimensions = new SizeF(7F, 15F);
            AutoScaleMode = AutoScaleMode.Font;
            ClientSize = new Size(868, 496);
            Controls.Add(RunAwayButton);
            Controls.Add(ButtonSkill2);
            Controls.Add(EnemyAbilityUseText);
            Controls.Add(ButtonSkill1);
            Controls.Add(EnemyName);
            Controls.Add(HeroName);
            Controls.Add(fightImgInvincible);
            Controls.Add(FightAPEnemy);
            Controls.Add(FightArmorEnemy);
            Controls.Add(FightADEnemy);
            Controls.Add(FightHealthEnemy);
            Controls.Add(FightAPHero);
            Controls.Add(FightArmorHero);
            Controls.Add(FightADHero);
            Controls.Add(FightHealthHero);
            Controls.Add(fightImgConquest);
            Controls.Add(fightImgAngstrom);
            Name = "Fight";
            Text = "Form1";
            ((System.ComponentModel.ISupportInitialize)fightImgInvincible).EndInit();
            ((System.ComponentModel.ISupportInitialize)fightImgAngstrom).EndInit();
            ((System.ComponentModel.ISupportInitialize)fightImgConquest).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private PictureBox fightImgInvincible;
        private PictureBox fightImgAngstrom;
        private PictureBox fightImgConquest;
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
    }
}