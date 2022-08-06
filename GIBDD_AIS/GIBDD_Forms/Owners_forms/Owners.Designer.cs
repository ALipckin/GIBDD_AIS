namespace GIBDD_AIS
{
    partial class Owners
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
            this.bD_GIBDDDataSet1 = new GIBDD_AIS.BD_GIBDDDataSet();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Owners_dataGridView = new System.Windows.Forms.DataGridView();
            this.SearchName_TextBox = new System.Windows.Forms.TextBox();
            this.SearchName_label = new System.Windows.Forms.Label();
            this.View_button = new System.Windows.Forms.Button();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Owners_label = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.TopLabelAuto = new System.Windows.Forms.Label();
            this.inputNewOwner_button = new System.Windows.Forms.Button();
            this.Accidents_dataGridView = new System.Windows.Forms.DataGridView();
            this.Accidents_label = new System.Windows.Forms.Label();
            this.ViewAccidents_button = new System.Windows.Forms.Button();
            this.panel2 = new System.Windows.Forms.Panel();
            ((System.ComponentModel.ISupportInitialize)(this.bD_GIBDDDataSet1)).BeginInit();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Owners_dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Accidents_dataGridView)).BeginInit();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // bD_GIBDDDataSet1
            // 
            this.bD_GIBDDDataSet1.DataSetName = "BD_GIBDDDataSet";
            this.bD_GIBDDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Owners_dataGridView);
            this.panel1.Controls.Add(this.SearchName_TextBox);
            this.panel1.Controls.Add(this.SearchName_label);
            this.panel1.Controls.Add(this.View_button);
            this.panel1.Controls.Add(this.Edit_button);
            this.panel1.Controls.Add(this.Owners_label);
            this.panel1.Location = new System.Drawing.Point(26, 49);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(377, 312);
            this.panel1.TabIndex = 0;
            // 
            // Owners_dataGridView
            // 
            this.Owners_dataGridView.AllowUserToAddRows = false;
            this.Owners_dataGridView.AllowUserToDeleteRows = false;
            this.Owners_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Owners_dataGridView.Location = new System.Drawing.Point(24, 50);
            this.Owners_dataGridView.Name = "Owners_dataGridView";
            this.Owners_dataGridView.ReadOnly = true;
            this.Owners_dataGridView.Size = new System.Drawing.Size(301, 138);
            this.Owners_dataGridView.TabIndex = 148;
            this.Owners_dataGridView.SelectionChanged += new System.EventHandler(this.Owners_dataGridView_SelectionChanged);
            // 
            // SearchName_TextBox
            // 
            this.SearchName_TextBox.Location = new System.Drawing.Point(194, 194);
            this.SearchName_TextBox.Name = "SearchName_TextBox";
            this.SearchName_TextBox.Size = new System.Drawing.Size(150, 20);
            this.SearchName_TextBox.TabIndex = 150;
            this.SearchName_TextBox.TextChanged += new System.EventHandler(this.SearchName_TextBox_TextChanged);
            // 
            // SearchName_label
            // 
            this.SearchName_label.AutoSize = true;
            this.SearchName_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.SearchName_label.Location = new System.Drawing.Point(21, 197);
            this.SearchName_label.Name = "SearchName_label";
            this.SearchName_label.Size = new System.Drawing.Size(103, 17);
            this.SearchName_label.TabIndex = 146;
            this.SearchName_label.Text = "Поиск по фио:";
            // 
            // View_button
            // 
            this.View_button.Location = new System.Drawing.Point(24, 275);
            this.View_button.Name = "View_button";
            this.View_button.Size = new System.Drawing.Size(320, 23);
            this.View_button.TabIndex = 144;
            this.View_button.Text = "Просмотр записи";
            this.View_button.UseCompatibleTextRendering = true;
            this.View_button.UseVisualStyleBackColor = true;
            this.View_button.Click += new System.EventHandler(this.View_button_Click);
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(24, 236);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(320, 23);
            this.Edit_button.TabIndex = 143;
            this.Edit_button.Text = "Редактирование записи";
            this.Edit_button.UseCompatibleTextRendering = true;
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Owners_label
            // 
            this.Owners_label.AutoSize = true;
            this.Owners_label.Location = new System.Drawing.Point(21, 24);
            this.Owners_label.Name = "Owners_label";
            this.Owners_label.Size = new System.Drawing.Size(137, 13);
            this.Owners_label.TabIndex = 140;
            this.Owners_label.Text = "Выберите автовладельца";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(47, 655);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(323, 23);
            this.exit_button.TabIndex = 142;
            this.exit_button.Text = "Закрыть форму";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // TopLabelAuto
            // 
            this.TopLabelAuto.AutoSize = true;
            this.TopLabelAuto.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.TopLabelAuto.Location = new System.Drawing.Point(143, 9);
            this.TopLabelAuto.Name = "TopLabelAuto";
            this.TopLabelAuto.Size = new System.Drawing.Size(154, 24);
            this.TopLabelAuto.TabIndex = 138;
            this.TopLabelAuto.Text = "Автовладельцы";
            // 
            // inputNewOwner_button
            // 
            this.inputNewOwner_button.Location = new System.Drawing.Point(44, 613);
            this.inputNewOwner_button.Name = "inputNewOwner_button";
            this.inputNewOwner_button.Size = new System.Drawing.Size(320, 23);
            this.inputNewOwner_button.TabIndex = 151;
            this.inputNewOwner_button.Text = "Ввод данных о новом автовладельце";
            this.inputNewOwner_button.UseCompatibleTextRendering = true;
            this.inputNewOwner_button.UseVisualStyleBackColor = true;
            this.inputNewOwner_button.Click += new System.EventHandler(this.inputNewOwner_button_Click);
            // 
            // Accidents_dataGridView
            // 
            this.Accidents_dataGridView.AllowUserToAddRows = false;
            this.Accidents_dataGridView.AllowUserToDeleteRows = false;
            this.Accidents_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Accidents_dataGridView.Location = new System.Drawing.Point(18, 46);
            this.Accidents_dataGridView.Name = "Accidents_dataGridView";
            this.Accidents_dataGridView.ReadOnly = true;
            this.Accidents_dataGridView.Size = new System.Drawing.Size(320, 66);
            this.Accidents_dataGridView.TabIndex = 149;
            // 
            // Accidents_label
            // 
            this.Accidents_label.AutoSize = true;
            this.Accidents_label.Location = new System.Drawing.Point(8, 18);
            this.Accidents_label.Name = "Accidents_label";
            this.Accidents_label.Size = new System.Drawing.Size(213, 13);
            this.Accidents_label.TabIndex = 150;
            this.Accidents_label.Text = "Выберите автопроисшествие владельца";
            // 
            // ViewAccidents_button
            // 
            this.ViewAccidents_button.Location = new System.Drawing.Point(24, 118);
            this.ViewAccidents_button.Name = "ViewAccidents_button";
            this.ViewAccidents_button.Size = new System.Drawing.Size(323, 24);
            this.ViewAccidents_button.TabIndex = 151;
            this.ViewAccidents_button.Text = "Посмотреть автопроисшествия";
            this.ViewAccidents_button.UseVisualStyleBackColor = true;
            this.ViewAccidents_button.Click += new System.EventHandler(this.ViewAccidents_button_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.ViewAccidents_button);
            this.panel2.Controls.Add(this.Accidents_label);
            this.panel2.Controls.Add(this.Accidents_dataGridView);
            this.panel2.Location = new System.Drawing.Point(26, 398);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(377, 159);
            this.panel2.TabIndex = 150;
            // 
            // Owners
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(419, 701);
            this.Controls.Add(this.inputNewOwner_button);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.TopLabelAuto);
            this.Controls.Add(this.exit_button);
            this.Name = "Owners";
            this.Text = "Owners";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Owners_FormClosed);
            this.Load += new System.EventHandler(this.Owners_Load);
            ((System.ComponentModel.ISupportInitialize)(this.bD_GIBDDDataSet1)).EndInit();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Owners_dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Accidents_dataGridView)).EndInit();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private BD_GIBDDDataSet bD_GIBDDDataSet1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button exit_button;
        private System.Windows.Forms.Label Owners_label;
        private System.Windows.Forms.Label TopLabelAuto;
        private System.Windows.Forms.DataGridView Owners_dataGridView;
        private System.Windows.Forms.TextBox SearchName_TextBox;
        private System.Windows.Forms.Label SearchName_label;
        private System.Windows.Forms.Button View_button;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button inputNewOwner_button;
        private System.Windows.Forms.DataGridView Accidents_dataGridView;
        private System.Windows.Forms.Label Accidents_label;
        private System.Windows.Forms.Button ViewAccidents_button;
        private System.Windows.Forms.Panel panel2;
    }
}