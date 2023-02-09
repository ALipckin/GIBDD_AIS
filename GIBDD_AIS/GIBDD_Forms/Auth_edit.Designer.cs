namespace GIBDD_AIS.GIBDD_Forms
{
    partial class Auth_edit
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
            this.Login_textBox = new System.Windows.Forms.TextBox();
            this.Password_textBox = new System.Windows.Forms.TextBox();
            this.Login_label = new System.Windows.Forms.Label();
            this.Password_label = new System.Windows.Forms.Label();
            this.Save_button = new System.Windows.Forms.Button();
            this.Login_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.Password_errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.Login_errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // Login_textBox
            // 
            this.Login_textBox.Location = new System.Drawing.Point(15, 34);
            this.Login_textBox.Name = "Login_textBox";
            this.Login_textBox.Size = new System.Drawing.Size(174, 20);
            this.Login_textBox.TabIndex = 0;
            // 
            // Password_textBox
            // 
            this.Password_textBox.Location = new System.Drawing.Point(15, 78);
            this.Password_textBox.Name = "Password_textBox";
            this.Password_textBox.Size = new System.Drawing.Size(174, 20);
            this.Password_textBox.TabIndex = 1;
            // 
            // Login_label
            // 
            this.Login_label.AutoSize = true;
            this.Login_label.Location = new System.Drawing.Point(12, 18);
            this.Login_label.Name = "Login_label";
            this.Login_label.Size = new System.Drawing.Size(38, 13);
            this.Login_label.TabIndex = 2;
            this.Login_label.Text = "Логин";
            // 
            // Password_label
            // 
            this.Password_label.AutoSize = true;
            this.Password_label.Location = new System.Drawing.Point(15, 61);
            this.Password_label.Name = "Password_label";
            this.Password_label.Size = new System.Drawing.Size(45, 13);
            this.Password_label.TabIndex = 3;
            this.Password_label.Text = "Пароль";
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
            this.Controls.Add(this.Password_label);
            this.Controls.Add(this.Login_label);
            this.Controls.Add(this.Password_textBox);
            this.Controls.Add(this.Login_textBox);
            this.Name = "Auth_edit";
            this.Text = "Auth_edit";
            this.Load += new System.EventHandler(this.Auth_edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.Login_errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Password_errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox Login_textBox;
        private System.Windows.Forms.TextBox Password_textBox;
        private System.Windows.Forms.Label Login_label;
        private System.Windows.Forms.Label Password_label;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.ErrorProvider Login_errorProvider;
        private System.Windows.Forms.ErrorProvider Password_errorProvider;
    }
}