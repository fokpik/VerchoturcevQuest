namespace VerchoturcevQuest{
    partial class FormConstructor
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
            this.label1 = new System.Windows.Forms.Label();
            this.nameTB = new System.Windows.Forms.TextBox();
            this.questionsLB = new System.Windows.Forms.ListBox();
            this.label3 = new System.Windows.Forms.Label();
            this.answersLB = new System.Windows.Forms.ListBox();
            this.label4 = new System.Windows.Forms.Label();
            this.NewQButton = new System.Windows.Forms.Button();
            this.deleteQButton = new System.Windows.Forms.Button();
            this.newAButton = new System.Windows.Forms.Button();
            this.deleteAButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Название теста:";
            // 
            // nameTB
            // 
            this.nameTB.Location = new System.Drawing.Point(16, 30);
            this.nameTB.Name = "nameTB";
            this.nameTB.Size = new System.Drawing.Size(121, 20);
            this.nameTB.TabIndex = 1;
            // 
            // questionsLB
            // 
            this.questionsLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.questionsLB.FormattingEnabled = true;
            this.questionsLB.Location = new System.Drawing.Point(144, 30);
            this.questionsLB.Name = "questionsLB";
            this.questionsLB.Size = new System.Drawing.Size(294, 160);
            this.questionsLB.TabIndex = 4;
            this.questionsLB.SelectedIndexChanged += new System.EventHandler(this.questionsLB_SelectedIndexChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(144, 13);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(55, 13);
            this.label3.TabIndex = 5;
            this.label3.Text = "Вопросы:";
            // 
            // answersLB
            // 
            this.answersLB.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.answersLB.FormattingEnabled = true;
            this.answersLB.Location = new System.Drawing.Point(444, 30);
            this.answersLB.Name = "answersLB";
            this.answersLB.Size = new System.Drawing.Size(247, 160);
            this.answersLB.TabIndex = 4;
            this.answersLB.SelectedIndexChanged += new System.EventHandler(this.answersLB_SelectedIndexChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(444, 14);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(48, 13);
            this.label4.TabIndex = 5;
            this.label4.Text = "Ответы:";
            // 
            // NewQButton
            // 
            this.NewQButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.NewQButton.Location = new System.Drawing.Point(144, 197);
            this.NewQButton.Name = "NewQButton";
            this.NewQButton.Size = new System.Drawing.Size(294, 23);
            this.NewQButton.TabIndex = 6;
            this.NewQButton.Text = "Создать";
            this.NewQButton.UseVisualStyleBackColor = true;
            this.NewQButton.Click += new System.EventHandler(this.NewQButton_Click);
            // 
            // deleteQButton
            // 
            this.deleteQButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteQButton.Enabled = false;
            this.deleteQButton.Location = new System.Drawing.Point(144, 226);
            this.deleteQButton.Name = "deleteQButton";
            this.deleteQButton.Size = new System.Drawing.Size(294, 23);
            this.deleteQButton.TabIndex = 6;
            this.deleteQButton.Text = "Удалить";
            this.deleteQButton.UseVisualStyleBackColor = true;
            this.deleteQButton.Click += new System.EventHandler(this.deleteQButton_Click);
            // 
            // newAButton
            // 
            this.newAButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.newAButton.Enabled = false;
            this.newAButton.Location = new System.Drawing.Point(444, 197);
            this.newAButton.Name = "newAButton";
            this.newAButton.Size = new System.Drawing.Size(247, 23);
            this.newAButton.TabIndex = 6;
            this.newAButton.Text = "Создать";
            this.newAButton.UseVisualStyleBackColor = true;
            this.newAButton.Click += new System.EventHandler(this.newAButton_Click);
            // 
            // deleteAButton
            // 
            this.deleteAButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.deleteAButton.Enabled = false;
            this.deleteAButton.Location = new System.Drawing.Point(444, 226);
            this.deleteAButton.Name = "deleteAButton";
            this.deleteAButton.Size = new System.Drawing.Size(247, 23);
            this.deleteAButton.TabIndex = 6;
            this.deleteAButton.Text = "Удалить";
            this.deleteAButton.UseVisualStyleBackColor = true;
            this.deleteAButton.Click += new System.EventHandler(this.deleteAButton_Click);
            // 
            // saveButton
            // 
            this.saveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.saveButton.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.saveButton.Location = new System.Drawing.Point(17, 226);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(121, 23);
            this.saveButton.TabIndex = 7;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            // 
            // FormConstructor
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(703, 257);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.deleteAButton);
            this.Controls.Add(this.deleteQButton);
            this.Controls.Add(this.newAButton);
            this.Controls.Add(this.NewQButton);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.answersLB);
            this.Controls.Add(this.questionsLB);
            this.Controls.Add(this.nameTB);
            this.Controls.Add(this.label1);
            this.MaximumSize = new System.Drawing.Size(719, 1500);
            this.MinimumSize = new System.Drawing.Size(719, 243);
            this.Name = "FormConstructor";
            this.Text = "Конструктор тестов";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormConstructor_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox nameTB;
        private System.Windows.Forms.ListBox questionsLB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.ListBox answersLB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Button NewQButton;
        private System.Windows.Forms.Button deleteQButton;
        private System.Windows.Forms.Button newAButton;
        private System.Windows.Forms.Button deleteAButton;
        private System.Windows.Forms.Button saveButton;
    }
}