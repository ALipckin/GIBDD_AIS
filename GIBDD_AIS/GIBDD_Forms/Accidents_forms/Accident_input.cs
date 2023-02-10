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
    public partial class Accident_input : Form
    {
        DataBase dataBase = new DataBase();
     
        public Accident_input()
        {
            InitializeComponent();
        }
        private void Accident_input_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            string Vehicle_querystring = $"SELECT Number as 'Номер', Brand as 'Марка', Color as 'Цвет' from VEHICLES";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Vehicle_querystring, dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            MembersOfAccident_dataGridView.DataSource = db.Tables[0];
            Reason_textBox.MaxLength = 30;
            AmountOfDamage_textBox.MaxLength = 53;
            RoadConditions_textBox.MaxLength = 30;
            Area_textBox.MaxLength = 30;
            dateTimePicker.CustomFormat = "dd-MM-yyyy";
            dateTimePicker.Format = DateTimePickerFormat.Custom;
            string[] Types = { "Столкновение", "Опрокидывание", "Наезд на стоящее тс", "Наезд на препятствие", "Наезд на пешехода", "Наезд на велосипедиста", "Наезд на животное", "Падение пассажира", "Другое" };
            Type_comboBox.Items.AddRange(Types);
            Type_comboBox.DropDownStyle = ComboBoxStyle.DropDownList;
          
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
            Accidents newForm = new Accidents();
            newForm.Show();
        }
        public void CalculateChosenID()
        {
           
            Int32 selectedRowCount =
            MembersOfAccident_dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                string chosenNumber = MembersOfAccident_dataGridView[0, MembersOfAccident_dataGridView.CurrentRow.Index].Value.ToString();
                string query = $"SELECT ID FROM VEHICLES WHERE Number LIKE '{chosenNumber}'";
                SqlDataReader dataReader = null;
                SqlCommand sqlCommand = new SqlCommand(query, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
               
                while (dataReader.Read())
                {
                    DataBank.ChosenID = dataReader[0].ToString();
                }
                dataReader.Close();
            }
            else
                MessageBox.Show("Выберете запись", "Запись не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);

       
        }
        private void create_button_Click(object sender, EventArgs e)
        {
            if (checkForm())
            {
                dataBase.openConnection();
                var date = dateTimePicker.Text;
                date.Reverse();
                int num = Int32.Parse(NumOfVictims_TextBox.Text);
                string querystring1 = $"INSERT INTO ACCIDENTS( Reason, Amount_of_damage, Road_conditions, Area, Type, Date, Num_of_victims) VALUES('{Reason_textBox.Text}','{AmountOfDamage_textBox.Text}','{RoadConditions_textBox.Text}','{Area_textBox.Text}','{Type_comboBox.Text}','{date}', '{num}')";
                SqlCommand sqlCommand1 = new SqlCommand(querystring1, dataBase.GetConnection());
                sqlCommand1.ExecuteNonQuery();
                
                string SI_QS = $"SELECT Max(ID) FROM ACCIDENTS";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(SI_QS, dataBase.GetConnection());
                DataSet db = new DataSet();
                
                dataAdapter.Fill(db);
                var MaxID = db.Tables[0].Rows[0][0].ToString();
                CalculateChosenID();
                string AddMemberQ = $"SET IDENTITY_INSERT HISTORYS on INSERT INTO HISTORYS(ACCIDENTS_ID, Start_D,End_D, Amount, VEHICLES_ID) VALUES('{MaxID}' ,'{date}','{date}', '1' ,'{DataBank.ChosenID}')";
                SqlCommand sqlCommand = new SqlCommand(AddMemberQ, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Успешно создано!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                dataBase.closeConnection();
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
            else
                errorProvider1.SetError(Box, "");
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
            else
                errorProvider1.SetError(Box, "");
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
            else
                errorProvider1.SetError(Box, "");
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
                if (isNumber != false)
                    status = true;
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

                errorProvider1.SetError(Box, "Дата не может быть больше текущей");
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
