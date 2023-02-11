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

            string quertystring = $"SELECT Surname, Name, Middle_name, Address, Birth_D FROM OWNERS where ID LIKE '{DataBank.Owner_ID}'";
            SqlCommand sqlCommand = new SqlCommand(quertystring, dataBase.GetConnection());
            dataReader = sqlCommand.ExecuteReader();

            _surnameTextBox.MaxLength = 30;
            _middleNameTextBox.MaxLength = 30;
            _surnameTextBox.MaxLength = 30;
            _addressTextBox.MaxLength = 60;
            _birthDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            _birthDateDateTimePicker.Format = DateTimePickerFormat.Custom;
            while (dataReader.Read())
            {
                _nameTextBox.Text = dataReader[1].ToString();
                _surnameTextBox.Text = dataReader[0].ToString();
                _middleNameTextBox.Text = dataReader[2].ToString();
                _addressTextBox.Text = dataReader[3].ToString();
                _birthDateDateTimePicker.Text = dataReader[4].ToString();
            }
            dataReader.Close();
        }
        private void delete_button_Click(object sender, EventArgs e)
        {
            try
            {
                string updateOwnerID = $"UPDATE VEHICLES SET OWNERS_ID = NULL WHERE OWNERS_ID = '{DataBank.Owner_ID}'";
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
        private void save_button_Click(object sender, EventArgs e)
        {
            if (checkForm())
            {
                String Name = _nameTextBox.Text;
                String Surname = _surnameTextBox.Text;
                String MiddleName = _middleNameTextBox.Text;
                String Address = _addressTextBox.Text;
                String BirthDate = _birthDateDateTimePicker.Text;
                BirthDate.Reverse();
                string query = $"UPDATE OWNERS SET Name = '{Name}', Surname = '{Surname}', Middle_Name = '{MiddleName}', Address = '{Address}', Birth_D = '{BirthDate}' where ID LIKE '{DataBank.Owner_ID}'";
                SqlCommand sqlCommand = new SqlCommand(query, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();

                MessageBox.Show("Сохранение прошло успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        private void OwnerSurname_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
                e.Handled = true;
        }
        private void OwnerName_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
                e.Handled = true;
        }
        private void OwnerMiddleName_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
                e.Handled = true;
        }
        private void Address_textBox_KeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 44 && l != 32 && !Char.IsDigit(l))
                e.Handled = true;
        }
        private bool CheckSurname()
        {
            bool status = true;
            if (_surnameTextBox.Text == "")
            {
                errorProvider1.SetError(_surnameTextBox, "Пожалуйста введите фамилию");
                status = false;
            }
            else
                errorProvider1.SetError(_surnameTextBox, "");
            return status;
        }

        private bool CheckName()
        {
            bool status = true;
            if (_nameTextBox.Text == "")
            {
                errorProvider1.SetError(_nameTextBox, "Пожалуйста введите имя");
                status = false;
            }
            else
                errorProvider1.SetError(_nameTextBox, "");
            return status;
        }
        private bool CheckMiddleName()
        {
            bool status = true;
            if (_middleNameTextBox.Text == "")
            {
                errorProvider1.SetError(_middleNameTextBox, "Пожалуйста введите отчество");
                status = false;
            }
            else
                errorProvider1.SetError(_middleNameTextBox, "");
            return status;
        }
        private bool CheckAddress()
        {
            bool status = true;
            if (_addressTextBox.Text == "")
            {
                errorProvider1.SetError(_addressTextBox, "Пожалуйста введите адрес");
                status = false;
            }
            else
                errorProvider1.SetError(_addressTextBox, "");
            return status;
        }
        private bool CheckAge()
        {
            bool status = true;
            if (_birthDateDateTimePicker.Text == "")
            {
                errorProvider1.SetError(_birthDateDateTimePicker, "Пожалуйста введите дату рождения");
            }
            else
            {
                errorProvider1.SetError(_birthDateDateTimePicker, "");
                try
                {
                    var bday = _birthDateDateTimePicker.Value;
                    DateTime now = DateTime.Today;
                    int age = now.Year - bday.Year;
                    if (bday > now.AddYears(-age)) age--;
                    if (age < 16)
                    {
                        errorProvider1.SetError(_birthDateDateTimePicker, "Владельцу должно быть больше 16 лет");
                        status = false;
                    }
                    else
                        errorProvider1.SetError(_birthDateDateTimePicker, "");
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(_birthDateDateTimePicker, "Пожалуйста введите дату рождения в формате даты");
                    status = false;
                }
            }
            return status;
        }
        private bool checkForm()
        {
            bool Surname = CheckSurname();
            bool MiddleName = CheckMiddleName();
            bool Name = CheckName();
            bool Address = CheckAddress();
            bool BirhD = CheckAge();
            if (Surname && MiddleName && Name && Address && BirhD)
            {
                return true;
            }
            else return false;
        }
    }
}