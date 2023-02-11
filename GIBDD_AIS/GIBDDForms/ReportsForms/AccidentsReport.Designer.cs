namespace GIBDD_AIS.GIBDDForms.ReportsForms.ReportData
{
    partial class AccidentsReport
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
            this.crystalReportViewer1 = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.EndD_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.StardD_dateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.load_button = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // crystalReportViewer1
            // 
            this.crystalReportViewer1.ActiveViewIndex = -1;
            this.crystalReportViewer1.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.crystalReportViewer1.Cursor = System.Windows.Forms.Cursors.Default;
            this.crystalReportViewer1.Location = new System.Drawing.Point(5, 38);
            this.crystalReportViewer1.Name = "crystalReportViewer1";
            this.crystalReportViewer1.Size = new System.Drawing.Size(1009, 492);
            this.crystalReportViewer1.TabIndex = 0;
            this.crystalReportViewer1.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // EndD_dateTimePicker
            // 
            this.EndD_dateTimePicker.Location = new System.Drawing.Point(295, 12);
            this.EndD_dateTimePicker.Name = "EndD_dateTimePicker";
            this.EndD_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.EndD_dateTimePicker.TabIndex = 1;
            // 
            // StardD_dateTimePicker
            // 
            this.StardD_dateTimePicker.Location = new System.Drawing.Point(60, 12);
            this.StardD_dateTimePicker.Name = "StardD_dateTimePicker";
            this.StardD_dateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.StardD_dateTimePicker.TabIndex = 2;
            // 
            // load_button
            // 
            this.load_button.Location = new System.Drawing.Point(541, 9);
            this.load_button.Name = "load_button";
            this.load_button.Size = new System.Drawing.Size(111, 23);
            this.load_button.TabIndex = 3;
            this.load_button.Text = "Сформировать";
            this.load_button.UseVisualStyleBackColor = true;
            this.load_button.Click += new System.EventHandler(this.load_button_Click);
            // 
            // Accidents_Report_Form
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 536);
            this.Controls.Add(this.load_button);
            this.Controls.Add(this.StardD_dateTimePicker);
            this.Controls.Add(this.EndD_dateTimePicker);
            this.Controls.Add(this.crystalReportViewer1);
            this.Name = "Accidents_Report_Form";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.Accidents_Report_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer crystalReportViewer1;
        private System.Windows.Forms.DateTimePicker EndD_dateTimePicker;
        private System.Windows.Forms.DateTimePicker StardD_dateTimePicker;
        private System.Windows.Forms.Button load_button;
    }
}