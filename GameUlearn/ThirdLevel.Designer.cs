
namespace GameUlearn
{
    partial class ThirdLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(ThirdLevel));
            this.Gogol = new System.Windows.Forms.PictureBox();
            this.FirstAnswer = new System.Windows.Forms.Button();
            this.SecondAnswer = new System.Windows.Forms.Button();
            this.ThirdAnswer = new System.Windows.Forms.Button();
            this.FourthAnswer = new System.Windows.Forms.Button();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.CountText = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Gogol)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // Gogol
            // 
            this.Gogol.Image = global::GameUlearn.Properties.Resources.Гоголь;
            this.Gogol.Location = new System.Drawing.Point(339, 295);
            this.Gogol.Name = "Gogol";
            this.Gogol.Size = new System.Drawing.Size(195, 270);
            this.Gogol.TabIndex = 0;
            this.Gogol.TabStop = false;
            // 
            // FirstAnswer
            // 
            this.FirstAnswer.BackColor = System.Drawing.Color.White;
            this.FirstAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstAnswer.Location = new System.Drawing.Point(4, 394);
            this.FirstAnswer.Name = "FirstAnswer";
            this.FirstAnswer.Size = new System.Drawing.Size(165, 40);
            this.FirstAnswer.TabIndex = 1;
            this.FirstAnswer.Text = "Женитьба Белугина";
            this.FirstAnswer.UseVisualStyleBackColor = false;
            this.FirstAnswer.Click += new System.EventHandler(this.FirstAnswer_Click);
            // 
            // SecondAnswer
            // 
            this.SecondAnswer.BackColor = System.Drawing.Color.White;
            this.SecondAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondAnswer.Location = new System.Drawing.Point(175, 394);
            this.SecondAnswer.Name = "SecondAnswer";
            this.SecondAnswer.Size = new System.Drawing.Size(165, 40);
            this.SecondAnswer.TabIndex = 2;
            this.SecondAnswer.Text = "Волки и овцы";
            this.SecondAnswer.UseVisualStyleBackColor = false;
            this.SecondAnswer.Click += new System.EventHandler(this.SecondAnswer_Click);
            // 
            // ThirdAnswer
            // 
            this.ThirdAnswer.BackColor = System.Drawing.Color.White;
            this.ThirdAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThirdAnswer.Location = new System.Drawing.Point(4, 472);
            this.ThirdAnswer.Name = "ThirdAnswer";
            this.ThirdAnswer.Size = new System.Drawing.Size(165, 40);
            this.ThirdAnswer.TabIndex = 3;
            this.ThirdAnswer.Text = "Свои люди - сочтёмся";
            this.ThirdAnswer.UseVisualStyleBackColor = false;
            this.ThirdAnswer.Click += new System.EventHandler(this.ThirdAnswer_Click);
            // 
            // FourthAnswer
            // 
            this.FourthAnswer.BackColor = System.Drawing.Color.White;
            this.FourthAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FourthAnswer.Location = new System.Drawing.Point(175, 472);
            this.FourthAnswer.Name = "FourthAnswer";
            this.FourthAnswer.Size = new System.Drawing.Size(165, 40);
            this.FourthAnswer.TabIndex = 4;
            this.FourthAnswer.Text = "Гроза";
            this.FourthAnswer.UseVisualStyleBackColor = false;
            this.FourthAnswer.Click += new System.EventHandler(this.FourthAnswer_Click);
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(6, 13);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 5;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.Location = new System.Drawing.Point(0, 140);
            this.QuestionLabel.Name = "QuestionLabel";
            this.QuestionLabel.Size = new System.Drawing.Size(534, 100);
            this.QuestionLabel.TabIndex = 6;
            this.QuestionLabel.Text = "Какая из пьес Островского имела несколько названий?";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // CountText
            // 
            this.CountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountText.Location = new System.Drawing.Point(187, 76);
            this.CountText.Name = "CountText";
            this.CountText.Size = new System.Drawing.Size(173, 38);
            this.CountText.TabIndex = 7;
            this.CountText.Text = "Счётчик:";
            this.CountText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LevelLabel
            // 
            this.LevelLabel.Image = global::GameUlearn.Properties.Resources.Третий_уровень;
            this.LevelLabel.Location = new System.Drawing.Point(0, 0);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(550, 600);
            this.LevelLabel.TabIndex = 8;
            this.LevelLabel.TabStop = false;
            this.LevelLabel.Click += new System.EventHandler(this.LevelLabel_Click);
            // 
            // ThirdLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameUlearn.Properties.Resources.набережная;
            this.ClientSize = new System.Drawing.Size(534, 561);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.CountText);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.FourthAnswer);
            this.Controls.Add(this.ThirdAnswer);
            this.Controls.Add(this.SecondAnswer);
            this.Controls.Add(this.FirstAnswer);
            this.Controls.Add(this.Gogol);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "ThirdLevel";
            this.Text = "Третий уровень";
            ((System.ComponentModel.ISupportInitialize)(this.Gogol)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelLabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox Gogol;
        private System.Windows.Forms.Button FirstAnswer;
        private System.Windows.Forms.Button SecondAnswer;
        private System.Windows.Forms.Button ThirdAnswer;
        private System.Windows.Forms.Button FourthAnswer;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Label CountText;
        private System.Windows.Forms.PictureBox LevelLabel;
    }
}