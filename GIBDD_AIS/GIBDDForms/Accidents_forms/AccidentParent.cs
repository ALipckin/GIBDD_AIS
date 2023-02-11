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

namespace GIBDD_AIS.GIBDDForms.Accidents_forms
{
    public partial class AccidentParent : Form
    {
       
        public AccidentParent()
        {
            InitializeComponent();
        }

        private void AccidentParent_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            string Vehicle_querystring = $"SELECT Number as 'Номер', Brand as 'Марка', Color as 'Цвет' from VEHICLES where ID IN (SELECT VEHICLES_ID FROM HISTORYS WHERE ACCIDENTS_ID LIKE'{DataBank.ChosenID}')";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Vehicle_querystring, dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            _dataGridView.DataSource = db.Tables[0];
        }

        private bool CheckReason()
        {
            var Box = _reasonTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider1.SetError(Box, "Требуется поле");
                status = false;
            }
            else errorProvider1.SetError(Box, "");
            return status;
        }
        private bool CheckAmountOfDamage()
        {
            var Box = _damageAmountTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider1.SetError(Box, "Требуется поле");
                status = false;
            }
            else
            {
                errorProvider1.SetError(Box, "");
                int numericValue;
                bool isNumber = int.TryParse(Box.Text, out numericValue);
                if (isNumber != false) status = true;
                else
                {
                    errorProvider1.SetError(Box, "Поле может содержать только число");
                    status = false;
                }
            }
            return status;
        }
        private bool CheckRoadConditions()
        {
            var Box = _roadConditionsTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider1.SetError(Box, "Требуется поле");
                status = false;
            }
            else errorProvider1.SetError(Box, "");
            return status;
        }
        private bool CheckArea()
        {
            var Box = _areaTextBox;
            bool status = true;

            if (Box.Text == "")
            {
                errorProvider1.SetError(Box, "Требуется поле");
                status = false;
            }
            else errorProvider1.SetError(Box, "");
            return status;
        }
        private bool CheckType()
        {
            var Box = _typeComboBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider1.SetError(Box, "Требуется поле");
                status = false;
            }
            else errorProvider1.SetError(Box, "");
            return status;
        }
        private bool CheckNumOfVictims()
        {
            var Box = _victimsTextBox;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider1.SetError(Box, "Требуется поле");
                status = false;
            }
            else
            {
                errorProvider1.SetError(Box, "");
                int numericValue;
                bool isNumber = int.TryParse(Box.Text, out numericValue);
                if (isNumber != false) status = true;
                else
                {
                    errorProvider1.SetError(Box, "Поле может содержать только число");
                    status = false;
                }
            }
            return status;
        }
        private bool CheckDate()
        {
            var Box = _dateDateTimePicker;
            bool status = true;
            if (Box.Text == "")
            {
                errorProvider1.SetError(Box, "Требуется поле");
                status = false;
            }
            else
                if (Box.Value > DateTime.Today)
            {

                errorProvider1.SetError(Box, "Дата то не может быть больше текущей");
                status = false;
            }
            else errorProvider1.SetError(Box, "");
            return status;
        }

        public bool checkForm()
        {
            bool Reason = CheckReason();
            bool AmountOfDamage = CheckAmountOfDamage();
            bool RoadConditions = CheckRoadConditions();
            bool Area = CheckArea();
            bool Type = CheckType();
            bool NumOfVictims = CheckNumOfVictims();
            bool Date = CheckDate();

            if (Reason && AmountOfDamage && RoadConditions && Area && Type && NumOfVictims && Date)
                return true;
            else return false;
        }

        private void _exitButton_Click(object sender, EventArgs e)
        {
            this.Close();
            Accidents newForm = new Accidents();
            newForm.Show();
        }
    }
}
