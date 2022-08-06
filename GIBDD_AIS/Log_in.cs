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
        private Label label_password;
        private TextBox textBox_login;
        private TextBox textBox_password;
        private Label label_login;
        private Button btnEnter;

        DataBase dataBase = new DataBase();
        public Log_in()
        {
            InitializeComponent();
            StartPosition = FormStartPosition.CenterScreen;
          
        }

        private void InitializeComponent()
        {
            this.label_password = new System.Windows.Forms.Label();
            this.textBox_login = new System.Windows.Forms.TextBox();
            this.textBox_password = new System.Windows.Forms.TextBox();
            this.label_login = new System.Windows.Forms.Label();
            this.btnEnter = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // label_password
            // 
            this.label_password.AutoSize = true;
            this.label_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_password.Location = new System.Drawing.Point(356, 224);
            this.label_password.Name = "label_password";
            this.label_password.Size = new System.Drawing.Size(67, 20);
            this.label_password.TabIndex = 8;
            this.label_password.Text = "Пароль";
            // 
            // textBox_login
            // 
            this.textBox_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox_login.Location = new System.Drawing.Point(289, 163);
            this.textBox_login.Multiline = true;
            this.textBox_login.Name = "textBox_login";
            this.textBox_login.Size = new System.Drawing.Size(222, 39);
            this.textBox_login.TabIndex = 6;
            this.textBox_login.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_login.TextChanged += new System.EventHandler(this.textBox_login_TextChanged);
            // 
            // textBox_password
            // 
            this.textBox_password.Font = new System.Drawing.Font("Microsoft Sans Serif", 20F);
            this.textBox_password.Location = new System.Drawing.Point(289, 247);
            this.textBox_password.Name = "textBox_password";
            this.textBox_password.Size = new System.Drawing.Size(222, 38);
            this.textBox_password.TabIndex = 7;
            this.textBox_password.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.textBox_password.UseSystemPasswordChar = true;
            // 
            // label_login
            // 
            this.label_login.AutoSize = true;
            this.label_login.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.label_login.Location = new System.Drawing.Point(368, 140);
            this.label_login.Name = "label_login";
            this.label_login.Size = new System.Drawing.Size(55, 20);
            this.label_login.TabIndex = 9;
            this.label_login.Text = "Логин";
            // 
            // btnEnter
            // 
            this.btnEnter.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F);
            this.btnEnter.Location = new System.Drawing.Point(289, 344);
            this.btnEnter.Name = "btnEnter";
            this.btnEnter.Size = new System.Drawing.Size(222, 37);
            this.btnEnter.TabIndex = 10;
            this.btnEnter.Text = "Вход";
            this.btnEnter.UseVisualStyleBackColor = true;
            this.btnEnter.Click += new System.EventHandler(this.btnEnter_Click);
            // 
            // Log_in
            // 
            this.ClientSize = new System.Drawing.Size(800, 521);
            this.Controls.Add(this.label_password);
            this.Controls.Add(this.textBox_login);
            this.Controls.Add(this.textBox_password);
            this.Controls.Add(this.label_login);
            this.Controls.Add(this.btnEnter);
            this.Name = "Log_in";
            this.Load += new System.EventHandler(this.Log_in_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        private void Log_in_Load(object sender, EventArgs e)
        {
            textBox_password.PasswordChar = '•';
            textBox_login.MaxLength = 60;
            textBox_password.MaxLength = 60;

        }

        private void textBox_login_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnEnter_Click(object sender, EventArgs e)
        {
            var login = textBox_login.Text;
            var password = textBox_password.Text;

            SqlDataAdapter adapter = new SqlDataAdapter();
            DataTable table = new DataTable();

            string querystring = $"select id, login, password from USERS where login = '{login}' and password = '{password}'";

            SqlCommand command= new SqlCommand(querystring, dataBase.GetConnection());

            adapter.SelectCommand = command;
            adapter.Fill(table);

            if(table.Rows.Count == 1)
            {
                MessageBox.Show("Вы успешно вошли!", "Успешно!", MessageBoxButtons.OK,MessageBoxIcon.Information);
                GIBDD frm1 = new GIBDD();
                this.Hide();
                frm1.ShowDialog();
                this.Close();
                this.Show();
            }
            else
                MessageBox.Show("Такого аккаунта не существует!", "Аккаунта не существует!", MessageBoxButtons.OK, MessageBoxIcon.Warning);

           
        }
    }
}
