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
        private DataTable _currData;
        private DataTable _newData;
        private List <string> _addedVehiclesID = new List<string>();
        private List<string> _removedVehiclesID = new List<string>();
        public AccidentEdit()
        {
            InitializeComponent();
        }

        private void AccidentEditLoad(object sender, EventArgs e)
        {
            _dataBase.openConnection();
            SqlDataReader dataReader = null;
            string currVehicleQueryString = $"SELECT Number as 'Номер', Brand as 'Марка', Color as 'Цвет' from VEHICLES where ID IN (SELECT VEHICLES_ID FROM HISTORYS WHERE ACCIDENTS_ID LIKE'{DataBank.ChosenID}')";
            SqlDataAdapter currDataAdapter = new SqlDataAdapter(currVehicleQueryString, _dataBase.GetConnection());
            _currData = new DataTable();
            currDataAdapter.Fill(_currData);
            currVehiclesDataGridView.DataSource = _currData;
      
            string newVehicleQueryString = $"SELECT Number as 'Номер', Brand as 'Марка', Color as 'Цвет' from VEHICLES where ID NOT IN (SELECT VEHICLES_ID FROM HISTORYS WHERE ACCIDENTS_ID LIKE'{DataBank.ChosenID}')";
            SqlDataAdapter newdDataAdapter = new SqlDataAdapter(newVehicleQueryString, _dataBase.GetConnection());
            _newData = new DataTable();
            newdDataAdapter.Fill(_newData);
            newVehiclesDataGridView.DataSource = _newData;

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

        public string CalculateDataGridViewVehicleID(DataGridView dataGridView)
        {
            int currRow =dataGridView.CurrentRow.Index;
            string chosenNumber = dataGridView[0, currRow].Value.ToString();
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

        private void saveButtonClick(object sender, EventArgs e)
        {

            if (checkForm())
            {
                var date = dateDateTimePicker.Text;
                date.Reverse();
                string query = $"UPDATE ACCIDENTS SET Date = '{dateDateTimePicker.Text}', Reason = '{reasonTextBox.Text}', Amount_of_damage = '{damageAmountTextBox.Text}' , Road_conditions = '{roadConditionsTextBox.Text}', Area = '{areaTextBox.Text}', Type = '{typeComboBox.Text}', Num_of_victims = '{victimsTextBox.Text}' WHERE ID LIKE '{DataBank.ChosenID}'";
                SqlCommand sqlCommand = new SqlCommand(query, _dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();

                if (_addedVehiclesID.Count > 0)
                {
                    for (int i = 0; i < _addedVehiclesID.Count; i++)
                    {
                        try
                        {
                            string insertHistoryQuery = $"INSERT INTO HISTORYS (VEHICLES_ID, ACCIDENTS_ID) VALUES('{_addedVehiclesID[i]}', '{DataBank.ChosenID}')";
                            SqlCommand historyCommand = new SqlCommand(insertHistoryQuery, _dataBase.GetConnection());
                            historyCommand.ExecuteNonQuery();
                        }
                        catch
                        { }
                    }
                }
                if (_removedVehiclesID.Count > 0)
                {
                    for (int i = 0; i < _removedVehiclesID.Count; i++)
                    {
                        Console.WriteLine("Deleting");
                        string deleteHistoryQuery = $"DELETE FROM HISTORYS WHERE VEHICLES_ID = '{_removedVehiclesID[i]}' AND ACCIDENTS_ID = '{DataBank.ChosenID}'";
                        SqlCommand historyCommand = new SqlCommand(deleteHistoryQuery, _dataBase.GetConnection());
                        historyCommand.ExecuteNonQuery();
                    }
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

        protected override void currVehiclesDataGridViewCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int currRow = currVehiclesDataGridView.CurrentRow.Index;
            string currID = CalculateDataGridViewVehicleID(currVehiclesDataGridView);
            _removedVehiclesID.Add(currID);
            object[] copyRow = _currData.Rows[currVehiclesDataGridView.CurrentRow.Index].ItemArray;
            _currData.Rows.RemoveAt(currRow);
            _newData.Rows.Add(copyRow);
            currVehiclesDataGridView.Refresh();
            newVehiclesDataGridView.Refresh();
        }

        private void newVehiclesDataGridViewCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int currRow = newVehiclesDataGridView.CurrentRow.Index;
            string currID = CalculateDataGridViewVehicleID(newVehiclesDataGridView);
            _addedVehiclesID.Add(currID);
            object[] copyRow = _newData.Rows[newVehiclesDataGridView.CurrentRow.Index].ItemArray;
            _newData.Rows.RemoveAt(currRow);
            _currData.Rows.Add(copyRow);
            currVehiclesDataGridView.Refresh();
            newVehiclesDataGridView.Refresh();
        }
    }
}
