namespace GIBDD_AIS.GIBDDForms.ReportsForms
{
    partial class StolenAutoReport
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
            this.searchTextBox = new System.Windows.Forms.TextBox();
            this.numberLabel = new System.Windows.Forms.Label();
            this.loadButton = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // mainCrystalReportViewer
            // 
            this.mainCrystalReportViewer.ActiveViewIndex = -1;
            this.mainCrystalReportViewer.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.mainCrystalReportViewer.Cursor = System.Windows.Forms.Cursors.Default;
            this.mainCrystalReportViewer.Location = new System.Drawing.Point(0, 38);
            this.mainCrystalReportViewer.Name = "mainCrystalReportViewer";
            this.mainCrystalReportViewer.Size = new System.Drawing.Size(1013, 478);
            this.mainCrystalReportViewer.TabIndex = 0;
            this.mainCrystalReportViewer.ToolPanelView = CrystalDecisions.Windows.Forms.ToolPanelViewType.None;
            this.mainCrystalReportViewer.Load += new System.EventHandler(this.crystalReportViewer1_Load);
            // 
            // searchTextBox
            // 
            this.searchTextBox.Location = new System.Drawing.Point(109, 12);
            this.searchTextBox.Name = "searchTextBox";
            this.searchTextBox.Size = new System.Drawing.Size(196, 20);
            this.searchTextBox.TabIndex = 1;
            // 
            // numberLabel
            // 
            this.numberLabel.AutoSize = true;
            this.numberLabel.Location = new System.Drawing.Point(35, 15);
            this.numberLabel.Name = "numberLabel";
            this.numberLabel.Size = new System.Drawing.Size(68, 13);
            this.numberLabel.TabIndex = 2;
            this.numberLabel.Text = "Гос. Номер:";
            // 
            // loadButton
            // 
            this.loadButton.Location = new System.Drawing.Point(339, 10);
            this.loadButton.Name = "loadButton";
            this.loadButton.Size = new System.Drawing.Size(128, 23);
            this.loadButton.TabIndex = 4;
            this.loadButton.Text = "Сформировать";
            this.loadButton.UseVisualStyleBackColor = true;
            this.loadButton.Click += new System.EventHandler(this.load_button_Click);
            // 
            // StolenAutoReport
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1013, 516);
            this.Controls.Add(this.loadButton);
            this.Controls.Add(this.numberLabel);
            this.Controls.Add(this.searchTextBox);
            this.Controls.Add(this.mainCrystalReportViewer);
            this.Name = "StolenAutoReport";
            this.Text = "Отчет";
            this.Load += new System.EventHandler(this.StolenAuto_ReportForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private CrystalDecisions.Windows.Forms.CrystalReportViewer mainCrystalReportViewer;
        private System.Windows.Forms.TextBox searchTextBox;
        private System.Windows.Forms.Label numberLabel;
        private System.Windows.Forms.Button loadButton;
    }
}