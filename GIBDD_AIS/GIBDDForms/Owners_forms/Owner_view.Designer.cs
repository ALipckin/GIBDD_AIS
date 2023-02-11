namespace GIBDD_AIS.GIBDD_Forms.Owners_forms
{
    partial class Owner_view
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
            this.exit_button = new System.Windows.Forms.Button();
            this.Owner_vehicles_dataGridView = new System.Windows.Forms.DataGridView();
            this.Owner_vehicles_label = new System.Windows.Forms.Label();
            this._topAutoLabel = new System.Windows.Forms.Label();
            this.BrirthD_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OwnerMiddleName_textBox = new System.Windows.Forms.TextBox();
            this.OwnerName_textBox = new System.Windows.Forms.TextBox();
            this.Owner_label = new System.Windows.Forms.Label();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.Address_label = new System.Windows.Forms.Label();
            this.BirthDate_label = new System.Windows.Forms.Label();
            this.OwnerSurname_textBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.Owner_vehicles_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(171, 453);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(135, 23);
            this.exit_button.TabIndex = 131;
            this.exit_button.Text = "Закрыть форму";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Owner_vehicles_dataGridView
            // 
            this.Owner_vehicles_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Owner_vehicles_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Owner_vehicles_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Owner_vehicles_dataGridView.Enabled = false;
            this.Owner_vehicles_dataGridView.Location = new System.Drawing.Point(21, 268);
            this.Owner_vehicles_dataGridView.Name = "Owner_vehicles_dataGridView";
            this.Owner_vehicles_dataGridView.Size = new System.Drawing.Size(400, 139);
            this.Owner_vehicles_dataGridView.TabIndex = 130;
            // 
            // Owner_vehicles_label
            // 
            this.Owner_vehicles_label.AutoSize = true;
            this.Owner_vehicles_label.Location = new System.Drawing.Point(150, 241);
            this.Owner_vehicles_label.Name = "Owner_vehicles_label";
            this.Owner_vehicles_label.Size = new System.Drawing.Size(135, 13);
            this.Owner_vehicles_label.TabIndex = 129;
            this.Owner_vehicles_label.Text = "Автомобили во владении";
            // 
            // _topAutoLabel
            // 
            this._topAutoLabel.AutoSize = true;
            this._topAutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._topAutoLabel.Location = new System.Drawing.Point(149, 18);
            this._topAutoLabel.Name = "_topAutoLabel";
            this._topAutoLabel.Size = new System.Drawing.Size(154, 48);
            this._topAutoLabel.TabIndex = 127;
            this._topAutoLabel.Text = "Автовладельцы\r\n(просмотр)";
            this._topAutoLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BrirthD_dateTimePicker
            // 
            this.BrirthD_dateTimePicker.Enabled = false;
            this.BrirthD_dateTimePicker.Location = new System.Drawing.Point(162, 188);
            this.BrirthD_dateTimePicker.Name = "BrirthD_dateTimePicker";
            this.BrirthD_dateTimePicker.Size = new System.Drawing.Size(248, 20);
            this.BrirthD_dateTimePicker.TabIndex = 174;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(27, 142);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 173;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(27, 116);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 172;
            this.label2.Text = "Имя:";
            // 
            // OwnerMiddleName_textBox
            // 
            this.OwnerMiddleName_textBox.CausesValidation = false;
            this.OwnerMiddleName_textBox.Enabled = false;
            this.OwnerMiddleName_textBox.Location = new System.Drawing.Point(162, 135);
            this.OwnerMiddleName_textBox.Name = "OwnerMiddleName_textBox";
            this.OwnerMiddleName_textBox.ReadOnly = true;
            this.OwnerMiddleName_textBox.Size = new System.Drawing.Size(248, 20);
            this.OwnerMiddleName_textBox.TabIndex = 171;
            // 
            // OwnerName_textBox
            // 
            this.OwnerName_textBox.CausesValidation = false;
            this.OwnerName_textBox.Enabled = false;
            this.OwnerName_textBox.Location = new System.Drawing.Point(162, 109);
            this.OwnerName_textBox.Name = "OwnerName_textBox";
            this.OwnerName_textBox.ReadOnly = true;
            this.OwnerName_textBox.Size = new System.Drawing.Size(248, 20);
            this.OwnerName_textBox.TabIndex = 170;
            // 
            // Owner_label
            // 
            this.Owner_label.AutoSize = true;
            this.Owner_label.Location = new System.Drawing.Point(27, 90);
            this.Owner_label.Name = "Owner_label";
            this.Owner_label.Size = new System.Drawing.Size(59, 13);
            this.Owner_label.TabIndex = 169;
            this.Owner_label.Text = "Фамилия:";
            // 
            // Address_textBox
            // 
            this.Address_textBox.Enabled = false;
            this.Address_textBox.Location = new System.Drawing.Point(162, 162);
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.ReadOnly = true;
            this.Address_textBox.Size = new System.Drawing.Size(248, 20);
            this.Address_textBox.TabIndex = 168;
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(27, 169);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(41, 13);
            this.Address_label.TabIndex = 167;
            this.Address_label.Text = "Адрес:";
            // 
            // BirthDate_label
            // 
            this.BirthDate_label.AutoSize = true;
            this.BirthDate_label.Location = new System.Drawing.Point(27, 194);
            this.BirthDate_label.Name = "BirthDate_label";
            this.BirthDate_label.Size = new System.Drawing.Size(89, 13);
            this.BirthDate_label.TabIndex = 166;
            this.BirthDate_label.Text = "Дата рождения:";
            // 
            // OwnerSurname_textBox
            // 
            this.OwnerSurname_textBox.CausesValidation = false;
            this.OwnerSurname_textBox.Enabled = false;
            this.OwnerSurname_textBox.Location = new System.Drawing.Point(162, 83);
            this.OwnerSurname_textBox.Name = "OwnerSurname_textBox";
            this.OwnerSurname_textBox.ReadOnly = true;
            this.OwnerSurname_textBox.Size = new System.Drawing.Size(248, 20);
            this.OwnerSurname_textBox.TabIndex = 165;
            // 
            // Owner_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 524);
            this.Controls.Add(this.BrirthD_dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OwnerMiddleName_textBox);
            this.Controls.Add(this.OwnerName_textBox);
            this.Controls.Add(this.Owner_label);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.BirthDate_label);
            this.Controls.Add(this.OwnerSurname_textBox);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.Owner_vehicles_dataGridView);
            this.Controls.Add(this.Owner_vehicles_label);
            this.Controls.Add(this._topAutoLabel);
            this.MaximumSize = new System.Drawing.Size(449, 563);
            this.MinimumSize = new System.Drawing.Size(449, 563);
            this.Name = "Owner_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр";
            this.Load += new System.EventHandler(this.Owner_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Owner_vehicles_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.DataGridView Owner_vehicles_dataGridView;
        private System.Windows.Forms.Label Owner_vehicles_label;
        private System.Windows.Forms.Label _topAutoLabel;
        private System.Windows.Forms.DateTimePicker BrirthD_dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OwnerMiddleName_textBox;
        private System.Windows.Forms.TextBox OwnerName_textBox;
        public System.Windows.Forms.Label Owner_label;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Label BirthDate_label;
        private System.Windows.Forms.TextBox OwnerSurname_textBox;
    }
}