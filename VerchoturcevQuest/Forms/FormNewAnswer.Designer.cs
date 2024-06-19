namespace VerchoturcevQuest{
    partial class FormNewAnswer
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
            this.tb_text = new System.Windows.Forms.TextBox();
            this.cb_iscorrect = new System.Windows.Forms.CheckBox();
            this.b_create = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(13, 13);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(77, 13);
            this.label1.TabIndex = 0;
            this.label1.Text = "Текст ответа:";
            // 
            // tb_text
            // 
            this.tb_text.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.tb_text.Location = new System.Drawing.Point(13, 30);
            this.tb_text.Multiline = true;
            this.tb_text.Name = "tb_text";
            this.tb_text.Size = new System.Drawing.Size(496, 59);
            this.tb_text.TabIndex = 1;
            // 
            // cb_iscorrect
            // 
            this.cb_iscorrect.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.cb_iscorrect.AutoSize = true;
            this.cb_iscorrect.Location = new System.Drawing.Point(13, 96);
            this.cb_iscorrect.Name = "cb_iscorrect";
            this.cb_iscorrect.Size = new System.Drawing.Size(90, 17);
            this.cb_iscorrect.TabIndex = 2;
            this.cb_iscorrect.Text = "Правильный";
            this.cb_iscorrect.UseVisualStyleBackColor = true;
            // 
            // b_create
            // 
            this.b_create.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.b_create.DialogResult = System.Windows.Forms.DialogResult.OK;
            this.b_create.Location = new System.Drawing.Point(434, 96);
            this.b_create.Name = "b_create";
            this.b_create.Size = new System.Drawing.Size(75, 23);
            this.b_create.TabIndex = 3;
            this.b_create.Text = "Создать";
            this.b_create.UseVisualStyleBackColor = true;
            // 
            // FormNewAnswer
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(521, 124);
            this.Controls.Add(this.b_create);
            this.Controls.Add(this.cb_iscorrect);
            this.Controls.Add(this.tb_text);
            this.Controls.Add(this.label1);
            this.Name = "FormNewAnswer";
            this.Text = "Новый ответ";
            this.FormClosing += new System.Windows.Forms.FormClosingEventHandler(this.FormNewAnswer_FormClosing);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox tb_text;
        private System.Windows.Forms.CheckBox cb_iscorrect;
        private System.Windows.Forms.Button b_create;
    }
}