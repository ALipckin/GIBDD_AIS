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
using System.Text.RegularExpressions;
using Microsoft.ReportingServices.ReportProcessing.ReportObjectModel;
using static System.Windows.Forms.VisualStyles.VisualStyleElement;
using Microsoft.Reporting.Map.WebForms.BingMaps;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;

namespace GIBDD_AIS.GIBDD_Forms.Owners_forms
{
    public partial class Owner_input : Form
    {
        DataBase dataBase = new DataBase();
        public Owner_input()
        {
            InitializeComponent();
        }
        private void Owner_inputcs_FormClosed(object sender, FormClosedEventArgs e)
        {
            Owners newForm = new Owners();
            newForm.Show();
        }
        private void Owner_inputcs_Load(object sender, EventArgs e)
        {
            OwnerSurname_textBox.MaxLength = 30;
            OwnerMiddleName_textBox.MaxLength = 30;
            OwnerName_textBox.MaxLength = 30;
            Address_textBox.MaxLength = 60;
            BirthD_dateTimePicker.CustomFormat = "dd-MM-yyyy";
            BirthD_dateTimePicker.Format = DateTimePickerFormat.Custom;
            errorProvider1.ContainerControl = this;
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void create_button_Click(object sender, EventArgs e)
        {
            dataBase.openConnection();
            SqlCommand sqlCommand = null;
            String Name = OwnerName_textBox.Text;
            String Surname = OwnerSurname_textBox.Text;
            String MiddleName = OwnerMiddleName_textBox.Text;
            String Address = Address_textBox.Text;
            String BirthDate = BirthD_dateTimePicker.Text;
            BirthDate.Reverse();
            if (checkForm())
            {
                    string create_owner = $"INSERT INTO OWNERS (Surname, Name, Middle_name, Address, Birth_D) values('{Name}', '{Surname}', '{MiddleName}', '{Address}', '{BirthDate}')";
                    sqlCommand = new SqlCommand(create_owner, dataBase.GetConnection());
                    sqlCommand.ExecuteNonQuery();
                    MessageBox.Show("Владелец успешно создан", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    this.Close();
            }
            else
               MessageBox.Show("Ошибка создания владельца", "Неправильный формат", MessageBoxButtons.OK, MessageBoxIcon.Warning);
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
        public bool ValidOwnerSurname(string OwnerName, out string errorMessage)
        {
            if (OwnerName.Length <= 3 && OwnerSurname_textBox.TextLength >= 50) {
                errorMessage = "Ошибка ввода имя должно быть больше 3 букв";
                return false;
            }
            else
            {
                errorMessage = "";
                return true;
            }
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
            if(OwnerMiddleName_textBox.Text == "")
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
            if(BirthD_dateTimePicker.Text == "")
                errorProvider1.SetError(BirthD_dateTimePicker, "Пожалуйста введите дату рождения");
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
                catch(Exception ex)
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
                return true;
            else return false;
        }
    }
}
