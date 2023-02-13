namespace GIBDD_AIS.GIBDDForms
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
            this.vehiclesButton = new System.Windows.Forms.Button();
            this.accidentsButton = new System.Windows.Forms.Button();
            this.ownersButton = new System.Windows.Forms.Button();
            this.descriptionLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            this.nameLabel = new System.Windows.Forms.Label();
            this.mainPanel = new System.Windows.Forms.Panel();
            this.changeAuthButton = new System.Windows.Forms.Button();
            this.imageList1 = new System.Windows.Forms.ImageList(this.components);
            this.mainPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // vehiclesButton
            // 
            this.vehiclesButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.vehiclesButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.vehiclesButton.Location = new System.Drawing.Point(238, 198);
            this.vehiclesButton.Name = "vehiclesButton";
            this.vehiclesButton.Size = new System.Drawing.Size(200, 50);
            this.vehiclesButton.TabIndex = 0;
            this.vehiclesButton.Text = "Автомобили";
            this.vehiclesButton.UseVisualStyleBackColor = true;
            this.vehiclesButton.Click += new System.EventHandler(this.vehiclesClick);
            // 
            // accidentsButton
            // 
            this.accidentsButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.accidentsButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.accidentsButton.Location = new System.Drawing.Point(238, 271);
            this.accidentsButton.Name = "accidentsButton";
            this.accidentsButton.Size = new System.Drawing.Size(200, 50);
            this.accidentsButton.TabIndex = 1;
            this.accidentsButton.Text = "ДТП";
            this.accidentsButton.UseVisualStyleBackColor = true;
            this.accidentsButton.Click += new System.EventHandler(this.accidentsButtonClick);
            // 
            // ownersButton
            // 
            this.ownersButton.AutoSize = true;
            this.ownersButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ownersButton.Location = new System.Drawing.Point(238, 345);
            this.ownersButton.Name = "ownersButton";
            this.ownersButton.Size = new System.Drawing.Size(200, 50);
            this.ownersButton.TabIndex = 2;
            this.ownersButton.Text = "Автовладельцы";
            this.ownersButton.UseVisualStyleBackColor = true;
            this.ownersButton.Click += new System.EventHandler(this.ownersClick);
            // 
            // descriptionLabel
            // 
            this.descriptionLabel.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.descriptionLabel.AutoSize = true;
            this.descriptionLabel.Font = new System.Drawing.Font("Arial Rounded MT Bold", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.descriptionLabel.Location = new System.Drawing.Point(234, 130);
            this.descriptionLabel.Name = "descriptionLabel";
            this.descriptionLabel.Size = new System.Drawing.Size(217, 44);
            this.descriptionLabel.TabIndex = 3;
            this.descriptionLabel.Text = "Работа с информационной\r\nсистемой\r\n";
            this.descriptionLabel.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // exitButton
            // 
            this.exitButton.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.exitButton.AutoSize = true;
            this.exitButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.exitButton.Location = new System.Drawing.Point(278, 512);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(150, 35);
            this.exitButton.TabIndex = 5;
            this.exitButton.Text = "Выход";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // nameLabel
            // 
            this.nameLabel.AutoSize = true;
            this.nameLabel.Font = new System.Drawing.Font("Arial Narrow", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.nameLabel.Location = new System.Drawing.Point(273, 29);
            this.nameLabel.Name = "nameLabel";
            this.nameLabel.Size = new System.Drawing.Size(128, 29);
            this.nameLabel.TabIndex = 23;
            this.nameLabel.Text = "АИС ГИБДД";
            // 
            // mainPanel
            // 
            this.mainPanel.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.mainPanel.Controls.Add(this.changeAuthButton);
            this.mainPanel.Controls.Add(this.descriptionLabel);
            this.mainPanel.Controls.Add(this.nameLabel);
            this.mainPanel.Controls.Add(this.vehiclesButton);
            this.mainPanel.Controls.Add(this.exitButton);
            this.mainPanel.Controls.Add(this.accidentsButton);
            this.mainPanel.Controls.Add(this.ownersButton);
            this.mainPanel.Location = new System.Drawing.Point(32, 21);
            this.mainPanel.Name = "mainPanel";
            this.mainPanel.Size = new System.Drawing.Size(682, 570);
            this.mainPanel.TabIndex = 24;
            // 
            // changeAuthButton
            // 
            this.changeAuthButton.BackgroundImageLayout = System.Windows.Forms.ImageLayout.None;
            this.changeAuthButton.Font = new System.Drawing.Font("Arial Rounded MT Bold", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.changeAuthButton.Location = new System.Drawing.Point(23, 505);
            this.changeAuthButton.Name = "changeAuthButton";
            this.changeAuthButton.Size = new System.Drawing.Size(109, 42);
            this.changeAuthButton.TabIndex = 24;
            this.changeAuthButton.Text = "Изменить учетные данные";
            this.changeAuthButton.UseVisualStyleBackColor = true;
            this.changeAuthButton.Click += new System.EventHandler(this.changeAuthButtonClick);
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
            this.Controls.Add(this.mainPanel);
            this.MaximizeBox = false;
            this.MinimumSize = new System.Drawing.Size(638, 470);
            this.Name = "GIBDD";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Главное окно";
            this.Load += new System.EventHandler(this.GIBDDLoad);
            this.mainPanel.ResumeLayout(false);
            this.mainPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button vehiclesButton;
        private System.Windows.Forms.Button accidentsButton;
        private System.Windows.Forms.Button ownersButton;
        private System.Windows.Forms.Label descriptionLabel;
        private System.Windows.Forms.Button exitButton;
        private System.Windows.Forms.Label nameLabel;
        private System.Windows.Forms.Panel mainPanel;
        private System.Windows.Forms.ImageList imageList1;
        private System.Windows.Forms.Button changeAuthButton;
    }
}