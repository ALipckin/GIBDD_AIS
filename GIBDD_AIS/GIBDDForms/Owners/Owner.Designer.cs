namespace GIBDD_AIS
{
    partial class Owner
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            this.ownersPanel = new System.Windows.Forms.Panel();
            this.ownersDataGridView = new System.Windows.Forms.DataGridView();
            this.searchNameTextBox = new System.Windows.Forms.TextBox();
            this.searchNameLabel = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.editButton = new System.Windows.Forms.Button();
            this.selectOwnerLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.topAutoLabel = new System.Windows.Forms.Label();
            this.inputNewOwnerButton = new System.Windows.Forms.Button();
            this.accidentsDataGridView = new System.Windows.Forms.DataGridView();
            this.selectAccidentLabel = new System.Windows.Forms.Label();
            this.viewAccidentsButton = new System.Windows.Forms.Button();
            this.accidentsPanel = new System.Windows.Forms.Panel();
            this.ownersPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.accidentsDataGridView)).BeginInit();
            this.accidentsPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // ownersPanel
            // 
            this.ownersPanel.Controls.Add(this.ownersDataGridView);
            this.ownersPanel.Controls.Add(this.searchNameTextBox);
            this.ownersPanel.Controls.Add(this.searchNameLabel);
            this.ownersPanel.Controls.Add(this.viewButton);
            this.ownersPanel.Controls.Add(this.editButton);
            this.ownersPanel.Controls.Add(this.selectOwnerLabel);
            this.ownersPanel.Location = new System.Drawing.Point(26, 62);
            this.ownersPanel.Name = "ownersPanel";
            this.ownersPanel.Size = new System.Drawing.Size(377, 304);
            this.ownersPanel.TabIndex = 0;
            // 
            // ownersDataGridView
            // 
            this.ownersDataGridView.AllowUserToAddRows = false;
            this.ownersDataGridView.AllowUserToDeleteRows = false;
            this.ownersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.ownersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ownersDataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.ownersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ownersDataGridView.Location = new System.Drawing.Point(24, 50);
            this.ownersDataGridView.MultiSelect = false;
            this.ownersDataGridView.Name = "ownersDataGridView";
            this.ownersDataGridView.ReadOnly = true;
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.ownersDataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle2;
            this.ownersDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            this.ownersDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle3;
            this.ownersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.ownersDataGridView.Size = new System.Drawing.Size(329, 138);
            this.ownersDataGridView.TabIndex = 148;
            this.ownersDataGridView.SelectionChanged += new System.EventHandler(this.ownersDataGridViewSelectionChanged);
            // 
            // searchNameTextBox
            // 
            this.searchNameTextBox.Location = new System.Drawing.Point(194, 201);
            this.searchNameTextBox.MaxLength = 100;
            this.searchNameTextBox.Name = "searchNameTextBox";
            this.searchNameTextBox.Size = new System.Drawing.Size(159, 20);
            this.searchNameTextBox.TabIndex = 150;
            this.searchNameTextBox.TextChanged += new System.EventHandler(this.searchNameTextBoxTextChanged);
            this.searchNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.searchNameTextBoxKeyPress);
            // 
            // searchNameLabel
            // 
            this.searchNameLabel.AutoSize = true;
            this.searchNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchNameLabel.Location = new System.Drawing.Point(21, 204);
            this.searchNameLabel.Name = "searchNameLabel";
            this.searchNameLabel.Size = new System.Drawing.Size(103, 17);
            this.searchNameLabel.TabIndex = 146;
            this.searchNameLabel.Text = "Поиск по фио:";
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(24, 265);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(329, 23);
            this.viewButton.TabIndex = 144;
            this.viewButton.Text = "Просмотр записи";
            this.viewButton.UseCompatibleTextRendering = true;
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButtonClick);
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(24, 236);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(329, 23);
            this.editButton.TabIndex = 143;
            this.editButton.Text = "Редактирование записи";
            this.editButton.UseCompatibleTextRendering = true;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButtonClick);
            // 
            // selectOwnerLabel
            // 
            this.selectOwnerLabel.AutoSize = true;
            this.selectOwnerLabel.Location = new System.Drawing.Point(21, 22);
            this.selectOwnerLabel.Name = "selectOwnerLabel";
            this.selectOwnerLabel.Size = new System.Drawing.Size(137, 13);
            this.selectOwnerLabel.TabIndex = 140;
            this.selectOwnerLabel.Text = "Выберите автовладельца";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(50, 660);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(329, 23);
            this.exitButton.TabIndex = 142;
            this.exitButton.Text = "Закрыть форму";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // topAutoLabel
            // 
            this.topAutoLabel.AutoSize = true;
            this.topAutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topAutoLabel.Location = new System.Drawing.Point(135, 14);
            this.topAutoLabel.Name = "topAutoLabel";
            this.topAutoLabel.Size = new System.Drawing.Size(154, 24);
            this.topAutoLabel.TabIndex = 138;
            this.topAutoLabel.Text = "Автовладельцы";
            // 
            // inputNewOwnerButton
            // 
            this.inputNewOwnerButton.Location = new System.Drawing.Point(50, 631);
            this.inputNewOwnerButton.Name = "inputNewOwnerButton";
            this.inputNewOwnerButton.Size = new System.Drawing.Size(329, 23);
            this.inputNewOwnerButton.TabIndex = 151;
            this.inputNewOwnerButton.Text = "Добавить";
            this.inputNewOwnerButton.UseCompatibleTextRendering = true;
            this.inputNewOwnerButton.UseVisualStyleBackColor = true;
            this.inputNewOwnerButton.Click += new System.EventHandler(this.inputNewOwnerButtonClick);
            // 
            // accidentsDataGridView
            // 
            this.accidentsDataGridView.AllowUserToAddRows = false;
            this.accidentsDataGridView.AllowUserToDeleteRows = false;
            this.accidentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accidentsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.accidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accidentsDataGridView.Location = new System.Drawing.Point(24, 36);
            this.accidentsDataGridView.MultiSelect = false;
            this.accidentsDataGridView.Name = "accidentsDataGridView";
            this.accidentsDataGridView.ReadOnly = true;
            this.accidentsDataGridView.RowHeadersVisible = false;
            this.accidentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accidentsDataGridView.Size = new System.Drawing.Size(329, 138);
            this.accidentsDataGridView.TabIndex = 149;
            // 
            // selectAccidentLabel
            // 
            this.selectAccidentLabel.AutoSize = true;
            this.selectAccidentLabel.Location = new System.Drawing.Point(21, 11);
            this.selectAccidentLabel.Name = "selectAccidentLabel";
            this.selectAccidentLabel.Size = new System.Drawing.Size(213, 13);
            this.selectAccidentLabel.TabIndex = 150;
            this.selectAccidentLabel.Text = "Выберите автопроисшествие владельца";
            // 
            // viewAccidentsButton
            // 
            this.viewAccidentsButton.Location = new System.Drawing.Point(24, 189);
            this.viewAccidentsButton.Name = "viewAccidentsButton";
            this.viewAccidentsButton.Size = new System.Drawing.Size(329, 24);
            this.viewAccidentsButton.TabIndex = 151;
            this.viewAccidentsButton.Text = "Просмотреть автопроисшествие";
            this.viewAccidentsButton.UseVisualStyleBackColor = true;
            this.viewAccidentsButton.Click += new System.EventHandler(this.viewAccidentsButtonClick);
            // 
            // accidentsPanel
            // 
            this.accidentsPanel.Controls.Add(this.viewAccidentsButton);
            this.accidentsPanel.Controls.Add(this.selectAccidentLabel);
            this.accidentsPanel.Controls.Add(this.accidentsDataGridView);
            this.accidentsPanel.Location = new System.Drawing.Point(26, 380);
            this.accidentsPanel.Name = "accidentsPanel";
            this.accidentsPanel.Size = new System.Drawing.Size(377, 232);
            this.accidentsPanel.TabIndex = 150;
            // 
            // Owner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 695);
            this.Controls.Add(this.inputNewOwnerButton);
            this.Controls.Add(this.accidentsPanel);
            this.Controls.Add(this.ownersPanel);
            this.Controls.Add(this.topAutoLabel);
            this.Controls.Add(this.exitButton);
            this.MaximumSize = new System.Drawing.Size(435, 734);
            this.MinimumSize = new System.Drawing.Size(435, 734);
            this.Name = "Owner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автовладельцы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Owners_FormClosed);
            this.Load += new System.EventHandler(this.Owners_Load);
            this.ownersPanel.ResumeLayout(false);
            this.ownersPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ownersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.accidentsDataGridView)).EndInit();
            this.accidentsPanel.ResumeLayout(false);
            this.accidentsPanel.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
   
        private System.Windows.Forms.Panel ownersPanel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label selectOwnerLabel;
        private System.Windows.Forms.Label topAutoLabel;
        private System.Windows.Forms.DataGridView ownersDataGridView;
        private System.Windows.Forms.TextBox searchNameTextBox;
        private System.Windows.Forms.Label searchNameLabel;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button inputNewOwnerButton;
        private System.Windows.Forms.DataGridView accidentsDataGridView;
        private System.Windows.Forms.Label selectAccidentLabel;
        private System.Windows.Forms.Button viewAccidentsButton;
        private System.Windows.Forms.Panel accidentsPanel;
    }
}