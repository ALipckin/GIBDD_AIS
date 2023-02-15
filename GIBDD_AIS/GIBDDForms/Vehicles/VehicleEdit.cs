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
using System.ComponentModel.DataAnnotations;
using GIBDD_AIS.GIBDDForms.Vehicles;
using static System.Windows.Forms.VisualStyles.VisualStyleElement.Tab;

namespace GIBDD_AIS.GIBDDForms.Vehicles
{
    public partial class VehicleEdit : GIBDD_AIS.BaseVehicle
    {
        DataBase _dataBase = new DataBase();
        public VehicleEdit()
        {
            InitializeComponent();
        }

        public void VehicleEditLoad(object sender, EventArgs e)
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

            bool wanted;
            SqlDataReader dataReader = null;
            lastTIDateTimePicker.CustomFormat = "dd-MM-yyyy";
            lastTIDateTimePicker.Format = DateTimePickerFormat.Custom;
            releaseDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            releaseDateDateTimePicker.Format = DateTimePickerFormat.Custom;
            string[] Types = { "Легковой", "Грузовой", "Грузопасажирский", "Автобус", "Спецтранспорт" };
            typeComboBox.Items.AddRange(Types);
            typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;

            string querystring = $"SELECT CONCAT(Surname, ' ', Name, ' ', Middle_Name) as 'ФИО' FROM OWNERS WHERE ID NOT IN(SELECT OWNERS_ID FROM VEHICLES WHERE ID = '{DataBank.ChosenID}')";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, _dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView.DataSource = db.Tables[0];

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
                    wanted = Convert.ToBoolean(dataReader[10].ToString());
                    if (wanted == true)
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

        private void deleteButtonClick(object sender, EventArgs e)
        {
            try
            {
                string delete_history = $"DELETE HISTORYS WHERE VEHICLES_ID = '{DataBank.ChosenID}'";

                string delete_vehicle = $"DELETE VEHICLES WHERE ID = '{DataBank.ChosenID}'";

                SqlCommand sqlCommand2 = new SqlCommand(delete_history, _dataBase.GetConnection());
                sqlCommand2.ExecuteNonQuery();
                SqlCommand sqlCommand1 = new SqlCommand(delete_vehicle, _dataBase.GetConnection());
                sqlCommand1.ExecuteNonQuery();
                MessageBox.Show("Удаление прошло успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            catch (Exception Ex)
            {
                MessageBox.Show(Ex.Message);
            }
        }
        private void saveButtonClick(object sender, EventArgs e)
        {
            if (checkForm() != false)
            {
                string owner = dataGridView[0, dataGridView.CurrentRow.Index].Value.ToString();
                String[] subs = owner.Split(' ');
                string querystring = $"SELECT ID FROM OWNERS WHERE Surname = '{subs[0]}' AND Name = '{subs[1]}' AND Middle_name = '{subs[2]}'";
                SqlDataAdapter dataAdapter1 = new SqlDataAdapter(querystring, _dataBase.GetConnection());
                DataSet db = new DataSet();
                dataAdapter1.Fill(db);
                string Owner_ID = db.Tables[0].Rows[0][0].ToString();
                var Brand = brandTextBox.Text;
                var VIN = vinTextBox.Text;
                var Type = typeComboBox.Text;
                var Release_D = releaseDateDateTimePicker.Text;
                var EngineV = engineVolumeTextBox.Text;
                var Engine_n = engineNumberTextBox.Text;
                var Chasis_n = chasisNumberTextBox.Text;
                var Body_n = bodyNumberTextBox.Text;
                var Color = colorTextBox.Text;
                var Number = numberTextBox.Text;
                var TI = lastTIDateTimePicker.Text;
                Release_D.Reverse();

                TI.Reverse();
                string create_vehicle = $"UPDATE VEHICLES SET Number = '{Number}', VIN = '{VIN}', Type = '{Type}', Release_D = '{Release_D}', Engine_volume = '{EngineV}', Brand = '{Brand}', Engine_n = '{Engine_n}', Chasis_n = '{Chasis_n}', Body_n = '{Body_n}', Color = '{Color}', Wanted = '{wantedCheckBox.Checked}', OWNERS_ID = '{Owner_ID}', TID = '{TI}' WHERE ID = {DataBank.ChosenID}";
                SqlCommand CreateVehicle_Command = new SqlCommand(create_vehicle, _dataBase.GetConnection());
                CreateVehicle_Command.ExecuteNonQuery();
                MessageBox.Show("Сохранение прошло успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Некорректные данные", "Ошибка", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void exitButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void searchTextBoxTextChanged(object sender, EventArgs e)
        {
            (dataGridView.DataSource as DataTable).DefaultView.RowFilter = $"ФИО LIKE '%{searchTextBox.Text}%'";
        }
        private void VehicleEditFormClosed(object sender, FormClosedEventArgs e)
        {
            Vehicle newForm = new Vehicle();
            newForm.Show();
        }

    }
}
