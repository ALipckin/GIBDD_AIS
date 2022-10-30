namespace GIBDD_AIS.GIBDD_Forms.Owners_forms
{
    partial class Owner_input
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
            this.TopLabelAuto = new System.Windows.Forms.Label();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.Address_label = new System.Windows.Forms.Label();
            this.BirthDate_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.OwnerSurname_textBox = new System.Windows.Forms.TextBox();
            this.create_button = new System.Windows.Forms.Button();
            this.Owner_label = new System.Windows.Forms.Label();
            this.OwnerName_textBox = new System.Windows.Forms.TextBox();
            this.OwnerMiddleName_textBox = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.BirthD_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // TopLabelAuto
            // 
            this.TopLabelAuto.AutoSize = true;
            this.TopLabelAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabelAuto.Location = new System.Drawing.Point(143, 21);
            this.TopLabelAuto.Name = "TopLabelAuto";
            this.TopLabelAuto.Size = new System.Drawing.Size(154, 48);
            this.TopLabelAuto.TabIndex = 127;
            this.TopLabelAuto.Text = "Автовладельцы\r\n(ввод)";
            this.TopLabelAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Address_textBox
            // 
            this.Address_textBox.Location = new System.Drawing.Point(153, 180);
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Size = new System.Drawing.Size(248, 20);
            this.Address_textBox.TabIndex = 144;
            this.Address_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Address_textBox_KeyPress);
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(18, 187);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(41, 13);
            this.Address_label.TabIndex = 143;
            this.Address_label.Text = "Адрес:";
            // 
            // BirthDate_label
            // 
            this.BirthDate_label.AutoSize = true;
            this.BirthDate_label.Location = new System.Drawing.Point(18, 212);
            this.BirthDate_label.Name = "BirthDate_label";
            this.BirthDate_label.Size = new System.Drawing.Size(89, 13);
            this.BirthDate_label.TabIndex = 141;
            this.BirthDate_label.Text = "Дата рождения:";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(266, 270);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(135, 23);
            this.exit_button.TabIndex = 140;
            this.exit_button.Text = "Закрыть форму";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // OwnerSurname_textBox
            // 
            this.OwnerSurname_textBox.CausesValidation = false;
            this.OwnerSurname_textBox.Location = new System.Drawing.Point(153, 101);
            this.OwnerSurname_textBox.Name = "OwnerSurname_textBox";
            this.OwnerSurname_textBox.Size = new System.Drawing.Size(248, 20);
            this.OwnerSurname_textBox.TabIndex = 137;
            this.OwnerSurname_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OwnerSurname_textBox_KeyPress);
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(21, 270);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(119, 23);
            this.create_button.TabIndex = 148;
            this.create_button.Text = "Сохранить";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // Owner_label
            // 
            this.Owner_label.AutoSize = true;
            this.Owner_label.Location = new System.Drawing.Point(18, 108);
            this.Owner_label.Name = "Owner_label";
            this.Owner_label.Size = new System.Drawing.Size(59, 13);
            this.Owner_label.TabIndex = 149;
            this.Owner_label.Text = "Фамилия:";
            // 
            // OwnerName_textBox
            // 
            this.OwnerName_textBox.CausesValidation = false;
            this.OwnerName_textBox.Location = new System.Drawing.Point(153, 127);
            this.OwnerName_textBox.Name = "OwnerName_textBox";
            this.OwnerName_textBox.Size = new System.Drawing.Size(248, 20);
            this.OwnerName_textBox.TabIndex = 150;
            this.OwnerName_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OwnerName_textBox_KeyPress);
            // 
            // OwnerMiddleName_textBox
            // 
            this.OwnerMiddleName_textBox.CausesValidation = false;
            this.OwnerMiddleName_textBox.Location = new System.Drawing.Point(153, 153);
            this.OwnerMiddleName_textBox.Name = "OwnerMiddleName_textBox";
            this.OwnerMiddleName_textBox.Size = new System.Drawing.Size(248, 20);
            this.OwnerMiddleName_textBox.TabIndex = 151;
            this.OwnerMiddleName_textBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OwnerMiddleName_textBox_KeyPress);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(18, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 152;
            this.label2.Text = "Имя:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(18, 160);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(57, 13);
            this.label3.TabIndex = 153;
            this.label3.Text = "Отчество:";
            // 
            // BirthD_dateTimePicker
            // 
            this.BirthD_dateTimePicker.Location = new System.Drawing.Point(153, 206);
            this.BirthD_dateTimePicker.Name = "BirthD_dateTimePicker";
            this.BirthD_dateTimePicker.Size = new System.Drawing.Size(248, 20);
            this.BirthD_dateTimePicker.TabIndex = 154;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Owner_input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 317);
            this.Controls.Add(this.BirthD_dateTimePicker);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.OwnerMiddleName_textBox);
            this.Controls.Add(this.OwnerName_textBox);
            this.Controls.Add(this.Owner_label);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.BirthDate_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.OwnerSurname_textBox);
            this.Controls.Add(this.TopLabelAuto);
            this.MaximumSize = new System.Drawing.Size(442, 356);
            this.MinimumSize = new System.Drawing.Size(442, 356);
            this.Name = "Owner_input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Owner_inputcs_FormClosed);
            this.Load += new System.EventHandler(this.Owner_inputcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TopLabelAuto;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.Label BirthDate_label;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.TextBox OwnerSurname_textBox;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.TextBox OwnerName_textBox;
        private System.Windows.Forms.TextBox OwnerMiddleName_textBox;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label Owner_label;
        private System.Windows.Forms.DateTimePicker BirthD_dateTimePicker;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}