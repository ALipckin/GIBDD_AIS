using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
using GIBDD_AIS.GIBDDForms;

namespace GIBDD_AIS
{
    public partial class Authorization : Form
    {
        private Label _labelName;
        private TextBox _textBoxLogin;
        private Label _labelLogin;
        private TextBox _textBoxPassword;
        private Label _labelPassword;
        private Button _btnEnter;
        private ErrorProvider _errorProvider;
        private IContainer components;
        DataBase dataBase = new DataBase();
        public Authorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this._labelName = new System.Windows.Forms.Label();
            this._labelLogin = new System.Windows.Forms.Label();
            this._textBoxLogin = new System.Windows.Forms.TextBox();
            this._labelPassword = new System.Windows.Forms.Label();
            this._textBoxPassword = new System.Windows.Forms.TextBox();
            this._btnEnter = new System.Windows.Forms.Button();
            this._errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // _labelName
            // 
            this._labelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this._labelName.AutoSize = true;
            this._labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this._labelName.Location = new System.Drawing.Point(357, 44);
            this._labelName.Name = "_labelName";
            this._labelName.Size = new System.Drawing.Size(202, 37);
            this._labelName.TabIndex = 12;
            this._labelName.Text = "АИС ГИБДД";
            // 
            // _labelLogin
            // 
            this._labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._labelLogin.AutoSize = true;
            this._labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._labelLogin.Location = new System.Drawing.Point(424, 170);
            this._labelLogin.Name = "_labelLogin";
            this._labelLogin.Size = new System.Drawing.Size(55, 20);
            this._labelLogin.TabIndex = 9;
            this._labelLogin.Text = "Логин";
            // 
            // _textBoxLogin
            // 
            this._textBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this._textBoxLogin.Location = new System.Drawing.Point(267, 193);
            this._textBoxLogin.MaxLength = 100;
            this._textBoxLogin.Multiline = true;
            this._textBoxLogin.Name = "_textBoxLogin";
            this._textBoxLogin.Size = new System.Drawing.Size(371, 38);
            this._textBoxLogin.TabIndex = 6;
            this._textBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._textBoxLogin.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_login_Validating_1);
            // 
            // _labelPassword
            // 
            this._labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this._labelPassword.AutoSize = true;
            this._labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._labelPassword.Location = new System.Drawing.Point(424, 273);
            this._labelPassword.Name = "_labelPassword";
            this._labelPassword.Size = new System.Drawing.Size(67, 20);
            this._labelPassword.TabIndex = 8;
            this._labelPassword.Text = "Пароль";
            // 
            // _textBoxPassword
            // 
            this._textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this._textBoxPassword.Location = new System.Drawing.Point(267, 296);
            this._textBoxPassword.MaxLength = 100;
            this._textBoxPassword.Name = "_textBoxPassword";
            this._textBoxPassword.Size = new System.Drawing.Size(371, 38);
            this._textBoxPassword.TabIndex = 7;
            this._textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this._textBoxPassword.UseSystemPasswordChar = true;
            // 
            // _btnEnter
            // 
            this._btnEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this._btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this._btnEnter.Location = new System.Drawing.Point(304, 379);
            this._btnEnter.Name = "_btnEnter";
            this._btnEnter.Size = new System.Drawing.Size(300, 39);
            this._btnEnter.TabIndex = 10;
            this._btnEnter.Text = "Вход";
            this._btnEnter.UseVisualStyleBackColor = true;
            this._btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // _errorProvider
            // 
            this._errorProvider.ContainerControl = this;
            // 
            // Log_in
            // 
            this.ClientSize = new System.Drawing.Size(899, 562);
            this.Controls.Add(this._btnEnter);
            this.Controls.Add(this._textBoxPassword);
            this.Controls.Add(this._labelPassword);
            this.Controls.Add(this._textBoxLogin);
            this.Controls.Add(this._labelLogin);
            this.Controls.Add(this._labelName);
            this.MaximizeBox = false;
            this.Name = "Log_in";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Log_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this._errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }
        private void Log_in_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(915, 601);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            _textBoxPassword.PasswordChar = '•';
            _textBoxLogin.MaxLength = 60;
            _textBoxPassword.MaxLength = 60;
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var login = _textBoxLogin.Text;
            var password = _textBoxPassword.Text;
                SqlDataAdapter adapter = new SqlDataAdapter();
                DataTable table = new DataTable();
                string querystring = $"select ID, Login, Password from USERS where Login = '{login}' and Password = '{password}'";
                SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());
                adapter.SelectCommand = command;
                adapter.Fill(table);
                if(ValidateChildren(ValidationConstraints.Enabled)){
                if (table.Rows.Count == 1)
                {
                    MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    GIBDD frm1 = new GIBDD();
                    this.Hide();
                    frm1.ShowDialog();
                    this.Close();
                  
                }
                else
                    MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void textBox_login_Validating_1(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(_textBoxLogin.Text))
            {
                e.Cancel = true;
                _textBoxLogin.Focus();
                _errorProvider.SetError(_textBoxLogin, "Пожалуйста, введите имя пользователя");
            }
            else
            {
                e.Cancel = false;
                _errorProvider.SetError(_textBoxLogin, null);
            }
        }
    }
}
