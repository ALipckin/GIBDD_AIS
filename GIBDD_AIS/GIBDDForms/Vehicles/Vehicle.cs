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
using GIBDD_AIS.GIBDDForms.Vehicles;

namespace GIBDD_AIS
{
    public partial class Vehicle : Form
    {
        DataBase dataBase = new DataBase();
        public Vehicle()
        {
            InitializeComponent();
        }
        private void VehiclesLoad(object sender, EventArgs e)
        {
            dataBase.openConnection();
            vehiclesDataGridView.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string querystring = "SELECT Number AS 'Номер', Brand as 'Марка' FROM VEHICLES";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            vehiclesDataGridView.DataSource = db.Tables[0];
        }
        private void searchNumberTextBoxTextChanged(object sender, EventArgs e)
        {
            (vehiclesDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"Номер LIKE '%{searchNumberTextBox.Text}%'";
        }
        private void searchBrandTextBoxTextChanged(object sender, EventArgs e)
        {
            (vehiclesDataGridView.DataSource as DataTable).DefaultView.RowFilter = $"Марка LIKE '%{searchBrandTextBox.Text}%'";
        }
        public void CalculateChosenID()
        {
           string chosenNumber = vehiclesDataGridView[0, vehiclesDataGridView.CurrentRow.Index].Value.ToString();
           string query = $"SELECT ID FROM VEHICLES WHERE Number LIKE '{chosenNumber}'";
           SqlDataReader dataReader = null;
           SqlCommand sqlCommand = new SqlCommand(query, dataBase.GetConnection());
           dataReader = sqlCommand.ExecuteReader();
           while (dataReader.Read())
           {
                DataBank.ChosenID = dataReader[0].ToString();
           }
           dataReader.Close();
        }
        private void viewClick(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
            vehiclesDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                CalculateChosenID();
                //Show form
                VehicleView newForm = new VehicleView();
                newForm.Show();
            }
            else
                MessageBox.Show("Выберете запись", "Запись не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }

        private void exitButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }
        private void editButtonClick(object sender, EventArgs e)
        {
            var selectedRowCount =
            vehiclesDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                CalculateChosenID();
                this.Close();
                VehicleEdit newForm = new VehicleEdit();
                newForm.Show();
            }
            else
                MessageBox.Show("Выберете запись", "Запись не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void inputButtonClick(object sender, EventArgs e)
        {
            string query = $"SELECT COUNT(ID) FROM OWNERS";
            SqlDataReader dataReader = null;
            SqlCommand sqlCommand = new SqlCommand(query, dataBase.GetConnection());
            dataReader = sqlCommand.ExecuteReader();
            string count = "0";
            while (dataReader.Read())
            {
                count = dataReader[0].ToString();
            }
            if (Convert.ToInt32(count) > 0)
            {
                this.Close();
                VehicleInput newForm = new VehicleInput();
                newForm.Show();
            }
            else
                MessageBox.Show("Сначало создайте владельца", "Нет владельцов", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }


    }
}
