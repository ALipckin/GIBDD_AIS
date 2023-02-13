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
    public partial class AccidentEdit : BaseFormsLibrary.BaseAccident
    {
        DataBase _dataBase = new DataBase();
        public AccidentEdit()
        {
            InitializeComponent();
        }

        private void AccidentEditLoad(object sender, EventArgs e)
        {
            _dataBase.openConnection();
            SqlDataReader dataReader = null;
            string Vehicle_querystring = $"SELECT Number as 'Номер', Brand as 'Марка', Color as 'Цвет' from VEHICLES where ID IN (SELECT VEHICLES_ID FROM HISTORYS WHERE ACCIDENTS_ID LIKE'{DataBank.ChosenID}')";
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
            try
            {
                string querystring = $"SELECT Reason, Amount_of_damage, Road_conditions, Area, Type, Date, Num_of_victims from ACCIDENTS where ID LIKE '{DataBank.ChosenID}'";
                SqlCommand sqlCommand = new SqlCommand(querystring, _dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    reasonTextBox.Text = dataReader[0].ToString();
                    damageAmountTextBox.Text = dataReader[1].ToString();
                    roadConditionsTextBox.Text = dataReader[2].ToString();
                    areaTextBox.Text = dataReader[3].ToString();
                    typeComboBox.Text = dataReader[4].ToString();
                    dateDateTimePicker.Text = dataReader[5].ToString();
                    victimsTextBox.Text = dataReader[6].ToString();
                }
                dataReader.Close();
            }
            catch
            {
                MessageBox.Show("Ошибка", "Ошибка заполнения", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        public string CalculateVehicleID()
        {
            Int32 selectedRowCount =
            dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                string chosenNumber = dataGridView[0, dataGridView.CurrentRow.Index].Value.ToString();
                string query = $"SELECT ID FROM VEHICLES WHERE Number LIKE '{chosenNumber}'";
                SqlDataReader dataReader = null;
                SqlCommand sqlCommand = new SqlCommand(query, _dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                string ID = "";
                while (dataReader.Read())
                {
                    ID = dataReader[0].ToString();
                }
                dataReader.Close();
                return ID;
            }
            return "";
        }

        private void saveButtonClick(object sender, EventArgs e)
        {
            if (checkForm())
            {
                var date = dateDateTimePicker.Text;
                date.Reverse();
                string query = $"UPDATE ACCIDENTS SET Date = '{dateDateTimePicker.Text}', Reason = '{reasonTextBox.Text}', Amount_of_damage = '{damageAmountTextBox.Text}' , Road_conditions = '{roadConditionsTextBox.Text}', Area = '{areaTextBox.Text}', Type = '{typeComboBox.Text}', Num_of_victims = '{victimsTextBox.Text}' WHERE ID LIKE '{DataBank.ChosenID}'";
                SqlCommand sqlCommand = new SqlCommand(query, _dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
                if (CalculateVehicleID() != "")
                {
                    query = $"UPDATE HISTORYS SET VEHICLES_ID = '{CalculateVehicleID()}' WHERE ACCIDENTS_ID = '{DataBank.ChosenID}'";
                    SqlDataAdapter dataAdapter = new SqlDataAdapter(query, _dataBase.GetConnection());
                    DataSet db = new DataSet();
                    dataAdapter.Fill(db);
                    var MaxID = db.Tables[0].Rows[0][0].ToString();
                }
                MessageBox.Show("Сохранение прошло успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Ошибка ввода", "Введите данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void deleteButtonClick(object sender, EventArgs e)
        {
            string delete_accidents = $"DELETE FROM ACCIDENTS WHERE ID = '{DataBank.ChosenID}'";
            string delete_historys = $"DELETE FROM HISTORYS WHERE ACCIDENTS_ID = '{DataBank.ChosenID}'";
            SqlCommand sqlCommand2 = new SqlCommand(delete_historys, _dataBase.GetConnection());
            sqlCommand2.ExecuteNonQuery();
            SqlCommand sqlCommand1 = new SqlCommand(delete_accidents, _dataBase.GetConnection());
            sqlCommand1.ExecuteNonQuery();

            MessageBox.Show("Удаление прошло успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void accidentEditFormClosed(object sender, FormClosedEventArgs e)
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
