﻿namespace GIBDD_AIS.GIBDDForms.Accidents
{
    partial class AccidentView
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
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // victimsTextBox
            // 
            this.victimsTextBox.ReadOnly = true;
            // 
            // typeComboBox
            // 
            this.typeComboBox.Enabled = false;
            // 
            // dateDateTimePicker
            // 
            this.dateDateTimePicker.Enabled = false;
            // 
            // areaTextBox
            // 
            this.areaTextBox.ReadOnly = true;
            // 
            // roadConditionsTextBox
            // 
            this.roadConditionsTextBox.ReadOnly = true;
            // 
            // reasonTextBox
            // 
            this.reasonTextBox.ReadOnly = true;
            // 
            // damageAmountTextBox
            // 
            this.damageAmountTextBox.ReadOnly = true;
            // 
            // AccidentView
            // 
            this.ClientSize = new System.Drawing.Size(467, 529);
            this.Name = "AccidentView";
            this.Load += new System.EventHandler(this.AccidentViewLoad);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
    }
}
