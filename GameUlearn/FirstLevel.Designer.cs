
namespace GameUlearn
{
    partial class FirstLevel
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
            this.SecondAnswer = new System.Windows.Forms.Button();
            this.FirstAnswer = new System.Windows.Forms.Button();
            this.FourthAnswer = new System.Windows.Forms.Button();
            this.ThirdAnswer = new System.Windows.Forms.Button();
            this.Pushkin = new System.Windows.Forms.PictureBox();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.CountText = new System.Windows.Forms.Label();
            this.LevelLabel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.Pushkin)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelLabel)).BeginInit();
            this.SuspendLayout();
            // 
            // SecondAnswer
            // 
            this.SecondAnswer.BackColor = System.Drawing.Color.White;
            this.SecondAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondAnswer.Location = new System.Drawing.Point(366, 373);
            this.SecondAnswer.Name = "SecondAnswer";
            this.SecondAnswer.Size = new System.Drawing.Size(165, 40);
            this.SecondAnswer.TabIndex = 0;
            this.SecondAnswer.Text = "Ларчик";
            this.SecondAnswer.UseVisualStyleBackColor = false;
            this.SecondAnswer.Click += new System.EventHandler(this.SecondAnswer_Click);
            // 
            // FirstAnswer
            // 
            this.FirstAnswer.BackColor = System.Drawing.Color.White;
            this.FirstAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FirstAnswer.Location = new System.Drawing.Point(195, 373);
            this.FirstAnswer.Name = "FirstAnswer";
            this.FirstAnswer.Size = new System.Drawing.Size(165, 40);
            this.FirstAnswer.TabIndex = 1;
            this.FirstAnswer.Text = "Осёл и соловей";
            this.FirstAnswer.UseVisualStyleBackColor = false;
            this.FirstAnswer.Click += new System.EventHandler(this.FirstAnswer_Click);
            // 
            // FourthAnswer
            // 
            this.FourthAnswer.BackColor = System.Drawing.Color.White;
            this.FourthAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FourthAnswer.Location = new System.Drawing.Point(366, 440);
            this.FourthAnswer.Name = "FourthAnswer";
            this.FourthAnswer.Size = new System.Drawing.Size(165, 40);
            this.FourthAnswer.TabIndex = 2;
            this.FourthAnswer.Text = "Мартышка и очки";
            this.FourthAnswer.UseVisualStyleBackColor = false;
            this.FourthAnswer.Click += new System.EventHandler(this.FourthAnswer_Click);
            // 
            // ThirdAnswer
            // 
            this.ThirdAnswer.BackColor = System.Drawing.Color.White;
            this.ThirdAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.ThirdAnswer.Location = new System.Drawing.Point(195, 440);
            this.ThirdAnswer.Name = "ThirdAnswer";
            this.ThirdAnswer.Size = new System.Drawing.Size(165, 40);
            this.ThirdAnswer.TabIndex = 3;
            this.ThirdAnswer.Text = " Квартет";
            this.ThirdAnswer.UseVisualStyleBackColor = false;
            this.ThirdAnswer.Click += new System.EventHandler(this.ThirdAnswer_Click);
            // 
            // Pushkin
            // 
            this.Pushkin.Image = global::GameUlearn.Properties.Resources.Пушкин;
            this.Pushkin.Location = new System.Drawing.Point(-22, 280);
            this.Pushkin.Name = "Pushkin";
            this.Pushkin.Size = new System.Drawing.Size(211, 283);
            this.Pushkin.TabIndex = 4;
            this.Pushkin.TabStop = false;
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.Location = new System.Drawing.Point(0, 140);
            this.QuestionLabel.Name = "label1";
            this.QuestionLabel.Size = new System.Drawing.Size(534, 100);
            this.QuestionLabel.TabIndex = 5;
            this.QuestionLabel.Text = "Басня И.А.Крылова про Мартышку, Осла, Козла и Медведя";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(6, 13);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 7;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // CountText
            // 
            this.CountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountText.Location = new System.Drawing.Point(187, 76);
            this.CountText.Name = "CountText";
            this.CountText.Size = new System.Drawing.Size(173, 38);
            this.CountText.TabIndex = 8;
            this.CountText.Text = "Счётчик: 0";
            this.CountText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // LevelLabel
            // 
            this.LevelLabel.Image = global::GameUlearn.Properties.Resources.Уровень;
            this.LevelLabel.Location = new System.Drawing.Point(-5, -11);
            this.LevelLabel.Name = "LevelLabel";
            this.LevelLabel.Size = new System.Drawing.Size(648, 764);
            this.LevelLabel.TabIndex = 9;
            this.LevelLabel.TabStop = false;
            this.LevelLabel.Click += new System.EventHandler(this.LevelLabel_Click);
            // 
            // FirstLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameUlearn.Properties.Resources.салон;
            this.ClientSize = new System.Drawing.Size(534, 561);
            this.Controls.Add(this.LevelLabel);
            this.Controls.Add(this.CountText);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.Pushkin);
            this.Controls.Add(this.ThirdAnswer);
            this.Controls.Add(this.FourthAnswer);
            this.Controls.Add(this.FirstAnswer);
            this.Controls.Add(this.SecondAnswer);
            this.Name = "FirstLevel";
            this.Text = "Первый уровень";
            ((System.ComponentModel.ISupportInitialize)(this.Pushkin)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.LevelLabel)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button SecondAnswer;
        private System.Windows.Forms.Button FirstAnswer;
        private System.Windows.Forms.Button FourthAnswer;
        private System.Windows.Forms.Button ThirdAnswer;
        private System.Windows.Forms.PictureBox Pushkin;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Label CountText;
        private System.Windows.Forms.PictureBox LevelLabel;
    }
}