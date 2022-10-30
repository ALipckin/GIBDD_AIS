namespace GIBDD_AIS.GIBDD_Forms.Accidents_forms
{
    partial class Accident_input
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
            this.exit_button = new System.Windows.Forms.Button();
            this.TopLabelAuto = new System.Windows.Forms.Label();
            this.create_button = new System.Windows.Forms.Button();
            this.MembersOfAccident_dataGridView = new System.Windows.Forms.DataGridView();
            this.Members_label = new System.Windows.Forms.Label();
            this.Type_comboBox = new System.Windows.Forms.ComboBox();
            this.dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.Type_label = new System.Windows.Forms.Label();
            this.Area_textBox = new System.Windows.Forms.TextBox();
            this.Area_label = new System.Windows.Forms.Label();
            this.RoadConditions_textBox = new System.Windows.Forms.TextBox();
            this.RoadConditions_label = new System.Windows.Forms.Label();
            this.Reason_textBox = new System.Windows.Forms.TextBox();
            this.Reason_label = new System.Windows.Forms.Label();
            this.AmountOfDamage_textBox = new System.Windows.Forms.TextBox();
            this.AmountOfDamage_label = new System.Windows.Forms.Label();
            this.Date_label = new System.Windows.Forms.Label();
            this.NumOfVictims_TextBox = new System.Windows.Forms.TextBox();
            this.NumOfVictims_label = new System.Windows.Forms.Label();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.MembersOfAccident_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(280, 491);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(135, 23);
            this.exit_button.TabIndex = 162;
            this.exit_button.Text = "Закрыть форму";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // TopLabelAuto
            // 
            this.TopLabelAuto.AutoSize = true;
            this.TopLabelAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabelAuto.Location = new System.Drawing.Point(134, 18);
            this.TopLabelAuto.Name = "TopLabelAuto";
            this.TopLabelAuto.Size = new System.Drawing.Size(186, 48);
            this.TopLabelAuto.TabIndex = 156;
            this.TopLabelAuto.Text = "Автопроисшествия\r\n(ввод)\r\n";
            this.TopLabelAuto.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // create_button
            // 
            this.create_button.Location = new System.Drawing.Point(35, 491);
            this.create_button.Name = "create_button";
            this.create_button.Size = new System.Drawing.Size(119, 23);
            this.create_button.TabIndex = 173;
            this.create_button.Text = "Сохранить";
            this.create_button.UseVisualStyleBackColor = true;
            this.create_button.Click += new System.EventHandler(this.create_button_Click);
            // 
            // MembersOfAccident_dataGridView
            // 
            this.MembersOfAccident_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.MembersOfAccident_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.MembersOfAccident_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.MembersOfAccident_dataGridView.Location = new System.Drawing.Point(24, 293);
            this.MembersOfAccident_dataGridView.Name = "MembersOfAccident_dataGridView";
            this.MembersOfAccident_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.MembersOfAccident_dataGridView.Size = new System.Drawing.Size(428, 139);
            this.MembersOfAccident_dataGridView.TabIndex = 175;
            // 
            // Members_label
            // 
            this.Members_label.AutoSize = true;
            this.Members_label.Location = new System.Drawing.Point(21, 277);
            this.Members_label.Name = "Members_label";
            this.Members_label.Size = new System.Drawing.Size(147, 13);
            this.Members_label.TabIndex = 174;
            this.Members_label.Text = "Авто участвовавшее в ДТП";
            // 
            // Type_comboBox
            // 
            this.Type_comboBox.FormattingEnabled = true;
            this.Type_comboBox.Location = new System.Drawing.Point(154, 186);
            this.Type_comboBox.Name = "Type_comboBox";
            this.Type_comboBox.Size = new System.Drawing.Size(286, 21);
            this.Type_comboBox.TabIndex = 188;
            // 
            // dateTimePicker
            // 
            this.dateTimePicker.Location = new System.Drawing.Point(154, 213);
            this.dateTimePicker.Name = "dateTimePicker";
            this.dateTimePicker.Size = new System.Drawing.Size(286, 20);
            this.dateTimePicker.TabIndex = 187;
            // 
            // Type_label
            // 
            this.Type_label.AutoSize = true;
            this.Type_label.Location = new System.Drawing.Point(19, 194);
            this.Type_label.Name = "Type_label";
            this.Type_label.Size = new System.Drawing.Size(29, 13);
            this.Type_label.TabIndex = 186;
            this.Type_label.Text = "Тип:";
            // 
            // Area_textBox
            // 
            this.Area_textBox.Location = new System.Drawing.Point(154, 158);
            this.Area_textBox.Name = "Area_textBox";
            this.Area_textBox.Size = new System.Drawing.Size(286, 20);
            this.Area_textBox.TabIndex = 185;
            // 
            // Area_label
            // 
            this.Area_label.AutoSize = true;
            this.Area_label.Location = new System.Drawing.Point(19, 165);
            this.Area_label.Name = "Area_label";
            this.Area_label.Size = new System.Drawing.Size(70, 13);
            this.Area_label.TabIndex = 184;
            this.Area_label.Text = "Территория:";
            // 
            // RoadConditions_textBox
            // 
            this.RoadConditions_textBox.Location = new System.Drawing.Point(154, 132);
            this.RoadConditions_textBox.Name = "RoadConditions_textBox";
            this.RoadConditions_textBox.Size = new System.Drawing.Size(286, 20);
            this.RoadConditions_textBox.TabIndex = 183;
            // 
            // RoadConditions_label
            // 
            this.RoadConditions_label.AutoSize = true;
            this.RoadConditions_label.Location = new System.Drawing.Point(19, 139);
            this.RoadConditions_label.Name = "RoadConditions_label";
            this.RoadConditions_label.Size = new System.Drawing.Size(109, 13);
            this.RoadConditions_label.TabIndex = 182;
            this.RoadConditions_label.Text = "Дорожные условия:";
            // 
            // Reason_textBox
            // 
            this.Reason_textBox.Location = new System.Drawing.Point(154, 80);
            this.Reason_textBox.Name = "Reason_textBox";
            this.Reason_textBox.Size = new System.Drawing.Size(286, 20);
            this.Reason_textBox.TabIndex = 181;
            // 
            // Reason_label
            // 
            this.Reason_label.AutoSize = true;
            this.Reason_label.Location = new System.Drawing.Point(19, 87);
            this.Reason_label.Name = "Reason_label";
            this.Reason_label.Size = new System.Drawing.Size(93, 13);
            this.Reason_label.TabIndex = 180;
            this.Reason_label.Text = "Обстоятельства:";
            // 
            // AmountOfDamage_textBox
            // 
            this.AmountOfDamage_textBox.Location = new System.Drawing.Point(154, 106);
            this.AmountOfDamage_textBox.Name = "AmountOfDamage_textBox";
            this.AmountOfDamage_textBox.Size = new System.Drawing.Size(286, 20);
            this.AmountOfDamage_textBox.TabIndex = 179;
            // 
            // AmountOfDamage_label
            // 
            this.AmountOfDamage_label.AutoSize = true;
            this.AmountOfDamage_label.Location = new System.Drawing.Point(19, 113);
            this.AmountOfDamage_label.Name = "AmountOfDamage_label";
            this.AmountOfDamage_label.Size = new System.Drawing.Size(76, 13);
            this.AmountOfDamage_label.TabIndex = 178;
            this.AmountOfDamage_label.Text = "Сумма урона:";
            // 
            // Date_label
            // 
            this.Date_label.AutoSize = true;
            this.Date_label.Location = new System.Drawing.Point(19, 219);
            this.Date_label.Name = "Date_label";
            this.Date_label.Size = new System.Drawing.Size(36, 13);
            this.Date_label.TabIndex = 177;
            this.Date_label.Text = "Дата:";
            // 
            // NumOfVictims_TextBox
            // 
            this.NumOfVictims_TextBox.Location = new System.Drawing.Point(154, 239);
            this.NumOfVictims_TextBox.Name = "NumOfVictims_TextBox";
            this.NumOfVictims_TextBox.Size = new System.Drawing.Size(286, 20);
            this.NumOfVictims_TextBox.TabIndex = 189;
            // 
            // NumOfVictims_label
            // 
            this.NumOfVictims_label.AutoSize = true;
            this.NumOfVictims_label.Location = new System.Drawing.Point(20, 242);
            this.NumOfVictims_label.Name = "NumOfVictims_label";
            this.NumOfVictims_label.Size = new System.Drawing.Size(100, 13);
            this.NumOfVictims_label.TabIndex = 190;
            this.NumOfVictims_label.Text = "Количество жертв";
            // 
            // errorProvider1
            // 
            this.errorProvider1.ContainerControl = this;
            // 
            // Accident_input
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(464, 524);
            this.Controls.Add(this.NumOfVictims_label);
            this.Controls.Add(this.NumOfVictims_TextBox);
            this.Controls.Add(this.Type_comboBox);
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
            this.Controls.Add(this.Date_label);
            this.Controls.Add(this.MembersOfAccident_dataGridView);
            this.Controls.Add(this.Members_label);
            this.Controls.Add(this.create_button);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.TopLabelAuto);
            this.MaximumSize = new System.Drawing.Size(480, 563);
            this.MinimumSize = new System.Drawing.Size(480, 563);
            this.Name = "Accident_input";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ввод";
            this.Load += new System.EventHandler(this.Accident_input_Load);
            ((System.ComponentModel.ISupportInitialize)(this.MembersOfAccident_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label TopLabelAuto;
        private System.Windows.Forms.Button create_button;
        private System.Windows.Forms.DataGridView MembersOfAccident_dataGridView;
        private System.Windows.Forms.Label Members_label;
        private System.Windows.Forms.ComboBox Type_comboBox;
        private System.Windows.Forms.DateTimePicker dateTimePicker;
        private System.Windows.Forms.Label Type_label;
        private System.Windows.Forms.TextBox Area_textBox;
        private System.Windows.Forms.Label Area_label;
        private System.Windows.Forms.TextBox RoadConditions_textBox;
        private System.Windows.Forms.Label RoadConditions_label;
        private System.Windows.Forms.TextBox Reason_textBox;
        private System.Windows.Forms.Label Reason_label;
        private System.Windows.Forms.TextBox AmountOfDamage_textBox;
        private System.Windows.Forms.Label AmountOfDamage_label;
        private System.Windows.Forms.Label Date_label;
        private System.Windows.Forms.TextBox NumOfVictims_TextBox;
        private System.Windows.Forms.Label NumOfVictims_label;
        private System.Windows.Forms.ErrorProvider errorProvider1;
    }
}