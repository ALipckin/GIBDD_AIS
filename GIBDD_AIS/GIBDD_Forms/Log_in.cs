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
using GIBDD_AIS.GIBDD_Forms;

namespace GIBDD_AIS
{
    public partial class Log_in : Form
    {
        private Label Main_label;
        private TextBox textBox_login;
        private Label label_login;
        private TextBox textBox_password;
        private Label label_password;
        private Button btnEnter;
        private ErrorProvider errorProvider1;
        private IContainer components;
        DataBase dataBase = new DataBase();
        public Log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
        }
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            this.Main_label = new System.Windows.Forms.Label();
            this.label_login = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.btnEnter = new System.Windows.Forms.Button();
            this.errorProvider1 = new System.Windows.Forms.ErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).BeginInit();
            this.SuspendLayout();
            // Main_label
            this.Main_label.Anchor = System.Windows.Forms.AnchorStyles.Top;
            this.Main_label.AutoSize = true;
            this.Main_label.Font = new System.Drawing.Font("Microsoft Sans Serif", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(204)));
            this.Main_label.Location = new System.Drawing.Point(357, 44);
            this.Main_label.Name = "Main_label";
            this.Main_label.Size = new System.Drawing.Size(202, 37);
            this.Main_label.TabIndex = 12;
            this.Main_label.Text = "АИС ГИБДД";
            // label_login
            this.label_login.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_login.Location = new System.Drawing.Point(424, 170);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(55, 20);
            this.label_login.TabIndex = 9;
            this.label_login.Text = "Логин";
            // textBox_login
            this.textBox_login.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox_login.Location = new System.Drawing.Point(267, 193);
            this.textBox_login.MaxLength = 100;
            this.textBox_login.Multiline = true;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(371, 38);
            this.textBox_login.TabIndex = 6;
            this.textBox_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_login.Validating += new System.ComponentModel.CancelEventHandler(this.textBox_login_Validating_1);
            // label_password
            this.label_password.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_password.Location = new System.Drawing.Point(424, 273);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(67, 20);
            this.label_password.TabIndex = 8;
            this.label_password.Text = "Пароль";
            // textBox_password
            this.textBox_password.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox_password.Location = new System.Drawing.Point(267, 296);
            this.textBox_password.MaxLength = 100;
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(371, 38);
            this.textBox_password.TabIndex = 7;
            this.textBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_password.UseSystemPasswordChar = true;
            // btnEnter
            this.btnEnter.Anchor = System.Windows.Forms.AnchorStyles.None;
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEnter.Location = new System.Drawing.Point(304, 379);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(300, 39);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "Вход";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            this.errorProvider1.ContainerControl = this;
            this.ClientSize = new System.Drawing.Size(899, 562);
            this.Controls.Add(this.btnEnter);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.Main_label);
            this.MaximizeBox = false;
            this.Name = "Log_in";
            this.Text = "Авторизация";
            this.Load += new System.EventHandler(this.Log_in_Load);
            ((System.ComponentModel.ISupportInitialize)(this.errorProvider1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();
        }
        private void Log_in_Load(object sender, EventArgs e)
        {
            ClientSize = new Size(915, 601);
            FormBorderStyle = FormBorderStyle.FixedSingle;
            textBox_password.PasswordChar = '•';
            textBox_login.MaxLength = 60;
            textBox_password.MaxLength = 60;
        }
        private void btnEnter_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            var login = textBox_login.Text;
            var password = textBox_password.Text;
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
            if (string.IsNullOrEmpty(textBox_login.Text))
            {
                e.Cancel = true;
                textBox_login.Focus();
                errorProvider1.SetError(textBox_login, "Пожалуйста, введите имя пользователя");
            }
            else
            {
                e.Cancel = false;
                errorProvider1.SetError(textBox_login, null);
            }
        }
    }
}
