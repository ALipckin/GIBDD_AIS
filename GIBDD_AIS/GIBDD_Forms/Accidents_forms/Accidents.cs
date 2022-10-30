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
using GIBDD_AIS.GIBDD_Forms.Accidents_forms;
using System.Windows.Forms.VisualStyles;
using CrystalDecisions.CrystalReports.Engine;
using GIBDD_AIS.GIBDD_Forms.Autos_forms;
namespace GIBDD_AIS
{
    public partial class Accidents : Form
    {
        DataBase dataBase = new DataBase();
        public Accidents()
        {
            InitializeComponent();
        }
        private void Accidents_Load(object sender, EventArgs e)
        {
            dataBase.openConnection();
            Accidents_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            Accidents_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            Accidents_dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
  
            string querystring = "SELECT Area as 'Место', Date as 'Дата' FROM ACCIDENTS ";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            Accidents_dataGridView.DataSource = db.Tables[0];
        }
        public void CalculateChosenID()
        {
            Int32 selectedRowCount =
            Accidents_dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                string Area = Accidents_dataGridView[0, Accidents_dataGridView.CurrentRow.Index].Value.ToString();
                string Date = Accidents_dataGridView.CurrentRow.Cells[1].Value.ToString();
                string querystring = $"SELECT ID FROM ACCIDENTS WHERE Area = '{Area}' AND Date = '{Date}'";
                SqlDataReader dataReader = null;
                SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    DataBank.chosenID = dataReader[0].ToString();
                }
                dataReader.Close();
            }
            else
                MessageBox.Show("Выберете запись", "Запись не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void View_button_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
            Accidents_dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                CalculateChosenID();
                Accident_view newForm = new Accident_view();
                newForm.Show();
            }
            else
                MessageBox.Show("Выберете запись", "Запись не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Edit_button_Click(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
            Accidents_dataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                CalculateChosenID();
                this.Close();
                Accident_edit newForm = new Accident_edit();
                newForm.Show(); ;
            }
            else
                MessageBox.Show("Выберете запись", "Запись не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void Input_Click(object sender, EventArgs e)
        {
            CalculateChosenID();
            this.Close();
            Accident_input newForm = new Accident_input();
            newForm.Show();
        }
        private void SearchDate_TextBox_TextChanged(object sender, EventArgs e)
        {
            string filter = $"Convert([Дата],'System.String') Like '%" + SearchDate_TextBox.Text + "%'";
            (Accidents_dataGridView.DataSource as DataTable).DefaultView.RowFilter = filter;
        }
        private void exit_button_Click(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
