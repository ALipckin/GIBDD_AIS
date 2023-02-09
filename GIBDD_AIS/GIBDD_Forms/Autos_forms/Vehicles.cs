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
using GIBDD_AIS.GIBDD_Forms.Autos_forms;

namespace GIBDD_AIS
{
    public partial class Vehicles : Form
    {
        DataBase dataBase = new DataBase();
        public Vehicles()
        {
            InitializeComponent();
        }
        private void Vehicles_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            dataGridView1.SelectionMode = DataGridViewSelectionMode.FullRowSelect;

            string querystring = "SELECT Number AS 'Номер', Brand as 'Марка' FROM VEHICLES";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            dataGridView1.DataSource = db.Tables[0];
        }
        private void SearchNumber_TextBox_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Номер LIKE '%{SearchNumber_TextBox.Text}%'";
        }
        private void SearchBrand_TextBox_TextChanged(object sender, EventArgs e)
        {
            (dataGridView1.DataSource as DataTable).DefaultView.RowFilter = $"Марка LIKE '%{SearchBrand_TextBox.Text}%'";
        }
        public void CalculateChosenID()
        {
           string chosenNumber = dataGridView1[0, dataGridView1.CurrentRow.Index].Value.ToString();
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
        private void View_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
            dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                CalculateChosenID();
                //Show form
                Vehicle_view newForm = new Vehicle_view();
                newForm.Show();
            }
            else
                MessageBox.Show("Выберете запись", "Запись не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Edit_Click(object sender, EventArgs e)
        {
            var selectedRowCount =
            dataGridView1.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                CalculateChosenID();
                this.Close();
                Vehicle_edit newForm = new Vehicle_edit();
                newForm.Show();
            }
            else
                MessageBox.Show("Выберете запись", "Запись не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }
        private void Input_button_Click(object sender, EventArgs e)
        {
                this.Close();
                Vehicle_input newForm = new Vehicle_input();
                newForm.Show();
        }
    }
}
