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
            this.mainCrystalReportViewer = new CrystalDecisions.Windows.Forms.CrystalReportViewer();
            this.endDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.startDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.loadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainCrystalReportViewer
            // 
            this.mainCrystalReportViewer.ActiveViewIndex = -1;
            this.mainCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainCrystalReportViewer.Location = new System.Drawing.Point(5, 38);
            this.mainCrystalReportViewer.Name = "mainCrystalReportViewer";
            this.mainCrystalReportViewer.Size = new System.Drawing.Size(1009, 492);
            this.mainCrystalReportViewer.TabIndex = 0;
            this.mainCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // endDateDateTimePicker
            // 
            this.endDateDateTimePicker.Location = new System.Drawing.Point(295, 12);
            this.endDateDateTimePicker.Name = "endDateDateTimePicker";
            this.endDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.endDateDateTimePicker.TabIndex = 1;
            // 
            // startDateDateTimePicker
            // 
            this.startDateDateTimePicker.Location = new System.Drawing.Point(60, 12);
            this.startDateDateTimePicker.Name = "startDateDateTimePicker";
            this.startDateDateTimePicker.Size = new System.Drawing.Size(200, 20);
            this.startDateDateTimePicker.TabIndex = 2;
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(541, 9);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(111, 23);
            this.loadButton.TabIndex = 3;
            this.loadButton.Text = "Сформировать";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.load_button_Click);
            // 
            // AccidentsReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1023, 536);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.startDateDateTimePicker);
            this.Controls.Add(this.endDateDateTimePicker);
            this.Controls.Add(this.mainCrystalReportViewer);
            this.Name = "AccidentsReport";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.Accidents_Report_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer mainCrystalReportViewer;
        private System.Windows.Forms.DateTimePicker endDateDateTimePicker;
        private System.Windows.Forms.DateTimePicker startDateDateTimePicker;
        private System.Windows.Forms.Button loadButton;
    }
}