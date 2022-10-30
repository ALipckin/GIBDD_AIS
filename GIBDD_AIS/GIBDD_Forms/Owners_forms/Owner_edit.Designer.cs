namespace GIBDD_AIS.GIBDD_Forms.Owners_forms
{
    partial class Owner_edit
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
            this.components = new System.ComponentModel.Container();
            this.exit_button = new System.Windows.Forms.Button();
            this.TopLabelAuto = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.BirthD_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.OwnerMiddleName_textBox = new System.Windows.Forms.TextBox();
            this.OwnerName_textBox = new System.Windows.Forms.TextBox();
            this.Owner_label = new System.Windows.Forms.Label();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.Address_label = new System.Windows.Forms.Label();
            this.BirthDate_label = new System.Windows.Forms.Label();
            this.OwnerSurname_textBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this.save_button = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(307, 253);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(124, 23);
            this.exit_button.TabIndex = 122;
            this.exit_button.Text = "Закрыть форму";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // TopLabelAuto
            // 
            this.TopLabelAuto.AutoSize = true;
            this.TopLabelAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabelAuto.Location = new System.Drawing.Point(179, 27);
            this.TopLabelAuto.Name = "TopLabelAuto";
            this.TopLabelAuto.Size = new System.Drawing.Size(172, 48);
            this.TopLabelAuto.TabIndex = 118;
            this.TopLabelAuto.Text = "Автовладельцы\r\n(редактирование)";
            this.TopLabelAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(51, 253);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(108, 23);
            this.delete_button.TabIndex = 125;
            this.delete_button.Text = "Удалить запись";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // BirthD_dateTimePicker
            // 
            this.BirthD_dateTimePicker.Location = new System.Drawing.Point(183, 202);
            this.BirthD_dateTimePicker.Name = "BirthD_dateTimePicker";
            this.BirthD_dateTimePicker.Size = new System.Drawing.Size(248, 20);
            this.BirthD_dateTimePicker.TabIndex = 164;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(48, 156);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 163;
            this.label3.Text = "Отчество:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(48, 130);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 162;
            this.label2.Text = "Имя:";
            // 
            // OwnerMiddleName_textBox
            // 
            this.OwnerMiddleName_textBox.CausesValidation = false;
            this.OwnerMiddleName_textBox.Location = new System.Drawing.Point(183, 149);
            this.OwnerMiddleName_textBox.MaxLength = 30;
            this.OwnerMiddleName_textBox.Name = "OwnerMiddleName_textBox";
            this.OwnerMiddleName_textBox.Size = new System.Drawing.Size(248, 20);
            this.OwnerMiddleName_textBox.TabIndex = 161;
            this.OwnerMiddleName_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OwnerMiddleName_textBox_KeyPress);
            // 
            // OwnerName_textBox
            // 
            this.OwnerName_textBox.CausesValidation = false;
            this.OwnerName_textBox.Location = new System.Drawing.Point(183, 123);
            this.OwnerName_textBox.MaxLength = 30;
            this.OwnerName_textBox.Name = "OwnerName_textBox";
            this.OwnerName_textBox.Size = new System.Drawing.Size(248, 20);
            this.OwnerName_textBox.TabIndex = 160;
            this.OwnerName_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OwnerName_textBox_KeyPress);
            // 
            // Owner_label
            // 
            this.Owner_label.AutoSize = true;
            this.Owner_label.Location = new System.Drawing.Point(48, 104);
            this.Owner_label.Name = "Owner_label";
            this.Owner_label.Size = new System.Drawing.Size(59, 13);
            this.Owner_label.TabIndex = 159;
            this.Owner_label.Text = "Фамилия:";
            // 
            // Address_textBox
            // 
            this.Address_textBox.Location = new System.Drawing.Point(183, 176);
            this.Address_textBox.MaxLength = 60;
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Size = new System.Drawing.Size(248, 20);
            this.Address_textBox.TabIndex = 158;
            this.Address_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Address_textBox_KeyPress);
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(48, 183);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(41, 13);
            this.Address_label.TabIndex = 157;
            this.Address_label.Text = "Адрес:";
            // 
            // BirthDate_label
            // 
            this.BirthDate_label.AutoSize = true;
            this.BirthDate_label.Location = new System.Drawing.Point(48, 208);
            this.BirthDate_label.Name = "BirthDate_label";
            this.BirthDate_label.Size = new System.Drawing.Size(89, 13);
            this.BirthDate_label.TabIndex = 156;
            this.BirthDate_label.Text = "Дата рождения:";
            // 
            // OwnerSurname_textBox
            // 
            this.OwnerSurname_textBox.CausesValidation = false;
            this.OwnerSurname_textBox.Location = new System.Drawing.Point(183, 97);
            this.OwnerSurname_textBox.Name = "OwnerSurname_textBox";
            this.OwnerSurname_textBox.Size = new System.Drawing.Size(248, 20);
            this.OwnerSurname_textBox.TabIndex = 155;
            this.OwnerSurname_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OwnerSurname_textBox_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // save_button
            // 
            this.save_button.Location = new System.Drawing.Point(165, 253);
            this.save_button.Name = "save_button";
            this.save_button.Size = new System.Drawing.Size(136, 23);
            this.save_button.TabIndex = 165;
            this.save_button.Text = "Сохранить";
            this.save_button.UseVisualStyleBackColor = true;
            this.save_button.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Owner_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 293);
            this.Controls.Add(this.save_button);
            this.Controls.Add(this.BirthD_dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OwnerMiddleName_textBox);
            this.Controls.Add(this.OwnerName_textBox);
            this.Controls.Add(this.Owner_label);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.BirthDate_label);
            this.Controls.Add(this.OwnerSurname_textBox);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.TopLabelAuto);
            this.MaximumSize = new System.Drawing.Size(525, 332);
            this.MinimumSize = new System.Drawing.Size(525, 332);
            this.Name = "Owner_edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Owner_edit_FormClosed);
            this.Load += new System.EventHandler(this.Owner_edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label TopLabelAuto;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.DateTimePicker BirthD_dateTimePicker;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox OwnerMiddleName_textBox;
        private System.Windows.Forms.TextBox OwnerName_textBox;
        public System.Windows.Forms.Label Owner_label;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Label BirthDate_label;
        private System.Windows.Forms.TextBox OwnerSurname_textBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button save_button;
    }
}