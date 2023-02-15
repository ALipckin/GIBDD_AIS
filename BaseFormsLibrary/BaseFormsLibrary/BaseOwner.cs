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
using static System.Windows.Forms.VisualStyles.VisualStyleElement;

namespace GIBDD_AIS.GIBDD_Forms.Owners_forms
{
    public partial class BaseOwner : Form
    {
     
        public BaseOwner()
        {
            InitializeComponent();
        }
        private void Owner_inputcs_FormClosed(object sender, FormClosedEventArgs e)
        {
        }
        private void Owner_inputcs_Load(object sender, EventArgs e)
        {
            surnameTextBox.MaxLength = 30;
            middleNameTextBox.MaxLength = 30;
            nameTextBox.MaxLength = 30;
            addressTextBox.MaxLength = 60;
            birthDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            birthDateDateTimePicker.Format = DateTimePickerFormat.Custom;
            errorProvider.ContainerControl = this;

        }
   
        private bool CheckSurname()
        {
            bool status = true;
            if (surnameTextBox.Text == "")
            {
                errorProvider.SetError(surnameTextBox, "Пожалуйста введите фамилию");
                status = false;
            }
            else
                errorProvider.SetError(surnameTextBox, "");
            return status;
        }
        private bool CheckName()
        {
            bool status = true;
            if (nameTextBox.Text == "")
            {
                errorProvider.SetError(nameTextBox, "Пожалуйста введите имя");
                status = false;
            }
            else
                errorProvider.SetError(nameTextBox, "");
            return status;
        }
        private bool CheckMiddleName()
        {
            bool status = true;
            if(middleNameTextBox.Text == "")
            {
                errorProvider.SetError(middleNameTextBox, "Пожалуйста введите отчество");
                status = false;
            }
            else
                errorProvider.SetError(middleNameTextBox, "");
            return status;
        }
        private bool CheckAddress()
        {
            bool status = true;
            if (addressTextBox.Text == "")
            {
                errorProvider.SetError(addressTextBox, "Пожалуйста введите адрес");
                status = false;
            }
            else
                errorProvider.SetError(addressTextBox, "");
            return status;
        }
        private bool CheckAge()
        {
            bool status = true;
            if(birthDateDateTimePicker.Text == "")
                errorProvider.SetError(birthDateDateTimePicker, "Пожалуйста введите дату рождения");
            else
            {
                errorProvider.SetError(birthDateDateTimePicker, "");
                try
                {
                    var bday = birthDateDateTimePicker.Value;
                    DateTime now = DateTime.Today;
                    int age = now.Year - bday.Year;
                    if (bday > now.AddYears(-age)) age--;
                    if (age < 16)
                    {
                        errorProvider.SetError(birthDateDateTimePicker, "Владельцу должно быть больше 16 лет");
                        status = false;
                    }
                    else
                        errorProvider.SetError(birthDateDateTimePicker, "");
                }
                catch(Exception ex)
                {
                    errorProvider.SetError(birthDateDateTimePicker, "Пожалуйста введите дату рождения в формате даты");
                    status = false;
                }
            }
            return status;
        }
        protected bool checkForm()
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

        private void surnameTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
                e.Handled = true;
        }
        private void nameTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
                e.Handled = true;
        }
        private void middleNameTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.')
                e.Handled = true;
        }

        private void addressTextBoxKeyPress(object sender, KeyPressEventArgs e)
        {
            char l = e.KeyChar;
            if ((l < 'А' || l > 'я') && l != '\b' && l != '.' && l != 44 && l != 32 && !Char.IsDigit(l))
                e.Handled = true;
        }

        private void exitButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
