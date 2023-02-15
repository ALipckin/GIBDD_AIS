using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.Entity.Core.Common.CommandTrees.ExpressionBuilder;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace GIBDD_AIS.GIBDDForms.Accidents
{
    public partial class AccidentInput : BaseFormsLibrary.BaseAccident
    {
        private DataTable _currData;
        private DataTable _newData;
        private List<string> _addedVehiclesID = new List<string>();
     

        public AccidentInput()
        {
            InitializeComponent();
        }
        private DataBase _dataBase = new DataBase();

        private void AccidentInputLoad(object sender, EventArgs e)
        {
            _dataBase.openConnection();
            string Vehicle_querystring = $"SELECT Number as 'Номер', Brand as 'Марка', Color as 'Цвет' from VEHICLES WHERE ID = -1";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Vehicle_querystring, _dataBase.GetConnection());
            _currData = new DataTable();
            dataAdapter.Fill(_currData);
            currVehiclesDataGridView.DataSource = _currData;

            string newVehicleQueryString = $"SELECT Number as 'Номер', Brand as 'Марка', Color as 'Цвет' from VEHICLES";
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
        }

        public string CalculateDataGridViewVehicleID(DataGridView dataGridView)
        {
            int currRow = dataGridView.CurrentRow.Index;
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
            if (checkForm() && _addedVehiclesID.Count > 0)
            {
                _dataBase.openConnection();
                var date = dateDateTimePicker.Text;
                date.Reverse();
                int num = int.Parse(victimsTextBox.Text);
                string newAccidentQuery = $"INSERT INTO ACCIDENTS( Reason, Amount_of_damage, Road_conditions, Area, Type, Date, Num_of_victims) VALUES('{reasonTextBox.Text}','{damageAmountTextBox.Text}','{roadConditionsTextBox.Text}','{areaTextBox.Text}','{typeComboBox.Text}','{date}', '{num}')";
                SqlCommand newAccidentCommand = new SqlCommand(newAccidentQuery, _dataBase.GetConnection());
                newAccidentCommand.ExecuteNonQuery();

                string newIDQuery = $"SELECT Max(ID) FROM ACCIDENTS";
                SqlCommand newIDCommand = new SqlCommand(newIDQuery, _dataBase.GetConnection());
                var newID = newIDCommand.ExecuteScalar();

                for (int i = 0; i < _addedVehiclesID.Count; i++)
                {
                    try
                    {
                        string insertHistoryQuery = $"INSERT INTO HISTORYS (VEHICLES_ID, ACCIDENTS_ID) VALUES('{_addedVehiclesID[i]}', '{newID}')";
                        SqlCommand historyCommand = new SqlCommand(insertHistoryQuery, _dataBase.GetConnection());
                        historyCommand.ExecuteNonQuery();
                    }
                    catch
                    { }
                }
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

        protected override void currVehiclesDataGridViewCellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            int currRow = currVehiclesDataGridView.CurrentRow.Index;
            string currID = CalculateDataGridViewVehicleID(currVehiclesDataGridView);
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
