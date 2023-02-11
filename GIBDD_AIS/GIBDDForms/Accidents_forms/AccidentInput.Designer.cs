namespace GIBDD_AIS.GIBDDForms.Accidents_forms
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
            this._saveButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(145, 482);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(141, 23);
            this._saveButton.TabIndex = 224;
            this._saveButton.Text = "Сохранить";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this._saveButton_Click);
            // 
            // AccidentInput
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.ClientSize = new System.Drawing.Size(481, 532);
            this.Controls.Add(this._saveButton);
            this.Name = "AccidentInput";
            this.Text = "Ввод";
            this.Load += new System.EventHandler(this.AccidentInput_Load);
            this.Controls.SetChildIndex(this._saveButton, 0);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button _saveButton;
    }
}
