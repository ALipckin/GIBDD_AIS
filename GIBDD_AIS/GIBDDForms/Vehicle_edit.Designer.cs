namespace GIBDD_AIS
{
    partial class Vehicle_edit
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
            System.Windows.Forms.Label _colorLabel;
            System.Windows.Forms.Label _lastTILabel;
            System.Windows.Forms.Label _numberLabel;
            System.Windows.Forms.Label _bodyNumberLabel;
            System.Windows.Forms.Label _chasisNumberLabel;
            System.Windows.Forms.Label _engineNumberLabel;
            System.Windows.Forms.Label _releaseDateLabel;
            System.Windows.Forms.Label _engineVolumeLabel;
            System.Windows.Forms.Label _typeLabel;
            System.Windows.Forms.Label _vinLabel;
            System.Windows.Forms.Label _brandLabel;
            this._topAutoLabel = new System.Windows.Forms.Label();
            this._exitButton = new System.Windows.Forms.Button();
            this._deleteButton = new System.Windows.Forms.Button();
            this._wantedCheckBox = new System.Windows.Forms.CheckBox();
            this._wantedLabel = new System.Windows.Forms.Label();
            this._saveButton = new System.Windows.Forms.Button();
            this.CurrOwner_label = new System.Windows.Forms.Label();
            this._searchLabel = new System.Windows.Forms.Label();
            this._searchTextBox = new System.Windows.Forms.TextBox();
            this._ownerLabel = new System.Windows.Forms.Label();
            this._dataGridView = new System.Windows.Forms.DataGridView();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            this._bodyNumberTextBox = new System.Windows.Forms.TextBox();
            this._numberTextBox = new System.Windows.Forms.TextBox();
            this._lastTIDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this._colorTextBox = new System.Windows.Forms.TextBox();
            this._chasisNumberTextBox = new System.Windows.Forms.TextBox();
            this._engineNumberTextBox = new System.Windows.Forms.TextBox();
            this._releaseDateDateTimePicker = new System.Windows.Forms.DateTimePicker();
            this._engineVolumeTextBox = new System.Windows.Forms.TextBox();
            this._typeComboBox = new System.Windows.Forms.ComboBox();
            this._brandTextBox = new System.Windows.Forms.TextBox();
            this._vinTextBox = new System.Windows.Forms.TextBox();
            this._contextMenuStrip = new System.Windows.Forms.ContextMenuStrip(this.components);
            _colorLabel = new System.Windows.Forms.Label();
            _lastTILabel = new System.Windows.Forms.Label();
            _numberLabel = new System.Windows.Forms.Label();
            _bodyNumberLabel = new System.Windows.Forms.Label();
            _chasisNumberLabel = new System.Windows.Forms.Label();
            _engineNumberLabel = new System.Windows.Forms.Label();
            _releaseDateLabel = new System.Windows.Forms.Label();
            _engineVolumeLabel = new System.Windows.Forms.Label();
            _typeLabel = new System.Windows.Forms.Label();
            _vinLabel = new System.Windows.Forms.Label();
            _brandLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _colorLabel
            // 
            _colorLabel.AutoSize = true;
            _colorLabel.Location = new System.Drawing.Point(37, 310);
            _colorLabel.Name = "_colorLabel";
            _colorLabel.Size = new System.Drawing.Size(35, 13);
            _colorLabel.TabIndex = 211;
            _colorLabel.Text = "Цвет:";
            // 
            // _lastTILabel
            // 
            _lastTILabel.AutoSize = true;
            _lastTILabel.Location = new System.Drawing.Point(37, 367);
            _lastTILabel.Name = "_lastTILabel";
            _lastTILabel.Size = new System.Drawing.Size(106, 13);
            _lastTILabel.TabIndex = 208;
            _lastTILabel.Text = "Дата последего то:";
            // 
            // _numberLabel
            // 
            _numberLabel.AutoSize = true;
            _numberLabel.Location = new System.Drawing.Point(37, 337);
            _numberLabel.Name = "_numberLabel";
            _numberLabel.Size = new System.Drawing.Size(66, 13);
            _numberLabel.TabIndex = 206;
            _numberLabel.Text = "Гос. номер:";
            // 
            // _bodyNumberLabel
            // 
            _bodyNumberLabel.AutoSize = true;
            _bodyNumberLabel.Location = new System.Drawing.Point(37, 284);
            _bodyNumberLabel.Name = "_bodyNumberLabel";
            _bodyNumberLabel.Size = new System.Drawing.Size(82, 13);
            _bodyNumberLabel.TabIndex = 204;
            _bodyNumberLabel.Text = "Номер кузова:";
            // 
            // _chasisNumberLabel
            // 
            _chasisNumberLabel.AutoSize = true;
            _chasisNumberLabel.Location = new System.Drawing.Point(37, 258);
            _chasisNumberLabel.Name = "_chasisNumberLabel";
            _chasisNumberLabel.Size = new System.Drawing.Size(79, 13);
            _chasisNumberLabel.TabIndex = 201;
            _chasisNumberLabel.Text = "Номер шасси:";
            // 
            // _engineNumberLabel
            // 
            _engineNumberLabel.AutoSize = true;
            _engineNumberLabel.Location = new System.Drawing.Point(37, 229);
            _engineNumberLabel.Name = "_engineNumberLabel";
            _engineNumberLabel.Size = new System.Drawing.Size(99, 13);
            _engineNumberLabel.TabIndex = 200;
            _engineNumberLabel.Text = "Номер двигателя:";
            // 
            // _releaseDateLabel
            // 
            _releaseDateLabel.AutoSize = true;
            _releaseDateLabel.Location = new System.Drawing.Point(37, 203);
            _releaseDateLabel.Name = "_releaseDateLabel";
            _releaseDateLabel.Size = new System.Drawing.Size(82, 13);
            _releaseDateLabel.TabIndex = 198;
            _releaseDateLabel.Text = "Дата выпуска:";
            // 
            // _engineVolumeLabel
            // 
            _engineVolumeLabel.AutoSize = true;
            _engineVolumeLabel.Location = new System.Drawing.Point(37, 174);
            _engineVolumeLabel.Name = "_engineVolumeLabel";
            _engineVolumeLabel.Size = new System.Drawing.Size(99, 13);
            _engineVolumeLabel.TabIndex = 196;
            _engineVolumeLabel.Text = "Обьем двигателя:";
            // 
            // _typeLabel
            // 
            _typeLabel.AutoSize = true;
            _typeLabel.Location = new System.Drawing.Point(37, 148);
            _typeLabel.Name = "_typeLabel";
            _typeLabel.Size = new System.Drawing.Size(29, 13);
            _typeLabel.TabIndex = 194;
            _typeLabel.Text = "Тип:";
            // 
            // _vinLabel
            // 
            _vinLabel.AutoSize = true;
            _vinLabel.Location = new System.Drawing.Point(37, 121);
            _vinLabel.Name = "_vinLabel";
            _vinLabel.Size = new System.Drawing.Size(28, 13);
            _vinLabel.TabIndex = 192;
            _vinLabel.Text = "VIN:";
            // 
            // _brandLabel
            // 
            _brandLabel.AutoSize = true;
            _brandLabel.Location = new System.Drawing.Point(37, 96);
            _brandLabel.Name = "_brandLabel";
            _brandLabel.Size = new System.Drawing.Size(43, 13);
            _brandLabel.TabIndex = 190;
            _brandLabel.Text = "Марка:";
            // 
            // _topAutoLabel
            // 
            this._topAutoLabel.AutoSize = true;
            this._topAutoLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._topAutoLabel.Location = new System.Drawing.Point(177, 15);
            this._topAutoLabel.Name = "_topAutoLabel";
            this._topAutoLabel.Size = new System.Drawing.Size(173, 48);
            this._topAutoLabel.TabIndex = 30;
            this._topAutoLabel.Text = "     Автомобили\r\n(Редактирование)";
            // 
            // _exitButton
            // 
            this._exitButton.Location = new System.Drawing.Point(333, 629);
            this._exitButton.Name = "_exitButton";
            this._exitButton.Size = new System.Drawing.Size(95, 33);
            this._exitButton.TabIndex = 29;
            this._exitButton.Text = "Закрыть";
            this._exitButton.UseVisualStyleBackColor = true;
            this._exitButton.Click += new System.EventHandler(this.exit_button_Click);
            // 
            // _deleteButton
            // 
            this._deleteButton.Location = new System.Drawing.Point(48, 629);
            this._deleteButton.Name = "_deleteButton";
            this._deleteButton.Size = new System.Drawing.Size(108, 34);
            this._deleteButton.TabIndex = 28;
            this._deleteButton.Text = "Удалить запись";
            this._deleteButton.UseVisualStyleBackColor = true;
            this._deleteButton.Click += new System.EventHandler(this.Delete_Button_Click);
            // 
            // _wantedCheckBox
            // 
            this._wantedCheckBox.AutoSize = true;
            this._wantedCheckBox.Location = new System.Drawing.Point(179, 394);
            this._wantedCheckBox.Name = "_wantedCheckBox";
            this._wantedCheckBox.Size = new System.Drawing.Size(15, 14);
            this._wantedCheckBox.TabIndex = 159;
            this._wantedCheckBox.UseVisualStyleBackColor = false;
            // 
            // _wantedLabel
            // 
            this._wantedLabel.AutoSize = true;
            this._wantedLabel.Location = new System.Drawing.Point(37, 394);
            this._wantedLabel.Name = "_wantedLabel";
            this._wantedLabel.Size = new System.Drawing.Size(64, 13);
            this._wantedLabel.TabIndex = 158;
            this._wantedLabel.Text = "В розыске:";
            // 
            // _saveButton
            // 
            this._saveButton.Location = new System.Drawing.Point(178, 629);
            this._saveButton.Name = "_saveButton";
            this._saveButton.Size = new System.Drawing.Size(127, 34);
            this._saveButton.TabIndex = 212;
            this._saveButton.Text = "Сохранить изменения";
            this._saveButton.UseVisualStyleBackColor = true;
            this._saveButton.Click += new System.EventHandler(this.Save_Button_Click);
            // 
            // CurrOwner_label
            // 
            this.CurrOwner_label.AutoSize = true;
            this.CurrOwner_label.Location = new System.Drawing.Point(279, 422);
            this.CurrOwner_label.Name = "CurrOwner_label";
            this.CurrOwner_label.Size = new System.Drawing.Size(0, 13);
            this.CurrOwner_label.TabIndex = 213;
            // 
            // _searchLabel
            // 
            this._searchLabel.AutoSize = true;
            this._searchLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this._searchLabel.Location = new System.Drawing.Point(46, 594);
            this._searchLabel.Name = "_searchLabel";
            this._searchLabel.Size = new System.Drawing.Size(103, 17);
            this._searchLabel.TabIndex = 187;
            this._searchLabel.Text = "Поиск по фио:";
            // 
            // _searchTextBox
            // 
            this._searchTextBox.Location = new System.Drawing.Point(219, 591);
            this._searchTextBox.MaxLength = 100;
            this._searchTextBox.Name = "_searchTextBox";
            this._searchTextBox.Size = new System.Drawing.Size(150, 20);
            this._searchTextBox.TabIndex = 189;
            this._searchTextBox.TextChanged += new System.EventHandler(this.SearchName_TextBox_TextChanged);
            // 
            // _ownerLabel
            // 
            this._ownerLabel.AutoSize = true;
            this._ownerLabel.Location = new System.Drawing.Point(39, 422);
            this._ownerLabel.Name = "_ownerLabel";
            this._ownerLabel.Size = new System.Drawing.Size(240, 13);
            this._ownerLabel.TabIndex = 186;
            this._ownerLabel.Text = "Выберите автовладельца, текущий владелец:";
            // 
            // _dataGridView
            // 
            this._dataGridView.AllowUserToAddRows = false;
            this._dataGridView.AllowUserToDeleteRows = false;
            this._dataGridView.AutoSizeColumnsMode = System.Windows.Forms.DataGridViewAutoSizeColumnsMode.Fill;
            this._dataGridView.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this._dataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this._dataGridView.Location = new System.Drawing.Point(49, 438);
            this._dataGridView.Name = "_dataGridView";
            this._dataGridView.ReadOnly = true;
            this._dataGridView.Size = new System.Drawing.Size(380, 138);
            this._dataGridView.TabIndex = 188;
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // _bodyNumberTextBox
            // 
            this._bodyNumberTextBox.Location = new System.Drawing.Point(181, 277);
            this._bodyNumberTextBox.Name = "_bodyNumberTextBox";
            this._bodyNumberTextBox.Size = new System.Drawing.Size(247, 20);
            this._bodyNumberTextBox.TabIndex = 224;
            // 
            // _numberTextBox
            // 
            this._numberTextBox.Location = new System.Drawing.Point(181, 330);
            this._numberTextBox.Name = "_numberTextBox";
            this._numberTextBox.Size = new System.Drawing.Size(247, 20);
            this._numberTextBox.TabIndex = 223;
            // 
            // _lastTIDateTimePicker
            // 
            this._lastTIDateTimePicker.Location = new System.Drawing.Point(181, 360);
            this._lastTIDateTimePicker.Name = "_lastTIDateTimePicker";
            this._lastTIDateTimePicker.Size = new System.Drawing.Size(247, 20);
            this._lastTIDateTimePicker.TabIndex = 222;
            // 
            // _colorTextBox
            // 
            this._colorTextBox.Location = new System.Drawing.Point(181, 304);
            this._colorTextBox.Name = "_colorTextBox";
            this._colorTextBox.Size = new System.Drawing.Size(248, 20);
            this._colorTextBox.TabIndex = 221;
            // 
            // _chasisNumberTextBox
            // 
            this._chasisNumberTextBox.Location = new System.Drawing.Point(181, 251);
            this._chasisNumberTextBox.Name = "_chasisNumberTextBox";
            this._chasisNumberTextBox.Size = new System.Drawing.Size(248, 20);
            this._chasisNumberTextBox.TabIndex = 220;
            // 
            // _engineNumberTextBox
            // 
            this._engineNumberTextBox.Location = new System.Drawing.Point(181, 222);
            this._engineNumberTextBox.Name = "_engineNumberTextBox";
            this._engineNumberTextBox.Size = new System.Drawing.Size(248, 20);
            this._engineNumberTextBox.TabIndex = 219;
            // 
            // _releaseDateDateTimePicker
            // 
            this._releaseDateDateTimePicker.Location = new System.Drawing.Point(181, 196);
            this._releaseDateDateTimePicker.Name = "_releaseDateDateTimePicker";
            this._releaseDateDateTimePicker.Size = new System.Drawing.Size(248, 20);
            this._releaseDateDateTimePicker.TabIndex = 218;
            // 
            // _engineVolumeTextBox
            // 
            this._engineVolumeTextBox.Location = new System.Drawing.Point(181, 167);
            this._engineVolumeTextBox.Name = "_engineVolumeTextBox";
            this._engineVolumeTextBox.Size = new System.Drawing.Size(248, 20);
            this._engineVolumeTextBox.TabIndex = 217;
            // 
            // _typeComboBox
            // 
            this._typeComboBox.FormattingEnabled = true;
            this._typeComboBox.Location = new System.Drawing.Point(181, 140);
            this._typeComboBox.Name = "_typeComboBox";
            this._typeComboBox.Size = new System.Drawing.Size(248, 21);
            this._typeComboBox.TabIndex = 216;
            // 
            // _brandTextBox
            // 
            this._brandTextBox.Location = new System.Drawing.Point(181, 89);
            this._brandTextBox.MaxLength = 30;
            this._brandTextBox.Name = "_brandTextBox";
            this._brandTextBox.Size = new System.Drawing.Size(247, 20);
            this._brandTextBox.TabIndex = 226;
            // 
            // _vinTextBox
            // 
            this._vinTextBox.Location = new System.Drawing.Point(181, 114);
            this._vinTextBox.MaxLength = 17;
            this._vinTextBox.Name = "_vinTextBox";
            this._vinTextBox.Size = new System.Drawing.Size(247, 20);
            this._vinTextBox.TabIndex = 236;
            // 
            // _contextMenuStrip
            // 
            this._contextMenuStrip.Name = "contextMenuStrip1";
            this._contextMenuStrip.Size = new System.Drawing.Size(61, 4);
            // 
            // Vehicle_edit
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(454, 671);
            this.Controls.Add(this._vinTextBox);
            this.Controls.Add(this._brandTextBox);
            this.Controls.Add(this._bodyNumberTextBox);
            this.Controls.Add(this._numberTextBox);
            this.Controls.Add(this._lastTIDateTimePicker);
            this.Controls.Add(this._colorTextBox);
            this.Controls.Add(this._chasisNumberTextBox);
            this.Controls.Add(this._engineNumberTextBox);
            this.Controls.Add(this._releaseDateDateTimePicker);
            this.Controls.Add(this._engineVolumeTextBox);
            this.Controls.Add(this._typeComboBox);
            this.Controls.Add(this.CurrOwner_label);
            this.Controls.Add(this._saveButton);
            this.Controls.Add(_colorLabel);
            this.Controls.Add(_lastTILabel);
            this.Controls.Add(_numberLabel);
            this.Controls.Add(_bodyNumberLabel);
            this.Controls.Add(_chasisNumberLabel);
            this.Controls.Add(_engineNumberLabel);
            this.Controls.Add(_releaseDateLabel);
            this.Controls.Add(_engineVolumeLabel);
            this.Controls.Add(_typeLabel);
            this.Controls.Add(_vinLabel);
            this.Controls.Add(_brandLabel);
            this.Controls.Add(this._dataGridView);
            this.Controls.Add(this._searchTextBox);
            this.Controls.Add(this._searchLabel);
            this.Controls.Add(this._ownerLabel);
            this.Controls.Add(this._wantedCheckBox);
            this.Controls.Add(this._wantedLabel);
            this.Controls.Add(this._topAutoLabel);
            this.Controls.Add(this._exitButton);
            this.Controls.Add(this._deleteButton);
            this.MaximumSize = new System.Drawing.Size(470, 710);
            this.MinimumSize = new System.Drawing.Size(470, 710);
            this.Name = "Vehicle_edit";
            this.StartPosition = System.Windows.Forms.FormStartPosition.Manual;
            this.Text = "Редактирование";
            this.Load += new System.EventHandler(this.Vehicle_edit_Load);
            ((System.ComponentModel.ISupportInitialize)(this._dataGridView)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label _topAutoLabel;
        private System.Windows.Forms.Button _exitButton;
        private System.Windows.Forms.Button _deleteButton;
        private System.Windows.Forms.CheckBox _wantedCheckBox;
        private System.Windows.Forms.Label _wantedLabel;
        private System.Windows.Forms.Button _saveButton;
        private System.Windows.Forms.Label CurrOwner_label;
        private System.Windows.Forms.Label _searchLabel;
        private System.Windows.Forms.TextBox _searchTextBox;
        private System.Windows.Forms.Label _ownerLabel;
        private System.Windows.Forms.DataGridView _dataGridView;
        private System.Windows.Forms.ErrorProvider _errorProvider;
        private System.Windows.Forms.TextBox _bodyNumberTextBox;
        private System.Windows.Forms.TextBox _numberTextBox;
        private System.Windows.Forms.DateTimePicker _lastTIDateTimePicker;
        private System.Windows.Forms.TextBox _colorTextBox;
        private System.Windows.Forms.TextBox _chasisNumberTextBox;
        private System.Windows.Forms.TextBox _engineNumberTextBox;
        private System.Windows.Forms.DateTimePicker _releaseDateDateTimePicker;
        private System.Windows.Forms.TextBox _engineVolumeTextBox;
        private System.Windows.Forms.ComboBox _typeComboBox;
        private System.Windows.Forms.TextBox _brandTextBox;
        private System.Windows.Forms.TextBox _vinTextBox;
        private System.Windows.Forms.ContextMenuStrip _contextMenuStrip;
    }
}