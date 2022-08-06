namespace GIBDD_AIS
{
    partial class Vehicles
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
            this.components = new System.ComponentModel.Container();
            this.panel1 = new System.Windows.Forms.Panel();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.SearchBrand_TextBox = new System.Windows.Forms.TextBox();
            this.SearchNumber_TextBox = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.Search2 = new System.Windows.Forms.Label();
            this.Search1 = new System.Windows.Forms.Label();
            this.View = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Edit = new System.Windows.Forms.Button();
            this.Accident = new System.Windows.Forms.Label();
            this.Input_button = new System.Windows.Forms.Button();
            this.backgroundWorker1 = new System.ComponentModel.BackgroundWorker();
            this.bD_GIBDDDataSet = new GIBDD_AIS.BD_GIBDDDataSet();
            this.vEHICLESBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.vEHICLESTableAdapter = new GIBDD_AIS.BD_GIBDDDataSetTableAdapters.VEHICLESTableAdapter();
            this.bDGIBDDDataSetBindingSource = new System.Windows.Forms.BindingSource(this.components);
            this.bD_GIBDDDataSet1 = new GIBDD_AIS.BD_GIBDDDataSet1();
            this.vEHICLESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vEHICLESTableAdapter1 = new GIBDD_AIS.BD_GIBDDDataSet1TableAdapters.VEHICLESTableAdapter();
            this.exit_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_GIBDDDataSet)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLESBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDGIBDDDataSetBindingSource)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_GIBDDDataSet1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLESBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.SearchBrand_TextBox);
            this.panel1.Controls.Add(this.SearchNumber_TextBox);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Search2);
            this.panel1.Controls.Add(this.Search1);
            this.panel1.Controls.Add(this.View);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Edit);
            this.panel1.Location = new System.Drawing.Point(116, 132);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(378, 370);
            this.panel1.TabIndex = 12;
            // 
            // dataGridView1
            // 
            this.dataGridView1.AllowUserToAddRows = false;
            this.dataGridView1.AllowUserToDeleteRows = false;
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(58, 46);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.ReadOnly = true;
            this.dataGridView1.Size = new System.Drawing.Size(274, 152);
            this.dataGridView1.TabIndex = 13;
            this.dataGridView1.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridView_CellContentClick);
            // 
            // SearchBrand_TextBox
            // 
            this.SearchBrand_TextBox.Location = new System.Drawing.Point(212, 254);
            this.SearchBrand_TextBox.Name = "SearchBrand_TextBox";
            this.SearchBrand_TextBox.Size = new System.Drawing.Size(129, 20);
            this.SearchBrand_TextBox.TabIndex = 15;
            this.SearchBrand_TextBox.TextChanged += new System.EventHandler(this.SearchBrand_TextBox_TextChanged);
            // 
            // SearchNumber_TextBox
            // 
            this.SearchNumber_TextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SearchNumber_TextBox.Location = new System.Drawing.Point(212, 219);
            this.SearchNumber_TextBox.Name = "SearchNumber_TextBox";
            this.SearchNumber_TextBox.Size = new System.Drawing.Size(129, 20);
            this.SearchNumber_TextBox.TabIndex = 14;
            this.SearchNumber_TextBox.WordWrap = false;
            this.SearchNumber_TextBox.TextChanged += new System.EventHandler(this.SearchNumber_TextBox_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(130, 13);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(125, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Выберите авто";
            // 
            // Search2
            // 
            this.Search2.AutoSize = true;
            this.Search2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Search2.Location = new System.Drawing.Point(39, 257);
            this.Search2.Name = "Search2";
            this.Search2.Size = new System.Drawing.Size(150, 17);
            this.Search2.TabIndex = 7;
            this.Search2.Text = "Поиск по марке авто.";
            // 
            // Search1
            // 
            this.Search1.AutoSize = true;
            this.Search1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Search1.Location = new System.Drawing.Point(39, 219);
            this.Search1.Name = "Search1";
            this.Search1.Size = new System.Drawing.Size(120, 17);
            this.Search1.TabIndex = 6;
            this.Search1.Text = "Поиск по номеру";
            // 
            // View
            // 
            this.View.Location = new System.Drawing.Point(58, 332);
            this.View.Name = "View";
            this.View.Size = new System.Drawing.Size(263, 23);
            this.View.TabIndex = 2;
            this.View.Text = "Просмотр записи";
            this.View.UseCompatibleTextRendering = true;
            this.View.UseVisualStyleBackColor = true;
            this.View.Click += new System.EventHandler(this.View_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // Edit
            // 
            this.Edit.Location = new System.Drawing.Point(58, 293);
            this.Edit.Name = "Edit";
            this.Edit.Size = new System.Drawing.Size(263, 23);
            this.Edit.TabIndex = 0;
            this.Edit.Text = "Редактирование записи";
            this.Edit.UseCompatibleTextRendering = true;
            this.Edit.UseVisualStyleBackColor = true;
            this.Edit.Click += new System.EventHandler(this.Edit_Click);
            // 
            // Accident
            // 
            this.Accident.AutoSize = true;
            this.Accident.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Accident.Location = new System.Drawing.Point(245, 62);
            this.Accident.Name = "Accident";
            this.Accident.Size = new System.Drawing.Size(158, 29);
            this.Accident.TabIndex = 11;
            this.Accident.Text = "Автомобили";
            // 
            // Input_button
            // 
            this.Input_button.Location = new System.Drawing.Point(174, 526);
            this.Input_button.Name = "Input_button";
            this.Input_button.Size = new System.Drawing.Size(263, 22);
            this.Input_button.TabIndex = 10;
            this.Input_button.Text = "Ввод новых данных";
            this.Input_button.UseCompatibleTextRendering = true;
            this.Input_button.UseVisualStyleBackColor = true;
            this.Input_button.Click += new System.EventHandler(this.Input_button_Click);
            // 
            // bD_GIBDDDataSet
            // 
            this.bD_GIBDDDataSet.DataSetName = "BD_GIBDDDataSet";
            this.bD_GIBDDDataSet.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEHICLESBindingSource
            // 
            this.vEHICLESBindingSource.DataMember = "VEHICLES";
            this.vEHICLESBindingSource.DataSource = this.bD_GIBDDDataSet;
            // 
            // vEHICLESTableAdapter
            // 
            this.vEHICLESTableAdapter.ClearBeforeFill = true;
            // 
            // bDGIBDDDataSetBindingSource
            // 
            this.bDGIBDDDataSetBindingSource.DataSource = this.bD_GIBDDDataSet;
            this.bDGIBDDDataSetBindingSource.Position = 0;
            // 
            // bD_GIBDDDataSet1
            // 
            this.bD_GIBDDDataSet1.DataSetName = "BD_GIBDDDataSet1";
            this.bD_GIBDDDataSet1.SchemaSerializationMode = System.Data.SchemaSerializationMode.IncludeSchema;
            // 
            // vEHICLESBindingSource1
            // 
            this.vEHICLESBindingSource1.DataMember = "VEHICLES";
            this.vEHICLESBindingSource1.DataSource = this.bD_GIBDDDataSet1;
            // 
            // vEHICLESTableAdapter1
            // 
            this.vEHICLESTableAdapter1.ClearBeforeFill = true;
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(226, 592);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(177, 23);
            this.exit_button.TabIndex = 30;
            this.exit_button.Text = "Закрыть форму";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Vehicles
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(610, 627);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Accident);
            this.Controls.Add(this.Input_button);
            this.Name = "Vehicles";
            this.Text = "Vehicles";
            this.Load += new System.EventHandler(this.Vehicles_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_GIBDDDataSet)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLESBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bDGIBDDDataSetBindingSource)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.bD_GIBDDDataSet1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLESBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Search2;
        private System.Windows.Forms.Label Search1;
        private System.Windows.Forms.Button View;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Edit;
        private System.Windows.Forms.Label Accident;
        private System.Windows.Forms.Button Input_button;
        private System.Windows.Forms.TextBox SearchBrand_TextBox;
        private System.Windows.Forms.TextBox SearchNumber_TextBox;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.ComponentModel.BackgroundWorker backgroundWorker1;
        private BD_GIBDDDataSet bD_GIBDDDataSet;
        private System.Windows.Forms.BindingSource vEHICLESBindingSource;
        private BD_GIBDDDataSetTableAdapters.VEHICLESTableAdapter vEHICLESTableAdapter;
        private System.Windows.Forms.BindingSource bDGIBDDDataSetBindingSource;
        private BD_GIBDDDataSet1 bD_GIBDDDataSet1;
        private System.Windows.Forms.BindingSource vEHICLESBindingSource1;
        private BD_GIBDDDataSet1TableAdapters.VEHICLESTableAdapter vEHICLESTableAdapter1;
        private System.Windows.Forms.Button exit_button;
    }
}