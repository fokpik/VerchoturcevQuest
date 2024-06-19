namespace VerchoturcevQuest{
    partial class FormMain
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
            this.testsList = new System.Windows.Forms.ListBox();
            this.testsLabel = new System.Windows.Forms.Label();
            this.startButton = new System.Windows.Forms.Button();
            this.newButton = new System.Windows.Forms.Button();
            this.resultsGrid = new System.Windows.Forms.DataGridView();
            this.ColumnGroup = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnName = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnResult = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ColumnDate = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).BeginInit();
            this.SuspendLayout();
            // 
            // testsList
            // 
            this.testsList.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.testsList.FormattingEnabled = true;
            this.testsList.Location = new System.Drawing.Point(16, 30);
            this.testsList.Name = "testsList";
            this.testsList.Size = new System.Drawing.Size(169, 173);
            this.testsList.TabIndex = 0;
            this.testsList.SelectedIndexChanged += new System.EventHandler(this.testsList_SelectedIndexChanged);
            // 
            // testsLabel
            // 
            this.testsLabel.AutoSize = true;
            this.testsLabel.Location = new System.Drawing.Point(13, 14);
            this.testsLabel.Name = "testsLabel";
            this.testsLabel.Size = new System.Drawing.Size(42, 13);
            this.testsLabel.TabIndex = 1;
            this.testsLabel.Text = "Тесты:";
            // 
            // startButton
            // 
            this.startButton.Location = new System.Drawing.Point(192, 30);
            this.startButton.Name = "startButton";
            this.startButton.Size = new System.Drawing.Size(104, 23);
            this.startButton.TabIndex = 2;
            this.startButton.Text = "Начать тест";
            this.startButton.UseVisualStyleBackColor = true;
            this.startButton.Click += new System.EventHandler(this.startButton_Click);
            // 
            // newButton
            // 
            this.newButton.Location = new System.Drawing.Point(192, 59);
            this.newButton.Name = "newButton";
            this.newButton.Size = new System.Drawing.Size(104, 23);
            this.newButton.TabIndex = 2;
            this.newButton.Text = "Новый тест";
            this.newButton.UseVisualStyleBackColor = true;
            this.newButton.Click += new System.EventHandler(this.newButton_Click);
            // 
            // resultsGrid
            // 
            this.resultsGrid.AllowUserToAddRows = false;
            this.resultsGrid.AllowUserToDeleteRows = false;
            this.resultsGrid.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.resultsGrid.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.resultsGrid.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ColumnGroup,
            this.ColumnName,
            this.ColumnResult,
            this.ColumnDate});
            this.resultsGrid.Location = new System.Drawing.Point(303, 30);
            this.resultsGrid.Name = "resultsGrid";
            this.resultsGrid.ReadOnly = true;
            this.resultsGrid.Size = new System.Drawing.Size(446, 173);
            this.resultsGrid.TabIndex = 3;
            // 
            // ColumnGroup
            // 
            this.ColumnGroup.HeaderText = "Группа";
            this.ColumnGroup.Name = "ColumnGroup";
            this.ColumnGroup.ReadOnly = true;
            this.ColumnGroup.Width = 50;
            // 
            // ColumnName
            // 
            this.ColumnName.HeaderText = "ФИО";
            this.ColumnName.Name = "ColumnName";
            this.ColumnName.ReadOnly = true;
            this.ColumnName.Width = 150;
            // 
            // ColumnResult
            // 
            this.ColumnResult.HeaderText = "Оценка";
            this.ColumnResult.Name = "ColumnResult";
            this.ColumnResult.ReadOnly = true;
            this.ColumnResult.Width = 50;
            // 
            // ColumnDate
            // 
            this.ColumnDate.HeaderText = "Время завершения";
            this.ColumnDate.Name = "ColumnDate";
            this.ColumnDate.ReadOnly = true;
            this.ColumnDate.Width = 150;
            // 
            // deleteButton
            // 
            this.deleteButton.Enabled = false;
            this.deleteButton.Location = new System.Drawing.Point(192, 88);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(104, 23);
            this.deleteButton.TabIndex = 2;
            this.deleteButton.Text = "Удалить тест";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // FormMain
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(761, 221);
            this.Controls.Add(this.resultsGrid);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.newButton);
            this.Controls.Add(this.startButton);
            this.Controls.Add(this.testsLabel);
            this.Controls.Add(this.testsList);
            this.MinimumSize = new System.Drawing.Size(327, 260);
            this.Name = "FormMain";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Тестирование";
            this.Load += new System.EventHandler(this.FormMain_Load);
            ((System.ComponentModel.ISupportInitialize)(this.resultsGrid)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.ListBox testsList;
        private System.Windows.Forms.Label testsLabel;
        private System.Windows.Forms.Button startButton;
        private System.Windows.Forms.Button newButton;
        private System.Windows.Forms.DataGridView resultsGrid;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnGroup;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnName;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnResult;
        private System.Windows.Forms.DataGridViewTextBoxColumn ColumnDate;
        private System.Windows.Forms.Button deleteButton;
    }
}

