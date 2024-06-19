namespace VerchoturcevQuest{
    partial class FormNewQuestion
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
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rb_free = new System.Windows.Forms.RadioButton();
            this.rb_multiple = new System.Windows.Forms.RadioButton();
            this.rb_single = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.tb_text = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.tb_answer = new System.Windows.Forms.TextBox();
            this.b_create = new System.Windows.Forms.Button();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rb_free);
            this.groupBox1.Controls.Add(this.rb_multiple);
            this.groupBox1.Controls.Add(this.rb_single);
            this.groupBox1.Location = new System.Drawing.Point(12, 12);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(200, 92);
            this.groupBox1.TabIndex = 1;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Тип вопроса";
            // 
            // rb_free
            // 
            this.rb_free.AutoSize = true;
            this.rb_free.Location = new System.Drawing.Point(7, 68);
            this.rb_free.Name = "rb_free";
            this.rb_free.Size = new System.Drawing.Size(144, 17);
            this.rb_free.TabIndex = 2;
            this.rb_free.TabStop = true;
            this.rb_free.Text = "Со свободным ответом";
            this.rb_free.UseVisualStyleBackColor = true;
            this.rb_free.CheckedChanged += new System.EventHandler(this.rb_free_CheckedChanged);
            // 
            // rb_multiple
            // 
            this.rb_multiple.AutoSize = true;
            this.rb_multiple.Location = new System.Drawing.Point(7, 44);
            this.rb_multiple.Name = "rb_multiple";
            this.rb_multiple.Size = new System.Drawing.Size(154, 17);
            this.rb_multiple.TabIndex = 1;
            this.rb_multiple.TabStop = true;
            this.rb_multiple.Text = "С несколькими ответами";
            this.rb_multiple.UseVisualStyleBackColor = true;
            // 
            // rb_single
            // 
            this.rb_single.AutoSize = true;
            this.rb_single.Checked = true;
            this.rb_single.Location = new System.Drawing.Point(7, 20);
            this.rb_single.Name = "rb_single";
            this.rb_single.Size = new System.Drawing.Size(112, 17);
            this.rb_single.TabIndex = 0;
            this.rb_single.TabStop = true;
            this.rb_single.Text = "С одним ответом";
            this.rb_single.UseVisualStyleBackColor = true;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(219, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(85, 13);
            this.label1.TabIndex = 2;
            this.label1.Text = "Текст вопроса:";
            // 
            // tb_text
            // 
            this.tb_text.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_text.Location = new System.Drawing.Point(222, 32);
            this.tb_text.Multiline = true;
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(405, 41);
            this.tb_text.TabIndex = 3;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(222, 80);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 4;
            this.label2.Text = "Ответ:";
            // 
            // tb_answer
            // 
            this.tb_answer.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_answer.Enabled = false;
            this.tb_answer.Location = new System.Drawing.Point(269, 80);
            this.tb_answer.Name = "tb_answer";
            this.tb_answer.Size = new System.Drawing.Size(358, 20);
            this.tb_answer.TabIndex = 5;
            // 
            // b_create
            // 
            this.b_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.b_create.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.b_create.Location = new System.Drawing.Point(552, 106);
            this.b_create.Name = "b_create";
            this.b_create.Size = new System.Drawing.Size(75, 23);
            this.b_create.TabIndex = 6;
            this.b_create.Text = "Создать";
            this.b_create.UseVisualStyleBackColor = true;
            // 
            // FormNewQuestion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(639, 135);
            this.Controls.Add(this.b_create);
            this.Controls.Add(this.tb_answer);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.tb_text);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.groupBox1);
            this.MaximumSize = new System.Drawing.Size(1500, 174);
            this.MinimumSize = new System.Drawing.Size(655, 174);
            this.Name = "FormNewQuestion";
            this.Text = "Новый вопрос";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNewQuestion_FormClosing);
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rb_free;
        private System.Windows.Forms.RadioButton rb_multiple;
        private System.Windows.Forms.RadioButton rb_single;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_text;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox tb_answer;
        private System.Windows.Forms.Button b_create;
    }
}