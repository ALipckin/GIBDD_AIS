namespace GIBDD_AIS
{
    partial class Vehicle_edit
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
            this.exit_button = new System.Windows.Forms.Button();
            this.Delete_Button = new System.Windows.Forms.Button();
            this.Chasis_n_textBox = new System.Windows.Forms.TextBox();
            this.Chasis_label = new System.Windows.Forms.Label();
            this.VIN = new System.Windows.Forms.Label();
            this.Owner_textBox = new System.Windows.Forms.TextBox();
            this.Engine_n_textBox = new System.Windows.Forms.TextBox();
            this.Number_textBox = new System.Windows.Forms.TextBox();
            this.lastTi_textBox = new System.Windows.Forms.TextBox();
            this.Color_textBox = new System.Windows.Forms.TextBox();
            this.wanted_checkBox = new System.Windows.Forms.CheckBox();
            this.label9 = new System.Windows.Forms.Label();
            this.label8 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.Brand_textBox = new System.Windows.Forms.TextBox();
            this.VIN_textBox = new System.Windows.Forms.TextBox();
            this.BirthDate_textBox = new System.Windows.Forms.TextBox();
            this.BirthDatelabel = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.label1.Location = new System.Drawing.Point(110, 39);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(272, 24);
            this.label1.TabIndex = 31;
            this.label1.Text = "(форма для редактирования)";
            // 
            // TopLabelAuto
            // 
            this.TopLabelAuto.AutoSize = true;
            this.TopLabelAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabelAuto.Location = new System.Drawing.Point(177, 15);
            this.TopLabelAuto.Name = "TopLabelAuto";
            this.TopLabelAuto.Size = new System.Drawing.Size(122, 24);
            this.TopLabelAuto.TabIndex = 30;
            this.TopLabelAuto.Text = "Автомобили";
            this.TopLabelAuto.Click += new System.EventHandler(this.TopLabelAuto_Click);
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(325, 392);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(95, 23);
            this.exit_button.TabIndex = 29;
            this.exit_button.Text = "Закрыть форму";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Delete_Button
            // 
            this.Delete_Button.Location = new System.Drawing.Point(40, 392);
            this.Delete_Button.Name = "Delete_Button";
            this.Delete_Button.Size = new System.Drawing.Size(108, 23);
            this.Delete_Button.TabIndex = 28;
            this.Delete_Button.Text = "Удалить запись";
            this.Delete_Button.UseVisualStyleBackColor = true;
            this.Delete_Button.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // Chasis_n_textBox
            // 
            this.Chasis_n_textBox.Location = new System.Drawing.Point(172, 145);
            this.Chasis_n_textBox.Name = "Chasis_n_textBox";
            this.Chasis_n_textBox.Size = new System.Drawing.Size(248, 20);
            this.Chasis_n_textBox.TabIndex = 169;
            this.Chasis_n_textBox.Leave += new System.EventHandler(this.Chasis_n_textBox_Leave);
            // 
            // Chasis_label
            // 
            this.Chasis_label.AutoSize = true;
            this.Chasis_label.Location = new System.Drawing.Point(37, 148);
            this.Chasis_label.Name = "Chasis_label";
            this.Chasis_label.Size = new System.Drawing.Size(79, 13);
            this.Chasis_label.TabIndex = 168;
            this.Chasis_label.Text = "Номер кузова";
            // 
            // VIN
            // 
            this.VIN.AutoSize = true;
            this.VIN.Location = new System.Drawing.Point(37, 113);
            this.VIN.Name = "VIN";
            this.VIN.Size = new System.Drawing.Size(25, 13);
            this.VIN.TabIndex = 166;
            this.VIN.Text = "VIN";
            // 
            // Owner_textBox
            // 
            this.Owner_textBox.Location = new System.Drawing.Point(172, 264);
            this.Owner_textBox.Name = "Owner_textBox";
            this.Owner_textBox.Size = new System.Drawing.Size(248, 20);
            this.Owner_textBox.TabIndex = 165;
            this.Owner_textBox.Leave += new System.EventHandler(this.Owner_textBox_Leave);
            // 
            // Engine_n_textBox
            // 
            this.Engine_n_textBox.Location = new System.Drawing.Point(172, 180);
            this.Engine_n_textBox.Name = "Engine_n_textBox";
            this.Engine_n_textBox.Size = new System.Drawing.Size(248, 20);
            this.Engine_n_textBox.TabIndex = 164;
            this.Engine_n_textBox.Leave += new System.EventHandler(this.Engine_n_textBox_Leave);
            // 
            // Number_textBox
            // 
            this.Number_textBox.Enabled = false;
            this.Number_textBox.Location = new System.Drawing.Point(172, 235);
            this.Number_textBox.Name = "Number_textBox";
            this.Number_textBox.Size = new System.Drawing.Size(248, 20);
            this.Number_textBox.TabIndex = 163;
            this.Number_textBox.Leave += new System.EventHandler(this.Number_textBox_Leave);
            // 
            // lastTi_textBox
            // 
            this.lastTi_textBox.Location = new System.Drawing.Point(172, 320);
            this.lastTi_textBox.Name = "lastTi_textBox";
            this.lastTi_textBox.Size = new System.Drawing.Size(248, 20);
            this.lastTi_textBox.TabIndex = 162;
            this.lastTi_textBox.Leave += new System.EventHandler(this.lastTi_textBox_Leave);
            // 
            // Color_textBox
            // 
            this.Color_textBox.Location = new System.Drawing.Point(172, 207);
            this.Color_textBox.Name = "Color_textBox";
            this.Color_textBox.Size = new System.Drawing.Size(248, 20);
            this.Color_textBox.TabIndex = 161;
            this.Color_textBox.Leave += new System.EventHandler(this.Color_textBox_Leave);
            // 
            // wanted_checkBox
            // 
            this.wanted_checkBox.AutoSize = true;
            this.wanted_checkBox.Location = new System.Drawing.Point(172, 355);
            this.wanted_checkBox.Name = "wanted_checkBox";
            this.wanted_checkBox.Size = new System.Drawing.Size(15, 14);
            this.wanted_checkBox.TabIndex = 159;
            this.wanted_checkBox.UseVisualStyleBackColor = false;
            this.wanted_checkBox.Leave += new System.EventHandler(this.wanted_checkBox_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(37, 356);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(64, 13);
            this.label9.TabIndex = 158;
            this.label9.Text = "В розыске:";
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(37, 323);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(122, 13);
            this.label8.TabIndex = 157;
            this.label8.Text = "Последний техосмотр:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(37, 267);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(59, 13);
            this.label7.TabIndex = 156;
            this.label7.Text = "Владелец:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(37, 238);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(63, 13);
            this.label6.TabIndex = 155;
            this.label6.Text = "Гос. номер";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(37, 210);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(70, 13);
            this.label5.TabIndex = 154;
            this.label5.Text = "Цвет кузова";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(37, 183);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(96, 13);
            this.label4.TabIndex = 153;
            this.label4.Text = "Номер двигателя";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(37, 83);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(40, 13);
            this.label2.TabIndex = 152;
            this.label2.Text = "Марка";
            // 
            // Brand_textBox
            // 
            this.Brand_textBox.Location = new System.Drawing.Point(172, 76);
            this.Brand_textBox.Name = "Brand_textBox";
            this.Brand_textBox.Size = new System.Drawing.Size(248, 20);
            this.Brand_textBox.TabIndex = 171;
            this.Brand_textBox.Leave += new System.EventHandler(this.Brand_textBox_Leave);
            // 
            // VIN_textBox
            // 
            this.VIN_textBox.Location = new System.Drawing.Point(172, 110);
            this.VIN_textBox.Name = "VIN_textBox";
            this.VIN_textBox.Size = new System.Drawing.Size(248, 20);
            this.VIN_textBox.TabIndex = 172;
            this.VIN_textBox.Leave += new System.EventHandler(this.VIN_textBox_Leave);
            // 
            // BirthDate_textBox
            // 
            this.BirthDate_textBox.Location = new System.Drawing.Point(172, 294);
            this.BirthDate_textBox.Name = "BirthDate_textBox";
            this.BirthDate_textBox.Size = new System.Drawing.Size(248, 20);
            this.BirthDate_textBox.TabIndex = 174;
            this.BirthDate_textBox.Leave += new System.EventHandler(this.BirthDate_textBox_Leave);
            // 
            // BirthDatelabel
            // 
            this.BirthDatelabel.AutoSize = true;
            this.BirthDatelabel.Location = new System.Drawing.Point(37, 297);
            this.BirthDatelabel.Name = "BirthDatelabel";
            this.BirthDatelabel.Size = new System.Drawing.Size(89, 13);
            this.BirthDatelabel.TabIndex = 173;
            this.BirthDatelabel.Text = "Дата рождения:";
            // 
            // Vehicle_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(471, 473);
            this.Controls.Add(this.BirthDate_textBox);
            this.Controls.Add(this.BirthDatelabel);
            this.Controls.Add(this.VIN_textBox);
            this.Controls.Add(this.Brand_textBox);
            this.Controls.Add(this.Chasis_n_textBox);
            this.Controls.Add(this.Chasis_label);
            this.Controls.Add(this.VIN);
            this.Controls.Add(this.Owner_textBox);
            this.Controls.Add(this.Engine_n_textBox);
            this.Controls.Add(this.Number_textBox);
            this.Controls.Add(this.lastTi_textBox);
            this.Controls.Add(this.Color_textBox);
            this.Controls.Add(this.wanted_checkBox);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.TopLabelAuto);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.Delete_Button);
            this.Name = "Vehicle_edit";
            this.Text = "Auto_edit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Vehicle_edit_FormClosed);
            this.Load += new System.EventHandler(this.Vehicle_edit_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label TopLabelAuto;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Button Delete_Button;
        private System.Windows.Forms.TextBox Chasis_n_textBox;
        private System.Windows.Forms.Label Chasis_label;
        private System.Windows.Forms.Label VIN;
        private System.Windows.Forms.TextBox Owner_textBox;
        private System.Windows.Forms.TextBox Engine_n_textBox;
        private System.Windows.Forms.TextBox Number_textBox;
        private System.Windows.Forms.TextBox lastTi_textBox;
        private System.Windows.Forms.TextBox Color_textBox;
        private System.Windows.Forms.CheckBox wanted_checkBox;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.TextBox Brand_textBox;
        private System.Windows.Forms.TextBox VIN_textBox;
        private System.Windows.Forms.TextBox BirthDate_textBox;
        private System.Windows.Forms.Label BirthDatelabel;
    }
}