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
    public partial class AccidentEdit : GIBDD_AIS.GIBDDForms.Accidents_forms.AccidentParent
    {
        DataBase dataBase = new DataBase();
        public AccidentEdit()
        {
            InitializeComponent();
        }

        private void AccidentEdit_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            SqlDataReader dataReader = null;
            _reasonTextBox.MaxLength = 30;
            _damageAmountTextBox.MaxLength = 53;
            _roadConditionsTextBox.MaxLength = 30;
            _areaTextBox.MaxLength = 30;
            _dateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            _dateDateTimePicker.Format = DateTimePickerFormat.Custom;
            string[] Types = { "Столкновение", "Опрокидывание", "Наезд на стоящее тс", "Наезд на препятствие", "Наезд на пешехода", "Наезд на велосипедиста", "Наезд на животное", "Падение пассажира", "Другое" };
            _typeComboBox.Items.AddRange(Types);
            _typeComboBox.DropDownStyle = ComboBoxStyle.DropDownList;
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


        private void _deleteButton_Click(object sender, EventArgs e)
        {
            string delete_accidents = $"DELETE FROM ACCIDENTS WHERE ID = '{DataBank.ChosenID}'";
            string delete_historys = $"DELETE FROM HISTORYS WHERE ACCIDENTS_ID = '{DataBank.ChosenID}'";
            SqlCommand sqlCommand2 = new SqlCommand(delete_historys, dataBase.GetConnection());
            sqlCommand2.ExecuteNonQuery();
            SqlCommand sqlCommand1 = new SqlCommand(delete_accidents, dataBase.GetConnection());
            sqlCommand1.ExecuteNonQuery();

            MessageBox.Show("Удаление прошло успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
            this.Close();
        }

        private void _saveButton_Click(object sender, EventArgs e)
        {
            if (checkForm())
            {
                var date = _dateDateTimePicker.Text;
                date.Reverse();
                string query = $"UPDATE ACCIDENTS SET Date = '{_dateDateTimePicker.Text}', Reason = '{_reasonTextBox.Text}', Amount_of_damage = '{_damageAmountTextBox.Text}' , Road_conditions = '{_roadConditionsTextBox.Text}', Area = '{_areaTextBox.Text}', Type = '{_typeComboBox.Text}', Num_of_victims = '{_victimsTextBox.Text}' WHERE ID LIKE '{DataBank.ChosenID}'";
                SqlCommand sqlCommand = new SqlCommand(query, dataBase.GetConnection());
                sqlCommand.ExecuteNonQuery();
                MessageBox.Show("Сохранение прошло успешно!", "Успешно", MessageBoxButtons.OK, MessageBoxIcon.Information);
                this.Close();
            }
            else
                MessageBox.Show("Ошибка ввода", "Введите данные", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
    }
}
