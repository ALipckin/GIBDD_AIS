namespace GIBDD_AIS.GIBDD_Forms.Owners_forms
{
    partial class BaseOwner
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
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.birthDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.middleNameLabel = new System.Windows.Forms.Label();
            this.nameLabel = new System.Windows.Forms.Label();
            this.middleNameTextBox = new System.Windows.Forms.TextBox();
            this.nameTextBox = new System.Windows.Forms.TextBox();
            this.surnameLabel = new System.Windows.Forms.Label();
            this.addressTextBox = new System.Windows.Forms.TextBox();
            this.addressLabel = new System.Windows.Forms.Label();
            this.birthDateLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.surnameTextBox = new System.Windows.Forms.TextBox();
            this.topLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.Location = new System.Drawing.Point(157, 207);
            this.birthDateDateTimePicker.Name = "birthDateDateTimePicker";
            this.birthDateDateTimePicker.Size = new System.Drawing.Size(248, 20);
            this.birthDateDateTimePicker.TabIndex = 166;
            // 
            // middleNameLabel
            // 
            this.middleNameLabel.AutoSize = true;
            this.middleNameLabel.Location = new System.Drawing.Point(22, 161);
            this.middleNameLabel.Name = "middleNameLabel";
            this.middleNameLabel.Size = new System.Drawing.Size(57, 13);
            this.middleNameLabel.TabIndex = 165;
            this.middleNameLabel.Text = "Отчество:";
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Location = new System.Drawing.Point(22, 135);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(32, 13);
            this.nameLabel.TabIndex = 164;
            this.nameLabel.Text = "Имя:";
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.CausesValidation = false;
            this.middleNameTextBox.Location = new System.Drawing.Point(157, 154);
            this.middleNameTextBox.Name = "middleNameTextBox";
            this.middleNameTextBox.Size = new System.Drawing.Size(248, 20);
            this.middleNameTextBox.TabIndex = 163;
            this.middleNameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.middleNameTextBoxKeyPress);
            // 
            // nameTextBox
            // 
            this.nameTextBox.CausesValidation = false;
            this.nameTextBox.Location = new System.Drawing.Point(157, 128);
            this.nameTextBox.Name = "nameTextBox";
            this.nameTextBox.Size = new System.Drawing.Size(248, 20);
            this.nameTextBox.TabIndex = 162;
            this.nameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.nameTextBoxKeyPress);
            // 
            // surnameLabel
            // 
            this.surnameLabel.AutoSize = true;
            this.surnameLabel.Location = new System.Drawing.Point(22, 109);
            this.surnameLabel.Name = "surnameLabel";
            this.surnameLabel.Size = new System.Drawing.Size(59, 13);
            this.surnameLabel.TabIndex = 161;
            this.surnameLabel.Text = "Фамилия:";
            // 
            // addressTextBox
            // 
            this.addressTextBox.Location = new System.Drawing.Point(157, 181);
            this.addressTextBox.Name = "addressTextBox";
            this.addressTextBox.Size = new System.Drawing.Size(248, 20);
            this.addressTextBox.TabIndex = 160;
            this.addressTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.addressTextBoxKeyPress);
            // 
            // addressLabel
            // 
            this.addressLabel.AutoSize = true;
            this.addressLabel.Location = new System.Drawing.Point(22, 188);
            this.addressLabel.Name = "addressLabel";
            this.addressLabel.Size = new System.Drawing.Size(41, 13);
            this.addressLabel.TabIndex = 159;
            this.addressLabel.Text = "Адрес:";
            // 
            // birthDateLabel
            // 
            this.birthDateLabel.AutoSize = true;
            this.birthDateLabel.Location = new System.Drawing.Point(22, 213);
            this.birthDateLabel.Name = "birthDateLabel";
            this.birthDateLabel.Size = new System.Drawing.Size(89, 13);
            this.birthDateLabel.TabIndex = 158;
            this.birthDateLabel.Text = "Дата рождения:";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(270, 271);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(135, 23);
            this.exitButton.TabIndex = 157;
            this.exitButton.Text = "Закрыть форму";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.CausesValidation = false;
            this.surnameTextBox.Location = new System.Drawing.Point(157, 102);
            this.surnameTextBox.Name = "surnameTextBox";
            this.surnameTextBox.Size = new System.Drawing.Size(248, 20);
            this.surnameTextBox.TabIndex = 156;
            this.surnameTextBox.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.surnameTextBoxKeyPress);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topLabel.Location = new System.Drawing.Point(147, 22);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(154, 24);
            this.topLabel.TabIndex = 155;
            this.topLabel.Text = "Автовладельцы";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // BaseOwner
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(426, 317);
            this.Controls.Add(this.birthDateDateTimePicker);
            this.Controls.Add(this.middleNameLabel);
            this.Controls.Add(this.nameLabel);
            this.Controls.Add(this.middleNameTextBox);
            this.Controls.Add(this.nameTextBox);
            this.Controls.Add(this.surnameLabel);
            this.Controls.Add(this.addressTextBox);
            this.Controls.Add(this.addressLabel);
            this.Controls.Add(this.birthDateLabel);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.surnameTextBox);
            this.Controls.Add(this.topLabel);
            this.MaximumSize = new System.Drawing.Size(442, 356);
            this.MinimumSize = new System.Drawing.Size(442, 356);
            this.Name = "BaseOwner";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Owner_inputcs_FormClosed);
            this.Load += new System.EventHandler(this.Owner_inputcs_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label middleNameLabel;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Label addressLabel;
        private System.Windows.Forms.Label birthDateLabel;
        protected System.Windows.Forms.Label surnameLabel;
        protected System.Windows.Forms.TextBox middleNameTextBox;
        protected System.Windows.Forms.TextBox nameTextBox;
        protected System.Windows.Forms.Button exitButton;
        protected System.Windows.Forms.TextBox addressTextBox;
        protected System.Windows.Forms.TextBox surnameTextBox;
        protected System.Windows.Forms.Label topLabel;
        protected System.Windows.Forms.ErrorProvider errorProvider;
        protected System.Windows.Forms.DateTimePicker birthDateDateTimePicker;
    }
}