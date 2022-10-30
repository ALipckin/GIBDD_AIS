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

            OwnerSurname_textBox.MaxLength = 30;
            OwnerMiddleName_textBox.MaxLength = 30;
            OwnerSurname_textBox.MaxLength = 30;
            Address_textBox.MaxLength = 60;
            BirthD_dateTimePicker.CustomFormat = "dd-MM-yyyy";
            BirthD_dateTimePicker.Format = DateTimePickerFormat.Custom;
            while (dataReader.Read())
            {
                OwnerName_textBox.Text = dataReader[1].ToString();
                OwnerSurname_textBox.Text = dataReader[0].ToString();
                OwnerMiddleName_textBox.Text = dataReader[2].ToString();
                Address_textBox.Text = dataReader[3].ToString();
                BirthD_dateTimePicker.Text = dataReader[4].ToString();
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
                String Name = OwnerName_textBox.Text;
                String Surname = OwnerSurname_textBox.Text;
                String MiddleName = OwnerMiddleName_textBox.Text;
                String Address = Address_textBox.Text;
                String BirthDate = BirthD_dateTimePicker.Text;
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
            if (OwnerSurname_textBox.Text == "")
            {
                errorProvider1.SetError(OwnerSurname_textBox, "Пожалуйста введите фамилию");
                status = false;
            }
            else
                errorProvider1.SetError(OwnerSurname_textBox, "");
            return status;
        }

        private bool CheckName()
        {
            bool status = true;
            if (OwnerName_textBox.Text == "")
            {
                errorProvider1.SetError(OwnerName_textBox, "Пожалуйста введите имя");
                status = false;
            }
            else
                errorProvider1.SetError(OwnerName_textBox, "");
            return status;
        }
        private bool CheckMiddleName()
        {
            bool status = true;
            if (OwnerMiddleName_textBox.Text == "")
            {
                errorProvider1.SetError(OwnerMiddleName_textBox, "Пожалуйста введите отчество");
                status = false;
            }
            else
                errorProvider1.SetError(OwnerMiddleName_textBox, "");
            return status;
        }
        private bool CheckAddress()
        {
            bool status = true;
            if (Address_textBox.Text == "")
            {
                errorProvider1.SetError(Address_textBox, "Пожалуйста введите адрес");
                status = false;
            }
            else
                errorProvider1.SetError(Address_textBox, "");
            return status;
        }
        private bool CheckAge()
        {
            bool status = true;
            if (BirthD_dateTimePicker.Text == "")
            {
                errorProvider1.SetError(BirthD_dateTimePicker, "Пожалуйста введите дату рождения");
            }
            else
            {
                errorProvider1.SetError(BirthD_dateTimePicker, "");
                try
                {
                    var bday = BirthD_dateTimePicker.Value;
                    DateTime now = DateTime.Today;
                    int age = now.Year - bday.Year;
                    if (bday > now.AddYears(-age)) age--;
                    if (age < 16)
                    {
                        errorProvider1.SetError(BirthD_dateTimePicker, "Владельцу должно быть больше 16 лет");
                        status = false;
                    }
                    else
                        errorProvider1.SetError(BirthD_dateTimePicker, "");
                }
                catch (Exception ex)
                {
                    errorProvider1.SetError(BirthD_dateTimePicker, "Пожалуйста введите дату рождения в формате даты");
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