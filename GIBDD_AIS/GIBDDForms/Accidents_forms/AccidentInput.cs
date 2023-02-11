using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GIBDD_AIS.GIBDDForms.Accidents_forms
{
    public partial class AccidentInput : GIBDD_AIS.GIBDDForms.Accidents_forms.AccidentParent
    {
        DataBase dataBase = new DataBase();
        public AccidentInput()
        {
            InitializeComponent();
        }

        private void AccidentInput_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            string Vehicle_querystring = $"SELECT Number as 'Номер', Brand as 'Марка', Color as 'Цвет' from VEHICLES";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Vehicle_querystring, dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            _dataGridView.DataSource = db.Tables[0];
            _reasonTextBox.MaxLength = 30;
            _damageAmountTextBox.MaxLength = 53;
            _roadConditionsTextBox.MaxLength = 30;
            _areaTextBox.MaxLength = 30;
            _dateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            _dateDateTimePicker.Format = DateTimePickerFormat.Custom;
            string[] Types = { "Столкновение", "Опрокидывание", "Наезд на стоящее тс", "Наезд на препятствие", "Наезд на пешехода", "Наезд на велосипедиста", "Наезд на животное", "Падение пассажира", "Другое" };
            _typeComboBox.Items.AddRange(Types);
            _typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

        }

        public void CalculateChosenID()
        {

            Int32 selectedRowCount =
            _dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                string chosenNumber = _dataGridView[0, _dataGridView.CurrentRow.Index].Value.ToString();
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

        private void _saveButton_Click(object sender, EventArgs e)
        {
            if (checkForm())
            {
                dataBase.openConnection();
                var date = _dateDateTimePicker.Text;
                date.Reverse();
                int num = Int32.Parse(_victimsTextBox.Text);
                string querystring1 = $"INSERT INTO ACCIDENTS( Reason, Amount_of_damage, Road_conditions, Area, Type, Date, Num_of_victims) VALUES('{_reasonTextBox.Text}','{_damageAmountTextBox.Text}','{_roadConditionsTextBox.Text}','{_areaTextBox.Text}','{_typeComboBox.Text}','{date}', '{num}')";
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
    }
}
