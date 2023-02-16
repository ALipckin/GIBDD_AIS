using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
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
            int maxLength = 30;
            brandTextBox.MaxLength = maxLength;
            vinTextBox.MaxLength = 17;
            bodyNumberTextBox.MaxLength = maxLength;
            engineVolumeTextBox.MaxLength = maxLength;
            engineNumberTextBox.MaxLength = maxLength;
            chasisNumberTextBox.MaxLength = maxLength;
            colorTextBox.MaxLength = maxLength;
            numberTextBox.MaxLength = 9;

            SqlDataReader dataReader = null;
            lastTIDateTimePicker.CustomFormat = "dd-MM-yyyy";
            lastTIDateTimePicker.Format = DateTimePickerFormat.Custom;
            releaseDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            releaseDateDateTimePicker.Format = DateTimePickerFormat.Custom;
            string[] types = { "Легковой", "Грузовой", "Грузопасажирский", "Автобус", "Спецтранспорт" };
            typeComboBox.Items.AddRange(types);
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            string querystring = "SELECT CONCAT(Surname, ' ', Name, ' ', Middle_Name) as 'ФИО' FROM OWNERS";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, _dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView.DataSource = db.Tables[0];

        }

        private void VehicleInputFormClosed(object sender, FormClosedEventArgs e)
        {
            Vehicle newForm = new Vehicle();
            newForm.Show();
        }

        private void saveButtonClick(object sender, EventArgs e)
        {
            if (checkForm())
            {
                _dataBase.openConnection();
                SqlCommand sqlCommand = null;
                var Brand = brandTextBox.Text;
                var VIN = vinTextBox.Text;
                var Type = typeComboBox.Text;
                var Release_D = releaseDateDateTimePicker.Text;
                Release_D.Reverse();

                var EngineV = engineVolumeTextBox.Text;
                var Engine_n = engineNumberTextBox.Text;
                var Chasis_n = chasisNumberTextBox.Text;
                var Body_n = bodyNumberTextBox.Text;
                var Color = colorTextBox.Text;
                var Number = numberTextBox.Text;
                var TI = lastTIDateTimePicker.Text;
                TI.Reverse();
                
                string owner = dataGridView[0, dataGridView.CurrentRow.Index].Value.ToString();
                String[] subs = owner.Split(' ');
                string ownerIDQuery = $"SELECT ID FROM OWNERS WHERE Surname = '{subs[0]}' AND Name = '{subs[1]}' AND Middle_name = '{subs[2]}'";
                SqlCommand ownerIDCommand = new SqlCommand(ownerIDQuery, _dataBase.GetConnection());
                var Owner_ID = ownerIDCommand.ExecuteScalar();

                string create_vehicle = $"INSERT INTO VEHICLES(Number, VIN, Type, Release_D, Engine_volume, Brand, Engine_n, Chasis_n, Body_n, Color, Wanted, OWNERS_ID, TID) values('{Number}','{VIN}','{Type}','{Release_D}','{EngineV}','{Brand}','{Engine_n}','{Chasis_n}','{Body_n}','{Color}', '{wantedCheckBox.Checked}','{Owner_ID}', '{TI}')";
                sqlCommand = new SqlCommand(create_vehicle, _dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Авто созданно", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Ошибка ввода", "Введите данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

    }
}
