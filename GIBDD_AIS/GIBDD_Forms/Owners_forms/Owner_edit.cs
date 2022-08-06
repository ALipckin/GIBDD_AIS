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
using GIBDD_AIS.GIBDD_Forms.Autos_forms;


namespace GIBDD_AIS.GIBDD_Forms.Owners_forms
{
    public partial class Owner_edit : Form
    {
        DataBase dataBase = new DataBase();
        public Owner_edit()
        {
            InitializeComponent();
        }

        private void Owner_edit_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            SqlDataReader dataReader = null;

            try
            {
                string OwnerName_querystring = $"SELECT Surname, Name, Middle_name from OWNERS where ID LIKE '{DataBank.Owner_ID}'";
                SqlCommand sqlCommand = new SqlCommand(OwnerName_querystring, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Owner_textBox.Text = dataReader[0].ToString() + " " + dataReader[1].ToString() + " " + dataReader[2].ToString();
                }
                dataReader.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка ФИО", "Ошибка ФИО", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                string OwnerAddress_quertystring = $"SELECT Address FROM OWNERS where ID LIKE '{DataBank.Owner_ID}'";
                SqlCommand sqlCommand = new SqlCommand(OwnerAddress_quertystring, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Address_textBox.Text = dataReader[0].ToString();
                }
                dataReader.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка адреса", "Ошибка адреса", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            try
            {
                string OwnerBirthDate_quertystring = $"SELECT Birth_D FROM OWNERS where ID LIKE '{DataBank.Owner_ID}'";
                SqlCommand sqlCommand = new SqlCommand(OwnerBirthDate_quertystring, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    var BirthDate = dataReader.GetDateTime(0);
                    BirthDate_textBox.Text = BirthDate.ToString("dd-MM-yyyy");

                }
                dataReader.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка даты рождения ", "Ошибка даты рождения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

        }

        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                string updateOwnerID = $"UPDATE VEHICLES SET OWNERS_ID = NULL WHERE OWNERS_ID LIKE '{DataBank.Owner_ID}'";
                string delete_owner = $"DELETE FROM OWNERS WHERE ID LIKE '{DataBank.Owner_ID}'";
                SqlCommand sqlCommand;

                sqlCommand = new SqlCommand(updateOwnerID, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
                sqlCommand = new SqlCommand(delete_owner, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Удаление прошло успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void Owner_edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owners newForm = new Owners();
            newForm.Show();
        }

        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Owner_textBox_Leave(object sender, EventArgs e)
        {
            String Owner = Owner_textBox.Text;
            String[] subs = Owner.Split(' ');
            string edit_vehicle = $"UPDATE OWNERS SET Surname = '{subs[0]}', Name = '{subs[1]}', Middle_name = '{subs[2]}' where ID LIKE '{DataBank.Owner_ID}'";
            SqlCommand sqlCommand = new SqlCommand(edit_vehicle, dataBase.GetConnection());
            sqlCommand.ExecuteNonQuery();
        }

        private void BirthDate_textBox_Leave(object sender, EventArgs e)
        {
            String BirthDate = BirthDate_textBox.Text;
            BirthDate.Reverse();
            string query = $"UPDATE OWNERS SET Birth_D = '{BirthDate}' where ID LIKE '{DataBank.Owner_ID}'";
            SqlCommand sqlCommand = new SqlCommand(query, dataBase.GetConnection());
            sqlCommand.ExecuteNonQuery();
        }

        private void Address_textBox_Leave(object sender, EventArgs e)
        {
            String Address = Address_textBox.Text;
            string OwnerAddress_quertystring = $"UPDATE OWNERS SET Address = '{Address}' where ID LIKE '{DataBank.Owner_ID}'";
            SqlCommand sqlCommand = new SqlCommand(OwnerAddress_quertystring, dataBase.GetConnection());
            sqlCommand.ExecuteReader();
        }
    }
}


