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
            this.BirthDate_textBox = new System.Windows.Forms.TextBox();
            this.BirthDate_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.TopLabelAuto = new System.Windows.Forms.Label();
            this.Owner_textBox = new System.Windows.Forms.TextBox();
            this.Owner = new System.Windows.Forms.Label();
            this.delete_button = new System.Windows.Forms.Button();
            this.Address_textBox = new System.Windows.Forms.TextBox();
            this.Address_label = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // BirthDate_textBox
            // 
            this.BirthDate_textBox.Location = new System.Drawing.Point(183, 162);
            this.BirthDate_textBox.Name = "BirthDate_textBox";
            this.BirthDate_textBox.Size = new System.Drawing.Size(248, 20);
            this.BirthDate_textBox.TabIndex = 124;
            this.BirthDate_textBox.Leave += new System.EventHandler(this.BirthDate_textBox_Leave);
            // 
            // BirthDate_label
            // 
            this.BirthDate_label.AutoSize = true;
            this.BirthDate_label.Location = new System.Drawing.Point(48, 165);
            this.BirthDate_label.Name = "BirthDate_label";
            this.BirthDate_label.Size = new System.Drawing.Size(89, 13);
            this.BirthDate_label.TabIndex = 123;
            this.BirthDate_label.Text = "Дата рождения:";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(296, 208);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(135, 23);
            this.exit_button.TabIndex = 122;
            this.exit_button.Text = "Закрыть форму";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(115, 51);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 24);
            this.label1.TabIndex = 119;
            this.label1.Text = "(форма для редактирования)";
            // 
            // TopLabelAuto
            // 
            this.TopLabelAuto.AutoSize = true;
            this.TopLabelAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabelAuto.Location = new System.Drawing.Point(179, 27);
            this.TopLabelAuto.Name = "TopLabelAuto";
            this.TopLabelAuto.Size = new System.Drawing.Size(154, 24);
            this.TopLabelAuto.TabIndex = 118;
            this.TopLabelAuto.Text = "Автовладельцы";
            // 
            // Owner_textBox
            // 
            this.Owner_textBox.CausesValidation = false;
            this.Owner_textBox.Location = new System.Drawing.Point(183, 110);
            this.Owner_textBox.Name = "Owner_textBox";
            this.Owner_textBox.Size = new System.Drawing.Size(248, 20);
            this.Owner_textBox.TabIndex = 117;
            this.Owner_textBox.Leave += new System.EventHandler(this.Owner_textBox_Leave);
            // 
            // Owner
            // 
            this.Owner.AutoSize = true;
            this.Owner.Location = new System.Drawing.Point(48, 113);
            this.Owner.Name = "Owner";
            this.Owner.Size = new System.Drawing.Size(59, 13);
            this.Owner.TabIndex = 116;
            this.Owner.Text = "Владелец:";
            // 
            // delete_button
            // 
            this.delete_button.Location = new System.Drawing.Point(51, 208);
            this.delete_button.Name = "delete_button";
            this.delete_button.Size = new System.Drawing.Size(115, 23);
            this.delete_button.TabIndex = 125;
            this.delete_button.Text = "Удалить запись";
            this.delete_button.UseVisualStyleBackColor = true;
            this.delete_button.Click += new System.EventHandler(this.delete_button_Click);
            // 
            // Address_textBox
            // 
            this.Address_textBox.Location = new System.Drawing.Point(183, 136);
            this.Address_textBox.Name = "Address_textBox";
            this.Address_textBox.Size = new System.Drawing.Size(248, 20);
            this.Address_textBox.TabIndex = 137;
            this.Address_textBox.Leave += new System.EventHandler(this.Address_textBox_Leave);
            // 
            // Address_label
            // 
            this.Address_label.AutoSize = true;
            this.Address_label.Location = new System.Drawing.Point(48, 139);
            this.Address_label.Name = "Address_label";
            this.Address_label.Size = new System.Drawing.Size(41, 13);
            this.Address_label.TabIndex = 136;
            this.Address_label.Text = "Адрес:";
            // 
            // Owner_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(499, 247);
            this.Controls.Add(this.Address_textBox);
            this.Controls.Add(this.Address_label);
            this.Controls.Add(this.delete_button);
            this.Controls.Add(this.BirthDate_textBox);
            this.Controls.Add(this.BirthDate_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopLabelAuto);
            this.Controls.Add(this.Owner_textBox);
            this.Controls.Add(this.Owner);
            this.Name = "Owner_edit";
            this.Text = "Owner_edit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Owner_edit_FormClosed);
            this.Load += new System.EventHandler(this.Owner_edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.TextBox BirthDate_textBox;
        private System.Windows.Forms.Label BirthDate_label;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TopLabelAuto;
        private System.Windows.Forms.TextBox Owner_textBox;
        private System.Windows.Forms.Label Owner;
        private System.Windows.Forms.Button delete_button;
        private System.Windows.Forms.TextBox Address_textBox;
        private System.Windows.Forms.Label Address_label;
    }
}