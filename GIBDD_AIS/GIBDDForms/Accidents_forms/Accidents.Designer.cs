namespace GIBDD_AIS
{
    partial class Accidents
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.SearchDate_TextBox = new System.Windows.Forms.TextBox();
            this.Accidents_dataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Search1 = new System.Windows.Forms.Label();
            this.View_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.Edit_button = new System.Windows.Forms.Button();
            this.Input = new System.Windows.Forms.Button();
            this.Accident = new System.Windows.Forms.Label();
            this.exit_button = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Accidents_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.SearchDate_TextBox);
            this.panel1.Controls.Add(this.Accidents_dataGridView);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Search1);
            this.panel1.Controls.Add(this.View_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.Edit_button);
            this.panel1.Location = new System.Drawing.Point(43, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 363);
            this.panel1.TabIndex = 9;
            // 
            // SearchDate_TextBox
            // 
            this.SearchDate_TextBox.AccessibleRole = System.Windows.Forms.AccessibleRole.None;
            this.SearchDate_TextBox.Location = new System.Drawing.Point(274, 223);
            this.SearchDate_TextBox.Name = "SearchDate_TextBox";
            this.SearchDate_TextBox.Size = new System.Drawing.Size(129, 20);
            this.SearchDate_TextBox.TabIndex = 15;
            this.SearchDate_TextBox.WordWrap = false;
            this.SearchDate_TextBox.TextChanged += new System.EventHandler(this.SearchDate_TextBox_TextChanged);
            // 
            // Accidents_dataGridView
            // 
            this.Accidents_dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.Accidents_dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.Accidents_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Accidents_dataGridView.Location = new System.Drawing.Point(85, 50);
            this.Accidents_dataGridView.Name = "Accidents_dataGridView";
            this.Accidents_dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.Accidents_dataGridView.Size = new System.Drawing.Size(380, 150);
            this.Accidents_dataGridView.TabIndex = 9;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label5.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label5.Location = new System.Drawing.Point(81, 27);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(118, 20);
            this.label5.TabIndex = 8;
            this.label5.Text = "Выберите дтп";
            // 
            // Search1
            // 
            this.Search1.AutoSize = true;
            this.Search1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Search1.Location = new System.Drawing.Point(121, 224);
            this.Search1.Name = "Search1";
            this.Search1.Size = new System.Drawing.Size(103, 17);
            this.Search1.TabIndex = 6;
            this.Search1.Text = "Поиск по дате";
            // 
            // View_button
            // 
            this.View_button.Location = new System.Drawing.Point(140, 308);
            this.View_button.Name = "View_button";
            this.View_button.Size = new System.Drawing.Size(263, 23);
            this.View_button.TabIndex = 2;
            this.View_button.Text = "Просмотр записи";
            this.View_button.UseCompatibleTextRendering = true;
            this.View_button.UseVisualStyleBackColor = true;
            this.View_button.Click += new System.EventHandler(this.View_button_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(0, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(0, 13);
            this.label2.TabIndex = 5;
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(140, 269);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(263, 23);
            this.Edit_button.TabIndex = 0;
            this.Edit_button.Text = "Редактирование записи";
            this.Edit_button.UseCompatibleTextRendering = true;
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(214, 502);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(215, 33);
            this.Input.TabIndex = 7;
            this.Input.Text = "Добавить";
            this.Input.UseCompatibleTextRendering = true;
            this.Input.UseVisualStyleBackColor = true;
            this.Input.Click += new System.EventHandler(this.Input_Click);
            // 
            // Accident
            // 
            this.Accident.AutoSize = true;
            this.Accident.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F);
            this.Accident.Location = new System.Drawing.Point(209, 45);
            this.Accident.Name = "Accident";
            this.Accident.Size = new System.Drawing.Size(237, 29);
            this.Accident.TabIndex = 8;
            this.Accident.Text = "Автопроисшествия";
            // 
            // exit_button
            // 
            this.exit_button.Location = new System.Drawing.Point(240, 556);
            this.exit_button.Name = "exit_button";
            this.exit_button.Size = new System.Drawing.Size(177, 23);
            this.exit_button.TabIndex = 31;
            this.exit_button.Text = "Закрыть";
            this.exit_button.UseVisualStyleBackColor = true;
            this.exit_button.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // Accidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(611, 601);
            this.Controls.Add(this.exit_button);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Accident);
            this.Controls.Add(this.Input);
            this.MaximumSize = new System.Drawing.Size(627, 640);
            this.MinimumSize = new System.Drawing.Size(627, 640);
            this.Name = "Accidents";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Автопроисшествия";
            this.Load += new System.EventHandler(this.Accidents_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Accidents_dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label Search1;
        private System.Windows.Forms.Button View_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.Button Input;
        private System.Windows.Forms.DataGridView Accidents_dataGridView;
        private System.Windows.Forms.Label Accident;
        private System.Windows.Forms.TextBox SearchDate_TextBox;
        private System.Windows.Forms.Button exit_button;
    }
}