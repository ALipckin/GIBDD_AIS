﻿namespace GIBDD_AIS.GIBDDForms
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(GIBDD));
            this._buttonVehicles = new System.Windows.Forms.Button();
            this._buttonAccidents = new System.Windows.Forms.Button();
            this.Owners = new System.Windows.Forms.Button();
            this.work_label = new System.Windows.Forms.Label();
            this.Exit_button = new System.Windows.Forms.Button();
            this.MainLabel = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.Change_auth_button = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.panel1.SuspendLayout();
            this.SuspendLayout();
            // 
            // _buttonVehicles
            // 
            this._buttonVehicles.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._buttonVehicles.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonVehicles.Location = new System.Drawing.Point(238, 198);
            this._buttonVehicles.Name = "_buttonVehicles";
            this._buttonVehicles.Size = new System.Drawing.Size(200, 50);
            this._buttonVehicles.TabIndex = 0;
            this._buttonVehicles.Text = "Автомобили";
            this._buttonVehicles.UseVisualStyleBackColor = true;
            this._buttonVehicles.Click += new System.EventHandler(this.Vehicles_Click);
            // 
            // _buttonAccidents
            // 
            this._buttonAccidents.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this._buttonAccidents.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this._buttonAccidents.Location = new System.Drawing.Point(238, 271);
            this._buttonAccidents.Name = "_buttonAccidents";
            this._buttonAccidents.Size = new System.Drawing.Size(200, 50);
            this._buttonAccidents.TabIndex = 1;
            this._buttonAccidents.Text = "ДТП";
            this._buttonAccidents.UseVisualStyleBackColor = true;
            this._buttonAccidents.Click += new System.EventHandler(this.Accidents_button_Click);
            // 
            // Owners
            // 
            this.Owners.AutoSize = true;
            this.Owners.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Owners.Location = new System.Drawing.Point(238, 345);
            this.Owners.Name = "Owners";
            this.Owners.Size = new System.Drawing.Size(200, 50);
            this.Owners.TabIndex = 2;
            this.Owners.Text = "Автовладельцы";
            this.Owners.UseVisualStyleBackColor = true;
            this.Owners.Click += new System.EventHandler(this.Owners_Click);
            // 
            // work_label
            // 
            this.work_label.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.work_label.AutoSize = true;
            this.work_label.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.work_label.Location = new System.Drawing.Point(234, 130);
            this.work_label.Name = "work_label";
            this.work_label.Size = new System.Drawing.Size(217, 44);
            this.work_label.TabIndex = 3;
            this.work_label.Text = "Работа с информационной\r\nсистемой\r\n";
            this.work_label.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // Exit_button
            // 
            this.Exit_button.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.Exit_button.AutoSize = true;
            this.Exit_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Exit_button.Location = new System.Drawing.Point(278, 512);
            this.Exit_button.Name = "Exit_button";
            this.Exit_button.Size = new System.Drawing.Size(150, 35);
            this.Exit_button.TabIndex = 5;
            this.Exit_button.Text = "Выход";
            this.Exit_button.UseVisualStyleBackColor = true;
            this.Exit_button.Click += new System.EventHandler(this.Exit_button_Click);
            // 
            // MainLabel
            // 
            this.MainLabel.AutoSize = true;
            this.MainLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MainLabel.Location = new System.Drawing.Point(273, 29);
            this.MainLabel.Name = "MainLabel";
            this.MainLabel.Size = new System.Drawing.Size(128, 29);
            this.MainLabel.TabIndex = 23;
            this.MainLabel.Text = "АИС ГИБДД";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.panel1.Controls.Add(this.Change_auth_button);
            this.panel1.Controls.Add(this.work_label);
            this.panel1.Controls.Add(this.MainLabel);
            this.panel1.Controls.Add(this._buttonVehicles);
            this.panel1.Controls.Add(this.Exit_button);
            this.panel1.Controls.Add(this._buttonAccidents);
            this.panel1.Controls.Add(this.Owners);
            this.panel1.Location = new System.Drawing.Point(32, 21);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(682, 570);
            this.panel1.TabIndex = 24;
            // 
            // Change_auth_button
            // 
            this.Change_auth_button.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.Change_auth_button.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Change_auth_button.Location = new System.Drawing.Point(23, 505);
            this.Change_auth_button.Name = "Change_auth_button";
            this.Change_auth_button.Size = new System.Drawing.Size(109, 42);
            this.Change_auth_button.TabIndex = 24;
            this.Change_auth_button.Text = "Изменить учетные данные";
            this.Change_auth_button.UseVisualStyleBackColor = true;
            this.Change_auth_button.Click += new System.EventHandler(this.Change_auth_button_Click);
            // 
            // imageList1
            // 
            this.imageList1.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("imageList1.ImageStream")));
            this.imageList1.TransparentColor = System.Drawing.Color.Transparent;
            this.imageList1.Images.SetKeyName(0, "ReportIcon.png");
            // 
            // GIBDD
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(753, 598);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(638, 470);
            this.Name = "GIBDD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.GIBDD_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button _buttonVehicles;
        private System.Windows.Forms.Button _buttonAccidents;
        private System.Windows.Forms.Button Owners;
        private System.Windows.Forms.Label work_label;
        private System.Windows.Forms.Button Exit_button;
        private System.Windows.Forms.Label MainLabel;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button Change_auth_button;
    }
}