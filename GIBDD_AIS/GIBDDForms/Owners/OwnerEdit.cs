using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GIBDD_AIS.GIBDDForms.Owners
{
    public partial class OwnerEdit : GIBDD_AIS.GIBDD_Forms.Owners_forms.BaseOwner
    {
        private DataBase _dataBase = new DataBase();
        public OwnerEdit()
        {
            InitializeComponent();
        }

        private void OwnerEditLoad(object sender, EventArgs e)
        {
            _dataBase.openConnection();
            SqlDataReader dataReader = null;

            string quertystring = $"SELECT Surname, Name, Middle_name, Address, Birth_D FROM OWNERS where ID LIKE '{DataBank.Owner_ID}'";
            SqlCommand sqlCommand = new SqlCommand(quertystring, _dataBase.GetConnection());
            dataReader = sqlCommand.ExecuteReader();

            surnameTextBox.MaxLength = 30;
            middleNameTextBox.MaxLength = 30;
            surnameTextBox.MaxLength = 30;
            addressTextBox.MaxLength = 60;
            birthDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            birthDateDateTimePicker.Format = DateTimePickerFormat.Custom;
            while (dataReader.Read())
            {
                nameTextBox.Text = dataReader[1].ToString();
                surnameTextBox.Text = dataReader[0].ToString();
                middleNameTextBox.Text = dataReader[2].ToString();
                addressTextBox.Text = dataReader[3].ToString();
                birthDateDateTimePicker.Text = dataReader[4].ToString();
            }
            dataReader.Close();
        }


        private void deleteButtonClick(object sender, EventArgs e)
        {
            try
            {
                string updateOwnerID = $"UPDATE VEHICLES SET OWNERS_ID = NULL WHERE OWNERS_ID = '{DataBank.Owner_ID}'";
                string delete_owner = $"DELETE FROM OWNERS WHERE ID LIKE '{DataBank.Owner_ID}'";
                SqlCommand sqlCommand;
                sqlCommand = new SqlCommand(updateOwnerID, _dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
                sqlCommand = new SqlCommand(delete_owner, _dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Удаление прошло успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }

        private void saveButtonClick(object sender, EventArgs e)
        {
            if (checkForm())
            {
                String Name = nameTextBox.Text;
                String Surname = surnameTextBox.Text;
                String MiddleName = middleNameTextBox.Text;
                String Address = addressTextBox.Text;
                String BirthDate = birthDateDateTimePicker.Text;
                BirthDate.Reverse();
                string query = $"UPDATE OWNERS SET Name = '{Name}', Surname = '{Surname}', Middle_Name = '{MiddleName}', Address = '{Address}', Birth_D = '{BirthDate}' where ID LIKE '{DataBank.Owner_ID}'";
                SqlCommand sqlCommand = new SqlCommand(query, _dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Сохранение прошло успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void OwnerEditFormClosed(object sender, FormClosedEventArgs e)
        {
            Owner newForm = new Owner();
            newForm.Show();
        }

    }
}
