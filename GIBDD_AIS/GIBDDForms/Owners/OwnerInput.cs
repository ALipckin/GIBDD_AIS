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
    public partial class OwnerInput : GIBDD_AIS.GIBDD_Forms.Owners_forms.BaseOwner
    {
        private DataBase _dataBase = new DataBase();
        public OwnerInput()
        {
            InitializeComponent();
        }

        private void OwnerInputLoad(object sender, EventArgs e)
        {
            _dataBase.openConnection();
            SqlDataReader dataReader = null;

            surnameTextBox.MaxLength = 30;
            middleNameTextBox.MaxLength = 30;
            surnameTextBox.MaxLength = 30;
            addressTextBox.MaxLength = 60;
            birthDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            birthDateDateTimePicker.Format = DateTimePickerFormat.Custom;

        }

        private void saveButton_Click(object sender, EventArgs e)
        {
            _dataBase.openConnection();
            SqlCommand sqlCommand = null;
            String Name = nameTextBox.Text;
            String Surname = surnameTextBox.Text;
            String MiddleName = middleNameTextBox.Text;
            String Address = addressTextBox.Text;
            String BirthDate = birthDateDateTimePicker.Text;
            BirthDate.Reverse();
            if (checkForm())
            {
                string create_owner = $"INSERT INTO OWNERS (Surname, Name, Middle_name, Address, Birth_D) values('{Surname}', '{Name}', '{MiddleName}', '{Address}', '{BirthDate}')";
                sqlCommand = new SqlCommand(create_owner, _dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Владелец успешно создан", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                this.Close();
            }
            else
                MessageBox.Show("Ошибка создания владельца", "Неправильный формат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void OwnerInputFormClosed(object sender, FormClosedEventArgs e)
        {
            Owner newForm = new Owner();
            newForm.Show();
        }
    }

}
