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
using GIBDD_AIS.GIBDDForms.Accidents;

namespace GIBDD_AIS
{
    public partial class Accident : Form
    {
        DataBase dataBase = new DataBase();
        public Accident()
        {
            InitializeComponent();
        }
        private void AccidentsLoad(object sender, EventArgs e)
        {
            dataBase.openConnection();
            accidentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            accidentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
            accidentsDataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
  
            string querystring = "SELECT Area as 'Место', Date as 'Дата' FROM ACCIDENTS ";
            SqlDataAdapter dataAdapter = new SqlDataAdapter(querystring, dataBase.GetConnection());
            DataSet db = new DataSet();
            dataAdapter.Fill(db);
            accidentsDataGridView.DataSource = db.Tables[0];
        }
        public void CalculateChosenID()
        {
            Int32 selectedRowCount =
            accidentsDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                string Area = accidentsDataGridView[0, accidentsDataGridView.CurrentRow.Index].Value.ToString();
                string Date = accidentsDataGridView.CurrentRow.Cells[1].Value.ToString();
                string querystring = $"SELECT ID FROM ACCIDENTS WHERE Area = '{Area}' AND Date = '{Date}'";
                SqlDataReader dataReader = null;
                SqlCommand sqlCommand = new SqlCommand(querystring, dataBase.GetConnection());
                dataReader = sqlCommand.ExecuteReader();
                while (dataReader.Read())
                {
                    DataBank.ChosenID = dataReader[0].ToString();
                }
                dataReader.Close();
            }
            else
                MessageBox.Show("Выберете запись", "Запись не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void viewButtonClick(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
            accidentsDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                CalculateChosenID();
                AccidentView newForm = new AccidentView();
                newForm.Show();
            }
            else
                MessageBox.Show("Выберете запись", "Запись не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void editButtonClick(object sender, EventArgs e)
        {
            Int32 selectedRowCount =
            accidentsDataGridView.Rows.GetRowCount(DataGridViewElementStates.Selected);
            if (selectedRowCount > 0)
            {
                CalculateChosenID();
                this.Close();
                AccidentEdit newForm = new AccidentEdit();
                newForm.Show();
            }
            else
                MessageBox.Show("Выберете запись", "Запись не выбрана", MessageBoxButtons.OK, MessageBoxIcon.Warning);
        }
        private void inputButtonClick(object sender, EventArgs e)
        {
            CalculateChosenID();
            this.Close();
            AccidentInput newForm = new AccidentInput();
            newForm.Show();
        }
        private void searchDateTextBoxTextChanged(object sender, EventArgs e)
        {
            string filter = $"Convert([Дата],'System.String') Like '%" + searchTextBox.Text + "%'";
            (accidentsDataGridView.DataSource as DataTable).DefaultView.RowFilter = filter;
        }

        private void exitButtonClick(object sender, EventArgs e)
        {
            this.Close();
        }

    }
}
