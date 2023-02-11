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
            this._exitButton = new System.Windows.Forms.Button();
            this._topLabelAuto = new System.Windows.Forms.Label();
            this._deleteButton = new System.Windows.Forms.Button();
            this._birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this._middleNameLabel = new System.Windows.Forms.Label();
            this._nameLabel = new System.Windows.Forms.Label();
            this._middleNameTextBox = new System.Windows.Forms.TextBox();
            this._nameTextBox = new System.Windows.Forms.TextBox();
            this._surnameLabel = new System.Windows.Forms.Label();
            this._addressTextBox = new System.Windows.Forms.TextBox();
            this._addressLabel = new System.Windows.Forms.Label();
            this._birthDateLabel = new System.Windows.Forms.Label();
            this._surnameTextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            this._saveButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // _exitButton
            // 
            this._exitButton.Location = new System.Drawing.Point(307, 253);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(124, 23);
            this._exitButton.TabIndex = 122;
            this._exitButton.Text = "Закрыть форму";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // _topLabelAuto
            // 
            this._topLabelAuto.AutoSize = true;
            this._topLabelAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._topLabelAuto.Location = new System.Drawing.Point(179, 27);
            this._topLabelAuto.Name = "_topLabelAuto";
            this._topLabelAuto.Size = new System.Drawing.Size(172, 48);
            this._topLabelAuto.TabIndex = 118;
            this._topLabelAuto.Text = "Автовладельцы\r\n(редактирование)";
            this._topLabelAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // _deleteButton
            // 
            this._deleteButton.Location = new System.Drawing.Point(51, 253);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(108, 23);
            this._deleteButton.TabIndex = 125;
            this._deleteButton.Text = "Удалить запись";
            this._deleteButton.UseVisualStyleBackColor = true;
            this._deleteButton.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // _birthDateDateTimePicker
            // 
            this._birthDateDateTimePicker.Location = new System.Drawing.Point(183, 202);
            this._birthDateDateTimePicker.Name = "_birthDateDateTimePicker";
            this._birthDateDateTimePicker.Size = new System.Drawing.Size(248, 20);
            this._birthDateDateTimePicker.TabIndex = 164;
            // 
            // _middleNameLabel
            // 
            this._middleNameLabel.AutoSize = true;
            this._middleNameLabel.Location = new System.Drawing.Point(48, 156);
            this._middleNameLabel.Name = "_middleNameLabel";
            this._middleNameLabel.Size = new System.Drawing.Size(57, 13);
            this._middleNameLabel.TabIndex = 163;
            this._middleNameLabel.Text = "Отчество:";
            // 
            // _nameLabel
            // 
            this._nameLabel.AutoSize = true;
            this._nameLabel.Location = new System.Drawing.Point(48, 130);
            this._nameLabel.Name = "_nameLabel";
            this._nameLabel.Size = new System.Drawing.Size(32, 13);
            this._nameLabel.TabIndex = 162;
            this._nameLabel.Text = "Имя:";
            // 
            // _middleNameTextBox
            // 
            this._middleNameTextBox.CausesValidation = false;
            this._middleNameTextBox.Location = new System.Drawing.Point(183, 149);
            this._middleNameTextBox.MaxLength = 30;
            this._middleNameTextBox.Name = "_middleNameTextBox";
            this._middleNameTextBox.Size = new System.Drawing.Size(248, 20);
            this._middleNameTextBox.TabIndex = 161;
            this._middleNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OwnerMiddleName_textBox_KeyPress);
            // 
            // _nameTextBox
            // 
            this._nameTextBox.CausesValidation = false;
            this._nameTextBox.Location = new System.Drawing.Point(183, 123);
            this._nameTextBox.MaxLength = 30;
            this._nameTextBox.Name = "_nameTextBox";
            this._nameTextBox.Size = new System.Drawing.Size(248, 20);
            this._nameTextBox.TabIndex = 160;
            this._nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OwnerName_textBox_KeyPress);
            // 
            // _surnameLabel
            // 
            this._surnameLabel.AutoSize = true;
            this._surnameLabel.Location = new System.Drawing.Point(48, 104);
            this._surnameLabel.Name = "_surnameLabel";
            this._surnameLabel.Size = new System.Drawing.Size(59, 13);
            this._surnameLabel.TabIndex = 159;
            this._surnameLabel.Text = "Фамилия:";
            // 
            // _addressTextBox
            // 
            this._addressTextBox.Location = new System.Drawing.Point(183, 176);
            this._addressTextBox.MaxLength = 60;
            this._addressTextBox.Name = "_addressTextBox";
            this._addressTextBox.Size = new System.Drawing.Size(248, 20);
            this._addressTextBox.TabIndex = 158;
            this._addressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.Address_textBox_KeyPress);
            // 
            // _addressLabel
            // 
            this._addressLabel.AutoSize = true;
            this._addressLabel.Location = new System.Drawing.Point(48, 183);
            this._addressLabel.Name = "_addressLabel";
            this._addressLabel.Size = new System.Drawing.Size(41, 13);
            this._addressLabel.TabIndex = 157;
            this._addressLabel.Text = "Адрес:";
            // 
            // _birthDateLabel
            // 
            this._birthDateLabel.AutoSize = true;
            this._birthDateLabel.Location = new System.Drawing.Point(48, 208);
            this._birthDateLabel.Name = "_birthDateLabel";
            this._birthDateLabel.Size = new System.Drawing.Size(89, 13);
            this._birthDateLabel.TabIndex = 156;
            this._birthDateLabel.Text = "Дата рождения:";
            // 
            // _surnameTextBox
            // 
            this._surnameTextBox.CausesValidation = false;
            this._surnameTextBox.Location = new System.Drawing.Point(183, 97);
            this._surnameTextBox.Name = "_surnameTextBox";
            this._surnameTextBox.Size = new System.Drawing.Size(248, 20);
            this._surnameTextBox.TabIndex = 155;
            this._surnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.OwnerSurname_textBox_KeyPress);
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(165, 253);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(136, 23);
            this._saveButton.TabIndex = 165;
            this._saveButton.Text = "Сохранить";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.save_button_Click);
            // 
            // Owner_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 293);
            this.Controls.Add(this._saveButton);
            this.Controls.Add(this._birthDateDateTimePicker);
            this.Controls.Add(this._middleNameLabel);
            this.Controls.Add(this._nameLabel);
            this.Controls.Add(this._middleNameTextBox);
            this.Controls.Add(this._nameTextBox);
            this.Controls.Add(this._surnameLabel);
            this.Controls.Add(this._addressTextBox);
            this.Controls.Add(this._addressLabel);
            this.Controls.Add(this._birthDateLabel);
            this.Controls.Add(this._surnameTextBox);
            this.Controls.Add(this._deleteButton);
            this.Controls.Add(this._exitButton);
            this.Controls.Add(this._topLabelAuto);
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
        private System.Windows.Forms.Button _exitButton;
        private System.Windows.Forms.Label _topLabelAuto;
        private System.Windows.Forms.Button _deleteButton;
        private System.Windows.Forms.DateTimePicker _birthDateDateTimePicker;
        private System.Windows.Forms.Label _middleNameLabel;
        private System.Windows.Forms.Label _nameLabel;
        private System.Windows.Forms.TextBox _middleNameTextBox;
        private System.Windows.Forms.TextBox _nameTextBox;
        public System.Windows.Forms.Label _surnameLabel;
        private System.Windows.Forms.TextBox _addressTextBox;
        private System.Windows.Forms.Label _addressLabel;
        private System.Windows.Forms.Label _birthDateLabel;
        private System.Windows.Forms.TextBox _surnameTextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
        private System.Windows.Forms.Button _saveButton;
    }
}