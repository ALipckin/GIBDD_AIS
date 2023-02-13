namespace GIBDD_AIS.GIBDDForms.ReportsForms
{
    partial class TIAutosReport
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
            this.SuspendLayout();
            // 
            // mainCrystalReportViewer
            // 
            this.mainCrystalReportViewer.ActiveViewIndex = -1;
            this.mainCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainCrystalReportViewer.Dock = System.Windows.Forms.DockStyle.Fill;
            this.mainCrystalReportViewer.Location = new System.Drawing.Point(0, 0);
            this.mainCrystalReportViewer.Name = "mainCrystalReportViewer";
            this.mainCrystalReportViewer.Size = new System.Drawing.Size(1106, 628);
            this.mainCrystalReportViewer.TabIndex = 0;
            this.mainCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            // 
            // TIAutosReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1106, 628);
            this.Controls.Add(this.mainCrystalReportViewer);
            this.Name = "TIAutosReport";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.TIAutos_Report_Form_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer mainCrystalReportViewer;
    }
}