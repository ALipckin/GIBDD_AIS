using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GIBDD_AIS.GIBDDForms.Vehicles
{
    public partial class VehicleInput : GIBDD_AIS.BaseVehicle
    {
        DataBase _dataBase = new DataBase();
        public VehicleInput()
        {
            InitializeComponent();
        }

        private void VehicleInputLoad(object sender, EventArgs e)
        {
            _dataBase.openConnection();
            int MaxLength = 30;
            brandTextBox.MaxLength = MaxLength;
            vinTextBox.MaxLength = 17;
            bodyNumberTextBox.MaxLength = MaxLength;
            engineVolumeTextBox.MaxLength = MaxLength;
            engineNumberTextBox.MaxLength = MaxLength;
            chasisNumberTextBox.MaxLength = MaxLength;
            colorTextBox.MaxLength = MaxLength;
            numberTextBox.MaxLength = 9;

            bool Wanted;
            SqlDataReader dataReader = null;
            lastTIDateTimePicker.CustomFormat = "dd-MM-yyyy";
            lastTIDateTimePicker.Format = DateTimePickerFormat.Custom;
            releaseDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            releaseDateDateTimePicker.Format = DateTimePickerFormat.Custom;
            string[] Types = { "Легковой", "Грузовой", "Грузопасажирский", "Автобус", "Спецтранспорт" };
            typeComboBox.Items.AddRange(Types);
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            // Fill dataGridView
            string querystring = "SELECT CONCAT(Surname, ' ', Name, ' ', Middle_Name) as 'ФИО' FROM OWNERS";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, _dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView.DataSource = db.Tables[0];

            // Calculate current owner
            string CurrOwnerQuerystring = $"SELECT CONCAT(Surname, ' ', Name, ' ', Middle_Name) as 'ФИО' FROM OWNERS where id in(SELECT OWNERS_ID FROM VEHICLES WHERE ID = '{DataBank.ChosenID}')";
            SqlCommand sqlCommand = new SqlCommand(CurrOwnerQuerystring, _dataBase.GetConnection());
            dataReader = sqlCommand.ExecuteReader();
            while (dataReader.Read())
            {
                currOwnerLabel.Text = dataReader[0].ToString();
            }
            dataReader.Close();

        }

        private void VehicleInputFormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void saveButtonClick(object sender, EventArgs e)
        {

        }

        private void exitButtonClick(object sender, EventArgs e)
        {

        }
    }
}
