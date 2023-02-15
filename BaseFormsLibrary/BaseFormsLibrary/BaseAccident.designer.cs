namespace BaseFormsLibrary
{
    partial class BaseAccident
    {
        /// <summary>
        ///  Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        ///  Clean up any resources being used.
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
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            this.membersLabel = new System.Windows.Forms.Label();
            this.typeLabel = new System.Windows.Forms.Label();
            this.victimsLabel = new System.Windows.Forms.Label();
            this.dateLabel = new System.Windows.Forms.Label();
            this.areaLabel = new System.Windows.Forms.Label();
            this.roadConditionsLabel = new System.Windows.Forms.Label();
            this.reasonLabel = new System.Windows.Forms.Label();
            this.damageAmountLabel = new System.Windows.Forms.Label();
            this.victimsTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.dateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.areaTextBox = new System.Windows.Forms.TextBox();
            this.roadConditionsTextBox = new System.Windows.Forms.TextBox();
            this.reasonTextBox = new System.Windows.Forms.TextBox();
            this.damageAmountTextBox = new System.Windows.Forms.TextBox();
            this.currVehiclesDataGridView = new System.Windows.Forms.DataGridView();
            this.exitButton = new System.Windows.Forms.Button();
            this.topLabel = new System.Windows.Forms.Label();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.currVehiclesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // membersLabel
            // 
            this.membersLabel.AutoSize = true;
            this.membersLabel.Location = new System.Drawing.Point(25, 265);
            this.membersLabel.Name = "membersLabel";
            this.membersLabel.Size = new System.Drawing.Size(160, 13);
            this.membersLabel.TabIndex = 239;
            this.membersLabel.Text = "Участники автопроисшествия";
            // 
            // typeLabel
            // 
            this.typeLabel.AutoSize = true;
            this.typeLabel.Location = new System.Drawing.Point(25, 177);
            this.typeLabel.Name = "typeLabel";
            this.typeLabel.Size = new System.Drawing.Size(29, 13);
            this.typeLabel.TabIndex = 238;
            this.typeLabel.Text = "Тип:";
            // 
            // victimsLabel
            // 
            this.victimsLabel.AutoSize = true;
            this.victimsLabel.Location = new System.Drawing.Point(25, 204);
            this.victimsLabel.Name = "victimsLabel";
            this.victimsLabel.Size = new System.Drawing.Size(100, 13);
            this.victimsLabel.TabIndex = 237;
            this.victimsLabel.Text = "Количество жертв";
            // 
            // dateLabel
            // 
            this.dateLabel.AutoSize = true;
            this.dateLabel.Location = new System.Drawing.Point(25, 233);
            this.dateLabel.Name = "dateLabel";
            this.dateLabel.Size = new System.Drawing.Size(36, 13);
            this.dateLabel.TabIndex = 236;
            this.dateLabel.Text = "Дата:";
            // 
            // areaLabel
            // 
            this.areaLabel.AutoSize = true;
            this.areaLabel.Location = new System.Drawing.Point(25, 149);
            this.areaLabel.Name = "areaLabel";
            this.areaLabel.Size = new System.Drawing.Size(70, 13);
            this.areaLabel.TabIndex = 235;
            this.areaLabel.Text = "Территория:";
            // 
            // roadConditionsLabel
            // 
            this.roadConditionsLabel.AutoSize = true;
            this.roadConditionsLabel.Location = new System.Drawing.Point(25, 123);
            this.roadConditionsLabel.Name = "roadConditionsLabel";
            this.roadConditionsLabel.Size = new System.Drawing.Size(109, 13);
            this.roadConditionsLabel.TabIndex = 234;
            this.roadConditionsLabel.Text = "Дорожные условия:";
            // 
            // reasonLabel
            // 
            this.reasonLabel.AutoSize = true;
            this.reasonLabel.Location = new System.Drawing.Point(25, 71);
            this.reasonLabel.Name = "reasonLabel";
            this.reasonLabel.Size = new System.Drawing.Size(93, 13);
            this.reasonLabel.TabIndex = 233;
            this.reasonLabel.Text = "Обстоятельства:";
            // 
            // damageAmountLabel
            // 
            this.damageAmountLabel.AutoSize = true;
            this.damageAmountLabel.Location = new System.Drawing.Point(25, 97);
            this.damageAmountLabel.Name = "damageAmountLabel";
            this.damageAmountLabel.Size = new System.Drawing.Size(76, 13);
            this.damageAmountLabel.TabIndex = 232;
            this.damageAmountLabel.Text = "Сумма урона:";
            // 
            // victimsTextBox
            // 
            this.victimsTextBox.Location = new System.Drawing.Point(146, 201);
            this.victimsTextBox.Name = "victimsTextBox";
            this.victimsTextBox.Size = new System.Drawing.Size(286, 20);
            this.victimsTextBox.TabIndex = 231;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(147, 174);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(286, 21);
            this.typeComboBox.TabIndex = 230;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Location = new System.Drawing.Point(146, 227);
            this.dateDateTimePicker.Name = "dateDateTimePicker";
            this.dateDateTimePicker.Size = new System.Drawing.Size(286, 20);
            this.dateDateTimePicker.TabIndex = 229;
            // 
            // areaTextBox
            // 
            this.areaTextBox.Location = new System.Drawing.Point(147, 146);
            this.areaTextBox.Name = "areaTextBox";
            this.areaTextBox.Size = new System.Drawing.Size(286, 20);
            this.areaTextBox.TabIndex = 228;
            // 
            // roadConditionsTextBox
            // 
            this.roadConditionsTextBox.Location = new System.Drawing.Point(147, 120);
            this.roadConditionsTextBox.Name = "roadConditionsTextBox";
            this.roadConditionsTextBox.Size = new System.Drawing.Size(286, 20);
            this.roadConditionsTextBox.TabIndex = 227;
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.Location = new System.Drawing.Point(147, 68);
            this.reasonTextBox.Name = "reasonTextBox";
            this.reasonTextBox.Size = new System.Drawing.Size(286, 20);
            this.reasonTextBox.TabIndex = 226;
            // 
            // damageAmountTextBox
            // 
            this.damageAmountTextBox.Location = new System.Drawing.Point(147, 94);
            this.damageAmountTextBox.Name = "damageAmountTextBox";
            this.damageAmountTextBox.Size = new System.Drawing.Size(286, 20);
            this.damageAmountTextBox.TabIndex = 225;
            // 
            // currVehiclesDataGridView
            // 
            this.currVehiclesDataGridView.AllowUserToAddRows = false;
            this.currVehiclesDataGridView.AllowUserToDeleteRows = false;
            this.currVehiclesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.currVehiclesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.currVehiclesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.currVehiclesDataGridView.Location = new System.Drawing.Point(28, 281);
            this.currVehiclesDataGridView.MultiSelect = false;
            this.currVehiclesDataGridView.Name = "currVehiclesDataGridView";
            this.currVehiclesDataGridView.ReadOnly = true;
            this.currVehiclesDataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            this.currVehiclesDataGridView.RowsDefaultCellStyle = dataGridViewCellStyle1;
            this.currVehiclesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.currVehiclesDataGridView.Size = new System.Drawing.Size(404, 139);
            this.currVehiclesDataGridView.TabIndex = 224;
            this.currVehiclesDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.currVehiclesDataGridViewCellMouseDoubleClick);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(297, 483);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(135, 23);
            this.exitButton.TabIndex = 223;
            this.exitButton.Text = "Закрыть форму";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F);
            this.topLabel.Location = new System.Drawing.Point(161, 20);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(186, 24);
            this.topLabel.TabIndex = 222;
            this.topLabel.Text = "Автопроисшествия\n";
            this.topLabel.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // BaseAccident
            // 
            this.ClientSize = new System.Drawing.Size(467, 529);
            this.Controls.Add(this.membersLabel);
            this.Controls.Add(this.typeLabel);
            this.Controls.Add(this.victimsLabel);
            this.Controls.Add(this.dateLabel);
            this.Controls.Add(this.areaLabel);
            this.Controls.Add(this.roadConditionsLabel);
            this.Controls.Add(this.reasonLabel);
            this.Controls.Add(this.damageAmountLabel);
            this.Controls.Add(this.victimsTextBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(this.dateDateTimePicker);
            this.Controls.Add(this.areaTextBox);
            this.Controls.Add(this.roadConditionsTextBox);
            this.Controls.Add(this.reasonTextBox);
            this.Controls.Add(this.damageAmountTextBox);
            this.Controls.Add(this.currVehiclesDataGridView);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.topLabel);
            this.Name = "BaseAccident";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.currVehiclesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private System.Windows.Forms.Label membersLabel;
        private System.Windows.Forms.Label typeLabel;
        private System.Windows.Forms.Label victimsLabel;
        private System.Windows.Forms.Label dateLabel;
        private System.Windows.Forms.Label areaLabel;
        private System.Windows.Forms.Label roadConditionsLabel;
        private System.Windows.Forms.Label reasonLabel;
        private System.Windows.Forms.Label damageAmountLabel;
        protected System.Windows.Forms.TextBox victimsTextBox;
        protected System.Windows.Forms.ComboBox typeComboBox;
        protected System.Windows.Forms.DateTimePicker dateDateTimePicker;
        protected System.Windows.Forms.TextBox areaTextBox;
        protected System.Windows.Forms.TextBox roadConditionsTextBox;
        protected System.Windows.Forms.TextBox reasonTextBox;
        protected System.Windows.Forms.TextBox damageAmountTextBox;
        protected System.Windows.Forms.Button exitButton;
        protected System.Windows.Forms.Label topLabel;
        protected System.Windows.Forms.ErrorProvider errorProvider;
        public System.Windows.Forms.DataGridView currVehiclesDataGridView;
    }
    
}