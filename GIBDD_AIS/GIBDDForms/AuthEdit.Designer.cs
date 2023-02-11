namespace GIBDD_AIS.GIBDDForms
{
    partial class AuthEdit
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
            this._loginTextBox = new System.Windows.Forms.TextBox();
            this._passwordTextBox = new System.Windows.Forms.TextBox();
            this._loginLabel = new System.Windows.Forms.Label();
            this._passwordLabel = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.Login_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Password_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Login_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _loginTextBox
            // 
            this._loginTextBox.Location = new System.Drawing.Point(15, 34);
            this._loginTextBox.Name = "_loginTextBox";
            this._loginTextBox.Size = new System.Drawing.Size(174, 20);
            this._loginTextBox.TabIndex = 0;
            // 
            // _passwordTextBox
            // 
            this._passwordTextBox.Location = new System.Drawing.Point(15, 78);
            this._passwordTextBox.Name = "_passwordTextBox";
            this._passwordTextBox.Size = new System.Drawing.Size(174, 20);
            this._passwordTextBox.TabIndex = 1;
            // 
            // _loginLabel
            // 
            this._loginLabel.AutoSize = true;
            this._loginLabel.Location = new System.Drawing.Point(12, 18);
            this._loginLabel.Name = "_loginLabel";
            this._loginLabel.Size = new System.Drawing.Size(38, 13);
            this._loginLabel.TabIndex = 2;
            this._loginLabel.Text = "Логин";
            // 
            // _passwordLabel
            // 
            this._passwordLabel.AutoSize = true;
            this._passwordLabel.Location = new System.Drawing.Point(15, 61);
            this._passwordLabel.Name = "_passwordLabel";
            this._passwordLabel.Size = new System.Drawing.Size(45, 13);
            this._passwordLabel.TabIndex = 3;
            this._passwordLabel.Text = "Пароль";
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(61, 113);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(75, 23);
            this.Save_button.TabIndex = 4;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Login_errorProvider
            // 
            this.Login_errorProvider.ContainerControl = this;
            // 
            // Password_errorProvider
            // 
            this.Password_errorProvider.ContainerControl = this;
            // 
            // Auth_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(218, 148);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this._passwordLabel);
            this.Controls.Add(this._loginLabel);
            this.Controls.Add(this._passwordTextBox);
            this.Controls.Add(this._loginTextBox);
            this.Name = "Auth_edit";
            this.Text = "Auth_edit";
            this.Load += new System.EventHandler(this.Auth_edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Login_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox _loginTextBox;
        private System.Windows.Forms.TextBox _passwordTextBox;
        private System.Windows.Forms.Label _loginLabel;
        private System.Windows.Forms.Label _passwordLabel;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.ErrorProvider Login_errorProvider;
        private System.Windows.Forms.ErrorProvider Password_errorProvider;
    }
}