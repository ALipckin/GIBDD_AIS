namespace GIBDD_AIS.GIBDDForms.Accidents
{
    partial class AccidentInput
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(28, 483);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 23);
            this.saveButton.TabIndex = 241;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButtonClick);
            // 
            // AccidentInput
            // 
            this.ClientSize = new System.Drawing.Size(467, 529);
            this.Controls.Add(this.saveButton);
            this.Name = "AccidentInput";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.accidentInputFormClosed);
            this.Load += new System.EventHandler(this.AccidentInputLoad);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button saveButton;
    }
}
