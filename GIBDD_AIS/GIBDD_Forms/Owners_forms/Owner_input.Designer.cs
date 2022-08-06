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
            this.label1 = new System.Windows.Forms.Label();
            this.TopLabelAuto = new System.Windows.Forms.Label();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.Address_label = new System.Windows.Forms.Label();
            this.BirthDate_textBox = new System.Windows.Forms.TextBox();
            this.BirthDate_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.Owner_textBox = new System.Windows.Forms.TextBox();
            this.create_button = new System.Windows.Forms.Button();
            this.Owner_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(135, 45);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(178, 24);
            this.label1.TabIndex = 128;
            this.label1.Text = "(форма для ввода)";
            // 
            // TopLabelAuto
            // 
            this.TopLabelAuto.AutoSize = true;
            this.TopLabelAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabelAuto.Location = new System.Drawing.Point(143, 21);
            this.TopLabelAuto.Name = "TopLabelAuto";
            this.TopLabelAuto.Size = new System.Drawing.Size(154, 24);
            this.TopLabelAuto.TabIndex = 127;
            this.TopLabelAuto.Text = "Автовладельцы";
            // 
            // Address_textBox
            // 
            this.Address_textBox.Location = new System.Drawing.Point(153, 127);
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Size = new System.Drawing.Size(248, 20);
            this.Address_textBox.TabIndex = 144;
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(18, 130);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(41, 13);
            this.Address_label.TabIndex = 143;
            this.Address_label.Text = "Адрес:";
            // 
            // BirthDate_textBox
            // 
            this.BirthDate_textBox.Location = new System.Drawing.Point(153, 153);
            this.BirthDate_textBox.Name = "BirthDate_textBox";
            this.BirthDate_textBox.Size = new System.Drawing.Size(248, 20);
            this.BirthDate_textBox.TabIndex = 142;
            // 
            // BirthDate_label
            // 
            this.BirthDate_label.AutoSize = true;
            this.BirthDate_label.Location = new System.Drawing.Point(18, 156);
            this.BirthDate_label.Name = "BirthDate_label";
            this.BirthDate_label.Size = new System.Drawing.Size(89, 13);
            this.BirthDate_label.TabIndex = 141;
            this.BirthDate_label.Text = "Дата рождения:";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(266, 210);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(135, 23);
            this.exit_button.TabIndex = 140;
            this.exit_button.Text = "Закрыть форму";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Owner_textBox
            // 
            this.Owner_textBox.CausesValidation = false;
            this.Owner_textBox.Location = new System.Drawing.Point(153, 101);
            this.Owner_textBox.Name = "Owner_textBox";
            this.Owner_textBox.Size = new System.Drawing.Size(248, 20);
            this.Owner_textBox.TabIndex = 137;
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(21, 210);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(119, 23);
            this.create_button.TabIndex = 148;
            this.create_button.Text = "Создать";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // Owner_label
            // 
            this.Owner_label.AutoSize = true;
            this.Owner_label.Location = new System.Drawing.Point(18, 104);
            this.Owner_label.Name = "Owner_label";
            this.Owner_label.Size = new System.Drawing.Size(37, 13);
            this.Owner_label.TabIndex = 149;
            this.Owner_label.Text = "ФИО:";
            // 
            // Owner_input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(441, 245);
            this.Controls.Add(this.Owner_label);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.BirthDate_textBox);
            this.Controls.Add(this.BirthDate_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.Owner_textBox);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopLabelAuto);
            this.Name = "Owner_input";
            this.Text = "Owner_inputcs";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Owner_inputcs_FormClosed);
            this.Load += new System.EventHandler(this.Owner_inputcs_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TopLabelAuto;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.Label Address_label;
        private System.Windows.Forms.TextBox BirthDate_textBox;
        private System.Windows.Forms.Label BirthDate_label;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.TextBox Owner_textBox;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.Label Owner_label;
    }
}