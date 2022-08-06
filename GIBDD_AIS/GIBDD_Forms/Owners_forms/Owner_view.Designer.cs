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
            this.BirthDate_textBox = new System.Windows.Forms.TextBox();
            this.BirthDate_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.Owner_vehicles_dataGridView = new System.Windows.Forms.DataGridView();
            this.Owner_vehicles_label = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.TopLabelAuto = new System.Windows.Forms.Label();
            this.Owner_textBox = new System.Windows.Forms.TextBox();
            this.Owner = new System.Windows.Forms.Label();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.Address_label = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.Owner_vehicles_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // BirthDate_textBox
            // 
            this.BirthDate_textBox.Enabled = false;
            this.BirthDate_textBox.Location = new System.Drawing.Point(153, 148);
            this.BirthDate_textBox.Name = "BirthDate_textBox";
            this.BirthDate_textBox.Size = new System.Drawing.Size(248, 20);
            this.BirthDate_textBox.TabIndex = 133;
            // 
            // BirthDate_label
            // 
            this.BirthDate_label.AutoSize = true;
            this.BirthDate_label.Location = new System.Drawing.Point(18, 151);
            this.BirthDate_label.Name = "BirthDate_label";
            this.BirthDate_label.Size = new System.Drawing.Size(89, 13);
            this.BirthDate_label.TabIndex = 132;
            this.BirthDate_label.Text = "Дата рождения:";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(171, 404);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(135, 23);
            this.exit_button.TabIndex = 131;
            this.exit_button.Text = "Закрыть форму";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Owner_vehicles_dataGridView
            // 
            this.Owner_vehicles_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Owner_vehicles_dataGridView.Enabled = false;
            this.Owner_vehicles_dataGridView.Location = new System.Drawing.Point(21, 219);
            this.Owner_vehicles_dataGridView.Name = "Owner_vehicles_dataGridView";
            this.Owner_vehicles_dataGridView.Size = new System.Drawing.Size(409, 139);
            this.Owner_vehicles_dataGridView.TabIndex = 130;
            // 
            // Owner_vehicles_label
            // 
            this.Owner_vehicles_label.AutoSize = true;
            this.Owner_vehicles_label.Location = new System.Drawing.Point(168, 193);
            this.Owner_vehicles_label.Name = "Owner_vehicles_label";
            this.Owner_vehicles_label.Size = new System.Drawing.Size(135, 13);
            this.Owner_vehicles_label.TabIndex = 129;
            this.Owner_vehicles_label.Text = "Автомобили во владении";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(127, 42);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(221, 24);
            this.label1.TabIndex = 128;
            this.label1.Text = "(форма для просмотра)";
            // 
            // TopLabelAuto
            // 
            this.TopLabelAuto.AutoSize = true;
            this.TopLabelAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabelAuto.Location = new System.Drawing.Point(149, 18);
            this.TopLabelAuto.Name = "TopLabelAuto";
            this.TopLabelAuto.Size = new System.Drawing.Size(154, 24);
            this.TopLabelAuto.TabIndex = 127;
            this.TopLabelAuto.Text = "Автовладельцы";
            // 
            // Owner_textBox
            // 
            this.Owner_textBox.CausesValidation = false;
            this.Owner_textBox.Enabled = false;
            this.Owner_textBox.Location = new System.Drawing.Point(153, 96);
            this.Owner_textBox.Name = "Owner_textBox";
            this.Owner_textBox.Size = new System.Drawing.Size(248, 20);
            this.Owner_textBox.TabIndex = 126;
            // 
            // Owner
            // 
            this.Owner.AutoSize = true;
            this.Owner.Location = new System.Drawing.Point(18, 99);
            this.Owner.Name = "Owner";
            this.Owner.Size = new System.Drawing.Size(59, 13);
            this.Owner.TabIndex = 125;
            this.Owner.Text = "Владелец:";
            // 
            // Address_textBox
            // 
            this.Address_textBox.Enabled = false;
            this.Address_textBox.Location = new System.Drawing.Point(153, 122);
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Size = new System.Drawing.Size(248, 20);
            this.Address_textBox.TabIndex = 135;
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(18, 125);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(41, 13);
            this.Address_label.TabIndex = 134;
            this.Address_label.Text = "Адрес:";
            // 
            // Owner_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(433, 456);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.BirthDate_textBox);
            this.Controls.Add(this.BirthDate_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.Owner_vehicles_dataGridView);
            this.Controls.Add(this.Owner_vehicles_label);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopLabelAuto);
            this.Controls.Add(this.Owner_textBox);
            this.Controls.Add(this.Owner);
            this.Name = "Owner_view";
            this.Text = "Owner_view";
            this.Load += new System.EventHandler(this.Owner_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Owner_vehicles_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BirthDate_textBox;
        private System.Windows.Forms.Label BirthDate_label;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.DataGridView Owner_vehicles_dataGridView;
        private System.Windows.Forms.Label Owner_vehicles_label;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TopLabelAuto;
        private System.Windows.Forms.TextBox Owner_textBox;
        private System.Windows.Forms.Label Owner;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.Label Address_label;
    }
}