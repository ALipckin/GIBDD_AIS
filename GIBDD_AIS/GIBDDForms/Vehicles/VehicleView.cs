using GIBDD_AIS.GIBDDForms.Owners;
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
    public partial class VehicleView : GIBDD_AIS.BaseVehicle
    {
        DataBase _dataBase = new DataBase();
        public VehicleView()
        {
            InitializeComponent();
        }

        private void VehicleViewLoad(object sender, EventArgs e)
        {
            _dataBase.openConnection();


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
            string querystring = $"SELECT Date as 'Дата', Reason as 'Обстоятельства' FROM ACCIDENTS WHERE ID IN(SELECT ACCIDENTS_ID FROM HISTORYS WHERE VEHICLES_ID LIKE '{DataBank.ChosenID}')";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, _dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView.DataSource = db.Tables[0];
            dataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            // Fill textBoxes
            try
            {
                string vehicle_querystring = $"SELECT Number, VIN, Type, Release_D, Engine_volume, Brand, Engine_n, Chasis_n, Body_n, Color, Wanted,OWNERS_ID, TID from VEHICLES WHERE ID LIKE '{DataBank.ChosenID}'";
                SqlCommand sqlCommand1 = new SqlCommand(vehicle_querystring, _dataBase.GetConnection());
                dataReader = sqlCommand1.ExecuteReader();
                while (dataReader.Read())
                {
                    numberTextBox.Text = dataReader[0].ToString();
                    vinTextBox.Text = dataReader[1].ToString();
                    typeComboBox.Text = dataReader[2].ToString();
                    releaseDateDateTimePicker.Text = dataReader[3].ToString();
                    engineVolumeTextBox.Text = dataReader[4].ToString();
                    brandTextBox.Text = dataReader[5].ToString();
                    engineNumberTextBox.Text = dataReader[6].ToString();
                    chasisNumberTextBox.Text = dataReader[7].ToString();
                    bodyNumberTextBox.Text = dataReader[8].ToString();
                    colorTextBox.Text = dataReader[9].ToString();
                    Wanted = Convert.ToBoolean(dataReader[10].ToString());
                    if (Wanted == true)
                    { wantedCheckBox.Checked = true; }
                    else { wantedCheckBox.Checked = false; }
                    DataBank.Owner_ID = dataReader[11].ToString();
                    lastTIDateTimePicker.Text = dataReader[12].ToString();
                }
                dataReader.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
            finally
            {
                if (dataReader != null && !dataReader.IsClosed)
                {
                    dataReader.Close();
                }
            }
        }

        private void VehicleViewFormClosed(object sender, FormClosedEventArgs e)
        {

        }

        private void ownerInfoButtonClick(object sender, EventArgs e)
        {
            OwnerView newForm = new OwnerView();
            newForm.Show();
        }

        private void exitButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
