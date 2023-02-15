using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GIBDD_AIS.GIBDDForms.Accidents
{
    public partial class AccidentView : BaseFormsLibrary.BaseAccident
    {   
        public AccidentView()
        {
            InitializeComponent();
        }
        private DataBase _dataBase = new DataBase();

        private void AccidentViewLoad(object sender, EventArgs e)
        {
            _dataBase.openConnection();
            SqlDataReader dataReader = null;
            string Vehicle_querystring = $"SELECT Number as 'Номер', Brand as 'Марка', Color as 'Цвет' from VEHICLES where ID IN (SELECT VEHICLES_ID FROM HISTORYS WHERE ACCIDENTS_ID LIKE'{DataBank.ChosenID}')";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(Vehicle_querystring, _dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            currVehiclesDataGridView.DataSource = db.Tables[0];
            currVehiclesDataGridView.Enabled = false;
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


    }
}
