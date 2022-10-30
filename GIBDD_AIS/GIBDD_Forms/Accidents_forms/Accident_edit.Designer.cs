namespace GIBDD_AIS.GIBDD_Forms.Accidents_forms
{
    partial class Accident_edit
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
            this.Type_label = new System.Windows.Forms.Label();
            this.Area_textBox = new System.Windows.Forms.TextBox();
            this.Area_label = new System.Windows.Forms.Label();
            this.RoadConditions_textBox = new System.Windows.Forms.TextBox();
            this.RoadConditions_label = new System.Windows.Forms.Label();
            this.Reason_textBox = new System.Windows.Forms.TextBox();
            this.Reason_label = new System.Windows.Forms.Label();
            this.AmountOfDamage_textBox = new System.Windows.Forms.TextBox();
            this.AmountOfDamage_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.Date_label = new System.Windows.Forms.Label();
            this.TopLabelAuto = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Delete_button = new System.Windows.Forms.Button();
            this.Save_button = new System.Windows.Forms.Button();
            this.Type_comboBox = new System.Windows.Forms.ComboBox();
            this.NumOfVictims_label = new System.Windows.Forms.Label();
            this.NumOfVictims_TextBox = new System.Windows.Forms.TextBox();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // Type_label
            // 
            this.Type_label.AutoSize = true;
            this.Type_label.Location = new System.Drawing.Point(31, 202);
            this.Type_label.Name = "Type_label";
            this.Type_label.Size = new System.Drawing.Size(29, 13);
            this.Type_label.TabIndex = 171;
            this.Type_label.Text = "Тип:";
            // 
            // Area_textBox
            // 
            this.Area_textBox.Location = new System.Drawing.Point(166, 166);
            this.Area_textBox.Name = "Area_textBox";
            this.Area_textBox.Size = new System.Drawing.Size(286, 20);
            this.Area_textBox.TabIndex = 170;
            // 
            // Area_label
            // 
            this.Area_label.AutoSize = true;
            this.Area_label.Location = new System.Drawing.Point(31, 173);
            this.Area_label.Name = "Area_label";
            this.Area_label.Size = new System.Drawing.Size(70, 13);
            this.Area_label.TabIndex = 169;
            this.Area_label.Text = "Территория:";
            // 
            // RoadConditions_textBox
            // 
            this.RoadConditions_textBox.Location = new System.Drawing.Point(166, 140);
            this.RoadConditions_textBox.Name = "RoadConditions_textBox";
            this.RoadConditions_textBox.Size = new System.Drawing.Size(286, 20);
            this.RoadConditions_textBox.TabIndex = 168;
            // 
            // RoadConditions_label
            // 
            this.RoadConditions_label.AutoSize = true;
            this.RoadConditions_label.Location = new System.Drawing.Point(31, 147);
            this.RoadConditions_label.Name = "RoadConditions_label";
            this.RoadConditions_label.Size = new System.Drawing.Size(109, 13);
            this.RoadConditions_label.TabIndex = 167;
            this.RoadConditions_label.Text = "Дорожные условия:";
            // 
            // Reason_textBox
            // 
            this.Reason_textBox.Location = new System.Drawing.Point(166, 88);
            this.Reason_textBox.Name = "Reason_textBox";
            this.Reason_textBox.Size = new System.Drawing.Size(286, 20);
            this.Reason_textBox.TabIndex = 166;
            // 
            // Reason_label
            // 
            this.Reason_label.AutoSize = true;
            this.Reason_label.Location = new System.Drawing.Point(31, 95);
            this.Reason_label.Name = "Reason_label";
            this.Reason_label.Size = new System.Drawing.Size(93, 13);
            this.Reason_label.TabIndex = 165;
            this.Reason_label.Text = "Обстоятельства:";
            // 
            // AmountOfDamage_textBox
            // 
            this.AmountOfDamage_textBox.Location = new System.Drawing.Point(166, 114);
            this.AmountOfDamage_textBox.Name = "AmountOfDamage_textBox";
            this.AmountOfDamage_textBox.Size = new System.Drawing.Size(286, 20);
            this.AmountOfDamage_textBox.TabIndex = 164;
            // 
            // AmountOfDamage_label
            // 
            this.AmountOfDamage_label.AutoSize = true;
            this.AmountOfDamage_label.Location = new System.Drawing.Point(31, 121);
            this.AmountOfDamage_label.Name = "AmountOfDamage_label";
            this.AmountOfDamage_label.Size = new System.Drawing.Size(76, 13);
            this.AmountOfDamage_label.TabIndex = 163;
            this.AmountOfDamage_label.Text = "Сумма урона:";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(341, 293);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(112, 23);
            this.exit_button.TabIndex = 162;
            this.exit_button.Text = "Закрыть форму";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Location = new System.Drawing.Point(31, 227);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(36, 13);
            this.Date_label.TabIndex = 158;
            this.Date_label.Text = "Дата:";
            // 
            // TopLabelAuto
            // 
            this.TopLabelAuto.AutoSize = true;
            this.TopLabelAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabelAuto.Location = new System.Drawing.Point(139, 20);
            this.TopLabelAuto.Name = "TopLabelAuto";
            this.TopLabelAuto.Size = new System.Drawing.Size(186, 48);
            this.TopLabelAuto.TabIndex = 156;
            this.TopLabelAuto.Text = "Автопроисшествия\r\n(редактирование)";
            this.TopLabelAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(166, 221);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(286, 20);
            this.dateTimePicker.TabIndex = 173;
            // 
            // Delete_button
            // 
            this.Delete_button.Location = new System.Drawing.Point(35, 293);
            this.Delete_button.Name = "Delete_button";
            this.Delete_button.Size = new System.Drawing.Size(100, 23);
            this.Delete_button.TabIndex = 174;
            this.Delete_button.Text = "Удалить";
            this.Delete_button.UseVisualStyleBackColor = true;
            this.Delete_button.Click += new System.EventHandler(this.Delete_button_Click);
            // 
            // Save_button
            // 
            this.Save_button.Location = new System.Drawing.Point(167, 293);
            this.Save_button.Name = "Save_button";
            this.Save_button.Size = new System.Drawing.Size(141, 23);
            this.Save_button.TabIndex = 175;
            this.Save_button.Text = "Сохранить";
            this.Save_button.UseVisualStyleBackColor = true;
            this.Save_button.Click += new System.EventHandler(this.Save_button_Click);
            // 
            // Type_comboBox
            // 
            this.Type_comboBox.FormattingEnabled = true;
            this.Type_comboBox.Location = new System.Drawing.Point(166, 194);
            this.Type_comboBox.Name = "Type_comboBox";
            this.Type_comboBox.Size = new System.Drawing.Size(286, 21);
            this.Type_comboBox.TabIndex = 176;
            // 
            // NumOfVictims_label
            // 
            this.NumOfVictims_label.AutoSize = true;
            this.NumOfVictims_label.Location = new System.Drawing.Point(32, 250);
            this.NumOfVictims_label.Name = "NumOfVictims_label";
            this.NumOfVictims_label.Size = new System.Drawing.Size(100, 13);
            this.NumOfVictims_label.TabIndex = 192;
            this.NumOfVictims_label.Text = "Количество жертв";
            // 
            // NumOfVictims_TextBox
            // 
            this.NumOfVictims_TextBox.Location = new System.Drawing.Point(166, 247);
            this.NumOfVictims_TextBox.Name = "NumOfVictims_TextBox";
            this.NumOfVictims_TextBox.Size = new System.Drawing.Size(286, 20);
            this.NumOfVictims_TextBox.TabIndex = 191;
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Accident_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(509, 328);
            this.Controls.Add(this.NumOfVictims_label);
            this.Controls.Add(this.NumOfVictims_TextBox);
            this.Controls.Add(this.Type_comboBox);
            this.Controls.Add(this.Save_button);
            this.Controls.Add(this.Delete_button);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.Type_label);
            this.Controls.Add(this.Area_textBox);
            this.Controls.Add(this.Area_label);
            this.Controls.Add(this.RoadConditions_textBox);
            this.Controls.Add(this.RoadConditions_label);
            this.Controls.Add(this.Reason_textBox);
            this.Controls.Add(this.Reason_label);
            this.Controls.Add(this.AmountOfDamage_textBox);
            this.Controls.Add(this.AmountOfDamage_label);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.TopLabelAuto);
            this.MaximumSize = new System.Drawing.Size(525, 367);
            this.MinimumSize = new System.Drawing.Size(525, 367);
            this.Name = "Accident_edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Редактирование";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Accident_edit_FormClosed);
            this.Load += new System.EventHandler(this.Accident_edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label Type_label;
        private System.Windows.Forms.TextBox Area_textBox;
        private System.Windows.Forms.Label Area_label;
        private System.Windows.Forms.TextBox RoadConditions_textBox;
        private System.Windows.Forms.Label RoadConditions_label;
        private System.Windows.Forms.TextBox Reason_textBox;
        private System.Windows.Forms.Label Reason_label;
        private System.Windows.Forms.TextBox AmountOfDamage_textBox;
        private System.Windows.Forms.Label AmountOfDamage_label;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.Label TopLabelAuto;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Button Delete_button;
        private System.Windows.Forms.Button Save_button;
        private System.Windows.Forms.ComboBox Type_comboBox;
        private System.Windows.Forms.Label NumOfVictims_label;
        private System.Windows.Forms.TextBox NumOfVictims_TextBox;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}