namespace GIBDD_AIS
{
    partial class Accident
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
            this.mainPanel = new System.Windows.Forms.Panel();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.accidentsDataGridView = new System.Windows.Forms.DataGridView();
            this.selectLabel = new System.Windows.Forms.Label();
            this.searchLabel = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.inputButton = new System.Windows.Forms.Button();
            this.topLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.mainPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accidentsDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // mainPanel
            // 
            this.mainPanel.Controls.Add(this.searchTextBox);
            this.mainPanel.Controls.Add(this.accidentsDataGridView);
            this.mainPanel.Controls.Add(this.selectLabel);
            this.mainPanel.Controls.Add(this.searchLabel);
            this.mainPanel.Controls.Add(this.viewButton);
            this.mainPanel.Controls.Add(this.label2);
            this.mainPanel.Controls.Add(this.editButton);
            this.mainPanel.Location = new System.Drawing.Point(43, 108);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(511, 363);
            this.mainPanel.TabIndex = 9;
            // 
            // searchTextBox
            // 
            this.searchTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.searchTextBox.Location = new System.Drawing.Point(274, 223);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(129, 20);
            this.searchTextBox.TabIndex = 15;
            this.searchTextBox.WordWrap = false;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchDateTextBoxTextChanged);
            // 
            // accidentsDataGridView
            // 
            this.accidentsDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.accidentsDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.accidentsDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.accidentsDataGridView.Location = new System.Drawing.Point(85, 50);
            this.accidentsDataGridView.Name = "accidentsDataGridView";
            this.accidentsDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.accidentsDataGridView.Size = new System.Drawing.Size(380, 150);
            this.accidentsDataGridView.TabIndex = 9;
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.selectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectLabel.Location = new System.Drawing.Point(81, 27);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(118, 20);
            this.selectLabel.TabIndex = 8;
            this.selectLabel.Text = "Выберите дтп";
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchLabel.Location = new System.Drawing.Point(121, 224);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(103, 17);
            this.searchLabel.TabIndex = 6;
            this.searchLabel.Text = "Поиск по дате";
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(140, 308);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(263, 23);
            this.viewButton.TabIndex = 2;
            this.viewButton.Text = "Просмотр записи";
            this.viewButton.UseCompatibleTextRendering = true;
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewButtonClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(140, 269);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(263, 23);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Редактирование записи";
            this.editButton.UseCompatibleTextRendering = true;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButtonClick);
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(214, 502);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(215, 33);
            this.inputButton.TabIndex = 7;
            this.inputButton.Text = "Добавить";
            this.inputButton.UseCompatibleTextRendering = true;
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButtonClick);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.topLabel.Location = new System.Drawing.Point(209, 45);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(237, 29);
            this.topLabel.TabIndex = 8;
            this.topLabel.Text = "Автопроисшествия";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(240, 556);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(177, 23);
            this.exitButton.TabIndex = 31;
            this.exitButton.Text = "Закрыть";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // Accident
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 601);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.mainPanel);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.inputButton);
            this.MaximumSize = new System.Drawing.Size(627, 640);
            this.MinimumSize = new System.Drawing.Size(627, 640);
            this.Name = "Accident";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автопроисшествия";
            this.Load += new System.EventHandler(this.AccidentsLoad);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.accidentsDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.DataGridView accidentsDataGridView;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Button exitButton;
    }
}