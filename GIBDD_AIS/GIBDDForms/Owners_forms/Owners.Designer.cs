namespace GIBDD_AIS
{
    partial class Owners
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
            this.panel1 = new System.Windows.Forms.Panel();
            this._ownersDataGridView = new System.Windows.Forms.DataGridView();
            this._searchNameTextBox = new System.Windows.Forms.TextBox();
            this._searchNameLabel = new System.Windows.Forms.Label();
            this._viewButton = new System.Windows.Forms.Button();
            this._editButton = new System.Windows.Forms.Button();
            this._ownersLabel = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this._topAutoLabel = new System.Windows.Forms.Label();
            this._inputNewOwnerButton = new System.Windows.Forms.Button();
            this._accidentsDataGridView = new System.Windows.Forms.DataGridView();
            this._accidentsLabel = new System.Windows.Forms.Label();
            this._viewAccidentsButton = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ownersDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._accidentsDataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this._ownersDataGridView);
            this.panel1.Controls.Add(this._searchNameTextBox);
            this.panel1.Controls.Add(this._searchNameLabel);
            this.panel1.Controls.Add(this._viewButton);
            this.panel1.Controls.Add(this._editButton);
            this.panel1.Controls.Add(this._ownersLabel);
            this.panel1.Location = new System.Drawing.Point(26, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 308);
            this.panel1.TabIndex = 0;
            // 
            // _ownersDataGridView
            // 
            this._ownersDataGridView.AllowUserToAddRows = false;
            this._ownersDataGridView.AllowUserToDeleteRows = false;
            this._ownersDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._ownersDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._ownersDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._ownersDataGridView.Location = new System.Drawing.Point(24, 50);
            this._ownersDataGridView.Name = "_ownersDataGridView";
            this._ownersDataGridView.ReadOnly = true;
            this._ownersDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._ownersDataGridView.Size = new System.Drawing.Size(323, 138);
            this._ownersDataGridView.TabIndex = 148;
            this._ownersDataGridView.SelectionChanged += new System.EventHandler(this.Owners_dataGridView_SelectionChanged);
            // 
            // _searchNameTextBox
            // 
            this._searchNameTextBox.Location = new System.Drawing.Point(194, 201);
            this._searchNameTextBox.MaxLength = 100;
            this._searchNameTextBox.Name = "_searchNameTextBox";
            this._searchNameTextBox.Size = new System.Drawing.Size(150, 20);
            this._searchNameTextBox.TabIndex = 150;
            this._searchNameTextBox.TextChanged += new System.EventHandler(this.SearchName_TextBox_TextChanged);
            this._searchNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.SearchName_TextBox_KeyPress);
            // 
            // _searchNameLabel
            // 
            this._searchNameLabel.AutoSize = true;
            this._searchNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this._searchNameLabel.Location = new System.Drawing.Point(21, 204);
            this._searchNameLabel.Name = "_searchNameLabel";
            this._searchNameLabel.Size = new System.Drawing.Size(103, 17);
            this._searchNameLabel.TabIndex = 146;
            this._searchNameLabel.Text = "Поиск по фио:";
            // 
            // _viewButton
            // 
            this._viewButton.Location = new System.Drawing.Point(24, 275);
            this._viewButton.Name = "_viewButton";
            this._viewButton.Size = new System.Drawing.Size(320, 23);
            this._viewButton.TabIndex = 144;
            this._viewButton.Text = "Просмотр записи";
            this._viewButton.UseCompatibleTextRendering = true;
            this._viewButton.UseVisualStyleBackColor = true;
            this._viewButton.Click += new System.EventHandler(this.View_button_Click);
            // 
            // _editButton
            // 
            this._editButton.Location = new System.Drawing.Point(24, 236);
            this._editButton.Name = "_editButton";
            this._editButton.Size = new System.Drawing.Size(320, 23);
            this._editButton.TabIndex = 143;
            this._editButton.Text = "Редактирование записи";
            this._editButton.UseCompatibleTextRendering = true;
            this._editButton.UseVisualStyleBackColor = true;
            this._editButton.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // _ownersLabel
            // 
            this._ownersLabel.AutoSize = true;
            this._ownersLabel.Location = new System.Drawing.Point(21, 22);
            this._ownersLabel.Name = "_ownersLabel";
            this._ownersLabel.Size = new System.Drawing.Size(137, 13);
            this._ownersLabel.TabIndex = 140;
            this._ownersLabel.Text = "Выберите автовладельца";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(41, 660);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(323, 23);
            this.exit_button.TabIndex = 142;
            this.exit_button.Text = "Закрыть форму";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // _topAutoLabel
            // 
            this._topAutoLabel.AutoSize = true;
            this._topAutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._topAutoLabel.Location = new System.Drawing.Point(135, 14);
            this._topAutoLabel.Name = "_topAutoLabel";
            this._topAutoLabel.Size = new System.Drawing.Size(154, 24);
            this._topAutoLabel.TabIndex = 138;
            this._topAutoLabel.Text = "Автовладельцы";
            // 
            // _inputNewOwnerButton
            // 
            this._inputNewOwnerButton.Location = new System.Drawing.Point(44, 595);
            this._inputNewOwnerButton.Name = "_inputNewOwnerButton";
            this._inputNewOwnerButton.Size = new System.Drawing.Size(320, 23);
            this._inputNewOwnerButton.TabIndex = 151;
            this._inputNewOwnerButton.Text = "Добавить";
            this._inputNewOwnerButton.UseCompatibleTextRendering = true;
            this._inputNewOwnerButton.UseVisualStyleBackColor = true;
            this._inputNewOwnerButton.Click += new System.EventHandler(this.inputNewOwner_button_Click);
            // 
            // _accidentsDataGridView
            // 
            this._accidentsDataGridView.AllowUserToAddRows = false;
            this._accidentsDataGridView.AllowUserToDeleteRows = false;
            this._accidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._accidentsDataGridView.Location = new System.Drawing.Point(18, 46);
            this._accidentsDataGridView.Name = "_accidentsDataGridView";
            this._accidentsDataGridView.ReadOnly = true;
            this._accidentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this._accidentsDataGridView.Size = new System.Drawing.Size(320, 66);
            this._accidentsDataGridView.TabIndex = 149;
            // 
            // _accidentsLabel
            // 
            this._accidentsLabel.AutoSize = true;
            this._accidentsLabel.Location = new System.Drawing.Point(8, 18);
            this._accidentsLabel.Name = "_accidentsLabel";
            this._accidentsLabel.Size = new System.Drawing.Size(213, 13);
            this._accidentsLabel.TabIndex = 150;
            this._accidentsLabel.Text = "Выберите автопроисшествие владельца";
            // 
            // _viewAccidentsButton
            // 
            this._viewAccidentsButton.Location = new System.Drawing.Point(18, 127);
            this._viewAccidentsButton.Name = "_viewAccidentsButton";
            this._viewAccidentsButton.Size = new System.Drawing.Size(320, 24);
            this._viewAccidentsButton.TabIndex = 151;
            this._viewAccidentsButton.Text = "Посмотреть автопроисшествие";
            this._viewAccidentsButton.UseVisualStyleBackColor = true;
            this._viewAccidentsButton.Click += new System.EventHandler(this.ViewAccidents_button_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this._viewAccidentsButton);
            this.panel2.Controls.Add(this._accidentsLabel);
            this.panel2.Controls.Add(this._accidentsDataGridView);
            this.panel2.Location = new System.Drawing.Point(26, 403);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 164);
            this.panel2.TabIndex = 150;
            // 
            // Owners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 695);
            this.Controls.Add(this._inputNewOwnerButton);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this._topAutoLabel);
            this.Controls.Add(this.exit_button);
            this.MaximumSize = new System.Drawing.Size(435, 734);
            this.MinimumSize = new System.Drawing.Size(435, 734);
            this.Name = "Owners";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автовладельцы";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Owners_FormClosed);
            this.Load += new System.EventHandler(this.Owners_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this._ownersDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._accidentsDataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
   
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label _ownersLabel;
        private System.Windows.Forms.Label _topAutoLabel;
        private System.Windows.Forms.DataGridView _ownersDataGridView;
        private System.Windows.Forms.TextBox _searchNameTextBox;
        private System.Windows.Forms.Label _searchNameLabel;
        private System.Windows.Forms.Button _viewButton;
        private System.Windows.Forms.Button _editButton;
        private System.Windows.Forms.Button _inputNewOwnerButton;
        private System.Windows.Forms.DataGridView _accidentsDataGridView;
        private System.Windows.Forms.Label _accidentsLabel;
        private System.Windows.Forms.Button _viewAccidentsButton;
        private System.Windows.Forms.Panel panel2;
    }
}