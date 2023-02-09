using Microsoft.Reporting.Map.WebForms.BingMaps;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace GIBDD_AIS.GIBDD_Forms
{
    public partial class Auth_edit : Form
    {
        public Auth_edit()
        {
            InitializeComponent();
        }

        private void Auth_edit_Load(object sender, EventArgs e)
        {

        }

        private void Save_button_Click(object sender, EventArgs e)
        {
            string NewLogin = Login_textBox.Text;
            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            string NewPassword = Password_textBox.Text;
            SqlCommand sqlCommand = null;

            if (CheckForm()) {
                string create_owner = $"UPDATE USERS SET Login = '{NewLogin}', Password = '{NewPassword}' WHERE ID = 1";
                sqlCommand = new SqlCommand(create_owner, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Данные изменены", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            

        }

        private bool CheckLogin()
        {
            string NewLogin = Login_textBox.Text;
            bool status = true;
            if (NewLogin.Length >= 20)
            {
                Login_errorProvider.SetError(Login_textBox, "Максимум 20 символов");
                status = false;
            }
            else
                Login_errorProvider.SetError(Login_textBox, "");
            return status;
        }
        private bool CheckPassword()
        {
            string NewPassword = Password_textBox.Text;
            bool status = true;
            if (NewPassword.Length >= 20)
            {
                Password_errorProvider.SetError(Password_textBox, "Максимум 20 символов");
                status = false;
            }
            else
                Password_errorProvider.SetError(Password_textBox, "");
            return status;
        }
  
        private bool CheckForm()
        {
            bool Login = CheckLogin();
            bool Password = CheckPassword();
        
            if (Login && Password)
                return true;
            else return false;
        }

    }
}
