using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GIBDD_AIS.GIBDDForms.Accidents
{
    public partial class AccidentInput : BaseFormsLibrary.BaseAccident
    {
        public AccidentInput()
        {
            InitializeComponent();
        }
        private DataBase _dataBase = new DataBase();

        private void AccidentInputLoad(object sender, EventArgs e)
        {
            _dataBase.openConnection();
            string Vehicle_querystring = $"SELECT Number as 'Номер', Brand as 'Марка', Color as 'Цвет' from VEHICLES";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Vehicle_querystring, _dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView.DataSource = db.Tables[0];
            reasonTextBox.MaxLength = 30;
            damageAmountTextBox.MaxLength = 53;
            roadConditionsTextBox.MaxLength = 30;
            areaTextBox.MaxLength = 30;
            dateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            dateDateTimePicker.Format = DateTimePickerFormat.Custom;
            string[] Types = { "Столкновение", "Опрокидывание", "Наезд на стоящее тс", "Наезд на препятствие", "Наезд на пешехода", "Наезд на велосипедиста", "Наезд на животное", "Падение пассажира", "Другое" };
            typeComboBox.Items.AddRange(Types);
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public void CalculateChosenID()
        {

            int selectedRowCount =
            dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                string chosenNumber = dataGridView[0, dataGridView.CurrentRow.Index].Value.ToString();
                string query = $"SELECT ID FROM VEHICLES WHERE Number LIKE '{chosenNumber}'";
                SqlDataReader dataReader = null;
                SqlCommand sqlCommand = new SqlCommand(query, _dataBase.GetConnection());
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

        private void saveButtonClick(object sender, EventArgs e)
        {
            if (checkForm())
            {
                _dataBase.openConnection();
                var date = dateDateTimePicker.Text;
                date.Reverse();
                int num = Int32.Parse(victimsTextBox.Text);
                string querystring1 = $"INSERT INTO ACCIDENTS( Reason, Amount_of_damage, Road_conditions, Area, Type, Date, Num_of_victims) VALUES('{reasonTextBox.Text}','{damageAmountTextBox.Text}','{roadConditionsTextBox.Text}','{areaTextBox.Text}','{typeComboBox.Text}','{date}', '{num}')";
                SqlCommand sqlCommand1 = new SqlCommand(querystring1, _dataBase.GetConnection());
                sqlCommand1.ExecuteNonQuery();

                string SI_QS = $"SELECT Max(ID) FROM ACCIDENTS";
                SqlDataAdapter dataAdapter = new SqlDataAdapter(SI_QS, _dataBase.GetConnection());
                DataSet db = new DataSet();

                dataAdapter.Fill(db);
                var MaxID = db.Tables[0].Rows[0][0].ToString();
                CalculateChosenID();
                string AddMemberQ = $"SET IDENTITY_INSERT HISTORYS on INSERT INTO HISTORYS(ACCIDENTS_ID, Start_D,End_D, Amount, VEHICLES_ID) VALUES('{MaxID}' ,'{date}','{date}', '1' ,'{DataBank.ChosenID}')";
                SqlCommand sqlCommand = new SqlCommand(AddMemberQ, _dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Успешно создано!", "Успешно!", MessageBoxButtons.OK, MessageBoxIcon.Information);
                _dataBase.closeConnection();
                this.Close();
            }
            else
                MessageBox.Show("Ошибка ввода", "Введите данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void accidentInputFormClosed(object sender, FormClosedEventArgs e)
        {
            Accident newForm = new Accident();
            newForm.Show();
        }

        private void exitButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
