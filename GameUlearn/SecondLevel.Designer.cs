
namespace GameUlearn
{
    partial class SecondLevel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SecondLevel));
            this.CountText = new System.Windows.Forms.Label();
            this.ExitBtn = new System.Windows.Forms.Button();
            this.FirstAnswer = new System.Windows.Forms.Button();
            this.SecondAnswer = new System.Windows.Forms.Button();
            this.ThirdAnswer = new System.Windows.Forms.Button();
            this.FourthAnswer = new System.Windows.Forms.Button();
            this.QuestionLabel = new System.Windows.Forms.Label();
            this.Chehov = new System.Windows.Forms.PictureBox();
            this.LevelLabel = new System.Windows.Forms.PictureBox();
            //LevelLabel = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(LevelLabel)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chehov)).BeginInit();
            this.SuspendLayout();
            // 
            // LabelLevel
            // 
            LevelLabel.Image = global::GameUlearn.Properties.Resources.Второй_Уровень;
            LevelLabel.Location = new System.Drawing.Point(0, 0);
            LevelLabel.Name = "LabelLevel";
            LevelLabel.Size = new System.Drawing.Size(550, 600);
            LevelLabel.TabIndex = 8;
            LevelLabel.TabStop = false;
            LevelLabel.Click += new System.EventHandler(this.LevelLabel_Click);
            // 
            // CountText
            // 
            this.CountText.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.CountText.Location = new System.Drawing.Point(83, 76);
            this.CountText.Name = "CountText";
            this.CountText.Size = new System.Drawing.Size(173, 38);
            this.CountText.TabIndex = 0;
            this.CountText.Text = "Счётчик:";
            this.CountText.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.CountText.Visible = true;
            // 
            // ExitBtn
            // 
            this.ExitBtn.Location = new System.Drawing.Point(6, 13);
            this.ExitBtn.Name = "ExitBtn";
            this.ExitBtn.Size = new System.Drawing.Size(75, 23);
            this.ExitBtn.TabIndex = 1;
            this.ExitBtn.Text = "Выход";
            this.ExitBtn.UseVisualStyleBackColor = true;
            this.ExitBtn.Click += new System.EventHandler(this.ExitBtn_Click);
            // 
            // FirstAnswer
            // 
            this.FirstAnswer.BackColor = System.Drawing.Color.White;
            this.FirstAnswer.Location = new System.Drawing.Point(6, 413);
            this.FirstAnswer.Name = "FirstAnswer";
            this.FirstAnswer.Size = new System.Drawing.Size(250, 45);
            this.FirstAnswer.TabIndex = 2;
            this.FirstAnswer.Text = "Любовь способна преодолеть любые трудности";
            this.FirstAnswer.UseVisualStyleBackColor = false;
            this.FirstAnswer.Click += new System.EventHandler(this.FirstAnswer_Click);
            // 
            // SecondAnswer
            // 
            this.SecondAnswer.BackColor = System.Drawing.Color.White;
            this.SecondAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.SecondAnswer.Location = new System.Drawing.Point(273, 413);
            this.SecondAnswer.Name = "SecondAnswer";
            this.SecondAnswer.Size = new System.Drawing.Size(250, 45);
            this.SecondAnswer.TabIndex = 3;
            this.SecondAnswer.Text = "Главным в жизни достойной личности является борьба за богатство";
            this.SecondAnswer.UseVisualStyleBackColor = false;
            this.SecondAnswer.Click += new System.EventHandler(this.SecondAnswer_Click);
            // 
            // ThirdAnswer
            // 
            this.ThirdAnswer.BackColor = System.Drawing.Color.White;
            this.ThirdAnswer.Location = new System.Drawing.Point(6, 488);
            this.ThirdAnswer.Name = "ThirdAnswer";
            this.ThirdAnswer.Size = new System.Drawing.Size(250, 45);
            this.ThirdAnswer.TabIndex = 4;
            this.ThirdAnswer.Text = "Осуждение нравов современной автору молодёжи";
            this.ThirdAnswer.UseVisualStyleBackColor = false;
            this.ThirdAnswer.Click += new System.EventHandler(this.ThirdAnswer_Click);
            // 
            // FourthAnswer
            // 
            this.FourthAnswer.BackColor = System.Drawing.Color.White;
            this.FourthAnswer.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.FourthAnswer.Location = new System.Drawing.Point(273, 488);
            this.FourthAnswer.Name = "FourthAnswer";
            this.FourthAnswer.Size = new System.Drawing.Size(250, 45);
            this.FourthAnswer.TabIndex = 5;
            this.FourthAnswer.Text = "Осуждение глупости, безнравственности и невоспитанности старого дворянства";
            this.FourthAnswer.UseVisualStyleBackColor = false;
            this.FourthAnswer.Click += new System.EventHandler(this.FourthAnswer_Click);
            // 
            // QuestionLabel
            // 
            this.QuestionLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 20.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.QuestionLabel.Location = new System.Drawing.Point(0, 287);
            this.QuestionLabel.Name = "question";
            this.QuestionLabel.Size = new System.Drawing.Size(534, 100);
            this.QuestionLabel.TabIndex = 6;
            this.QuestionLabel.Text = "Выберите основную идею произведения \"Недоросль\"";
            this.QuestionLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Chehov
            // 
            this.Chehov.Image = global::GameUlearn.Properties.Resources.Чехов;
            this.Chehov.Location = new System.Drawing.Point(329, -19);
            this.Chehov.Name = "Chehov";
            this.Chehov.Size = new System.Drawing.Size(236, 303);
            this.Chehov.TabIndex = 7;
            this.Chehov.TabStop = false;
            // 
            // SecondLevel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::GameUlearn.Properties.Resources.Сад;
            this.ClientSize = new System.Drawing.Size(534, 561);
            this.Controls.Add(LevelLabel);
            this.Controls.Add(this.Chehov);
            this.Controls.Add(this.QuestionLabel);
            this.Controls.Add(this.FourthAnswer);
            this.Controls.Add(this.ThirdAnswer);
            this.Controls.Add(this.SecondAnswer);
            this.Controls.Add(this.FirstAnswer);
            this.Controls.Add(this.ExitBtn);
            this.Controls.Add(this.CountText);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SecondLevel";
            this.Text = "Второй уровень";
            ((System.ComponentModel.ISupportInitialize)(LevelLabel)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Chehov)).EndInit();
            this.ResumeLayout(false);

        }
      

        #endregion

        private System.Windows.Forms.Label CountText;
        private System.Windows.Forms.Button ExitBtn;
        private System.Windows.Forms.Button FirstAnswer;
        private System.Windows.Forms.Button SecondAnswer;
        private System.Windows.Forms.Button ThirdAnswer;
        private System.Windows.Forms.Button FourthAnswer;
        private System.Windows.Forms.Label QuestionLabel;
        private System.Windows.Forms.PictureBox Chehov;
        private System.Windows.Forms.PictureBox LevelLabel;
    }
}