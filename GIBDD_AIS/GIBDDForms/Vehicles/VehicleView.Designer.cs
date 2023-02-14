namespace GIBDD_AIS.GIBDDForms.Vehicles
{
    partial class VehicleView
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
            this.ownerInfoButton = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // currOwnerLabel
            // 
            this.currOwnerLabel.Enabled = false;
            this.currOwnerLabel.Visible = false;
            // 
            // ownerLabel
            // 
            this.ownerLabel.Size = new System.Drawing.Size(107, 13);
            this.ownerLabel.Text = "Автопроисшествия:";
            // 
            // vinTextBox
            // 
            this.vinTextBox.ReadOnly = true;
            // 
            // brandTextBox
            // 
            this.brandTextBox.ReadOnly = true;
            // 
            // bodyNumberTextBox
            // 
            this.bodyNumberTextBox.ReadOnly = true;
            // 
            // numberTextBox
            // 
            this.numberTextBox.ReadOnly = true;
            // 
            // lastTIDateTimePicker
            // 
            this.lastTIDateTimePicker.Enabled = false;
            // 
            // colorTextBox
            // 
            this.colorTextBox.ReadOnly = true;
            // 
            // chasisNumberTextBox
            // 
            this.chasisNumberTextBox.ReadOnly = true;
            // 
            // engineNumberTextBox
            // 
            this.engineNumberTextBox.ReadOnly = true;
            // 
            // releaseDateDateTimePicker
            // 
            this.releaseDateDateTimePicker.Enabled = false;
            // 
            // engineVolumeTextBox
            // 
            this.engineVolumeTextBox.ReadOnly = true;
            // 
            // typeComboBox
            // 
            this.typeComboBox.Enabled = false;
            // 
            // wantedCheckBox
            // 
            this.wantedCheckBox.Enabled = false;
            // 
            // exitButton
            // 
            this.exitButton.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // ownerInfoButton
            // 
            this.ownerInfoButton.Location = new System.Drawing.Point(40, 614);
            this.ownerInfoButton.Name = "ownerInfoButton";
            this.ownerInfoButton.Size = new System.Drawing.Size(231, 33);
            this.ownerInfoButton.TabIndex = 326;
            this.ownerInfoButton.Text = "Информация о владельце";
            this.ownerInfoButton.UseVisualStyleBackColor = true;
            this.ownerInfoButton.Click += new System.EventHandler(this.ownerInfoButtonClick);
            // 
            // VehicleView
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(454, 671);
            this.Controls.Add(this.ownerInfoButton);
            this.Name = "VehicleView";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.VehicleViewFormClosed);
            this.Load += new System.EventHandler(this.VehicleViewLoad);
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
            this.Controls.SetChildIndex(this.ownerInfoButton, 0);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button ownerInfoButton;
    }
}
