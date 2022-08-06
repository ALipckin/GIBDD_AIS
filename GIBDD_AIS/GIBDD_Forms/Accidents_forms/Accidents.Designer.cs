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
            this.Accidents_dataGridView = new System.Windows.Forms.DataGridView();
            this.label5 = new System.Windows.Forms.Label();
            this.Search2 = new System.Windows.Forms.Label();
            this.Search1 = new System.Windows.Forms.Label();
            this.View_button = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.Edit_button = new System.Windows.Forms.Button();
            this.comboBox2 = new System.Windows.Forms.ComboBox();
            this.Input = new System.Windows.Forms.Button();
            this.Accident = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.Accidents_dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Accidents_dataGridView);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.Search2);
            this.panel1.Controls.Add(this.Search1);
            this.panel1.Controls.Add(this.View_button);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.comboBox1);
            this.panel1.Controls.Add(this.Edit_button);
            this.panel1.Controls.Add(this.comboBox2);
            this.panel1.Location = new System.Drawing.Point(43, 108);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(511, 370);
            this.panel1.TabIndex = 9;
            // 
            // Accidents_dataGridView
            // 
            this.Accidents_dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.Accidents_dataGridView.Location = new System.Drawing.Point(85, 50);
            this.Accidents_dataGridView.Name = "Accidents_dataGridView";
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
            // Search2
            // 
            this.Search2.AutoSize = true;
            this.Search2.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Search2.Location = new System.Drawing.Point(121, 262);
            this.Search2.Name = "Search2";
            this.Search2.Size = new System.Drawing.Size(150, 17);
            this.Search2.TabIndex = 7;
            this.Search2.Text = "Поиск по марке авто.";
            // 
            // Search1
            // 
            this.Search1.AutoSize = true;
            this.Search1.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.Search1.Location = new System.Drawing.Point(121, 224);
            this.Search1.Name = "Search1";
            this.Search1.Size = new System.Drawing.Size(120, 17);
            this.Search1.TabIndex = 6;
            this.Search1.Text = "Поиск по номеру";
            // 
            // View_button
            // 
            this.View_button.Location = new System.Drawing.Point(140, 337);
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
            // comboBox1
            // 
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Location = new System.Drawing.Point(277, 224);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(141, 21);
            this.comboBox1.TabIndex = 3;
            // 
            // Edit_button
            // 
            this.Edit_button.Location = new System.Drawing.Point(140, 298);
            this.Edit_button.Name = "Edit_button";
            this.Edit_button.Size = new System.Drawing.Size(263, 23);
            this.Edit_button.TabIndex = 0;
            this.Edit_button.Text = "Редактирование записи";
            this.Edit_button.UseCompatibleTextRendering = true;
            this.Edit_button.UseVisualStyleBackColor = true;
            this.Edit_button.Click += new System.EventHandler(this.Edit_button_Click);
            // 
            // comboBox2
            // 
            this.comboBox2.FormattingEnabled = true;
            this.comboBox2.Location = new System.Drawing.Point(277, 258);
            this.comboBox2.Name = "comboBox2";
            this.comboBox2.Size = new System.Drawing.Size(141, 21);
            this.comboBox2.TabIndex = 4;
            // 
            // Input
            // 
            this.Input.Location = new System.Drawing.Point(214, 502);
            this.Input.Name = "Input";
            this.Input.Size = new System.Drawing.Size(215, 33);
            this.Input.TabIndex = 7;
            this.Input.Text = "Ввод новых данных";
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
            // Accidents
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(638, 585);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.Accident);
            this.Controls.Add(this.Input);
            this.Name = "Accidents";
            this.Text = "Accidents";
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
        private System.Windows.Forms.Label Search2;
        private System.Windows.Forms.Label Search1;
        private System.Windows.Forms.Button View_button;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.Button Edit_button;
        private System.Windows.Forms.ComboBox comboBox2;
        private System.Windows.Forms.Button Input;
        private System.Windows.Forms.DataGridView Accidents_dataGridView;
        private System.Windows.Forms.Label Accident;
    }
}