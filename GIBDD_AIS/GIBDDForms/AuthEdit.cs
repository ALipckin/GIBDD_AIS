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

namespace GIBDD_AIS.GIBDDForms
{
    public partial class AuthEdit : Form
    {
        public AuthEdit()
        {
            InitializeComponent();
        }
        private void AuthEditLoad(object sender, EventArgs e)
        {

        }
        private void saveButtonClick(object sender, EventArgs e)
        {
            string NewLogin = loginTextBox.Text;
            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            string NewPassword = passwordTextBox.Text;
            SqlCommand sqlCommand = null;

            if (CheckForm())
            {
                string create_owner = $"UPDATE USERS SET Login = '{NewLogin}', Password = '{NewPassword}' WHERE ID = 1";
                sqlCommand = new SqlCommand(create_owner, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Данные изменены", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
        }

        private bool CheckLogin()
        {
            string newLogin = loginTextBox.Text;
            bool status = true;
            if (newLogin.Length >= 20)
            {
                Login_errorProvider.SetError(loginTextBox, "Максимум 20 символов");
                status = false;
            }
            else
                Login_errorProvider.SetError(loginTextBox, "");
            return status;
        }
        private bool CheckPassword()
        {
            string newPassword = passwordTextBox.Text;
            bool status = true;
            if (newPassword.Length >= 20)
            {
                Password_errorProvider.SetError(passwordTextBox, "Максимум 20 символов");
                status = false;
            }
            else
                Password_errorProvider.SetError(passwordTextBox, "");
            return status;
        }
  
        private bool CheckForm()
        {
            bool login = CheckLogin();
            bool password = CheckPassword();
        
            if (login && password)
                return true;
            else return false;
        }


    }
}
