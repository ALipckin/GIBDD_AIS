using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GIBDD_AIS.GIBDDForms.Accidents_forms
{
    public partial class AccidentView : GIBDD_AIS.GIBDDForms.Accidents_forms.AccidentParent
    {
        public AccidentView()
        {
            InitializeComponent();
        }

        private void AccidentView_Load(object sender, EventArgs e)
        {
            DataBase dataBase = new DataBase();
            dataBase.openConnection();
            SqlDataReader dataReader = null;

            _reasonTextBox.MaxLength = 30;
            _reasonTextBox.ReadOnly = true;
            _damageAmountTextBox.MaxLength = 53;
            _damageAmountTextBox.ReadOnly = true;
            _roadConditionsTextBox.MaxLength = 30;
            _roadConditionsTextBox.ReadOnly = true;
            _areaTextBox.MaxLength = 30;
            _areaTextBox.ReadOnly = true;
            _dateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            _dateDateTimePicker.Format = DateTimePickerFormat.Custom;
            _dateDateTimePicker.Enabled = false;
            string[] Types = { "Столкновение", "Опрокидывание", "Наезд на стоящее тс", "Наезд на препятствие", "Наезд на пешехода", "Наезд на велосипедиста", "Наезд на животное", "Падение пассажира", "Другое" };
            _typeComboBox.Items.AddRange(Types);
            _typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
            _typeComboBox.Enabled = false;
            _dataGridView.ReadOnly = true;
            _victimsTextBox.ReadOnly = true;
            try
            {
                string querystring = $"SELECT Reason, Amount_of_damage, Road_conditions, Area, Type, Date, Num_of_victims from ACCIDENTS where ID LIKE '{DataBank.ChosenID}'";
                SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    _reasonTextBox.Text = dataReader[0].ToString();
                    _damageAmountTextBox.Text = dataReader[1].ToString();
                    _roadConditionsTextBox.Text = dataReader[2].ToString();
                    _areaTextBox.Text = dataReader[3].ToString();
                    _typeComboBox.Text = dataReader[4].ToString();
                    _dateDateTimePicker.Text = dataReader[5].ToString();
                    _victimsTextBox.Text = dataReader[6].ToString();
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
