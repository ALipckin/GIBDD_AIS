namespace GIBDD_AIS.GIBDDForms.Owners
{
    partial class OwnerView
    {
        /// <summary>
        /// Обязательная переменная конструктора.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Освободить все используемые ресурсы.
        /// </summary>
        /// <param name="disposing">истинно, если управляемый ресурс должен быть удален; иначе ложно.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Код, автоматически созданный конструктором форм Windows

        /// <summary>
        /// Требуемый метод для поддержки конструктора — не изменяйте 
        /// содержимое этого метода с помощью редактора кода.
        /// </summary>
        private void InitializeComponent()
        {
            this.vehiclesDataGridView = new System.Windows.Forms.DataGridView();
            this.vehiclesLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // middleNameTextBox
            // 
            this.middleNameTextBox.MaxLength = 30;
            this.middleNameTextBox.ReadOnly = true;
            // 
            // nameTextBox
            // 
            this.nameTextBox.MaxLength = 30;
            this.nameTextBox.ReadOnly = true;
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(270, 445);
            // 
            // addressTextBox
            // 
            this.addressTextBox.MaxLength = 60;
            this.addressTextBox.ReadOnly = true;
            // 
            // surnameTextBox
            // 
            this.surnameTextBox.MaxLength = 30;
            this.surnameTextBox.ReadOnly = true;
            // 
            // birthDateDateTimePicker
            // 
            this.birthDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            this.birthDateDateTimePicker.Enabled = false;
            this.birthDateDateTimePicker.Format = System.Windows.Forms.DateTimePickerFormat.Custom;
            // 
            // vehiclesDataGridView
            // 
            this.vehiclesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vehiclesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.vehiclesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.vehiclesDataGridView.Enabled = false;
            this.vehiclesDataGridView.Location = new System.Drawing.Point(25, 276);
            this.vehiclesDataGridView.MultiSelect = false;
            this.vehiclesDataGridView.Name = "vehiclesDataGridView";
            this.vehiclesDataGridView.ReadOnly = true;
            this.vehiclesDataGridView.RowHeadersVisible = false;
            this.vehiclesDataGridView.Size = new System.Drawing.Size(380, 139);
            this.vehiclesDataGridView.TabIndex = 168;
            // 
            // vehiclesLabel
            // 
            this.vehiclesLabel.AutoSize = true;
            this.vehiclesLabel.Location = new System.Drawing.Point(134, 249);
            this.vehiclesLabel.Name = "vehiclesLabel";
            this.vehiclesLabel.Size = new System.Drawing.Size(135, 13);
            this.vehiclesLabel.TabIndex = 167;
            this.vehiclesLabel.Text = "Автомобили во владении";
            // 
            // OwnerView
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(426, 480);
            this.Controls.Add(this.vehiclesDataGridView);
            this.Controls.Add(this.vehiclesLabel);
            this.MaximumSize = new System.Drawing.Size(442, 519);
            this.Name = "OwnerView";
            this.Load += new System.EventHandler(this.OwnerViewLoad);
            this.Controls.SetChildIndex(this.topLabel, 0);
            this.Controls.SetChildIndex(this.surnameTextBox, 0);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.Controls.SetChildIndex(this.addressTextBox, 0);
            this.Controls.SetChildIndex(this.surnameLabel, 0);
            this.Controls.SetChildIndex(this.nameTextBox, 0);
            this.Controls.SetChildIndex(this.middleNameTextBox, 0);
            this.Controls.SetChildIndex(this.birthDateDateTimePicker, 0);
            this.Controls.SetChildIndex(this.vehiclesLabel, 0);
            this.Controls.SetChildIndex(this.vehiclesDataGridView, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView vehiclesDataGridView;
        private System.Windows.Forms.Label vehiclesLabel;
    }
}
