namespace GIBDD_AIS
{
    partial class BaseVehicle
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
            System.Windows.Forms.Label colorLabel;
            System.Windows.Forms.Label lastTILabel;
            System.Windows.Forms.Label numberLabel;
            System.Windows.Forms.Label bodyNumberLabel;
            System.Windows.Forms.Label chasisNumberLabel;
            System.Windows.Forms.Label engineNumberLabel;
            System.Windows.Forms.Label releaseDateLabel;
            System.Windows.Forms.Label engineVolumeLabel;
            System.Windows.Forms.Label typeLabel;
            System.Windows.Forms.Label vinLabel;
            System.Windows.Forms.Label brandLabel;
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle7 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle8 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle9 = new System.Windows.Forms.DataGridViewCellStyle();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this.ownerLabel = new System.Windows.Forms.Label();
            this.vinTextBox = new System.Windows.Forms.TextBox();
            this.brandTextBox = new System.Windows.Forms.TextBox();
            this.bodyNumberTextBox = new System.Windows.Forms.TextBox();
            this.numberTextBox = new System.Windows.Forms.TextBox();
            this.lastTIDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.colorTextBox = new System.Windows.Forms.TextBox();
            this.chasisNumberTextBox = new System.Windows.Forms.TextBox();
            this.engineNumberTextBox = new System.Windows.Forms.TextBox();
            this.releaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this.engineVolumeTextBox = new System.Windows.Forms.TextBox();
            this.typeComboBox = new System.Windows.Forms.ComboBox();
            this.dataGridView = new System.Windows.Forms.DataGridView();
            this.wantedCheckBox = new System.Windows.Forms.CheckBox();
            this.wantedLabel = new System.Windows.Forms.Label();
            this.topAutoLabel = new System.Windows.Forms.Label();
            this.exitButton = new System.Windows.Forms.Button();
            colorLabel = new System.Windows.Forms.Label();
            lastTILabel = new System.Windows.Forms.Label();
            numberLabel = new System.Windows.Forms.Label();
            bodyNumberLabel = new System.Windows.Forms.Label();
            chasisNumberLabel = new System.Windows.Forms.Label();
            engineNumberLabel = new System.Windows.Forms.Label();
            releaseDateLabel = new System.Windows.Forms.Label();
            engineVolumeLabel = new System.Windows.Forms.Label();
            typeLabel = new System.Windows.Forms.Label();
            vinLabel = new System.Windows.Forms.Label();
            brandLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // colorLabel
            // 
            colorLabel.AutoSize = true;
            colorLabel.Location = new System.Drawing.Point(31, 307);
            colorLabel.Name = "colorLabel";
            colorLabel.Size = new System.Drawing.Size(35, 13);
            colorLabel.TabIndex = 312;
            colorLabel.Text = "Цвет:";
            // 
            // lastTILabel
            // 
            lastTILabel.AutoSize = true;
            lastTILabel.Location = new System.Drawing.Point(31, 364);
            lastTILabel.Name = "lastTILabel";
            lastTILabel.Size = new System.Drawing.Size(106, 13);
            lastTILabel.TabIndex = 311;
            lastTILabel.Text = "Дата последего то:";
            // 
            // numberLabel
            // 
            numberLabel.AutoSize = true;
            numberLabel.Location = new System.Drawing.Point(31, 334);
            numberLabel.Name = "numberLabel";
            numberLabel.Size = new System.Drawing.Size(66, 13);
            numberLabel.TabIndex = 310;
            numberLabel.Text = "Гос. номер:";
            // 
            // bodyNumberLabel
            // 
            bodyNumberLabel.AutoSize = true;
            bodyNumberLabel.Location = new System.Drawing.Point(31, 281);
            bodyNumberLabel.Name = "bodyNumberLabel";
            bodyNumberLabel.Size = new System.Drawing.Size(82, 13);
            bodyNumberLabel.TabIndex = 309;
            bodyNumberLabel.Text = "Номер кузова:";
            // 
            // chasisNumberLabel
            // 
            chasisNumberLabel.AutoSize = true;
            chasisNumberLabel.Location = new System.Drawing.Point(31, 255);
            chasisNumberLabel.Name = "chasisNumberLabel";
            chasisNumberLabel.Size = new System.Drawing.Size(79, 13);
            chasisNumberLabel.TabIndex = 308;
            chasisNumberLabel.Text = "Номер шасси:";
            // 
            // engineNumberLabel
            // 
            engineNumberLabel.AutoSize = true;
            engineNumberLabel.Location = new System.Drawing.Point(31, 226);
            engineNumberLabel.Name = "engineNumberLabel";
            engineNumberLabel.Size = new System.Drawing.Size(99, 13);
            engineNumberLabel.TabIndex = 307;
            engineNumberLabel.Text = "Номер двигателя:";
            // 
            // releaseDateLabel
            // 
            releaseDateLabel.AutoSize = true;
            releaseDateLabel.Location = new System.Drawing.Point(31, 200);
            releaseDateLabel.Name = "releaseDateLabel";
            releaseDateLabel.Size = new System.Drawing.Size(82, 13);
            releaseDateLabel.TabIndex = 306;
            releaseDateLabel.Text = "Дата выпуска:";
            // 
            // engineVolumeLabel
            // 
            engineVolumeLabel.AutoSize = true;
            engineVolumeLabel.Location = new System.Drawing.Point(31, 171);
            engineVolumeLabel.Name = "engineVolumeLabel";
            engineVolumeLabel.Size = new System.Drawing.Size(99, 13);
            engineVolumeLabel.TabIndex = 305;
            engineVolumeLabel.Text = "Обьем двигателя:";
            // 
            // typeLabel
            // 
            typeLabel.AutoSize = true;
            typeLabel.Location = new System.Drawing.Point(31, 145);
            typeLabel.Name = "typeLabel";
            typeLabel.Size = new System.Drawing.Size(29, 13);
            typeLabel.TabIndex = 304;
            typeLabel.Text = "Тип:";
            // 
            // vinLabel
            // 
            vinLabel.AutoSize = true;
            vinLabel.Location = new System.Drawing.Point(31, 118);
            vinLabel.Name = "vinLabel";
            vinLabel.Size = new System.Drawing.Size(28, 13);
            vinLabel.TabIndex = 303;
            vinLabel.Text = "VIN:";
            // 
            // brandLabel
            // 
            brandLabel.AutoSize = true;
            brandLabel.Location = new System.Drawing.Point(31, 93);
            brandLabel.Name = "brandLabel";
            brandLabel.Size = new System.Drawing.Size(43, 13);
            brandLabel.TabIndex = 302;
            brandLabel.Text = "Марка:";
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // ownerLabel
            // 
            this.ownerLabel.AutoSize = true;
            this.ownerLabel.Location = new System.Drawing.Point(31, 421);
            this.ownerLabel.Name = "ownerLabel";
            this.ownerLabel.Size = new System.Drawing.Size(140, 13);
            this.ownerLabel.TabIndex = 324;
            this.ownerLabel.Text = "Выберите автовладельца:";
            // 
            // vinTextBox
            // 
            this.vinTextBox.Location = new System.Drawing.Point(175, 111);
            this.vinTextBox.MaxLength = 17;
            this.vinTextBox.Name = "vinTextBox";
            this.vinTextBox.Size = new System.Drawing.Size(247, 20);
            this.vinTextBox.TabIndex = 323;
            // 
            // brandTextBox
            // 
            this.brandTextBox.Location = new System.Drawing.Point(175, 86);
            this.brandTextBox.MaxLength = 30;
            this.brandTextBox.Name = "brandTextBox";
            this.brandTextBox.Size = new System.Drawing.Size(247, 20);
            this.brandTextBox.TabIndex = 322;
            // 
            // bodyNumberTextBox
            // 
            this.bodyNumberTextBox.Location = new System.Drawing.Point(175, 274);
            this.bodyNumberTextBox.Name = "bodyNumberTextBox";
            this.bodyNumberTextBox.Size = new System.Drawing.Size(247, 20);
            this.bodyNumberTextBox.TabIndex = 321;
            // 
            // numberTextBox
            // 
            this.numberTextBox.Location = new System.Drawing.Point(175, 327);
            this.numberTextBox.Name = "numberTextBox";
            this.numberTextBox.Size = new System.Drawing.Size(247, 20);
            this.numberTextBox.TabIndex = 320;
            // 
            // lastTIDateTimePicker
            // 
            this.lastTIDateTimePicker.Location = new System.Drawing.Point(175, 357);
            this.lastTIDateTimePicker.Name = "lastTIDateTimePicker";
            this.lastTIDateTimePicker.Size = new System.Drawing.Size(247, 20);
            this.lastTIDateTimePicker.TabIndex = 319;
            // 
            // colorTextBox
            // 
            this.colorTextBox.Location = new System.Drawing.Point(175, 301);
            this.colorTextBox.Name = "colorTextBox";
            this.colorTextBox.Size = new System.Drawing.Size(248, 20);
            this.colorTextBox.TabIndex = 318;
            // 
            // chasisNumberTextBox
            // 
            this.chasisNumberTextBox.Location = new System.Drawing.Point(175, 248);
            this.chasisNumberTextBox.Name = "chasisNumberTextBox";
            this.chasisNumberTextBox.Size = new System.Drawing.Size(248, 20);
            this.chasisNumberTextBox.TabIndex = 317;
            // 
            // engineNumberTextBox
            // 
            this.engineNumberTextBox.Location = new System.Drawing.Point(175, 219);
            this.engineNumberTextBox.Name = "engineNumberTextBox";
            this.engineNumberTextBox.Size = new System.Drawing.Size(248, 20);
            this.engineNumberTextBox.TabIndex = 316;
            // 
            // releaseDateDateTimePicker
            // 
            this.releaseDateDateTimePicker.Location = new System.Drawing.Point(175, 193);
            this.releaseDateDateTimePicker.Name = "releaseDateDateTimePicker";
            this.releaseDateDateTimePicker.Size = new System.Drawing.Size(248, 20);
            this.releaseDateDateTimePicker.TabIndex = 315;
            // 
            // engineVolumeTextBox
            // 
            this.engineVolumeTextBox.Location = new System.Drawing.Point(175, 164);
            this.engineVolumeTextBox.Name = "engineVolumeTextBox";
            this.engineVolumeTextBox.Size = new System.Drawing.Size(248, 20);
            this.engineVolumeTextBox.TabIndex = 314;
            // 
            // typeComboBox
            // 
            this.typeComboBox.FormattingEnabled = true;
            this.typeComboBox.Location = new System.Drawing.Point(175, 137);
            this.typeComboBox.Name = "typeComboBox";
            this.typeComboBox.Size = new System.Drawing.Size(248, 21);
            this.typeComboBox.TabIndex = 313;
            // 
            // dataGridView
            // 
            this.dataGridView.AllowUserToAddRows = false;
            this.dataGridView.AllowUserToDeleteRows = false;
            this.dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this.dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            dataGridViewCellStyle7.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle7.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle7.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle7.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle7.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle7.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle7.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle7;
            this.dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView.Location = new System.Drawing.Point(34, 446);
            this.dataGridView.Name = "dataGridView";
            this.dataGridView.ReadOnly = true;
            dataGridViewCellStyle8.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleCenter;
            dataGridViewCellStyle8.BackColor = System.Drawing.SystemColors.Control;
            dataGridViewCellStyle8.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            dataGridViewCellStyle8.ForeColor = System.Drawing.SystemColors.WindowText;
            dataGridViewCellStyle8.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle8.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle8.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridView.RowHeadersDefaultCellStyle = dataGridViewCellStyle8;
            this.dataGridView.RowHeadersVisible = false;
            dataGridViewCellStyle9.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.dataGridView.RowsDefaultCellStyle = dataGridViewCellStyle9;
            this.dataGridView.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dataGridView.Size = new System.Drawing.Size(389, 138);
            this.dataGridView.TabIndex = 301;
            // 
            // wantedCheckBox
            // 
            this.wantedCheckBox.AutoSize = true;
            this.wantedCheckBox.Location = new System.Drawing.Point(173, 391);
            this.wantedCheckBox.Name = "wantedCheckBox";
            this.wantedCheckBox.Size = new System.Drawing.Size(15, 14);
            this.wantedCheckBox.TabIndex = 300;
            this.wantedCheckBox.UseVisualStyleBackColor = false;
            // 
            // wantedLabel
            // 
            this.wantedLabel.AutoSize = true;
            this.wantedLabel.Location = new System.Drawing.Point(31, 391);
            this.wantedLabel.Name = "wantedLabel";
            this.wantedLabel.Size = new System.Drawing.Size(64, 13);
            this.wantedLabel.TabIndex = 299;
            this.wantedLabel.Text = "В розыске:";
            // 
            // topAutoLabel
            // 
            this.topAutoLabel.AutoSize = true;
            this.topAutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.topAutoLabel.Location = new System.Drawing.Point(156, 23);
            this.topAutoLabel.Name = "topAutoLabel";
            this.topAutoLabel.Size = new System.Drawing.Size(147, 24);
            this.topAutoLabel.TabIndex = 298;
            this.topAutoLabel.Text = "     Автомобили";
            // 
            // exitButton
            // 
            this.exitButton.Location = new System.Drawing.Point(327, 614);
            this.exitButton.Name = "exitButton";
            this.exitButton.Size = new System.Drawing.Size(95, 33);
            this.exitButton.TabIndex = 297;
            this.exitButton.Text = "Закрыть";
            this.exitButton.UseVisualStyleBackColor = true;
            this.exitButton.Click += new System.EventHandler(this.exitButtonClick);
            // 
            // BaseVehicle
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 671);
            this.Controls.Add(this.ownerLabel);
            this.Controls.Add(this.vinTextBox);
            this.Controls.Add(this.brandTextBox);
            this.Controls.Add(this.bodyNumberTextBox);
            this.Controls.Add(this.numberTextBox);
            this.Controls.Add(this.lastTIDateTimePicker);
            this.Controls.Add(this.colorTextBox);
            this.Controls.Add(this.chasisNumberTextBox);
            this.Controls.Add(this.engineNumberTextBox);
            this.Controls.Add(this.releaseDateDateTimePicker);
            this.Controls.Add(this.engineVolumeTextBox);
            this.Controls.Add(this.typeComboBox);
            this.Controls.Add(colorLabel);
            this.Controls.Add(lastTILabel);
            this.Controls.Add(numberLabel);
            this.Controls.Add(bodyNumberLabel);
            this.Controls.Add(chasisNumberLabel);
            this.Controls.Add(engineNumberLabel);
            this.Controls.Add(releaseDateLabel);
            this.Controls.Add(engineVolumeLabel);
            this.Controls.Add(typeLabel);
            this.Controls.Add(vinLabel);
            this.Controls.Add(brandLabel);
            this.Controls.Add(this.dataGridView);
            this.Controls.Add(this.wantedCheckBox);
            this.Controls.Add(this.wantedLabel);
            this.Controls.Add(this.topAutoLabel);
            this.Controls.Add(this.exitButton);
            this.MaximumSize = new System.Drawing.Size(470, 710);
            this.MinimumSize = new System.Drawing.Size(470, 710);
            this.Name = "BaseVehicle";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        protected System.Windows.Forms.ErrorProvider errorProvider;
        protected System.Windows.Forms.Label ownerLabel;
        protected System.Windows.Forms.TextBox vinTextBox;
        protected System.Windows.Forms.TextBox brandTextBox;
        protected System.Windows.Forms.TextBox bodyNumberTextBox;
        protected System.Windows.Forms.TextBox numberTextBox;
        protected System.Windows.Forms.DateTimePicker lastTIDateTimePicker;
        protected System.Windows.Forms.TextBox colorTextBox;
        protected System.Windows.Forms.TextBox chasisNumberTextBox;
        protected System.Windows.Forms.TextBox engineNumberTextBox;
        protected System.Windows.Forms.DateTimePicker releaseDateDateTimePicker;
        protected System.Windows.Forms.TextBox engineVolumeTextBox;
        protected System.Windows.Forms.ComboBox typeComboBox;
        protected System.Windows.Forms.DataGridView dataGridView;
        protected System.Windows.Forms.CheckBox wantedCheckBox;
        protected System.Windows.Forms.Label wantedLabel;
        protected System.Windows.Forms.Label topAutoLabel;
        protected System.Windows.Forms.Button exitButton;
    }
}