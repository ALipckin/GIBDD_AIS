using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Text;
using System.Windows.Forms;

namespace GIBDD_AIS.GIBDDForms.Owners
{
    public partial class OwnerView : GIBDD_AIS.GIBDD_Forms.Owners_forms.BaseOwner
    {
        DataBase _dataBase = new DataBase();
        public OwnerView()
        {
            InitializeComponent();
        }
        private void OwnerViewLoad(object sender, EventArgs e)
        {
            _dataBase.openConnection();
            SqlDataReader dataReader = null;

            string quertystring = $"SELECT Surname, Name, Middle_name, Address, Birth_D FROM OWNERS where ID LIKE '{DataBank.Owner_ID}'";
            SqlCommand sqlCommand = new SqlCommand(quertystring, _dataBase.GetConnection());
            dataReader = sqlCommand.ExecuteReader();

            surnameTextBox.MaxLength = 30;
            middleNameTextBox.MaxLength = 30;
            surnameTextBox.MaxLength = 30;
            addressTextBox.MaxLength = 60;
            birthDateDateTimePicker.CustomFormat = "dd-MM-yyyy";
            birthDateDateTimePicker.Format = DateTimePickerFormat.Custom;
            while (dataReader.Read())
            {
                nameTextBox.Text = dataReader[1].ToString();
                surnameTextBox.Text = dataReader[0].ToString();
                middleNameTextBox.Text = dataReader[2].ToString();
                addressTextBox.Text = dataReader[3].ToString();
                birthDateDateTimePicker.Text = dataReader[4].ToString();
            }
            dataReader.Close();
            string querystring = $"SELECT Number AS 'Номер', Brand as 'Марка' FROM VEHICLES WHERE OWNERS_ID LIKE '{DataBank.Owner_ID}'";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, _dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            vehiclesDataGridView.DataSource = db.Tables[0];
        }

    }
}
