namespace GIBDD_AIS
{
    partial class Vehicle
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
            this.vehiclesPanel = new System.Windows.Forms.Panel();
            this.vehiclesDataGridView = new System.Windows.Forms.DataGridView();
            this.searchBrandTextBox = new System.Windows.Forms.TextBox();
            this.searchNumberTextBox = new System.Windows.Forms.TextBox();
            this.selectLabel = new System.Windows.Forms.Label();
            this.searchBrandLabel = new System.Windows.Forms.Label();
            this.searchNuberLabel = new System.Windows.Forms.Label();
            this.viewButton = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.editButton = new System.Windows.Forms.Button();
            this.topLabel = new System.Windows.Forms.Label();
            this.inputButton = new System.Windows.Forms.Button();
            this.exitButton = new System.Windows.Forms.Button();
            this.vEHICLESBindingSource1 = new System.Windows.Forms.BindingSource(this.components);
            this.vehiclesPanel.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLESBindingSource1)).BeginInit();
            this.SuspendLayout();
            // 
            // vehiclesPanel
            // 
            this.vehiclesPanel.Controls.Add(this.vehiclesDataGridView);
            this.vehiclesPanel.Controls.Add(this.searchBrandTextBox);
            this.vehiclesPanel.Controls.Add(this.searchNumberTextBox);
            this.vehiclesPanel.Controls.Add(this.selectLabel);
            this.vehiclesPanel.Controls.Add(this.searchBrandLabel);
            this.vehiclesPanel.Controls.Add(this.searchNuberLabel);
            this.vehiclesPanel.Controls.Add(this.viewButton);
            this.vehiclesPanel.Controls.Add(this.label2);
            this.vehiclesPanel.Controls.Add(this.editButton);
            this.vehiclesPanel.Location = new System.Drawing.Point(116, 79);
            this.vehiclesPanel.Name = "vehiclesPanel";
            this.vehiclesPanel.Size = new System.Drawing.Size(378, 370);
            this.vehiclesPanel.TabIndex = 12;
            // 
            // vehiclesDataGridView
            // 
            this.vehiclesDataGridView.AllowUserToAddRows = false;
            this.vehiclesDataGridView.AllowUserToDeleteRows = false;
            this.vehiclesDataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.vehiclesDataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.vehiclesDataGridView.Location = new System.Drawing.Point(42, 46);
            this.vehiclesDataGridView.MultiSelect = false;
            this.vehiclesDataGridView.Name = "vehiclesDataGridView";
            this.vehiclesDataGridView.ReadOnly = true;
            this.vehiclesDataGridView.RowHeadersVisible = false;
            this.vehiclesDataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.vehiclesDataGridView.Size = new System.Drawing.Size(299, 152);
            this.vehiclesDataGridView.TabIndex = 13;
            // 
            // searchBrandTextBox
            // 
            this.searchBrandTextBox.Location = new System.Drawing.Point(212, 254);
            this.searchBrandTextBox.MaxLength = 20;
            this.searchBrandTextBox.Name = "searchBrandTextBox";
            this.searchBrandTextBox.Size = new System.Drawing.Size(129, 20);
            this.searchBrandTextBox.TabIndex = 15;
            this.searchBrandTextBox.TextChanged += new System.EventHandler(this.searchBrandTextBoxTextChanged);
            // 
            // searchNumberTextBox
            // 
            this.searchNumberTextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.searchNumberTextBox.Location = new System.Drawing.Point(212, 219);
            this.searchNumberTextBox.MaxLength = 10;
            this.searchNumberTextBox.Name = "searchNumberTextBox";
            this.searchNumberTextBox.Size = new System.Drawing.Size(129, 20);
            this.searchNumberTextBox.TabIndex = 14;
            this.searchNumberTextBox.WordWrap = false;
            this.searchNumberTextBox.TextChanged += new System.EventHandler(this.searchNumberTextBoxTextChanged);
            // 
            // selectLabel
            // 
            this.selectLabel.AutoSize = true;
            this.selectLabel.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.selectLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.selectLabel.ForeColor = System.Drawing.SystemColors.ControlText;
            this.selectLabel.Location = new System.Drawing.Point(130, 13);
            this.selectLabel.Name = "selectLabel";
            this.selectLabel.Size = new System.Drawing.Size(125, 20);
            this.selectLabel.TabIndex = 8;
            this.selectLabel.Text = "Выберите авто";
            // 
            // searchBrandLabel
            // 
            this.searchBrandLabel.AutoSize = true;
            this.searchBrandLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchBrandLabel.Location = new System.Drawing.Point(39, 257);
            this.searchBrandLabel.Name = "searchBrandLabel";
            this.searchBrandLabel.Size = new System.Drawing.Size(150, 17);
            this.searchBrandLabel.TabIndex = 7;
            this.searchBrandLabel.Text = "Поиск по марке авто.";
            // 
            // searchNuberLabel
            // 
            this.searchNuberLabel.AutoSize = true;
            this.searchNuberLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.searchNuberLabel.Location = new System.Drawing.Point(39, 219);
            this.searchNuberLabel.Name = "searchNuberLabel";
            this.searchNuberLabel.Size = new System.Drawing.Size(120, 17);
            this.searchNuberLabel.TabIndex = 6;
            this.searchNuberLabel.Text = "Поиск по номеру";
            // 
            // viewButton
            // 
            this.viewButton.Location = new System.Drawing.Point(58, 332);
            this.viewButton.Name = "viewButton";
            this.viewButton.Size = new System.Drawing.Size(263, 23);
            this.viewButton.TabIndex = 2;
            this.viewButton.Text = "Просмотр записи";
            this.viewButton.UseCompatibleTextRendering = true;
            this.viewButton.UseVisualStyleBackColor = true;
            this.viewButton.Click += new System.EventHandler(this.viewClick);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // editButton
            // 
            this.editButton.Location = new System.Drawing.Point(58, 293);
            this.editButton.Name = "editButton";
            this.editButton.Size = new System.Drawing.Size(263, 23);
            this.editButton.TabIndex = 0;
            this.editButton.Text = "Редактирование записи";
            this.editButton.UseCompatibleTextRendering = true;
            this.editButton.UseVisualStyleBackColor = true;
            this.editButton.Click += new System.EventHandler(this.editButtonClick);
            // 
            // topLabel
            // 
            this.topLabel.AutoSize = true;
            this.topLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.topLabel.Location = new System.Drawing.Point(233, 19);
            this.topLabel.Name = "topLabel";
            this.topLabel.Size = new System.Drawing.Size(158, 29);
            this.topLabel.TabIndex = 11;
            this.topLabel.Text = "Автомобили";
            // 
            // inputButton
            // 
            this.inputButton.Location = new System.Drawing.Point(174, 473);
            this.inputButton.Name = "inputButton";
            this.inputButton.Size = new System.Drawing.Size(263, 22);
            this.inputButton.TabIndex = 10;
            this.inputButton.Text = "Добавить";
            this.inputButton.UseCompatibleTextRendering = true;
            this.inputButton.UseVisualStyleBackColor = true;
            this.inputButton.Click += new System.EventHandler(this.inputButtonClick);
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(214, 533);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(177, 23);
            this.exitButton.TabIndex = 30;
            this.exitButton.Text = "Закрыть";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // vEHICLESBindingSource1
            // 
            this.vEHICLESBindingSource1.DataMember = "VEHICLES";
            // 
            // Vehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 586);
            this.Controls.Add(this.exitButton);
            this.Controls.Add(this.vehiclesPanel);
            this.Controls.Add(this.topLabel);
            this.Controls.Add(this.inputButton);
            this.MaximumSize = new System.Drawing.Size(642, 625);
            this.MinimumSize = new System.Drawing.Size(642, 625);
            this.Name = "Vehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автомобили";
            this.Load += new System.EventHandler(this.VehiclesLoad);
            this.vehiclesPanel.ResumeLayout(false);
            this.vehiclesPanel.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.vehiclesDataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.vEHICLESBindingSource1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel vehiclesPanel;
        private System.Windows.Forms.Label selectLabel;
        private System.Windows.Forms.Label searchBrandLabel;
        private System.Windows.Forms.Label searchNuberLabel;
        private System.Windows.Forms.Button viewButton;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button editButton;
        private System.Windows.Forms.Label topLabel;
        private System.Windows.Forms.Button inputButton;
        private System.Windows.Forms.TextBox searchBrandTextBox;
        private System.Windows.Forms.TextBox searchNumberTextBox;
        private System.Windows.Forms.DataGridView vehiclesDataGridView;
       
        private System.Windows.Forms.BindingSource vEHICLESBindingSource1;
      
        private System.Windows.Forms.Button exitButton;
    }
}