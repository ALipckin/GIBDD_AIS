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
        private Label labelName;
        private TextBox textBoxLogin;
        private Label labelLogin;
        private TextBox textBoxPassword;
        private Label labelPassword;
        private Button btnEnter;
        private ErrorProvider errorProvider;
        private IContainer components;
        DataBase dataBase = new DataBase();
        public Authorization()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void AuthorizationLoad(object sender, EventArgs e)
        {
            ClientSize = new Size(915, 601);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            textBoxPassword.PasswordChar = '•';
            textBoxLogin.MaxLength = 60;
            textBoxPassword.MaxLength = 60;
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.labelName = new System.Windows.Forms.Label();
            this.labelLogin = new System.Windows.Forms.Label();
            this.textBoxLogin = new System.Windows.Forms.TextBox();
            this.labelPassword = new System.Windows.Forms.Label();
            this.textBoxPassword = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.errorProvider = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelName
            // 
            this.labelName.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.labelName.AutoSize = true;
            this.labelName.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.labelName.Location = new System.Drawing.Point(357, 44);
            this.labelName.Name = "labelName";
            this.labelName.Size = new System.Drawing.Size(202, 37);
            this.labelName.TabIndex = 12;
            this.labelName.Text = "АИС ГИБДД";
            // 
            // labelLogin
            // 
            this.labelLogin.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelLogin.AutoSize = true;
            this.labelLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelLogin.Location = new System.Drawing.Point(424, 170);
            this.labelLogin.Name = "labelLogin";
            this.labelLogin.Size = new System.Drawing.Size(55, 20);
            this.labelLogin.TabIndex = 9;
            this.labelLogin.Text = "Логин";
            // 
            // textBoxLogin
            // 
            this.textBoxLogin.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxLogin.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxLogin.Location = new System.Drawing.Point(267, 193);
            this.textBoxLogin.MaxLength = 100;
            this.textBoxLogin.Multiline = true;
            this.textBoxLogin.Name = "textBoxLogin";
            this.textBoxLogin.Size = new System.Drawing.Size(371, 38);
            this.textBoxLogin.TabIndex = 6;
            this.textBoxLogin.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxLogin.Validating += new System.ComponentModel.CancelEventHandler(this.textBoxLoginValidating);
            // 
            // labelPassword
            // 
            this.labelPassword.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
            | System.Windows.Forms.AnchorStyles.Left)
            | System.Windows.Forms.AnchorStyles.Right)));
            this.labelPassword.AutoSize = true;
            this.labelPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.labelPassword.Location = new System.Drawing.Point(424, 273);
            this.labelPassword.Name = "labelPassword";
            this.labelPassword.Size = new System.Drawing.Size(67, 20);
            this.labelPassword.TabIndex = 8;
            this.labelPassword.Text = "Пароль";
            // 
            // textBoxPassword
            // 
            this.textBoxPassword.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBoxPassword.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBoxPassword.Location = new System.Drawing.Point(267, 296);
            this.textBoxPassword.MaxLength = 100;
            this.textBoxPassword.Name = "textBoxPassword";
            this.textBoxPassword.Size = new System.Drawing.Size(371, 38);
            this.textBoxPassword.TabIndex = 7;
            this.textBoxPassword.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBoxPassword.UseSystemPasswordChar = true;
            // 
            // btnEnter
            // 
            this.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEnter.Location = new System.Drawing.Point(304, 379);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(300, 39);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "Вход";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnterClick);
            // 
            // errorProvider
            // 
            this.errorProvider.ContainerControl = this;
            // 
            // Authorization
            // 
            this.ClientSize = new System.Drawing.Size(899, 562);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.textBoxPassword);
            this.Controls.Add(this.labelPassword);
            this.Controls.Add(this.textBoxLogin);
            this.Controls.Add(this.labelLogin);
            this.Controls.Add(this.labelName);
            this.MaximizeBox = false;
            this.Name = "Authorization";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.AuthorizationLoad);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void btnEnterClick(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var login = textBoxLogin.Text;
            var password = textBoxPassword.Text;
            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();
            string querystring = $"select ID, Login, Password from USERS where Login = '{login}' and Password = '{password}'";
            SqlCommand command = new SqlCommand(querystring, dataBase.GetConnection());
            adapter.SelectCommand = command;
            adapter.Fill(table);
            if (ValidateChildren(ValidationConstraints.Enabled))
            {
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

        private void textBoxLoginValidating(object sender, CancelEventArgs e)
        {
            if (string.IsNullOrEmpty(textBoxLogin.Text))
            {
                e.Cancel = true;
                textBoxLogin.Focus();
                errorProvider.SetError(textBoxLogin, "Пожалуйста, введите имя пользователя");
            }
            else
            {
                e.Cancel = false;
                errorProvider.SetError(textBoxLogin, null);
            }
        }


    }
}
