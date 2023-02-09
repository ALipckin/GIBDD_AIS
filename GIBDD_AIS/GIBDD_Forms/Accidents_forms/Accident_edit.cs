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

namespace GIBDD_AIS.GIBDD_Forms.Accidents_forms
{
    public partial class Accident_edit : Form
    {
        DataBase dataBase = new DataBase();
        public Accident_edit()
        {
            InitializeComponent();
        }
        private void Accident_edit_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            SqlDataReader dataReader = null;
            Reason_textBox.MaxLength = 30;
            AmountOfDamage_textBox.MaxLength = 53;
            RoadConditions_textBox.MaxLength = 30;
            Area_textBox.MaxLength = 30;
            dateTimePicker.CustomFormat = "dd-MM-yyyy";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            string[] Types = { "Столкновение", "Опрокидывание", "Наезд на стоящее тс", "Наезд на препятствие", "Наезд на пешехода", "Наезд на велосипедиста", "Наезд на животное", "Падение пассажира", "Другое" };
            Type_comboBox.Items.AddRange(Types);
            Type_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            try
            {
                string querystring = $"SELECT Reason, Amount_of_damage, Road_conditions, Area, Type, Date, Num_of_victims from ACCIDENTS where ID LIKE '{DataBank.ChosenID}'";
                SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    Reason_textBox.Text = dataReader[0].ToString();
                    AmountOfDamage_textBox.Text = dataReader[1].ToString();
                    RoadConditions_textBox.Text = dataReader[2].ToString();
                    Area_textBox.Text = dataReader[3].ToString();
                    Type_comboBox.Text = dataReader[4].ToString();
                    dateTimePicker.Text = dataReader[5].ToString();
                    NumOfVictims_TextBox.Text = dataReader[6].ToString();
                }
                dataReader.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Accident_edit_FormClosed(object sender, FormClosedEventArgs e)
        {
            Accidents newForm = new Accidents();
            newForm.Show();
        }
        private void Delete_button_Click(object sender, EventArgs e)
        {
            string delete_accidents = $"DELETE FROM ACCIDENTS WHERE ID = '{DataBank.ChosenID}'";
            string delete_historys = $"DELETE FROM HISTORYS WHERE ACCIDENTS_ID = '{DataBank.ChosenID}'";
            SqlCommand sqlCommand2 = new SqlCommand(delete_historys, dataBase.GetConnection());
            sqlCommand2.ExecuteNonQuery();
            SqlCommand sqlCommand1 = new SqlCommand(delete_accidents, dataBase.GetConnection());
            sqlCommand1.ExecuteNonQuery();

            MessageBox.Show("Удаление прошло успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }
        private void Save_button_Click(object sender, EventArgs e)
        {
            if (checkForm())
            {
                var date = dateTimePicker.Text;
                date.Reverse();
                string query = $"UPDATE ACCIDENTS SET Date = '{dateTimePicker.Text}', Reason = '{Reason_textBox.Text}', Amount_of_damage = '{AmountOfDamage_textBox.Text}' , Road_conditions = '{RoadConditions_textBox.Text}', Area = '{Area_textBox.Text}', Type = '{Type_comboBox.Text}', Num_of_victims = '{NumOfVictims_TextBox.Text}' WHERE ID LIKE '{DataBank.ChosenID}'";
                SqlCommand sqlCommand = new SqlCommand(query, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Сохранение прошло успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Ошибка ввода", "Введите данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private bool CheckReason()
        {
            var Box = Reason_textBox;
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
            var Box = AmountOfDamage_textBox;
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
            var Box = RoadConditions_textBox;
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
            var Box = Area_textBox;
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
            var Box = Type_comboBox;
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
            var Box = NumOfVictims_TextBox;
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
            var Box = dateTimePicker;
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

            if (Reason && AmountOfDamage && RoadConditions && Area && Type && NumOfVictims&&Date)
                return true;
            else return false;
        }
    }
}
