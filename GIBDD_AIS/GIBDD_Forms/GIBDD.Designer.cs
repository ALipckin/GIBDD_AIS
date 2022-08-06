namespace GIBDD_AIS.GIBDD_Forms
{
    partial class GIBDD
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
            this.Vehicles = new System.Windows.Forms.Button();
            this.Accidents_button = new System.Windows.Forms.Button();
            this.Owners = new System.Windows.Forms.Button();
            this.panel1 = new System.Windows.Forms.Panel();
            this.work_label = new System.Windows.Forms.Label();
            this.gibdd_label = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.tableAdapterManager1 = new GIBDD_AIS.BD_GIBDDDataSet1TableAdapters.TableAdapterManager();
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // Vehicles
            // 
            this.Vehicles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Vehicles.Location = new System.Drawing.Point(48, 17);
            this.Vehicles.Name = "Vehicles";
            this.Vehicles.Size = new System.Drawing.Size(202, 46);
            this.Vehicles.TabIndex = 0;
            this.Vehicles.Text = "Автомобили";
            this.Vehicles.UseVisualStyleBackColor = true;
            this.Vehicles.Click += new System.EventHandler(this.Vehicles_Click);
            // 
            // Accidents_button
            // 
            this.Accidents_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Accidents_button.Location = new System.Drawing.Point(48, 82);
            this.Accidents_button.Name = "Accidents_button";
            this.Accidents_button.Size = new System.Drawing.Size(202, 42);
            this.Accidents_button.TabIndex = 1;
            this.Accidents_button.Text = "ДТП";
            this.Accidents_button.UseVisualStyleBackColor = true;
            this.Accidents_button.Click += new System.EventHandler(this.Accidents_button_Click);
            // 
            // Owners
            // 
            this.Owners.Location = new System.Drawing.Point(48, 146);
            this.Owners.Name = "Owners";
            this.Owners.Size = new System.Drawing.Size(202, 43);
            this.Owners.TabIndex = 2;
            this.Owners.Text = "Владельцы";
            this.Owners.UseVisualStyleBackColor = true;
            this.Owners.Click += new System.EventHandler(this.Owners_Click);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.Owners);
            this.panel1.Controls.Add(this.Vehicles);
            this.panel1.Controls.Add(this.Accidents_button);
            this.panel1.Location = new System.Drawing.Point(250, 155);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(293, 219);
            this.panel1.TabIndex = 3;
            // 
            // work_label
            // 
            this.work_label.AutoSize = true;
            this.work_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.work_label.Location = new System.Drawing.Point(253, 121);
            this.work_label.Name = "work_label";
            this.work_label.Size = new System.Drawing.Size(290, 20);
            this.work_label.TabIndex = 3;
            this.work_label.Text = "Работа с информационной системой";
            // 
            // gibdd_label
            // 
            this.gibdd_label.AutoSize = true;
            this.gibdd_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.gibdd_label.Location = new System.Drawing.Point(354, 47);
            this.gibdd_label.Name = "gibdd_label";
            this.gibdd_label.Size = new System.Drawing.Size(75, 24);
            this.gibdd_label.TabIndex = 4;
            this.gibdd_label.Text = "ГИБДД";
            // 
            // Exit_button
            // 
            this.Exit_button.Location = new System.Drawing.Point(319, 467);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(167, 31);
            this.Exit_button.TabIndex = 5;
            this.Exit_button.Text = "Выйти из базы данных";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // tableAdapterManager1
            // 
            this.tableAdapterManager1.BackupDataSetBeforeUpdate = false;
            this.tableAdapterManager1.Connection = null;
            this.tableAdapterManager1.UpdateOrder = GIBDD_AIS.BD_GIBDDDataSet1TableAdapters.TableAdapterManager.UpdateOrderOption.InsertUpdateDelete;
            this.tableAdapterManager1.VEHICLESTableAdapter = null;
            // 
            // GIBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 566);
            this.Controls.Add(this.Exit_button);
            this.Controls.Add(this.gibdd_label);
            this.Controls.Add(this.work_label);
            this.Controls.Add(this.panel1);
            this.Name = "GIBDD";
            this.Text = "GIBDD";
            this.Load += new System.EventHandler(this.GIBDD_Load);
            this.panel1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button Vehicles;
        private System.Windows.Forms.Button Accidents_button;
        private System.Windows.Forms.Button Owners;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label work_label;
        private System.Windows.Forms.Label gibdd_label;
        private System.Windows.Forms.Button Exit_button;
        private BD_GIBDDDataSet1TableAdapters.TableAdapterManager tableAdapterManager1;
    }
}