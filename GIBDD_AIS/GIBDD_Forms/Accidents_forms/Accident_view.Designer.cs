namespace GIBDD_AIS.GIBDD_Forms.Accidents_forms
{
    partial class Accident_view
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
            this.TopLabelAuto = new System.Windows.Forms.Label();
            this.Reason_textBox = new System.Windows.Forms.TextBox();
            this.Reason_label = new System.Windows.Forms.Label();
            this.AmountOfDamage_textBox = new System.Windows.Forms.TextBox();
            this.AmountOfDamage_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.MembersOfAccident_dataGridView = new System.Windows.Forms.DataGridView();
            this.Members_label = new System.Windows.Forms.Label();
            this.RoadConditions_textBox = new System.Windows.Forms.TextBox();
            this.RoadConditions_label = new System.Windows.Forms.Label();
            this.Area_textBox = new System.Windows.Forms.TextBox();
            this.Area_label = new System.Windows.Forms.Label();
            this.Type_textBox = new System.Windows.Forms.TextBox();
            this.Type_label = new System.Windows.Forms.Label();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Date_label = new System.Windows.Forms.Label();
            this.NumOfVictims_label = new System.Windows.Forms.Label();
            this.NumOfVictims_TextBox = new System.Windows.Forms.TextBox();
            ((System.ComponentModel.ISupportInitialize)(this.MembersOfAccident_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // TopLabelAuto
            // 
            this.TopLabelAuto.AutoSize = true;
            this.TopLabelAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabelAuto.Location = new System.Drawing.Point(153, 23);
            this.TopLabelAuto.Name = "TopLabelAuto";
            this.TopLabelAuto.Size = new System.Drawing.Size(186, 48);
            this.TopLabelAuto.TabIndex = 68;
            this.TopLabelAuto.Text = "Автопроисшествия\r\n(просмотр)";
            this.TopLabelAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // Reason_textBox
            // 
            this.Reason_textBox.Enabled = false;
            this.Reason_textBox.Location = new System.Drawing.Point(180, 91);
            this.Reason_textBox.Name = "Reason_textBox";
            this.Reason_textBox.Size = new System.Drawing.Size(248, 20);
            this.Reason_textBox.TabIndex = 144;
            // 
            // Reason_label
            // 
            this.Reason_label.AutoSize = true;
            this.Reason_label.Location = new System.Drawing.Point(45, 98);
            this.Reason_label.Name = "Reason_label";
            this.Reason_label.Size = new System.Drawing.Size(93, 13);
            this.Reason_label.TabIndex = 143;
            this.Reason_label.Text = "Обстоятельства:";
            // 
            // AmountOfDamage_textBox
            // 
            this.AmountOfDamage_textBox.Enabled = false;
            this.AmountOfDamage_textBox.Location = new System.Drawing.Point(180, 117);
            this.AmountOfDamage_textBox.Name = "AmountOfDamage_textBox";
            this.AmountOfDamage_textBox.Size = new System.Drawing.Size(248, 20);
            this.AmountOfDamage_textBox.TabIndex = 142;
            // 
            // AmountOfDamage_label
            // 
            this.AmountOfDamage_label.AutoSize = true;
            this.AmountOfDamage_label.Location = new System.Drawing.Point(45, 124);
            this.AmountOfDamage_label.Name = "AmountOfDamage_label";
            this.AmountOfDamage_label.Size = new System.Drawing.Size(76, 13);
            this.AmountOfDamage_label.TabIndex = 141;
            this.AmountOfDamage_label.Text = "Сумма урона:";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(180, 476);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(135, 23);
            this.exit_button.TabIndex = 140;
            this.exit_button.Text = "Закрыть форму";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // MembersOfAccident_dataGridView
            // 
            this.MembersOfAccident_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MembersOfAccident_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MembersOfAccident_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MembersOfAccident_dataGridView.Enabled = false;
            this.MembersOfAccident_dataGridView.Location = new System.Drawing.Point(48, 299);
            this.MembersOfAccident_dataGridView.Name = "MembersOfAccident_dataGridView";
            this.MembersOfAccident_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MembersOfAccident_dataGridView.Size = new System.Drawing.Size(380, 139);
            this.MembersOfAccident_dataGridView.TabIndex = 139;
            // 
            // Members_label
            // 
            this.Members_label.AutoSize = true;
            this.Members_label.Location = new System.Drawing.Point(45, 283);
            this.Members_label.Name = "Members_label";
            this.Members_label.Size = new System.Drawing.Size(160, 13);
            this.Members_label.TabIndex = 138;
            this.Members_label.Text = "Участники автопроисшествия";
            // 
            // RoadConditions_textBox
            // 
            this.RoadConditions_textBox.Enabled = false;
            this.RoadConditions_textBox.Location = new System.Drawing.Point(180, 143);
            this.RoadConditions_textBox.Name = "RoadConditions_textBox";
            this.RoadConditions_textBox.Size = new System.Drawing.Size(248, 20);
            this.RoadConditions_textBox.TabIndex = 146;
            // 
            // RoadConditions_label
            // 
            this.RoadConditions_label.AutoSize = true;
            this.RoadConditions_label.Location = new System.Drawing.Point(45, 150);
            this.RoadConditions_label.Name = "RoadConditions_label";
            this.RoadConditions_label.Size = new System.Drawing.Size(109, 13);
            this.RoadConditions_label.TabIndex = 145;
            this.RoadConditions_label.Text = "Дорожные условия:";
            // 
            // Area_textBox
            // 
            this.Area_textBox.Enabled = false;
            this.Area_textBox.Location = new System.Drawing.Point(180, 169);
            this.Area_textBox.Name = "Area_textBox";
            this.Area_textBox.Size = new System.Drawing.Size(248, 20);
            this.Area_textBox.TabIndex = 148;
            // 
            // Area_label
            // 
            this.Area_label.AutoSize = true;
            this.Area_label.Location = new System.Drawing.Point(45, 176);
            this.Area_label.Name = "Area_label";
            this.Area_label.Size = new System.Drawing.Size(70, 13);
            this.Area_label.TabIndex = 147;
            this.Area_label.Text = "Территория:";
            // 
            // Type_textBox
            // 
            this.Type_textBox.Enabled = false;
            this.Type_textBox.Location = new System.Drawing.Point(180, 195);
            this.Type_textBox.Name = "Type_textBox";
            this.Type_textBox.Size = new System.Drawing.Size(248, 20);
            this.Type_textBox.TabIndex = 155;
            // 
            // Type_label
            // 
            this.Type_label.AutoSize = true;
            this.Type_label.Location = new System.Drawing.Point(45, 202);
            this.Type_label.Name = "Type_label";
            this.Type_label.Size = new System.Drawing.Size(29, 13);
            this.Type_label.TabIndex = 154;
            this.Type_label.Text = "Тип:";
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Enabled = false;
            this.dateTimePicker.Location = new System.Drawing.Point(179, 221);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.RightToLeft = System.Windows.Forms.RightToLeft.No;
            this.dateTimePicker.Size = new System.Drawing.Size(249, 20);
            this.dateTimePicker.TabIndex = 189;
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Location = new System.Drawing.Point(45, 227);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(36, 13);
            this.Date_label.TabIndex = 188;
            this.Date_label.Text = "Дата:";
            // 
            // NumOfVictims_label
            // 
            this.NumOfVictims_label.AutoSize = true;
            this.NumOfVictims_label.Location = new System.Drawing.Point(45, 250);
            this.NumOfVictims_label.Name = "NumOfVictims_label";
            this.NumOfVictims_label.Size = new System.Drawing.Size(100, 13);
            this.NumOfVictims_label.TabIndex = 194;
            this.NumOfVictims_label.Text = "Количество жертв";
            // 
            // NumOfVictims_TextBox
            // 
            this.NumOfVictims_TextBox.Enabled = false;
            this.NumOfVictims_TextBox.Location = new System.Drawing.Point(179, 247);
            this.NumOfVictims_TextBox.Name = "NumOfVictims_TextBox";
            this.NumOfVictims_TextBox.Size = new System.Drawing.Size(249, 20);
            this.NumOfVictims_TextBox.TabIndex = 193;
            // 
            // Accident_view
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 514);
            this.Controls.Add(this.NumOfVictims_label);
            this.Controls.Add(this.NumOfVictims_TextBox);
            this.Controls.Add(this.dateTimePicker);
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.Type_textBox);
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
            this.Controls.Add(this.MembersOfAccident_dataGridView);
            this.Controls.Add(this.Members_label);
            this.Controls.Add(this.TopLabelAuto);
            this.MaximumSize = new System.Drawing.Size(493, 553);
            this.MinimumSize = new System.Drawing.Size(493, 553);
            this.Name = "Accident_view";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Просмотр";
            this.Load += new System.EventHandler(this.Accident_view_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MembersOfAccident_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label TopLabelAuto;
        private System.Windows.Forms.TextBox Reason_textBox;
        private System.Windows.Forms.Label Reason_label;
        private System.Windows.Forms.TextBox AmountOfDamage_textBox;
        private System.Windows.Forms.Label AmountOfDamage_label;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.DataGridView MembersOfAccident_dataGridView;
        private System.Windows.Forms.Label Members_label;
        private System.Windows.Forms.TextBox RoadConditions_textBox;
        private System.Windows.Forms.Label RoadConditions_label;
        private System.Windows.Forms.TextBox Area_textBox;
        private System.Windows.Forms.Label Area_label;
        private System.Windows.Forms.TextBox Type_textBox;
        private System.Windows.Forms.Label Type_label;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.Label NumOfVictims_label;
        private System.Windows.Forms.TextBox NumOfVictims_TextBox;
    }
}