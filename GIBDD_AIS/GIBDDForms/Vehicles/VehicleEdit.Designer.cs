namespace GIBDD_AIS.GIBDDForms.Vehicles
{
    partial class VehicleEdit
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
            this.saveButton = new System.Windows.Forms.Button();
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.searchLabel = new System.Windows.Forms.Label();
            this.deleteButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(328, 638);
            this.exitButton.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(160, 637);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(127, 34);
            this.saveButton.TabIndex = 329;
            this.saveButton.Text = "Сохранить изменения";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButtonClick);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(140, 597);
            this.searchTextBox.MaxLength = 100;
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(282, 20);
            this.searchTextBox.TabIndex = 328;
            this.searchTextBox.TextChanged += new System.EventHandler(this.searchTextBoxTextChanged);
            // 
            // searchLabel
            // 
            this.searchLabel.AutoSize = true;
            this.searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchLabel.Location = new System.Drawing.Point(31, 600);
            this.searchLabel.Name = "searchLabel";
            this.searchLabel.Size = new System.Drawing.Size(103, 17);
            this.searchLabel.TabIndex = 327;
            this.searchLabel.Text = "Поиск по фио:";
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(34, 638);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(108, 34);
            this.deleteButton.TabIndex = 326;
            this.deleteButton.Text = "Удалить запись";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButtonClick);
            // 
            // VehicleEdit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(454, 683);
            this.Controls.Add(this.saveButton);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.searchLabel);
            this.Controls.Add(this.deleteButton);
            this.MaximumSize = new System.Drawing.Size(470, 722);
            this.MinimumSize = new System.Drawing.Size(470, 722);
            this.Name = "VehicleEdit";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VehicleEditFormClosed);
            this.Load += new System.EventHandler(this.VehicleEditLoad);
            this.Controls.SetChildIndex(this.exitButton, 0);
            this.Controls.SetChildIndex(this.topAutoLabel, 0);
            this.Controls.SetChildIndex(this.wantedLabel, 0);
            this.Controls.SetChildIndex(this.wantedCheckBox, 0);
            this.Controls.SetChildIndex(this.typeComboBox, 0);
            this.Controls.SetChildIndex(this.engineVolumeTextBox, 0);
            this.Controls.SetChildIndex(this.releaseDateDateTimePicker, 0);
            this.Controls.SetChildIndex(this.engineNumberTextBox, 0);
            this.Controls.SetChildIndex(this.chasisNumberTextBox, 0);
            this.Controls.SetChildIndex(this.colorTextBox, 0);
            this.Controls.SetChildIndex(this.lastTIDateTimePicker, 0);
            this.Controls.SetChildIndex(this.numberTextBox, 0);
            this.Controls.SetChildIndex(this.bodyNumberTextBox, 0);
            this.Controls.SetChildIndex(this.brandTextBox, 0);
            this.Controls.SetChildIndex(this.vinTextBox, 0);
            this.Controls.SetChildIndex(this.ownerLabel, 0);
            this.Controls.SetChildIndex(this.currOwnerLabel, 0);
            this.Controls.SetChildIndex(this.deleteButton, 0);
            this.Controls.SetChildIndex(this.searchLabel, 0);
            this.Controls.SetChildIndex(this.searchTextBox, 0);
            this.Controls.SetChildIndex(this.saveButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label searchLabel;
        private System.Windows.Forms.Button deleteButton;
    }
}
