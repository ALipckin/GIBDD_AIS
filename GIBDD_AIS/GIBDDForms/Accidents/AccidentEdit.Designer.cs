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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // exitButton
            // 
            this.exitButton.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // deleteButton
            // 
            this.deleteButton.Location = new System.Drawing.Point(39, 483);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(114, 23);
            this.deleteButton.TabIndex = 241;
            this.deleteButton.Text = "Удалить";
            this.deleteButton.UseVisualStyleBackColor = true;
            this.deleteButton.Click += new System.EventHandler(this.deleteButtonClick);
            // 
            // saveButton
            // 
            this.saveButton.Location = new System.Drawing.Point(165, 483);
            this.saveButton.Name = "saveButton";
            this.saveButton.Size = new System.Drawing.Size(106, 23);
            this.saveButton.TabIndex = 240;
            this.saveButton.Text = "Сохранить";
            this.saveButton.UseVisualStyleBackColor = true;
            this.saveButton.Click += new System.EventHandler(this.saveButtonClick);
            // 
            // AccidentEdit
            // 
            this.ClientSize = new System.Drawing.Size(467, 529);
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button saveButton;
    }
}
