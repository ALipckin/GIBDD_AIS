namespace GIBDD_AIS.GIBDDForms.Accidents
{
    partial class AccidentEdit
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
            this.deleteButton = new System.Windows.Forms.Button();
            this.saveButton = new System.Windows.Forms.Button();
            this.newVehiclesDataGridView = new System.Windows.Forms.DataGridView();
            this.chooseLabel = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVehiclesDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(286, 633);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(28, 633);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(114, 23);
            this.deleteButton.TabIndex = 241;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButtonClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(154, 633);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 23);
            this.saveButton.TabIndex = 240;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButtonClick);
            // 
            // newVehiclesDataGridView
            // 
            this.newVehiclesDataGridView.AllowUserToAddRows = false;
            this.newVehiclesDataGridView.AllowUserToDeleteRows = false;
            this.newVehiclesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.newVehiclesDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.newVehiclesDataGridView.Location = new System.Drawing.Point(28, 450);
            this.newVehiclesDataGridView.MultiSelect = false;
            this.newVehiclesDataGridView.Name = "newVehiclesDataGridView";
            this.newVehiclesDataGridView.ReadOnly = true;
            this.newVehiclesDataGridView.RowHeadersVisible = false;
            this.newVehiclesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.newVehiclesDataGridView.Size = new System.Drawing.Size(405, 150);
            this.newVehiclesDataGridView.TabIndex = 242;
            this.newVehiclesDataGridView.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.newVehiclesDataGridViewCellMouseDoubleClick);
            // 
            // chooseLabel
            // 
            this.chooseLabel.AutoSize = true;
            this.chooseLabel.Location = new System.Drawing.Point(28, 431);
            this.chooseLabel.Name = "chooseLabel";
            this.chooseLabel.Size = new System.Drawing.Size(149, 13);
            this.chooseLabel.TabIndex = 243;
            this.chooseLabel.Text = "Выберите нового участника";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(332, 431);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(101, 13);
            this.label1.TabIndex = 244;
            this.label1.Text = "- двойное нажатие";
            // 
            // AccidentEdit
            // 
            this.ClientSize = new System.Drawing.Size(467, 668);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.chooseLabel);
            this.Controls.Add(this.newVehiclesDataGridView);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.saveButton);
            this.Name = "AccidentEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.accidentEditFormClosed);
            this.Load += new System.EventHandler(this.AccidentEditLoad);
            this.Controls.SetChildIndex(this.topLabel, 0);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.Controls.SetChildIndex(this.damageAmountTextBox, 0);
            this.Controls.SetChildIndex(this.reasonTextBox, 0);
            this.Controls.SetChildIndex(this.roadConditionsTextBox, 0);
            this.Controls.SetChildIndex(this.areaTextBox, 0);
            this.Controls.SetChildIndex(this.dateDateTimePicker, 0);
            this.Controls.SetChildIndex(this.typeComboBox, 0);
            this.Controls.SetChildIndex(this.victimsTextBox, 0);
            this.Controls.SetChildIndex(this.saveButton, 0);
            this.Controls.SetChildIndex(this.deleteButton, 0);
            this.Controls.SetChildIndex(this.newVehiclesDataGridView, 0);
            this.Controls.SetChildIndex(this.chooseLabel, 0);
            this.Controls.SetChildIndex(this.label1, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.newVehiclesDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.DataGridView newVehiclesDataGridView;
        private System.Windows.Forms.Label chooseLabel;
        private System.Windows.Forms.Label label1;
    }
}
